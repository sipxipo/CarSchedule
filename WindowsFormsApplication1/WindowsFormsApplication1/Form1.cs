using System;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Data;
using CarScheduleCore.Model;
using CarScheduleCore.Ultility;

namespace CarScheduleCore
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            GetAllSchedule();
            DataGridSetting();

        }

        private void DataGridSetting()
        {
            #region Booked Schedule GridView 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Add("WashMan", "Người Đặt");
            dataGridView1.Columns.Add("CarNumber", "Biển Số");
            dataGridView1.Columns.Add("BookedTime", "Giờ Đặt");
            dataGridView1.Columns.Add("WashingType", "Loại");

            dataGridView1.Columns["WashMan"].DataPropertyName = "WashMan_Name";
            dataGridView1.Columns["CarNumber"].DataPropertyName = "CarNumber";
            dataGridView1.Columns["BookedTime"].DataPropertyName = "BookedTime";
            dataGridView1.Columns["WashingType"].DataPropertyName = "WashingType";
            TypeDescriptor.AddProvider((new MyTypeDescriptionProvider<WashMan>(typeof(CarWashingSchedule))), typeof(CarWashingSchedule));
            dataGridView1.Columns["WashMan"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["CarNumber"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["BookedTime"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["WashingType"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["BookedTime"].DefaultCellStyle.Format = "hh:mm tt";
         
            #endregion

            #region Washing Schedule GridView 
            dataGridView2.AutoGenerateColumns = false;

            dataGridView2.Columns.Add("WashMan", "Người Đặt");
            dataGridView2.Columns.Add("CarNumber", "Biển Số");
            dataGridView2.Columns.Add("WashTime", "Giờ Rửa");
            dataGridView2.Columns.Add("WashingType", "Loại");

            dataGridView2.Columns["WashMan"].DataPropertyName = "WashMan_Name";
            dataGridView2.Columns["CarNumber"].DataPropertyName = "CarNumber";
            dataGridView2.Columns["WashTime"].DataPropertyName = "WashTime";
            dataGridView2.Columns["WashingType"].DataPropertyName = "WashingType";
            TypeDescriptor.AddProvider((new MyTypeDescriptionProvider<WashMan>(typeof(CarWashingSchedule))), typeof(CarWashingSchedule));
            dataGridView2.Columns["WashMan"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView2.Columns["CarNumber"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView2.Columns["WashTime"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView2.Columns["WashingType"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView2.Columns["WashTime"].DefaultCellStyle.Format = "hh:mm tt";

            #endregion

            #region Finished Schedule GridView 
            dataGridView3.AutoGenerateColumns = false;

            dataGridView3.Columns.Add("WashMan", "Người Đặt");
            dataGridView3.Columns.Add("CarNumber", "Biển Số");
            dataGridView3.Columns.Add("BookedTime", "Giờ Đặt");
            dataGridView3.Columns.Add("WashTime", "Giờ Rửa");
            dataGridView3.Columns.Add("FinishTime", "Kết Thúc");
            dataGridView3.Columns.Add("WashingType", "Loại");

            dataGridView3.Columns["WashMan"].DataPropertyName = "WashMan_Name";
            dataGridView3.Columns["CarNumber"].DataPropertyName = "CarNumber";
            dataGridView3.Columns["BookedTime"].DataPropertyName = "BookedTime";
            dataGridView3.Columns["WashTime"].DataPropertyName = "WashTime";
            dataGridView3.Columns["FinishTime"].DataPropertyName = "FinishTime";
            dataGridView3.Columns["WashingType"].DataPropertyName = "WashingType";

            TypeDescriptor.AddProvider((new MyTypeDescriptionProvider<WashMan>(typeof(CarWashingSchedule))), typeof(CarWashingSchedule));
            dataGridView3.Columns["WashMan"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView3.Columns["CarNumber"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView3.Columns["BookedTime"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView3.Columns["WashTime"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView3.Columns["FinishTime"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView3.Columns["WashingType"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView3.Columns["BookedTime"].DefaultCellStyle.Format = "hh:mm tt";
            dataGridView3.Columns["FinishTime"].DefaultCellStyle.Format = "hh:mm tt";
            dataGridView3.Columns["WashTime"].DefaultCellStyle.Format = "hh:mm tt";
            #endregion

            #region Late Schedule GridView 
            dataGridView4.AutoGenerateColumns = false;
            dataGridView4.Columns.Add("WashMan", "Người Đặt");
            dataGridView4.Columns.Add("CarNumber", "Biển Số");
            dataGridView4.Columns.Add("BookedTime", "Giờ Đặt");
            dataGridView4.Columns.Add("WashingType", "Loại");

            dataGridView4.Columns["WashMan"].DataPropertyName = "WashMan_Name";
            dataGridView4.Columns["CarNumber"].DataPropertyName = "CarNumber";
            dataGridView4.Columns["BookedTime"].DataPropertyName = "BookedTime";
            dataGridView4.Columns["WashingType"].DataPropertyName = "WashingType";
            TypeDescriptor.AddProvider((new MyTypeDescriptionProvider<WashMan>(typeof(CarWashingSchedule))), typeof(CarWashingSchedule));
            dataGridView4.Columns["WashMan"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView4.Columns["CarNumber"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView4.Columns["BookedTime"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView4.Columns["WashingType"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView4.Columns["BookedTime"].DefaultCellStyle.Format = "hh:mm tt";
            #endregion
        }

        #region Methods

        private async void GetAllSchedule()
        {
            using (var client = new HttpClient())
            {
                var serializedProduct = JsonConvert.SerializeObject(new SearchCarWashingSchedule { IsDate = true, BookedTime = DateTime.Now });
                var content = new StringContent(serializedProduct, Encoding.UTF8, "application/json");
                var result = await client.PostAsync(string.Format("{0}/{1}", Common.CARWASHING_URI, "SearchCarWashings"), content);
                if (result.IsSuccessStatusCode)
                {
                    var productJsonString = await result.Content.ReadAsStringAsync();

                    var data = JsonConvert.DeserializeObject<CarWashingSchedule[]>(productJsonString).ToList();
                    data = data.OrderBy(x => x.BookedTime).ToList();
                    dataGridView1.DataSource = data.Where(x => x.WashingStatus == WashingStatus.New).ToList();
                    dataGridView2.DataSource = data.Where(x => x.WashingStatus == WashingStatus.Washing).ToList();
                    dataGridView3.DataSource = data.Where(x => x.WashingStatus == WashingStatus.Finished).ToList();
                    dataGridView4.DataSource = data.Where(x => x.WashingStatus == WashingStatus.Late).ToList();

                }
            }
        }
        private bool Validate()
        {
            if (DateTime.Now.Hour < 7 || DateTime.Now.Hour > 16)
            {
                MessageBox.Show("Ngoài giờ làm việc !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }
        private async void UpdateSchedule(CarWashingSchedule schedule)
        {
            using (var client = new HttpClient())
            {
                var serializedProduct = JsonConvert.SerializeObject(schedule);
                var content = new StringContent(serializedProduct, Encoding.UTF8, "application/json");
                var result = await client.PutAsync(String.Format("{0}/{1}?id={2}", Common.CARWASHING_URI, "PutCarWashing", schedule.Id), content);
            }
            GetAllSchedule();
        }


        #endregion

        #region Event 
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString();

        }
        private void button3_Click(object sender, EventArgs e)
        {
            GetAllSchedule();
        }
        private void StartWashing_Click(object sender, EventArgs e)
        {

            if (dataGridView1.CurrentRow == null || !Validate()) return;

            var selected = (CarWashingSchedule)dataGridView1.CurrentRow.DataBoundItem;
            selected.WashingStatus = WashingStatus.Washing;
            selected.WashTime = DateTime.Now;
            UpdateSchedule(selected);
        }
        private void Finished_Washing_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow == null || !Validate()) return;
            var selected = (CarWashingSchedule)dataGridView2.CurrentRow.DataBoundItem;
            selected.WashingStatus = WashingStatus.Finished;
            selected.FinishTime = DateTime.Now;
            UpdateSchedule(selected);
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            var selected = (CarWashingSchedule)dataGridView1.CurrentRow.DataBoundItem;
            lblStartCarNumber.Text = selected.CarNumber;
        }
        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow == null) return;
            var selected = (CarWashingSchedule)dataGridView2.CurrentRow.DataBoundItem;
            lblWashingCarNumber.Text = selected.CarNumber;
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            GetAllSchedule();
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetAllSchedule();
        }
        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //get display name of enum  to datagridview 
            DataGridView dataGridView = sender as DataGridView;
            if (dataGridView == null) return;
            if (dataGridView.Columns[e.ColumnIndex].Name == "WashingType")
            {
                e.Value = ((WashingType)e.Value).DisplayName();
            }
        }

        #endregion


    }



}
