namespace Assiment2_NET103
{
    partial class form2
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nu = new System.Windows.Forms.RadioButton();
            this.nam = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaSV = new System.Windows.Forms.TextBox();
            this.HoTen = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.SDT = new System.Windows.Forms.TextBox();
            this.Hinh = new System.Windows.Forms.PictureBox();
            this.New = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.DiaChi = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hinh)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "MaSV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ Tên ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Email ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "SDT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Giới Tính ";
            // 
            // nu
            // 
            this.nu.AutoSize = true;
            this.nu.Location = new System.Drawing.Point(296, 176);
            this.nu.Name = "nu";
            this.nu.Size = new System.Drawing.Size(48, 20);
            this.nu.TabIndex = 2;
            this.nu.TabStop = true;
            this.nu.Text = "Nữ ";
            this.nu.UseVisualStyleBackColor = true;
            // 
            // nam
            // 
            this.nam.AutoSize = true;
            this.nam.Location = new System.Drawing.Point(149, 176);
            this.nam.Name = "nam";
            this.nam.Size = new System.Drawing.Size(60, 20);
            this.nam.TabIndex = 2;
            this.nam.TabStop = true;
            this.nam.Text = "Nam ";
            this.nam.UseVisualStyleBackColor = true;
            this.nam.CheckedChanged += new System.EventHandler(this.nam_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 266);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(795, 184);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // MaSV
            // 
            this.MaSV.Location = new System.Drawing.Point(149, 25);
            this.MaSV.Name = "MaSV";
            this.MaSV.Size = new System.Drawing.Size(195, 22);
            this.MaSV.TabIndex = 4;
            // 
            // HoTen
            // 
            this.HoTen.Location = new System.Drawing.Point(149, 60);
            this.HoTen.Name = "HoTen";
            this.HoTen.Size = new System.Drawing.Size(195, 22);
            this.HoTen.TabIndex = 4;
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(149, 98);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(195, 22);
            this.Email.TabIndex = 4;
            // 
            // SDT
            // 
            this.SDT.Location = new System.Drawing.Point(149, 138);
            this.SDT.Name = "SDT";
            this.SDT.Size = new System.Drawing.Size(195, 22);
            this.SDT.TabIndex = 4;
            // 
            // Hinh
            // 
            this.Hinh.InitialImage = null;
            this.Hinh.Location = new System.Drawing.Point(411, 12);
            this.Hinh.Name = "Hinh";
            this.Hinh.Size = new System.Drawing.Size(135, 130);
            this.Hinh.TabIndex = 5;
            this.Hinh.TabStop = false;
            this.Hinh.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // New
            // 
            this.New.Location = new System.Drawing.Point(423, 176);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(66, 29);
            this.New.TabIndex = 6;
            this.New.Text = "New";
            this.New.UseVisualStyleBackColor = true;
            this.New.Click += new System.EventHandler(this.button1_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(495, 176);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(66, 29);
            this.Save.TabIndex = 6;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(495, 224);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(66, 29);
            this.Update.TabIndex = 6;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Địa Chỉ  ";
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(423, 222);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(60, 31);
            this.delete.TabIndex = 8;
            this.delete.Text = "delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // DiaChi
            // 
            this.DiaChi.Location = new System.Drawing.Point(146, 202);
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Size = new System.Drawing.Size(197, 50);
            this.DiaChi.TabIndex = 9;
            this.DiaChi.Text = "";
            // 
            // form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DiaChi);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.New);
            this.Controls.Add(this.Hinh);
            this.Controls.Add(this.SDT);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.HoTen);
            this.Controls.Add(this.MaSV);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.nam);
            this.Controls.Add(this.nu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "form2";
            this.Text = "form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.form2_FormClosing);
            this.Load += new System.EventHandler(this.form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton nu;
        private System.Windows.Forms.RadioButton nam;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox MaSV;
        private System.Windows.Forms.TextBox HoTen;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox SDT;
        private System.Windows.Forms.PictureBox Hinh;
        private System.Windows.Forms.Button New;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.RichTextBox DiaChi;
    }
}