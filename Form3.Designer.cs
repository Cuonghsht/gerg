namespace Assiment2_NET103
{
    partial class Form3
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
            this.MaSV = new System.Windows.Forms.TextBox();
            this.TimKiem = new System.Windows.Forms.Button();
            this.New = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.HoTen = new System.Windows.Forms.TextBox();
            this.MaSVHien = new System.Windows.Forms.TextBox();
            this.TiengAnh = new System.Windows.Forms.TextBox();
            this.TinHoc = new System.Windows.Forms.TextBox();
            this.GDTC = new System.Windows.Forms.TextBox();
            this.Delete = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DiemTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã SV:";
            // 
            // MaSV
            // 
            this.MaSV.Location = new System.Drawing.Point(130, 22);
            this.MaSV.Name = "MaSV";
            this.MaSV.Size = new System.Drawing.Size(222, 22);
            this.MaSV.TabIndex = 2;
            // 
            // TimKiem
            // 
            this.TimKiem.Location = new System.Drawing.Point(433, 15);
            this.TimKiem.Name = "TimKiem";
            this.TimKiem.Size = new System.Drawing.Size(145, 34);
            this.TimKiem.TabIndex = 3;
            this.TimKiem.Text = "Tìm Kiếm ";
            this.TimKiem.UseVisualStyleBackColor = true;
            this.TimKiem.Click += new System.EventHandler(this.TimKiem_Click);
            // 
            // New
            // 
            this.New.Location = new System.Drawing.Point(546, 9);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(111, 34);
            this.New.TabIndex = 3;
            this.New.Text = "New";
            this.New.UseVisualStyleBackColor = true;
            this.New.Click += new System.EventHandler(this.New_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TimKiem);
            this.groupBox1.Controls.Add(this.MaSV);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(82, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(597, 69);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ tên SV";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã SV";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tiếng Anh ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tin Học ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "GDTC";
            // 
            // HoTen
            // 
            this.HoTen.Location = new System.Drawing.Point(140, 21);
            this.HoTen.Name = "HoTen";
            this.HoTen.Size = new System.Drawing.Size(156, 22);
            this.HoTen.TabIndex = 2;
            this.HoTen.TextChanged += new System.EventHandler(this.HoTen_TextChanged);
            // 
            // MaSVHien
            // 
            this.MaSVHien.Location = new System.Drawing.Point(140, 64);
            this.MaSVHien.Name = "MaSVHien";
            this.MaSVHien.Size = new System.Drawing.Size(156, 22);
            this.MaSVHien.TabIndex = 2;
            // 
            // TiengAnh
            // 
            this.TiengAnh.Location = new System.Drawing.Point(140, 115);
            this.TiengAnh.Name = "TiengAnh";
            this.TiengAnh.Size = new System.Drawing.Size(156, 22);
            this.TiengAnh.TabIndex = 2;
            // 
            // TinHoc
            // 
            this.TinHoc.Location = new System.Drawing.Point(140, 167);
            this.TinHoc.Name = "TinHoc";
            this.TinHoc.Size = new System.Drawing.Size(156, 22);
            this.TinHoc.TabIndex = 2;
            // 
            // GDTC
            // 
            this.GDTC.Location = new System.Drawing.Point(140, 209);
            this.GDTC.Name = "GDTC";
            this.GDTC.Size = new System.Drawing.Size(156, 22);
            this.GDTC.TabIndex = 2;
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(546, 135);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(111, 34);
            this.Delete.TabIndex = 3;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(546, 194);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(111, 34);
            this.Update.TabIndex = 3;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(546, 67);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(111, 34);
            this.Save.TabIndex = 3;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DiemTB);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.Save);
            this.groupBox2.Controls.Add(this.Update);
            this.groupBox2.Controls.Add(this.New);
            this.groupBox2.Controls.Add(this.Delete);
            this.groupBox2.Controls.Add(this.GDTC);
            this.groupBox2.Controls.Add(this.TinHoc);
            this.groupBox2.Controls.Add(this.TiengAnh);
            this.groupBox2.Controls.Add(this.MaSVHien);
            this.groupBox2.Controls.Add(this.HoTen);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(82, 147);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(671, 271);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // DiemTB
            // 
            this.DiemTB.Location = new System.Drawing.Point(433, 135);
            this.DiemTB.Name = "DiemTB";
            this.DiemTB.Size = new System.Drawing.Size(73, 22);
            this.DiemTB.TabIndex = 5;
            this.DiemTB.TextChanged += new System.EventHandler(this.DiemTB_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(442, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Điểm TB";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(5, 431);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(787, 128);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 566);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form3";
            this.Text = "Form3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MaSV;
        private System.Windows.Forms.Button TimKiem;
        private System.Windows.Forms.Button New;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox HoTen;
        private System.Windows.Forms.TextBox MaSVHien;
        private System.Windows.Forms.TextBox TiengAnh;
        private System.Windows.Forms.TextBox TinHoc;
        private System.Windows.Forms.TextBox GDTC;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox DiemTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}