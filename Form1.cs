using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assiment2_NET103
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Model1 m = new Model1();
        private void Login_Click(object sender, EventArgs e)
        {
            var check = (from i in m.Userss where (i.Username == TaiKhoan.Text && i.Password == MatKhau.Text) select i).FirstOrDefault();
            if (TaiKhoan.Text == "" || MatKhau.Text == "")
            {
                MessageBox.Show("Không được để trống tài khỏan và mật khẩu ");
            }
            else if (check == null)
            {
                MessageBox.Show("tài khoản hoặc mật khẩu không chính xác ");
            }
            else
            {

                var checkrole = m.Userss.Find(TaiKhoan.Text);
                if (checkrole.Role == "canbodaotao")
                {
                    form2 form2 = new form2();
                    form2.FormClosed += (x, y) => this.Show();
                    form2.Show();
                    this.Hide();
                }
                else
                {
                    Form3 f = new Form3();
                    f.FormClosed += (x, y) => this.Show();
                    f.Show();
                    this.Hide();
                }
            }

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" Xác nhận thoát khỏi chương trình", "Xác Nhận", MessageBoxButtons.YesNo)== DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void MatKhau_TextChanged(object sender, EventArgs e)
        {
            MatKhau.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (MatKhau.PasswordChar =='\0')
            {
                MatKhau.PasswordChar = '*';
            }
            else
            {
                MatKhau.PasswordChar = '\0';

            }
        }
    }
}
