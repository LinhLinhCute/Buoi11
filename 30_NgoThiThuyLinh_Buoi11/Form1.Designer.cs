namespace _30_NgoThiThuyLinh_Buoi11
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
            this.components = new System.ComponentModel.Container();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Hien = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.dgv_SinhVien = new System.Windows.Forms.DataGridView();
            this.grb_ThayDoi = new System.Windows.Forms.GroupBox();
            this.txt_MaSV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Ten = new System.Windows.Forms.TextBox();
            this.txt_Lop = new System.Windows.Forms.TextBox();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txt_NgaySinh = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.btn_TaoId = new System.Windows.Forms.Button();
            this.btn_RandomId = new System.Windows.Forms.Button();
            this.btn_TG = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SinhVien)).BeginInit();
            this.grb_ThayDoi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(12, 184);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(75, 23);
            this.btn_Them.TabIndex = 0;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Hien
            // 
            this.btn_Hien.Location = new System.Drawing.Point(153, 184);
            this.btn_Hien.Name = "btn_Hien";
            this.btn_Hien.Size = new System.Drawing.Size(75, 23);
            this.btn_Hien.TabIndex = 1;
            this.btn_Hien.Text = "Hiện Thị";
            this.btn_Hien.UseVisualStyleBackColor = true;
            this.btn_Hien.Click += new System.EventHandler(this.btn_Hien_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(307, 184);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_Xoa.TabIndex = 2;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(470, 184);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 3;
            this.btn_Update.Text = "Cập nhật";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // dgv_SinhVien
            // 
            this.dgv_SinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SinhVien.Location = new System.Drawing.Point(12, 12);
            this.dgv_SinhVien.Name = "dgv_SinhVien";
            this.dgv_SinhVien.Size = new System.Drawing.Size(533, 148);
            this.dgv_SinhVien.TabIndex = 5;
            this.dgv_SinhVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_SinhVien_CellContentClick);
            // 
            // grb_ThayDoi
            // 
            this.grb_ThayDoi.Controls.Add(this.pictureBox1);
            this.grb_ThayDoi.Controls.Add(this.txt_NgaySinh);
            this.grb_ThayDoi.Controls.Add(this.txt_DiaChi);
            this.grb_ThayDoi.Controls.Add(this.txt_Lop);
            this.grb_ThayDoi.Controls.Add(this.txt_Ten);
            this.grb_ThayDoi.Controls.Add(this.label5);
            this.grb_ThayDoi.Controls.Add(this.label4);
            this.grb_ThayDoi.Controls.Add(this.label3);
            this.grb_ThayDoi.Controls.Add(this.label2);
            this.grb_ThayDoi.Controls.Add(this.label1);
            this.grb_ThayDoi.Controls.Add(this.txt_MaSV);
            this.grb_ThayDoi.Location = new System.Drawing.Point(27, 239);
            this.grb_ThayDoi.Name = "grb_ThayDoi";
            this.grb_ThayDoi.Size = new System.Drawing.Size(495, 144);
            this.grb_ThayDoi.TabIndex = 6;
            this.grb_ThayDoi.TabStop = false;
            this.grb_ThayDoi.Text = "CapNhat";
            // 
            // txt_MaSV
            // 
            this.txt_MaSV.Location = new System.Drawing.Point(77, 19);
            this.txt_MaSV.Name = "txt_MaSV";
            this.txt_MaSV.Size = new System.Drawing.Size(100, 20);
            this.txt_MaSV.TabIndex = 0;
            this.txt_MaSV.TextChanged += new System.EventHandler(this.txt_MaSV_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "MaSV:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "TênSV :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "MaLop :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "NgaySinh :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(277, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "DiaChi :";
            // 
            // txt_Ten
            // 
            this.txt_Ten.Location = new System.Drawing.Point(77, 46);
            this.txt_Ten.Name = "txt_Ten";
            this.txt_Ten.Size = new System.Drawing.Size(209, 20);
            this.txt_Ten.TabIndex = 6;
            // 
            // txt_Lop
            // 
            this.txt_Lop.Location = new System.Drawing.Point(77, 77);
            this.txt_Lop.Name = "txt_Lop";
            this.txt_Lop.Size = new System.Drawing.Size(100, 20);
            this.txt_Lop.TabIndex = 7;
            this.txt_Lop.TextChanged += new System.EventHandler(this.txt_Lop_TextChanged);
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(342, 13);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(147, 20);
            this.txt_DiaChi.TabIndex = 8;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txt_NgaySinh
            // 
            this.txt_NgaySinh.Location = new System.Drawing.Point(77, 110);
            this.txt_NgaySinh.Name = "txt_NgaySinh";
            this.txt_NgaySinh.Size = new System.Drawing.Size(209, 20);
            this.txt_NgaySinh.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(342, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 81);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 411);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Random ID:";
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(70, 406);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(196, 20);
            this.txt_Id.TabIndex = 8;
            // 
            // btn_TaoId
            // 
            this.btn_TaoId.Location = new System.Drawing.Point(272, 406);
            this.btn_TaoId.Name = "btn_TaoId";
            this.btn_TaoId.Size = new System.Drawing.Size(75, 23);
            this.btn_TaoId.TabIndex = 9;
            this.btn_TaoId.Text = "Tạo";
            this.btn_TaoId.UseVisualStyleBackColor = true;
            this.btn_TaoId.Click += new System.EventHandler(this.btn_TaoId_Click);
            // 
            // btn_RandomId
            // 
            this.btn_RandomId.Location = new System.Drawing.Point(353, 406);
            this.btn_RandomId.Name = "btn_RandomId";
            this.btn_RandomId.Size = new System.Drawing.Size(93, 23);
            this.btn_RandomId.TabIndex = 10;
            this.btn_RandomId.Text = "Tạo Random";
            this.btn_RandomId.UseVisualStyleBackColor = true;
            this.btn_RandomId.Click += new System.EventHandler(this.btn_RandomId_Click);
            // 
            // btn_TG
            // 
            this.btn_TG.Location = new System.Drawing.Point(452, 405);
            this.btn_TG.Name = "btn_TG";
            this.btn_TG.Size = new System.Drawing.Size(90, 23);
            this.btn_TG.TabIndex = 11;
            this.btn_TG.Text = "Tạo theo giờ";
            this.btn_TG.UseVisualStyleBackColor = true;
            this.btn_TG.Click += new System.EventHandler(this.btn_TG_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 463);
            this.Controls.Add(this.btn_TG);
            this.Controls.Add(this.btn_RandomId);
            this.Controls.Add(this.btn_TaoId);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.grb_ThayDoi);
            this.Controls.Add(this.dgv_SinhVien);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Hien);
            this.Controls.Add(this.btn_Them);
            this.Name = "Form1";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SinhVien)).EndInit();
            this.grb_ThayDoi.ResumeLayout(false);
            this.grb_ThayDoi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Hien;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.DataGridView dgv_SinhVien;
        private System.Windows.Forms.GroupBox grb_ThayDoi;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.TextBox txt_Lop;
        private System.Windows.Forms.TextBox txt_Ten;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_MaSV;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txt_NgaySinh;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_TaoId;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_TG;
        private System.Windows.Forms.Button btn_RandomId;
    }
}

