using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Printing;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BTL_Lich
{
    partial class NhaSi
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhaSi));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpHoSo = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbTTNS = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnTDMK = new System.Windows.Forms.Button();
            this.lbHoTen = new System.Windows.Forms.Label();
            this.lbNgSinh = new System.Windows.Forms.Label();
            this.btnCSTTCN = new System.Windows.Forms.Button();
            this.lbDienThoai = new System.Windows.Forms.Label();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tpLichHen = new System.Windows.Forms.TabPage();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dgvLHCN = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvLHKH = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMoreDetail = new System.Windows.Forms.Button();
            this.tpHoSoBenhAn = new System.Windows.Forms.TabPage();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabControl1.SuspendLayout();
            this.tpHoSo.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tpLichHen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLHCN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLHKH)).BeginInit();
            this.tpHoSoBenhAn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpHoSo);
            this.tabControl1.Controls.Add(this.tpLichHen);
            this.tabControl1.Controls.Add(this.tpHoSoBenhAn);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(50, 25);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(982, 553);
            this.tabControl1.TabIndex = 0;
            // 
            // tpHoSo
            // 
            this.tpHoSo.Controls.Add(this.panel2);
            this.tpHoSo.Location = new System.Drawing.Point(4, 29);
            this.tpHoSo.Name = "tpHoSo";
            this.tpHoSo.Padding = new System.Windows.Forms.Padding(3);
            this.tpHoSo.Size = new System.Drawing.Size(974, 520);
            this.tpHoSo.TabIndex = 2;
            this.tpHoSo.Text = "Hồ sơ cá nhân";
            this.tpHoSo.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbTTNS);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(974, 520);
            this.panel2.TabIndex = 8;
            // 
            // lbTTNS
            // 
            this.lbTTNS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTTNS.AutoSize = true;
            this.lbTTNS.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lbTTNS.ForeColor = System.Drawing.Color.Blue;
            this.lbTTNS.Location = new System.Drawing.Point(363, 14);
            this.lbTTNS.Name = "lbTTNS";
            this.lbTTNS.Size = new System.Drawing.Size(249, 35);
            this.lbTTNS.TabIndex = 8;
            this.lbTTNS.Text = "THÔNG TIN NHA SĨ";
            this.lbTTNS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbTTNS.Click += new System.EventHandler(this.lbTTNS_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.btnTDMK);
            this.panel1.Controls.Add(this.lbHoTen);
            this.panel1.Controls.Add(this.lbNgSinh);
            this.panel1.Controls.Add(this.btnCSTTCN);
            this.panel1.Controls.Add(this.lbDienThoai);
            this.panel1.Controls.Add(this.lbDiaChi);
            this.panel1.Location = new System.Drawing.Point(539, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(427, 364);
            this.panel1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(86, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 33);
            this.button1.TabIndex = 11;
            this.button1.Text = "Đăng xuất";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(178, 178);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(138, 22);
            this.textBox4.TabIndex = 10;
            this.textBox4.Text = "43C Xẻo Lá";
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged_1);
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(178, 129);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(138, 22);
            this.textBox3.TabIndex = 9;
            this.textBox3.Text = "0836068079";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(178, 82);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(138, 22);
            this.textBox2.TabIndex = 8;
            this.textBox2.Text = "12/03/2003";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(178, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(138, 22);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "Lê Huỳnh Phúc";
            // 
            // btnTDMK
            // 
            this.btnTDMK.Location = new System.Drawing.Point(86, 291);
            this.btnTDMK.Name = "btnTDMK";
            this.btnTDMK.Size = new System.Drawing.Size(218, 33);
            this.btnTDMK.TabIndex = 6;
            this.btnTDMK.Text = "Đổi mật khẩu";
            this.btnTDMK.UseVisualStyleBackColor = true;
            // 
            // lbHoTen
            // 
            this.lbHoTen.AutoSize = true;
            this.lbHoTen.Location = new System.Drawing.Point(43, 38);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(49, 16);
            this.lbHoTen.TabIndex = 1;
            this.lbHoTen.Text = "Họ tên:";
            // 
            // lbNgSinh
            // 
            this.lbNgSinh.AutoSize = true;
            this.lbNgSinh.Location = new System.Drawing.Point(43, 86);
            this.lbNgSinh.Name = "lbNgSinh";
            this.lbNgSinh.Size = new System.Drawing.Size(72, 16);
            this.lbNgSinh.TabIndex = 2;
            this.lbNgSinh.Text = "Ngày Sinh:";
            // 
            // btnCSTTCN
            // 
            this.btnCSTTCN.Location = new System.Drawing.Point(86, 252);
            this.btnCSTTCN.Name = "btnCSTTCN";
            this.btnCSTTCN.Size = new System.Drawing.Size(218, 33);
            this.btnCSTTCN.TabIndex = 5;
            this.btnCSTTCN.Text = "Chỉnh sửa thông tin cá nhân";
            this.btnCSTTCN.UseVisualStyleBackColor = true;
            // 
            // lbDienThoai
            // 
            this.lbDienThoai.AutoSize = true;
            this.lbDienThoai.Location = new System.Drawing.Point(43, 132);
            this.lbDienThoai.Name = "lbDienThoai";
            this.lbDienThoai.Size = new System.Drawing.Size(75, 16);
            this.lbDienThoai.TabIndex = 3;
            this.lbDienThoai.Text = "Điện Thoại:";
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Location = new System.Drawing.Point(43, 182);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(50, 16);
            this.lbDiaChi.TabIndex = 4;
            this.lbDiaChi.Text = "Địa chỉ:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BTL_Lich.Properties.Resources.dentist;
            this.pictureBox1.Location = new System.Drawing.Point(63, 94);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(361, 364);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // tpLichHen
            // 
            this.tpLichHen.Controls.Add(this.textBox10);
            this.tpLichHen.Controls.Add(this.label18);
            this.tpLichHen.Controls.Add(this.textBox9);
            this.tpLichHen.Controls.Add(this.label16);
            this.tpLichHen.Controls.Add(this.label14);
            this.tpLichHen.Controls.Add(this.dgvLHCN);
            this.tpLichHen.Controls.Add(this.label6);
            this.tpLichHen.Controls.Add(this.dateTimePicker1);
            this.tpLichHen.Controls.Add(this.label5);
            this.tpLichHen.Controls.Add(this.textBox6);
            this.tpLichHen.Controls.Add(this.label4);
            this.tpLichHen.Controls.Add(this.textBox5);
            this.tpLichHen.Controls.Add(this.label3);
            this.tpLichHen.Controls.Add(this.label2);
            this.tpLichHen.Controls.Add(this.dgvLHKH);
            this.tpLichHen.Controls.Add(this.label1);
            this.tpLichHen.Controls.Add(this.btnMoreDetail);
            this.tpLichHen.Location = new System.Drawing.Point(4, 29);
            this.tpLichHen.Name = "tpLichHen";
            this.tpLichHen.Padding = new System.Windows.Forms.Padding(3);
            this.tpLichHen.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tpLichHen.Size = new System.Drawing.Size(974, 520);
            this.tpLichHen.TabIndex = 3;
            this.tpLichHen.Text = "Lịch hẹn";
            this.tpLichHen.UseVisualStyleBackColor = true;
            this.tpLichHen.Click += new System.EventHandler(this.tpLichHen_Click);
            // 
            // textBox10
            // 
            this.textBox10.Enabled = false;
            this.textBox10.Location = new System.Drawing.Point(440, 163);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(255, 22);
            this.textBox10.TabIndex = 25;
            this.textBox10.Text = "3";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(305, 169);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(82, 16);
            this.label18.TabIndex = 24;
            this.label18.Text = "Phòng khám";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // textBox9
            // 
            this.textBox9.Enabled = false;
            this.textBox9.Location = new System.Drawing.Point(440, 191);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(255, 22);
            this.textBox9.TabIndex = 22;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(305, 188);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(103, 16);
            this.label16.TabIndex = 21;
            this.label16.Text = "Mô tả hoạt động";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(514, 252);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(142, 25);
            this.label14.TabIndex = 20;
            this.label14.Text = "Lịch hẹn cá nhân";
            // 
            // dgvLHCN
            // 
            this.dgvLHCN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLHCN.Location = new System.Drawing.Point(519, 291);
            this.dgvLHCN.Name = "dgvLHCN";
            this.dgvLHCN.RowHeadersWidth = 51;
            this.dgvLHCN.RowTemplate.Height = 24;
            this.dgvLHCN.Size = new System.Drawing.Size(430, 204);
            this.dgvLHCN.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(681, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "h";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(440, 107);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(255, 22);
            this.dateTimePicker1.TabIndex = 17;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(305, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Ngày khám";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBox6
            // 
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(440, 135);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(255, 22);
            this.textBox6.TabIndex = 15;
            this.textBox6.Text = "14";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(305, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Giờ khám";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(440, 79);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(255, 22);
            this.textBox5.TabIndex = 13;
            this.textBox5.Text = "Lê Huỳnh Phúc";
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(305, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Họ tên bệnh nhân";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Lịch hẹn khách hàng";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dgvLHKH
            // 
            this.dgvLHKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLHKH.Location = new System.Drawing.Point(24, 291);
            this.dgvLHKH.Name = "dgvLHKH";
            this.dgvLHKH.RowHeadersWidth = 51;
            this.dgvLHKH.RowTemplate.Height = 24;
            this.dgvLHKH.Size = new System.Drawing.Size(430, 204);
            this.dgvLHKH.TabIndex = 10;
            this.dgvLHKH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(383, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 35);
            this.label1.TabIndex = 9;
            this.label1.Text = "LỊCH HẸN HÔM NAY";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnMoreDetail
            // 
            this.btnMoreDetail.Location = new System.Drawing.Point(863, 12);
            this.btnMoreDetail.Name = "btnMoreDetail";
            this.btnMoreDetail.Size = new System.Drawing.Size(105, 30);
            this.btnMoreDetail.TabIndex = 0;
            this.btnMoreDetail.Text = "Xem toàn bộ";
            this.btnMoreDetail.UseVisualStyleBackColor = true;
            this.btnMoreDetail.Click += new System.EventHandler(this.btnMoreDetail_Click);
            // 
            // tpHoSoBenhAn
            // 
            this.tpHoSoBenhAn.Controls.Add(this.button9);
            this.tpHoSoBenhAn.Controls.Add(this.button8);
            this.tpHoSoBenhAn.Controls.Add(this.dataGridView3);
            this.tpHoSoBenhAn.Controls.Add(this.button6);
            this.tpHoSoBenhAn.Controls.Add(this.button7);
            this.tpHoSoBenhAn.Controls.Add(this.button4);
            this.tpHoSoBenhAn.Controls.Add(this.button5);
            this.tpHoSoBenhAn.Controls.Add(this.dataGridView4);
            this.tpHoSoBenhAn.Controls.Add(this.button3);
            this.tpHoSoBenhAn.Controls.Add(this.label13);
            this.tpHoSoBenhAn.Controls.Add(this.label12);
            this.tpHoSoBenhAn.Controls.Add(this.label11);
            this.tpHoSoBenhAn.Controls.Add(this.dataGridView2);
            this.tpHoSoBenhAn.Controls.Add(this.dateTimePicker2);
            this.tpHoSoBenhAn.Controls.Add(this.label10);
            this.tpHoSoBenhAn.Controls.Add(this.textBox8);
            this.tpHoSoBenhAn.Controls.Add(this.label9);
            this.tpHoSoBenhAn.Controls.Add(this.textBox7);
            this.tpHoSoBenhAn.Controls.Add(this.label8);
            this.tpHoSoBenhAn.Controls.Add(this.label7);
            this.tpHoSoBenhAn.Location = new System.Drawing.Point(4, 29);
            this.tpHoSoBenhAn.Name = "tpHoSoBenhAn";
            this.tpHoSoBenhAn.Padding = new System.Windows.Forms.Padding(3);
            this.tpHoSoBenhAn.Size = new System.Drawing.Size(974, 520);
            this.tpHoSoBenhAn.TabIndex = 4;
            this.tpHoSoBenhAn.Text = "Hồ sơ bệnh án";
            this.tpHoSoBenhAn.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(866, 73);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(88, 28);
            this.button9.TabIndex = 36;
            this.button9.Text = "Tạo mới";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(326, 350);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(95, 26);
            this.button8.TabIndex = 35;
            this.button8.Text = "Cập nhật";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(19, 196);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(402, 136);
            this.dataGridView3.TabIndex = 34;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(879, 167);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 33;
            this.button6.Text = "Sửa";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(798, 167);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 32;
            this.button7.Text = "Thêm";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(346, 167);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 31;
            this.button4.Text = "Sửa";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(265, 167);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 30;
            this.button5.Text = "Thêm";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(552, 196);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.Size = new System.Drawing.Size(402, 136);
            this.dataGridView4.TabIndex = 29;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(225, 349);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 27);
            this.button3.TabIndex = 27;
            this.button3.Text = "Sửa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(549, 174);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 16);
            this.label13.TabIndex = 24;
            this.label13.Text = "Dich vụ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 177);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 16);
            this.label12.TabIndex = 22;
            this.label12.Text = "Thuốc";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(14, 348);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(129, 25);
            this.label11.TabIndex = 21;
            this.label11.Text = "Hồ sơ bệnh án";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(19, 381);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(935, 121);
            this.dataGridView2.TabIndex = 20;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(170, 117);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(251, 22);
            this.dateTimePicker2.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 16);
            this.label10.TabIndex = 18;
            this.label10.Text = "Ngày khám";
            // 
            // textBox8
            // 
            this.textBox8.Enabled = false;
            this.textBox8.Location = new System.Drawing.Point(638, 117);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(316, 22);
            this.textBox8.TabIndex = 17;
            this.textBox8.Text = "sâu răng";
            this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(549, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Chẩn đoán";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // textBox7
            // 
            this.textBox7.Enabled = false;
            this.textBox7.Location = new System.Drawing.Point(170, 77);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(138, 22);
            this.textBox7.TabIndex = 15;
            this.textBox7.Text = "Lê Hoàng Phúc";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Họ tên bệnh nhân";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(387, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(213, 35);
            this.label7.TabIndex = 10;
            this.label7.Text = "HỒ SƠ BỆNH ÁN";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NhaSi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NhaSi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NHA SĨ";
            this.Load += new System.EventHandler(this.NhaSi_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpHoSo.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tpLichHen.ResumeLayout(false);
            this.tpLichHen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLHCN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLHKH)).EndInit();
            this.tpHoSoBenhAn.ResumeLayout(false);
            this.tpHoSoBenhAn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tpHoSo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TabPage tpLichHen;
        private TabPage tpHoSoBenhAn;
        private Panel panel2;
        private Label lbTTNS;
        private Panel panel1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button btnTDMK;
        private Label lbHoTen;
        private Label lbNgSinh;
        private Button btnCSTTCN;
        private Label lbDienThoai;
        private Label lbDiaChi;
        private PictureBox pictureBox1;
        private Button btnMoreDetail;
        private Label label1;
        private DataGridView dgvLHKH;
        private Label label2;
        private Button button1;
        private TextBox textBox5;
        private Label label3;
        private Label label5;
        private TextBox textBox6;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Label label6;
        private TextBox textBox8;
        private Label label9;
        private TextBox textBox7;
        private Label label8;
        private Label label7;
        private DateTimePicker dateTimePicker2;
        private Label label10;
        private Label label11;
        private DataGridView dataGridView2;
        private Label label12;
        private Label label13;
        private DataGridView dataGridView4;
        private Button button3;
        private Button button6;
        private Button button7;
        private Button button4;
        private Button button5;
        private DataGridView dataGridView3;
        private Label label14;
        private DataGridView dgvLHCN;
        private TextBox textBox10;
        private Label label18;
        private TextBox textBox9;
        private Label label16;
        private Button button8;
        private Button button9;
    }
}