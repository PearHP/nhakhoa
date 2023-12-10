using System.Windows.Forms;
using System;
using BTL_Lich;
using System.Collections.Generic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using System.Data.SqlClient;
using System.Data;

namespace BTL_Lich
{
    public partial class NhaSi : Form
    {
        string connectionString = "Server=HUYNHPHUC;Database=QLPhongKham;User Id=sa;Password=123;";
        public NhaSi()
        {
            InitializeComponent();
        }
        private void LoadDataIntoDataGridView()
        {
            try
            {
                // Tạo kết nối đến cơ sở dữ liệu
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    //Nha sĩ
                    // Truy vấn SQL để lấy dữ liệu từ bảng hoặc thủ tục lưu trữ
                    string query = "SELECT * FROM THUOC";
                    SqlCommand command1 = new SqlCommand(query, connection);

                    // Sử dụng SqlDataAdapter để lấy dữ liệu từ truy vấn
                    SqlDataAdapter adapter1 = new SqlDataAdapter(command1);
                    DataTable dataTable1 = new DataTable();

                    // Đổ dữ liệu vào DataTable
                    adapter1.Fill(dataTable1);

                    // Gán DataTable vào DataGridView
                    dataGridView3.DataSource = dataTable1;

                    

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void IsClick(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn đã click");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCSTTCN_Click(object sender, EventArgs e)
        {
        
        }

        private void btnTDMK_Click(object sender, EventArgs e)
        {
       
        }

        private void NhaSi_Load(object sender, EventArgs e)
        {
            List<LichHen> lishLh = new List<LichHen>();

            for (int i = 1; i <= 10; i++)
            {
                LichHen lhKhachHang = new LichHen()
                {
                    MaLichHen = "00" + i.ToString(),
                    NgayKham = $"12/{i:D2}/2023",
                    GioKham = i % 2 == 0 ? 8 : 14,
                    PhongKham = (i + 2) * 3 % 10
                };

                lishLh.Add(lhKhachHang);
            }

            List<LichHen> appointments = new List<LichHen>();
            for (int i = 11; i <= 14; i++)
            {
                appointments.Add(new LichHen
                {
                    MaLichHen = i.ToString(),
                    NgayKham = DateTime.Now.AddDays(i).ToString("yyyy-MM-dd"),
                    GioKham = 0,
                    PhongKham = 0,
                    MoTaHD = "Personal appointment"
                }); ;
            }

            dgvLHCN.DataSource = appointments;

            DataGridViewCheckBoxColumn checkboxColumn = new DataGridViewCheckBoxColumn();
            checkboxColumn.HeaderText = "Select"; // Set the column header text
            checkboxColumn.Name = "checkboxColumn"; // Set a name for the column

            // Add the checkbox column to the DataGridView
            dgvLHKH.Columns.Add(checkboxColumn);
            dgvLHKH.DataSource = lishLh;


            //List<Thuoc> dstt = new List<Thuoc>();
            //Thuoc tt;
            //tt = new Thuoc() { MaThuoc = 1, TenThuoc = "Amoxicillin", SoLuong = 3, TongTien = 150000 };
            //dstt.Add(tt);
            //tt = new Thuoc() { MaThuoc = 2, TenThuoc = "Spiramycin", SoLuong = 4, TongTien = 180000 };
            //dstt.Add(tt);
            //tt = new Thuoc() { MaThuoc = 3, TenThuoc = "Metronidazol", SoLuong = 1, TongTien = 200000 };
            //dstt.Add(tt);
            //dataGridView3.DataSource = dstt;

            LoadDataIntoDataGridView();

            List<DichVu> sampleDichVuList = new List<DichVu>();

            for (int i = 1; i <= 10; i++)
            {
                DichVu dv = new DichVu
                {
                    MaDichVu = i,
                    TenDichVu = $"Dich Vu {i}",
                    MoTa = $"Mo ta cho Dich Vu {i}",
                    Gia = new Random().Next(10000, 50000)
                };
                sampleDichVuList.Add(dv);
            }

            dataGridView4.DataSource = sampleDichVuList;

            List<HoSoBenhAn> hsba = new List<HoSoBenhAn>();
            HoSoBenhAn ba;
            ba = new HoSoBenhAn() { MaBenhAn = "BA1", ChanDoan = "Đau nướu mềm", NgayDieuTri = "08/11/2023", MaToaThuoc =  "TT01", MaDungDichVu = "DV01", PhongKham = "I32", MaNhaSiPhuTrach = "NS3" };
            hsba.Add(ba);
            ba = new HoSoBenhAn() { MaBenhAn = "BA2", ChanDoan = "Sâu răng cấp tính", NgayDieuTri = "06/10/2023", MaToaThuoc = "TT02", MaDungDichVu = "DV02", PhongKham = "C12", MaNhaSiPhuTrach = "NS1" };
            hsba.Add(ba);
            ba = new HoSoBenhAn() { MaBenhAn = "BA3", ChanDoan = "Cao răng nhiều", NgayDieuTri = "20/11/2023", MaToaThuoc = "TT03", MaDungDichVu = "DV03", PhongKham = "E302", MaNhaSiPhuTrach = "NS5" };
            hsba.Add(ba);
            ba = new HoSoBenhAn() { MaBenhAn = "BA4", ChanDoan = "Đau răng khôn", NgayDieuTri = "12/11/2023", MaToaThuoc = "TT04", MaDungDichVu = "DV04", PhongKham = "I323", MaNhaSiPhuTrach = "NS1" };
            hsba.Add(ba);
            ba = new HoSoBenhAn() { MaBenhAn = "BA5", ChanDoan = "Đau nướu mềm", NgayDieuTri = "09/12/2023",MaToaThuoc =  "TT05", MaDungDichVu = "DV05", PhongKham = "A32", MaNhaSiPhuTrach = "NS2" };
            hsba.Add(ba);
       
            dataGridView2.DataSource = hsba;


        }
         
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnMoreDetail_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty((sender as Button).Text))
                return;
            Calender lich = new Calender();
            lich.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbTTNS_Click(object sender, EventArgs e)
        {

        }

        private void tpLichHen_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            // Clear DataGridView
    
            dataGridView3.DataSource = null;
            dataGridView4.DataSource = null;

            // Clear TextBox
            textBox7.Text = string.Empty;
            textBox7.Enabled = true;
            textBox8.Text = string.Empty;
            textBox8.Enabled = true;

            // Add more control clearing code here if needed
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox7.Enabled = true;
            textBox8.Enabled = true;
        }
    }
}