namespace btDichVuKhamBenh
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lsbdichvu = new System.Windows.Forms.ListBox();
            this.lsbdanhsach = new System.Windows.Forms.ListBox();
            this.txbhoten = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnchon = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.rtbthongtin = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txbngay = new System.Windows.Forms.TextBox();
            this.txbthang = new System.Windows.Forms.TextBox();
            this.txbnam = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(88, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dịch Vụ Khám Bệnh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên bệnh nhân:";
            // 
            // lsbdichvu
            // 
            this.lsbdichvu.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbdichvu.FormattingEnabled = true;
            this.lsbdichvu.ItemHeight = 15;
            this.lsbdichvu.Items.AddRange(new object[] {
            "Siêu Âm",
            "Thử máu",
            "Nội Soi",
            "X-Quang"});
            this.lsbdichvu.Location = new System.Drawing.Point(49, 151);
            this.lsbdichvu.Name = "lsbdichvu";
            this.lsbdichvu.Size = new System.Drawing.Size(120, 64);
            this.lsbdichvu.TabIndex = 2;
            this.lsbdichvu.SelectedIndexChanged += new System.EventHandler(this.lsbdichvu_SelectedIndexChanged);
            // 
            // lsbdanhsach
            // 
            this.lsbdanhsach.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbdanhsach.FormattingEnabled = true;
            this.lsbdanhsach.ItemHeight = 15;
            this.lsbdanhsach.Location = new System.Drawing.Point(222, 151);
            this.lsbdanhsach.Name = "lsbdanhsach";
            this.lsbdanhsach.Size = new System.Drawing.Size(120, 64);
            this.lsbdanhsach.TabIndex = 3;
            // 
            // txbhoten
            // 
            this.txbhoten.Location = new System.Drawing.Point(159, 64);
            this.txbhoten.Name = "txbhoten";
            this.txbhoten.Size = new System.Drawing.Size(183, 20);
            this.txbhoten.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Chọn dịch vụ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(229, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Danh sách đã chọn:";
            // 
            // btnchon
            // 
            this.btnchon.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchon.ForeColor = System.Drawing.Color.Red;
            this.btnchon.Location = new System.Drawing.Point(63, 229);
            this.btnchon.Name = "btnchon";
            this.btnchon.Size = new System.Drawing.Size(75, 23);
            this.btnchon.TabIndex = 8;
            this.btnchon.Text = "Chọn";
            this.btnchon.UseVisualStyleBackColor = true;
            this.btnchon.Click += new System.EventHandler(this.btnchon_Click);
            // 
            // btnreset
            // 
            this.btnreset.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.ForeColor = System.Drawing.Color.Red;
            this.btnreset.Location = new System.Drawing.Point(159, 229);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(75, 23);
            this.btnreset.TabIndex = 9;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.ForeColor = System.Drawing.Color.Red;
            this.btnthoat.Location = new System.Drawing.Point(257, 229);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 10;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // rtbthongtin
            // 
            this.rtbthongtin.Location = new System.Drawing.Point(49, 258);
            this.rtbthongtin.Name = "rtbthongtin";
            this.rtbthongtin.Size = new System.Drawing.Size(293, 115);
            this.rtbthongtin.TabIndex = 11;
            this.rtbthongtin.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(51, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ngày";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(151, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tháng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(258, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Năm";
            // 
            // txbngay
            // 
            this.txbngay.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbngay.Location = new System.Drawing.Point(89, 94);
            this.txbngay.Name = "txbngay";
            this.txbngay.Size = new System.Drawing.Size(31, 22);
            this.txbngay.TabIndex = 15;
            this.txbngay.TextChanged += new System.EventHandler(this.txbngay_TextChanged);
            // 
            // txbthang
            // 
            this.txbthang.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbthang.Location = new System.Drawing.Point(195, 94);
            this.txbthang.Name = "txbthang";
            this.txbthang.Size = new System.Drawing.Size(31, 22);
            this.txbthang.TabIndex = 16;
            this.txbthang.TextChanged += new System.EventHandler(this.txbthang_TextChanged);
            // 
            // txbnam
            // 
            this.txbnam.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbnam.Location = new System.Drawing.Point(293, 95);
            this.txbnam.Name = "txbnam";
            this.txbnam.Size = new System.Drawing.Size(49, 22);
            this.txbnam.TabIndex = 17;
            this.txbnam.TextChanged += new System.EventHandler(this.txbnam_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(407, 395);
            this.Controls.Add(this.txbnam);
            this.Controls.Add(this.txbthang);
            this.Controls.Add(this.txbngay);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rtbthongtin);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btnchon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbhoten);
            this.Controls.Add(this.lsbdanhsach);
            this.Controls.Add(this.lsbdichvu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lsbdichvu;
        private System.Windows.Forms.ListBox lsbdanhsach;
        private System.Windows.Forms.TextBox txbhoten;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnchon;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.RichTextBox rtbthongtin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbngay;
        private System.Windows.Forms.TextBox txbthang;
        private System.Windows.Forms.TextBox txbnam;
    }
}

