using CarScheduleCore.Model;
using CarScheduleCore.Ultility;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace CarSchedule
{
    public partial class ScheduleBookForm : Form
    {
        private ScheduleMainForm _scheduleMainForm;
        public ScheduleBookForm(ScheduleMainForm scheduleMainForm)
        {
            _scheduleMainForm = scheduleMainForm;

            InitializeComponent();

            lbl_TimeSlotBooked.Text = string.Join(":", _scheduleMainForm.TimeSlot);
            lbl_date.Text = DateTime.Now.ToString("dd/MM/yyyy");

            rdo_Paint.Tag = WashingType.Paint;
            rdo_Normal.Tag = WashingType.Normal;
            rdo_Cleanup.Tag = WashingType.Cleanup;
            rdo_General.Tag = WashingType.General;
        }


        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Book_Click(object sender, EventArgs e)
        {

            var button = (Button)sender;
            if (button == null) return;
            if (string.IsNullOrEmpty(txt_CarNumber.Text))
            {
                MessageBox.Show("Vui lòng nhập số xe !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (_scheduleMainForm.TimeSlot == null)
            {
                MessageBox.Show("Vui lòng chọn giờ !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var schedule = new CarWashingSchedule
            {
                CarNumber = txt_CarNumber.Text.Trim(),
                GuestStatus = rdo_waiting.Checked ? GuestStatus.Waiting : GuestStatus.Gone,
                WashingStatus = WashingStatus.New,
                WashingType = (WashingType)group_WashingType.Controls.OfType<RadioButton>().FirstOrDefault(x => x.Checked).Tag,
                WashManId = _scheduleMainForm.WashManForm.SelectedWashMan.Id,

                BookedTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, int.Parse(_scheduleMainForm.TimeSlot[0]), int.Parse(_scheduleMainForm.TimeSlot[1]), 0)
            };

            _scheduleMainForm.CreateSchedule(schedule);
            this.Close();



        }
    }
}
