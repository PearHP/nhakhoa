namespace BTL_Lich
{
    partial class Calender
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cmpPreMonth = new System.Windows.Forms.Button();
            this.cmpNextMonth = new System.Windows.Forms.Button();
            this.cmdThu = new System.Windows.Forms.Button();
            this.cmdSun = new System.Windows.Forms.Button();
            this.cmdSat = new System.Windows.Forms.Button();
            this.cmdFri = new System.Windows.Forms.Button();
            this.cmdWed = new System.Windows.Forms.Button();
            this.cmdTue = new System.Windows.Forms.Button();
            this.cmdMon = new System.Windows.Forms.Button();
            this.pnlMaTrixNgay = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmdToDay = new System.Windows.Forms.Button();
            this.dtpkDate = new System.Windows.Forms.DateTimePicker();
            this.tmNotify = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(16, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(947, 518);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.pnlMaTrixNgay);
            this.panel2.Location = new System.Drawing.Point(0, 57);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(947, 462);
            this.panel2.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cmpPreMonth);
            this.panel4.Controls.Add(this.cmpNextMonth);
            this.panel4.Controls.Add(this.cmdThu);
            this.panel4.Controls.Add(this.cmdSun);
            this.panel4.Controls.Add(this.cmdSat);
            this.panel4.Controls.Add(this.cmdFri);
            this.panel4.Controls.Add(this.cmdWed);
            this.panel4.Controls.Add(this.cmdTue);
            this.panel4.Controls.Add(this.cmdMon);
            this.panel4.Location = new System.Drawing.Point(4, 4);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(939, 65);
            this.panel4.TabIndex = 2;
            // 
            // cmpPreMonth
            // 
            this.cmpPreMonth.Location = new System.Drawing.Point(4, 4);
            this.cmpPreMonth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmpPreMonth.Name = "cmpPreMonth";
            this.cmpPreMonth.Size = new System.Drawing.Size(80, 53);
            this.cmpPreMonth.TabIndex = 10;
            this.cmpPreMonth.Text = "<";
            this.cmpPreMonth.UseVisualStyleBackColor = true;
            this.cmpPreMonth.Click += new System.EventHandler(this.cmpPreMonth_Click);
            // 
            // cmpNextMonth
            // 
            this.cmpNextMonth.Location = new System.Drawing.Point(848, 4);
            this.cmpNextMonth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmpNextMonth.Name = "cmpNextMonth";
            this.cmpNextMonth.Size = new System.Drawing.Size(80, 53);
            this.cmpNextMonth.TabIndex = 9;
            this.cmpNextMonth.Text = ">";
            this.cmpNextMonth.UseVisualStyleBackColor = true;
            this.cmpNextMonth.Click += new System.EventHandler(this.cmpNextMonth_Click);
            // 
            // cmdThu
            // 
            this.cmdThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdThu.Location = new System.Drawing.Point(416, 4);
            this.cmdThu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdThu.Name = "cmdThu";
            this.cmdThu.Size = new System.Drawing.Size(100, 53);
            this.cmdThu.TabIndex = 3;
            this.cmdThu.Text = "Thứ 5";
            this.cmdThu.UseVisualStyleBackColor = true;
            // 
            // cmdSun
            // 
            this.cmdSun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSun.Location = new System.Drawing.Point(740, 4);
            this.cmdSun.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdSun.Name = "cmdSun";
            this.cmdSun.Size = new System.Drawing.Size(100, 53);
            this.cmdSun.TabIndex = 6;
            this.cmdSun.Text = "Chủ nhật";
            this.cmdSun.UseVisualStyleBackColor = true;
            // 
            // cmdSat
            // 
            this.cmdSat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSat.Location = new System.Drawing.Point(632, 4);
            this.cmdSat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdSat.Name = "cmdSat";
            this.cmdSat.Size = new System.Drawing.Size(100, 53);
            this.cmdSat.TabIndex = 5;
            this.cmdSat.Text = "Thứ 7";
            this.cmdSat.UseVisualStyleBackColor = true;
            // 
            // cmdFri
            // 
            this.cmdFri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdFri.Location = new System.Drawing.Point(524, 4);
            this.cmdFri.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdFri.Name = "cmdFri";
            this.cmdFri.Size = new System.Drawing.Size(100, 53);
            this.cmdFri.TabIndex = 4;
            this.cmdFri.Text = "Thứ 6";
            this.cmdFri.UseVisualStyleBackColor = true;
            // 
            // cmdWed
            // 
            this.cmdWed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdWed.Location = new System.Drawing.Point(308, 4);
            this.cmdWed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdWed.Name = "cmdWed";
            this.cmdWed.Size = new System.Drawing.Size(100, 53);
            this.cmdWed.TabIndex = 2;
            this.cmdWed.Text = "Thứ 4";
            this.cmdWed.UseVisualStyleBackColor = true;
            // 
            // cmdTue
            // 
            this.cmdTue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdTue.Location = new System.Drawing.Point(200, 4);
            this.cmdTue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdTue.Name = "cmdTue";
            this.cmdTue.Size = new System.Drawing.Size(100, 53);
            this.cmdTue.TabIndex = 1;
            this.cmdTue.Text = "Thứ 3";
            this.cmdTue.UseVisualStyleBackColor = true;
            // 
            // cmdMon
            // 
            this.cmdMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdMon.Location = new System.Drawing.Point(92, 4);
            this.cmdMon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdMon.Name = "cmdMon";
            this.cmdMon.Size = new System.Drawing.Size(100, 53);
            this.cmdMon.TabIndex = 0;
            this.cmdMon.Text = "Thứ 2";
            this.cmdMon.UseVisualStyleBackColor = true;
            // 
            // pnlMaTrixNgay
            // 
            this.pnlMaTrixNgay.Location = new System.Drawing.Point(96, 76);
            this.pnlMaTrixNgay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlMaTrixNgay.Name = "pnlMaTrixNgay";
            this.pnlMaTrixNgay.Size = new System.Drawing.Size(752, 374);
            this.pnlMaTrixNgay.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cmdToDay);
            this.panel3.Controls.Add(this.dtpkDate);
            this.panel3.Location = new System.Drawing.Point(4, 4);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(939, 46);
            this.panel3.TabIndex = 1;
            // 
            // cmdToDay
            // 
            this.cmdToDay.Location = new System.Drawing.Point(611, 4);
            this.cmdToDay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdToDay.Name = "cmdToDay";
            this.cmdToDay.Size = new System.Drawing.Size(100, 28);
            this.cmdToDay.TabIndex = 1;
            this.cmdToDay.Text = "Hôm nay";
            this.cmdToDay.UseVisualStyleBackColor = true;
            this.cmdToDay.Click += new System.EventHandler(this.cmdToDay_Click);
            // 
            // dtpkDate
            // 
            this.dtpkDate.Location = new System.Drawing.Point(308, 7);
            this.dtpkDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpkDate.Name = "dtpkDate";
            this.dtpkDate.Size = new System.Drawing.Size(268, 22);
            this.dtpkDate.TabIndex = 0;
            this.dtpkDate.ValueChanged += new System.EventHandler(this.dtpkDate_ValueChanged);
            // 
            // tmNotify
            // 
            this.tmNotify.Enabled = true;
            this.tmNotify.Interval = 5000;
            this.tmNotify.Tick += new System.EventHandler(this.tmNotify_Tick);
            // 
            // Calender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(978, 530);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Calender";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calendar";
            this.Load += new System.EventHandler(this.Calender_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button cmdThu;
        private System.Windows.Forms.Button cmdSun;
        private System.Windows.Forms.Button cmdSat;
        private System.Windows.Forms.Button cmdFri;
        private System.Windows.Forms.Button cmdWed;
        private System.Windows.Forms.Button cmdTue;
        private System.Windows.Forms.Button cmdMon;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button cmdToDay;
        private System.Windows.Forms.DateTimePicker dtpkDate;
        private System.Windows.Forms.Panel pnlMaTrixNgay;
        private System.Windows.Forms.Button cmpNextMonth;
        private System.Windows.Forms.Button btnPreMonth;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button cmpPreMonth;
        private System.Windows.Forms.Timer tmNotify;
    }
}

