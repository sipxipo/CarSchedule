using CarScheduleCore.Model;
using CarScheduleCore.Ultility;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Windows.Forms;

namespace CarSchedule
{
    public partial class WashManForm : Form
    {
        #region Properties
        public WashMan SelectedWashMan
        {
            get
            {
                return (WashMan)cbb_WashMan.SelectedItem;
            }

        }
        public ComboBox ComboBoxWashMan
        {
            get
            {
                return cbb_WashMan;
            }

        }

        #endregion

        #region Contructor
        public WashManForm()
        {
            InitializeComponent();
            GetAllWashMan();
        }

        #endregion

        #region Event
        private void button1_Click(object sender, EventArgs e)
        {
            var mainForm = new ScheduleMainForm(this);
            mainForm.ShowDialog();
            this.Close();
        }
        #endregion 

        #region Call API  

        private async void GetAllWashMan()
        {
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(Common.WASHMAN_URI))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var productJsonString = await response.Content.ReadAsStringAsync();
                        var data = JsonConvert.DeserializeObject<WashMan[]>(productJsonString);              
                        cbb_WashMan.DataSource = data;
                        cbb_WashMan.Tag = data;
                        cbb_WashMan.DisplayMember = "Name";
                        cbb_WashMan.ValueMember = "Id";
                    }
                    else
                    {
                        MessageBox.Show(response.StatusCode.ToString());
                    }
                }
            }
        }

        #endregion 
    }
}
