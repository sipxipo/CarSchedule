using System;
using System.ComponentModel;


namespace CarScheduleCore.Ultility
{

    public class MyTypeDescriptionProvider<T> : TypeDescriptionProvider
    {
        private ICustomTypeDescriptor td;
        public MyTypeDescriptionProvider(Type type)
            : this(TypeDescriptor.GetProvider(type))
        {
        }
        public MyTypeDescriptionProvider(TypeDescriptionProvider parent)
            : base(parent)
        {
        }
        public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance)
        {
            if (td == null)
            {
                td = base.GetTypeDescriptor(objectType, instance);
                td = new MyCustomTypeDescriptor(td, typeof(T));
            }
            return td;
        }
    }

    public class SubPropertyDescriptor : PropertyDescriptor
    {
        private PropertyDescriptor _subPD;
        private PropertyDescriptor _parentPD;

        public SubPropertyDescriptor(PropertyDescriptor parentPD, PropertyDescriptor subPD, string pdname)
            : base(pdname, null)
        {
            _subPD = subPD;
            _parentPD = parentPD;
        }

        public override bool IsReadOnly { get { return false; } }
        public override void ResetValue(object component) { }
        public override bool CanResetValue(object component) { return false; }
        public override bool ShouldSerializeValue(object component)
        {
            return true;
        }

        public override Type ComponentType
        {
            get { return _parentPD.ComponentType; }
        }
        public override Type PropertyType { get { return _subPD.PropertyType; } }

        public override object GetValue(object component)
        {
            return _subPD.GetValue(_parentPD.GetValue(component));
        }

        public override void SetValue(object component, object value)
        {
            _subPD.SetValue(_parentPD.GetValue(component), value);
            OnValueChanged(component, EventArgs.Empty);
        }
    }

    public class MyCustomTypeDescriptor : CustomTypeDescriptor
    {
        Type typeProperty;
        public MyCustomTypeDescriptor(ICustomTypeDescriptor parent, Type type)
            : base(parent)
        {
            typeProperty = type;
        }
        public override PropertyDescriptorCollection GetProperties(Attribute[] attributes)
        {
            PropertyDescriptorCollection cols = base.GetProperties(attributes);

            string propertyName = "";
            foreach (PropertyDescriptor col in cols)
            {
                if (col.PropertyType.Name == typeProperty.Name)
                    propertyName = col.Name;
            }
            PropertyDescriptor pd = cols[propertyName];
            PropertyDescriptorCollection children = pd.GetChildProperties();
            PropertyDescriptor[] array = new PropertyDescriptor[cols.Count + children.Count];
            int count = cols.Count;
            cols.CopyTo(array, 0);

            foreach (PropertyDescriptor cpd in children)
            {
                array[count] = new SubPropertyDescriptor(pd, cpd, pd.Name + "_" + cpd.Name);
                count++;
            }

            PropertyDescriptorCollection newcols = new PropertyDescriptorCollection(array);
            return newcols;
        }

    }
  
}
