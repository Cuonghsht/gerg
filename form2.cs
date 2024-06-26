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
    public partial class form2 : Form
    {
        public form2()
        {
            InitializeComponent();
            MessageBox.Show("Đăng nhập thành công ");
            HienThidata();
        }

        Model1 m = new Model1();
        public void HienThidata()
        {
            dataGridView1.DataSource = m.Students.ToList();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MaSV.Text = "";
            HoTen.Text = "";
            Email.Text = "";
            SDT.Text = "";
            nam.Checked = false;
            nu.Checked = false;
            DiaChi.Text = "";
            Hinh.ImageLocation = "";

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            var checktrung = (from i in m.Students where i.MaSV == MaSV.Text select i).FirstOrDefault();
            string gioitinh;
            if (nam.Checked == true)
            {
                gioitinh = "nam";
            }
            else
            {
                gioitinh = "Nu";
            }

            if (MaSV.Text == "" || HoTen.Text == "" || Email.Text == "" || SDT.Text == "" || DiaChi.Text == "")
            {
                MessageBox.Show("day nhap day du thong tin vao");
            }
            else
            {

                if (checktrung != null)
                {
                    MessageBox.Show("Sinh vien nay da ton tai");
                }
                else
                {
                    var a = new Student() { GioiTinh = gioitinh, MaSV = MaSV.Text, Email = Email.Text, DiaChi = DiaChi.Text, Hinh = Hinh.ImageLocation, HoTen = HoTen.Text, SDT = SDT.Text };
                    m.Students.Add(a);
                    m.SaveChanges();
                    MessageBox.Show("đã thêm thành công ");
                    HienThidata();
                }
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow a = dataGridView1.Rows[e.RowIndex];

                MaSV.Text = a.Cells["MaSV"].Value.ToString();
                HoTen.Text = a.Cells["HoTen"].Value.ToString();
                Email.Text = a.Cells["Email"].Value.ToString();
                SDT.Text = a.Cells["SDT"].Value.ToString();
                DiaChi.Text = a.Cells["DiaChi"].Value.ToString();
                caidachon = a.Cells["MaSV"].Value.ToString();

            }
        }
        public static string caidachon = "";
        private void Update_Click(object sender, EventArgs e)
        {


            Student ss = m.Students.Find(caidachon);
            ss.HoTen = HoTen.Text;
            ss.Email = Email.Text;
            ss.SDT = SDT.Text;
            ss.DiaChi = DiaChi.Text;
            m.SaveChanges();
            MessageBox.Show("cap nhat thanh cong");
            HienThidata();


        }

        private void delete_Click(object sender, EventArgs e)
        {
            var delete = ((from i in m.Students where i.MaSV == MaSV.Text select i).ToList()).FirstOrDefault();
            var delete2 = ((from i in m.Grades where i.MaSV == MaSV.Text select i).ToList()).FirstOrDefault();
            if (delete == null)
            {
                MessageBox.Show("Sinh viên này không tông tại ");
            }
            else
            {
                if (delete2 == null)
                {

                    m.Students.Remove(delete);
                    MessageBox.Show("đã xóa thành công ");
                    m.SaveChanges();
                    HienThidata();
                }
                else
                {
                    m.Grades.Remove(delete2);
                    m.Students.Remove(delete);
                    MessageBox.Show("đã xóa thành công ");
                    m.SaveChanges();
                    HienThidata();
                }
            }
        }

        private void nam_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void form2_Load(object sender, EventArgs e)
        {
            Hinh.Image = new Bitmap(Application.StartupPath + "\\Resources\\Screenshot 2024-03-23 144536.png");
            Hinh.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("ban co muon thoat khoi chuong trinh nay khong", "Xacnhan", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
