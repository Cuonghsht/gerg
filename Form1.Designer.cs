namespace Assiment2_NET103
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
            this.TaiKhoan = new System.Windows.Forms.TextBox();
            this.MatKhau = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password";
            // 
            // TaiKhoan
            // 
            this.TaiKhoan.Location = new System.Drawing.Point(254, 46);
            this.TaiKhoan.Name = "TaiKhoan";
            this.TaiKhoan.Size = new System.Drawing.Size(227, 22);
            this.TaiKhoan.TabIndex = 1;
            // 
            // MatKhau
            // 
            this.MatKhau.Location = new System.Drawing.Point(254, 98);
            this.MatKhau.Name = "MatKhau";
            this.MatKhau.Size = new System.Drawing.Size(227, 22);
            this.MatKhau.TabIndex = 1;
            this.MatKhau.TextChanged += new System.EventHandler(this.MatKhau_TextChanged);
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(254, 191);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(82, 26);
            this.Login.TabIndex = 2;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(399, 191);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(82, 26);
            this.Cancel.TabIndex = 2;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(500, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 26);
            this.button1.TabIndex = 3;
            this.button1.Text = "👁️";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.MatKhau);
            this.Controls.Add(this.TaiKhoan);
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
        private System.Windows.Forms.TextBox TaiKhoan;
        private System.Windows.Forms.TextBox MatKhau;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button button1;
    }
}

