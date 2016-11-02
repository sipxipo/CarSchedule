using CarScheduleCore.Model;
using CarScheduleCore.Ultility;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace CarSchedule
{
    public partial class ScheduleMainForm : Form
    {

        #region Propertise
        private string[] _timeSlot;
        private Color _oldSelectColor;
        private List<CarWashingSchedule> _mainSchedules;
        private TableLayoutPanel _tableLayoutPanel1 = new TableLayoutPanel();
        public WashManForm WashManForm { get; set; }
        public string[] TimeSlot
        {
            get
            {
                return _timeSlot;
            }

            set
            {
                _timeSlot = value;
            }
        }
      
        #endregion

        public ScheduleMainForm(WashManForm washManForm)
        {

            this.WashManForm = washManForm;
            InitializeComponent();

            #region Tab_Main

            lbl_WashManName.Text = washManForm.SelectedWashMan.Name.ToUpper();
            cbb_WashMan.DataSource = washManForm.ComboBoxWashMan.DataSource;
            cbb_WashMan.DisplayMember = washManForm.ComboBoxWashMan.DisplayMember;
            cbb_WashMan.ValueMember = washManForm.ComboBoxWashMan.ValueMember;


            CreateTimeSlot();
            GetAllSchedule();
            #endregion

            #region Tab_Analysis

            List<WashMan> list = ((WashMan[])washManForm.ComboBoxWashMan.Tag).ToList();
            list.Add(new WashMan { Name = "All", Id = -1 });
            cbb_WashMan_Analysis.DataSource = list.OrderBy(x => x.Name).ToList();
            cbb_WashMan_Analysis.DisplayMember = washManForm.ComboBoxWashMan.DisplayMember;
            cbb_WashMan_Analysis.ValueMember = washManForm.ComboBoxWashMan.ValueMember;
            cbb_WashMan_Analysis.SelectedValue = -1;

            cbb_WashingType.DataSource = Enum.GetValues(typeof(WashingType));


            #region Booked Schedule GridView 
            dgrid_Schedule.AutoGenerateColumns = false;
            dgrid_Schedule.Columns.Add("Date", "Ngày");
            dgrid_Schedule.Columns.Add("WashMan", "Người Đặt");
            dgrid_Schedule.Columns.Add("CarNumber", "Biển Số");
            dgrid_Schedule.Columns.Add("BookedTime", "Giờ Đặt");
            dgrid_Schedule.Columns.Add("WashTime", "Giờ Rửa");
            dgrid_Schedule.Columns.Add("FinishTime", "Kết Thúc");
            dgrid_Schedule.Columns.Add("WashingType", "Loại");

            dgrid_Schedule.Columns["Date"].DataPropertyName = "BookedTime";
            dgrid_Schedule.Columns["WashMan"].DataPropertyName = "WashMan_Name";
            dgrid_Schedule.Columns["CarNumber"].DataPropertyName = "CarNumber";
            dgrid_Schedule.Columns["BookedTime"].DataPropertyName = "BookedTime";
            dgrid_Schedule.Columns["WashTime"].DataPropertyName = "WashTime";
            dgrid_Schedule.Columns["FinishTime"].DataPropertyName = "FinishTime";
            dgrid_Schedule.Columns["WashingType"].DataPropertyName = "WashingType";

            dgrid_Schedule.Columns["Date"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgrid_Schedule.Columns["WashMan"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgrid_Schedule.Columns["CarNumber"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgrid_Schedule.Columns["BookedTime"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgrid_Schedule.Columns["WashTime"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgrid_Schedule.Columns["FinishTime"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgrid_Schedule.Columns["WashingType"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgrid_Schedule.Columns["BookedTime"].DefaultCellStyle.Format = "hh:mm tt";
            dgrid_Schedule.Columns["FinishTime"].DefaultCellStyle.Format = "hh:mm tt";
            dgrid_Schedule.Columns["WashTime"].DefaultCellStyle.Format = "hh:mm tt";
            dgrid_Schedule.Columns["Date"].DefaultCellStyle.Format = "MM/dd/yyyy";
            TypeDescriptor.AddProvider((new MyTypeDescriptionProvider<WashMan>(typeof(CarWashingSchedule))), typeof(CarWashingSchedule));

            #endregion

            #endregion


            timer1.Start();
            timer2.Start();
        }
   

        #region Call API  

        public async void GetAllSchedule()
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
                    _mainSchedules = data;
                    UpdateTimeSlotUILayout(data);
                }

            }
        }


        public async void DeleteSchedule(int id)
        {
            using (var client = new HttpClient())
            {
                var result = await client.DeleteAsync(String.Format("{0}/{1}?id={2}", Common.CARWASHING_URI, "DeleteCarWashing", id));
                if (result.IsSuccessStatusCode)
                {
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //todo seperate UI code 
                    //update UI 
                    var button = _tableLayoutPanel1.Controls.Find("btn1_" + TimeSlot[0] + ":" + TimeSlot[1], true).FirstOrDefault();
                    if (button == null) return;
                    button.BackColor = SystemColors.Control;
                    button.ForeColor = Color.Black;
                    button.Text = TimeSlot[0] + ":" + TimeSlot[1];
                    button.Tag = TimeSlot[0] + ":" + TimeSlot[1];
                }
                else
                {
                    MessageBox.Show("Xóa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

        }

        public async void CreateSchedule(CarWashingSchedule schedule)
        {
            using (var client = new HttpClient())
            {
                var serializedProduct = JsonConvert.SerializeObject(schedule);
                var content = new StringContent(serializedProduct, Encoding.UTF8, "application/json");
                var result = await client.PostAsync(string.Format("{0}/{1}", Common.CARWASHING_URI, "PostCarWashing"), content);
                if (result.IsSuccessStatusCode)
                {
                    MessageBox.Show("Lập lịch thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetAllSchedule();
                }
                else
                {
                    MessageBox.Show(result.StatusCode.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }



            }
        }

        public async void SearchSchedule(SearchCarWashingSchedule schedule)
        {
            using (var client = new HttpClient())
            {
                var serializedProduct = JsonConvert.SerializeObject(schedule);
                var content = new StringContent(serializedProduct, Encoding.UTF8, "application/json");
                var result = await client.PostAsync(string.Format("{0}/{1}", Common.CARWASHING_URI, "SearchCarWashings"), content);
                if (result.IsSuccessStatusCode)
                {
                    var productJsonString = await result.Content.ReadAsStringAsync();

                    var data = JsonConvert.DeserializeObject<CarWashingSchedule[]>(productJsonString).ToList();
                    if (data != null)
                        dgrid_Schedule.DataSource = data.OrderByDescending(x => x.BookedTime).ToList();


                }
                else
                {
                    MessageBox.Show(result.StatusCode.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }



            }
        }

        private async void UpdateLateSchedule()
        {
            using (var client = new HttpClient())
            {
                //update late schedule
                foreach (var schedule in _mainSchedules.Where(x => x.BookedTime < DateTime.Now && x.WashingStatus == WashingStatus.New))
                {
                    schedule.WashingStatus = WashingStatus.Late;
                    var updateContent = new StringContent(JsonConvert.SerializeObject(schedule), Encoding.UTF8, "application/json");
                    var updateResult = await client.PutAsync(String.Format("{0}/{1}?id={2}", Common.CARWASHING_URI, "PutCarWashing", schedule.Id), updateContent);
                    if (!updateResult.IsSuccessStatusCode)
                    {
                        MessageBox.Show(updateResult.StatusCode.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                    }
                    else
                    {
                        var button = _tableLayoutPanel1.Controls.Find("btn1_" + schedule.BookedTime.ToString("HH:mm"), true).FirstOrDefault();
                        if (button == null) return;
                        button.BackColor = Color.Red;
                        button.Text = string.Format("{0}\n{1}\n{2}\n{3}", schedule.CarNumber, cbb_WashMan.Items.OfType<WashMan>().FirstOrDefault(x => x.Id == schedule.WashManId).Name, schedule.GuestStatus, schedule.WashingType);

                        button.ForeColor = Color.White;
                        button.Tag = button.Tag.ToString() + ":" + schedule.Id;
                    }
                }


            }
        }


        #endregion

        #region Helper 
        private void CopyAlltoClipboard()
        {
            dgrid_Schedule.SelectAll();
            DataObject dataObj = dgrid_Schedule.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }
        private void ReleaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occurred while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
        private void UpdateTimeSlotUILayout(List<CarWashingSchedule> data)
        {
            if (data != null)
            {
                #region Update TimeSlot Button 
                foreach (var layout in _tableLayoutPanel1.Controls.OfType<TableLayoutPanel>())
                {
                    layout.ColumnCount = 1;
                    var slot = layout.Controls.OfType<Button>().ToList();
                    slot.ForEach(x =>
                    {
                        x.BackColor = SystemColors.Control;
                        x.ForeColor = Color.Black;
                        x.Text = x.Name.Substring(5, 5);
                        x.Tag = x.Name.Substring(5, 5);
                        x.Visible = !x.Name.Contains("btn2");
                    });

                }

                var filter = checkBox1.Checked ? data : data.Where(x => x.WashManId == ((WashMan)cbb_WashMan.SelectedItem).Id);
                foreach (var schedule in filter)
                {
                    var button = _tableLayoutPanel1.Controls.Find("btn1_" + schedule.BookedTime.ToString("HH:mm"), true).FirstOrDefault();
                    var txtInfo = string.Format("{0}\n{1}\n{2}\n{3}", schedule.CarNumber, cbb_WashMan.Items.OfType<WashMan>().FirstOrDefault(x => x.Id == schedule.WashManId).Name, schedule.GuestStatus, schedule.WashingType);
                    switch (schedule.WashingStatus)
                    {
                        case WashingStatus.Washing:
                            var date = Common.TimeRoundDown(schedule.WashTime ?? DateTime.Now).ToString("HH:mm");
                            //    var date = Common.TimeRoundDown(DateTime.Now.AddHours(9).AddMinutes(20)).ToString("HH:mm");
                            var currentSlot = data.FirstOrDefault(x => x.BookedTime.ToString("HH:mm") == date && x.WashingStatus == WashingStatus.Late);

                            if (currentSlot == null)
                            {
                                var button1 = _tableLayoutPanel1.Controls.Find("btn1_" + date, true).FirstOrDefault();
                                button1.BackColor = Color.Gold;
                                button1.Text = txtInfo;
                                button1.ForeColor = Color.White;
                                button1.Tag = button.Tag.ToString() + ":" + schedule.Id;

                            }
                            else
                            {
                                var layout = (TableLayoutPanel)_tableLayoutPanel1.Controls.Find("layout_mulSchedule" + date, true).FirstOrDefault();
                                layout.ColumnCount = 2;
                                var button2 = _tableLayoutPanel1.Controls.Find("btn2_" + date, true).FirstOrDefault();
                                button2.BackColor = Color.Gold;
                                button2.Text = txtInfo;
                                button2.Visible = true;
                                button2.ForeColor = Color.White;
                                button2.Tag = button.Tag.ToString() + ":" + schedule.Id;
                            }

                            break;

                        case WashingStatus.Finished:
                            date = Common.TimeRoundDown(schedule.FinishTime ?? DateTime.Now).ToString("HH:mm");
                            currentSlot = data.FirstOrDefault(x => x.BookedTime.ToString("HH:mm") == date && x.WashingStatus == WashingStatus.Late);

                            if (currentSlot == null)
                            {
                                var button1 = _tableLayoutPanel1.Controls.Find("btn1_" + date, true).FirstOrDefault();
                                button1.BackColor = Color.Green;
                                button1.Text = txtInfo;
                                button1.ForeColor = Color.White;
                                button1.Tag = button.Tag.ToString() + ":" + schedule.Id;
                            }
                            else
                            {
                                var layout = (TableLayoutPanel)_tableLayoutPanel1.Controls.Find("layout_mulSchedule" + date, true).FirstOrDefault();
                                layout.ColumnCount = 2;
                                var button2 = _tableLayoutPanel1.Controls.Find("btn2_" + date, true).FirstOrDefault();
                                button2.BackColor = Color.Green;
                                button2.Text = txtInfo;
                                button2.Visible = true;
                                button2.ForeColor = Color.White;
                                button2.Tag = button.Tag.ToString() + ":" + schedule.Id;

                            }
                            break;

                        case WashingStatus.New:
                            button.BackColor = Color.Blue;
                            button.Text = txtInfo;
                            button.ForeColor = Color.White;
                            button.Tag = button.Tag.ToString() + ":" + schedule.Id;

                            break;

                        case WashingStatus.Late:
                            button.BackColor = Color.Red;
                            button.Text = txtInfo;
                            button.ForeColor = Color.White;
                            button.Tag = button.Tag.ToString() + ":" + schedule.Id;

                            break;
                        default:
                            button.BackColor = SystemColors.Control;
                            button.Text = button.Tag.ToString();
                            button.ForeColor = Color.Black;
                            button.Tag = button.Tag.ToString();

                            break;

                    }



                }
                #endregion

                #region Update Car Listbox 


                if (lst_carwaiting.DataSource == null || (lst_carwaiting.DataSource != null && data.Count != ((List<CarWashingSchedule>)lst_carwaiting.DataSource).Count))
                {
                    lst_carwaiting.DataSource = data.OrderBy(x => x.BookedTime).Where(x => x.WashingStatus == WashingStatus.New).ToList();

                }
                lst_carwaiting.DisplayMember = "CarNumber";
                lst_carwaiting.ValueMember = "Id";

                if (lst_carwashing.DataSource == null || (lst_carwashing.DataSource != null && data.Count != ((List<CarWashingSchedule>)lst_carwashing.DataSource).Count))
                {
                    lst_carwashing.DataSource = data.OrderBy(x => x.BookedTime).Where(x => x.WashingStatus == WashingStatus.Finished).ToList();

                }
                lst_carwashing.DisplayMember = "CarNumber";
                lst_carwashing.ValueMember = "Id";
                #endregion

            }
        }
        private void CreateTimeSlot()
        {
            var colNum = 10;
            var rowNum = 60 / Common.TIME_RANGE + 1;
            _tableLayoutPanel1.AutoScroll = true;
            _tableLayoutPanel1.AutoSize = true;
            _tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            _tableLayoutPanel1.BackColor = SystemColors.GradientInactiveCaption;
            _tableLayoutPanel1.ColumnCount = colNum;
            _tableLayoutPanel1.Dock = DockStyle.Fill;
            _tableLayoutPanel1.Location = new Point(1, 103);
            _tableLayoutPanel1.Margin = new Padding(1);
            _tableLayoutPanel1.Name = "tableLayoutPanel1";
            _tableLayoutPanel1.RowCount = rowNum;
            tableLayoutPanel3.Controls.Add(_tableLayoutPanel1, 0, 1);
            _tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5f));
            _tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));

            for (int i = 0; i < colNum - 1; i++)
            {
                //add hour label
                _tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F / colNum));
                var hour = (i + 8).ToString("00");
                var lbl_h = new Label();
                lbl_h.AutoSize = true;
                lbl_h.Dock = DockStyle.Fill;
                lbl_h.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                lbl_h.ForeColor = Color.Navy;
                lbl_h.Name = "lbl_h_" + hour;
                lbl_h.Size = new Size(114, 58);
                lbl_h.TabIndex = 11;
                lbl_h.Text = hour;
                lbl_h.TextAlign = ContentAlignment.MiddleCenter;
                _tableLayoutPanel1.Controls.Add(lbl_h, i + 1, 0);


                for (int j = 0; j < rowNum - 1; j++)
                {
                    if (i == 0)
                    {
                        //add minute label
                        _tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 90 / rowNum));
                        var minitute = (j * Common.TIME_RANGE).ToString("00");
                        var lbl_m = new Label();
                        lbl_m.AutoSize = true;
                        lbl_m.Dock = DockStyle.Fill;
                        lbl_m.Font = new Font("Microsoft Sans Serif", 2 * Common.TIME_RANGE > 30 ? 25F : 2F * Common.TIME_RANGE, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                        lbl_m.ForeColor = Color.Navy;
                        lbl_m.Name = "lbl_m_" + minitute;
                        lbl_m.Size = new Size(114, 58);
                        lbl_m.TabIndex = 11;
                        lbl_m.Text = minitute;
                        lbl_m.TextAlign = ContentAlignment.MiddleCenter;
                        _tableLayoutPanel1.Controls.Add(lbl_m, 0, j + 1);
                    }

                    //add timeslot button 
                    var layout_mulSchedule = new TableLayoutPanel();
                    layout_mulSchedule.ColumnCount = 1;
                    layout_mulSchedule.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
                    layout_mulSchedule.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
                    layout_mulSchedule.Dock = DockStyle.Fill;
                    layout_mulSchedule.Name = "layout_mulSchedule" + (i + 8).ToString("00") + ":" + (j * Common.TIME_RANGE).ToString("00");
                    layout_mulSchedule.RowCount = 1;
                    layout_mulSchedule.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
                    layout_mulSchedule.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));

                    var button1 = new Button
                    {
                        Dock = DockStyle.Fill,
                        Location = new Point(522, 541),
                        Name = "btn1_" + (i + 8).ToString("00") + ":" + (j * Common.TIME_RANGE).ToString("00"),
                        Size = new Size(110, 94),
                        TabIndex = int.Parse(i.ToString() + j.ToString()),
                        Text = (i + 8).ToString("00") + ":" + (j * Common.TIME_RANGE).ToString("00"),
                        Tag = (i + 8).ToString("00") + ":" + (j * Common.TIME_RANGE).ToString("00"),
                        BackColor = SystemColors.Control,
                        Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0))),


                    };
                    var button2 = new Button
                    {
                        Dock = DockStyle.Fill,
                        Location = new Point(522, 541),
                        Name = "btn2_" + (i + 8).ToString("00") + ":" + (j * Common.TIME_RANGE).ToString("00"),
                        Size = new Size(110, 94),
                        TabIndex = int.Parse(i.ToString() + j.ToString()),
                        Text = (i + 8).ToString("00") + ":" + (j * Common.TIME_RANGE).ToString("00"),
                        Tag = (i + 8).ToString("00") + ":" + (j * Common.TIME_RANGE).ToString("00"),
                        Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0))),
                        BackColor = SystemColors.Control,
                        Visible = false
                    };
                    button1.Click += new EventHandler(TimeSlot_Click);
                    button2.Click += new EventHandler(TimeSlot_Click);
                    layout_mulSchedule.Controls.Add(button1, 0, 0);
                    layout_mulSchedule.Controls.Add(button2, 1, 0);

                    _tableLayoutPanel1.Controls.Add(layout_mulSchedule, i + 1, j + 1);
                }
            }


        }

        #endregion

        #region Event
        private void TimeSlot_Click(object sender, EventArgs e)
        {
            if (sender == null) return;
            var button = (Button)sender;
            TimeSlot = button.Tag.ToString().Split(':');
            if (!checkBox1.Checked && e != null)
            {
                MessageBox.Show("Vui lòng chọn xem tất cả để đặt hẹn !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            foreach (var layout in _tableLayoutPanel1.Controls.OfType<TableLayoutPanel>())
            {
                var slot = layout.Controls.OfType<Button>().FirstOrDefault(x => x.BackColor == Color.DimGray);
                if (slot != null)
                    slot.BackColor = _oldSelectColor;
            }

            if (TimeSlot != null && TimeSlot.Count() == 2 && button.BackColor == SystemColors.Control)
            {
                var bookForm = new ScheduleBookForm(this);
                bookForm.ShowDialog();
            }

            _oldSelectColor = button.BackColor;
            button.BackColor = Color.DimGray;



        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            if (button == null) return;
            if (TimeSlot == null || TimeSlot.Count() < 3)
            {
                MessageBox.Show("Vui lòng chọn giờ hợp lệ !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DeleteSchedule(int.Parse(TimeSlot[2]));
        }

        private void btnRefesh_Click_1(object sender, EventArgs e)
        {
            GetAllSchedule();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            cbb_WashMan.Enabled = !checkBox1.Checked;
            GetAllSchedule();
        }

        private void cbb_WashMan_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetAllSchedule();
        }

        private void lst_carwaiting_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = (CarWashingSchedule)lst_carwaiting.SelectedItem;
            if (item == null) return;

            foreach (var layout in _tableLayoutPanel1.Controls.OfType<TableLayoutPanel>())
            {
                var slot = layout.Controls.OfType<Button>().FirstOrDefault(x => x.Tag.ToString().Contains(item.Id.ToString()));
                if (slot != null)
                {
                    //     TimeSlot_Click(slot, null);
                    break;
                }
            }

        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_Date.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lbl_Time.Text = DateTime.Now.ToString("HH:mm:ss tt ");

            foreach (var control in _tableLayoutPanel1.Controls.OfType<Label>())
            {
                if (control.Name.ToString().Contains("h_" + DateTime.Now.Hour.ToString("00")) || control.Name.ToString().Contains("m_" + Common.TimeRoundDown(DateTime.Now).Minute.ToString("00")))
                {
                    control.BackColor = Color.Navy;
                    control.ForeColor = Color.White;
                }
                else
                {
                    control.BackColor = SystemColors.GradientInactiveCaption;
                    control.ForeColor = Color.Navy;
                }


            }


        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabControl1.TabPages["tab_Analysis"])
            {
                btn_Analysis_Click(sender, e);
            }
        }

        private void btn_Analysis_Click(object sender, EventArgs e)
        {
            SearchSchedule(new SearchCarWashingSchedule
            {
                CarNumber = txtCarNumber.Text,
                WashingType = ((WashingType)cbb_WashingType.SelectedItem),
                WashManId = ((WashMan)cbb_WashMan_Analysis.SelectedItem).Id,
                BookedTime = dPick_Date.Value.Date,
                IsDate = chk_Date.Checked,
                IsMonth = chk_Month.Checked,
                IsYear = chk_Year.Checked,
                Month = dPick_Month.Value.Month,
                Year = dPick_Year.Value.Year
            });
        }

        private void chk_Date_Click(object sender, EventArgs e)
        {
            var check = (CheckBox)sender;
            if (check == null) return;

            switch (check.Tag.ToString())
            {
                case "Date":
                    dPick_Month.Enabled = false;
                    dPick_Year.Enabled = false;
                    dPick_Date.Enabled = check.Checked;
                    chk_Month.Checked = false;
                    chk_Year.Checked = false;
                    break;
                case "Month":
                    dPick_Month.Enabled = check.Checked;
                    dPick_Date.Enabled = false;
                    chk_Date.Checked = false;
                    break;
                case "Year":
                    dPick_Year.Enabled = check.Checked;
                    dPick_Date.Enabled = false;
                    chk_Date.Checked = false;
                    break;

            }

        }


        private void btn_Excel_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xls)|*.xls";
            sfd.FileName = "Inventory_Adjustment_Export.xls";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                // Copy DataGridView results to clipboard
                CopyAlltoClipboard();

                object misValue = System.Reflection.Missing.Value;
                Excel.Application xlexcel = new Excel.Application();

                xlexcel.DisplayAlerts = false; // Without this you will get two confirm overwrite prompts
                Excel.Workbook xlWorkBook = xlexcel.Workbooks.Add(misValue);
                Excel.Worksheet xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                // Format column D as text before pasting results, this was required for my data
                Excel.Range rng = xlWorkSheet.get_Range("A:A").Cells;
                rng.EntireColumn.NumberFormat = "MM/dd/yyyy"; ;

                // Paste clipboard results to worksheet range
                Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[1, 1];
                CR.Select();
                xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);

                //// For some reason column A is always blank in the worksheet. ¯\_(ツ)_/¯
                //// Delete blank column A and select cell A1
                //Excel.Range delRng = xlWorkSheet.get_Range("A:A").Cells;
                //delRng.Delete(Type.Missing);
                //xlWorkSheet.get_Range("A1").Select();




                // Save the excel file under the captured location from the SaveFileDialog
                xlWorkBook.SaveAs(sfd.FileName, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                xlexcel.DisplayAlerts = true;
                xlWorkBook.Close(true, misValue, misValue);
                xlexcel.Quit();

                ReleaseObject(xlWorkSheet);
                ReleaseObject(xlWorkBook);
                ReleaseObject(xlexcel);

                // Clear Clipboard and DataGridView selection
                Clipboard.Clear();
                dgrid_Schedule.ClearSelection();

                // Open the newly saved excel file
                if (File.Exists(sfd.FileName))
                    System.Diagnostics.Process.Start(sfd.FileName);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            GetAllSchedule();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            GetAllSchedule();
            UpdateLateSchedule();
        }

        #endregion

    }
}

