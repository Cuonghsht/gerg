using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assiment2_NET103
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            MessageBox.Show("Đăng nhập thành công ");
            InitializeComponent();
            loaddata();
            HoTen.Enabled = false;
            DiemTB.Enabled = false;
        }
        public Model1 m = new Model1();
        public void loaddata()
        {
            var a = (from i in m.Grades join n in m.Students on i.MaSV equals n.MaSV select new { Id = i.Id, HoVaTen = n.HoTen, MaSV = i.MaSV, TA = i.TA, GDTC = i.GDTC, TinHoc = i.TinHoc, DTB = ((i.TA + i.TinHoc + i.GDTC) / 3) });
            var hienthitop3 = a.OrderByDescending(x => x.DTB).Take(3).ToList();

            dataGridView1.DataSource = hienthitop3.ToList();

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void HoTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {
           if(MaSVHien.Text == "")
            {
                MessageBox.Show("nhap vao thong tin");
            }
            else
            {
                var delete = m.Grades.FirstOrDefault(s => s.Id == idfake);
                if (delete != null)
                {
                    m.Grades.Remove(delete);
                    m.SaveChanges();
                    MessageBox.Show("đã xóa thành công");
                    loaddata();
                }
                else
                {
                    MessageBox.Show("không tồn tại ");
                }
            }

        }

        void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                var a = dataGridView1.Rows[e.RowIndex];
                MaSVHien.Text = a.Cells["MaSV"].Value.ToString();
                TiengAnh.Text = a.Cells["TA"].Value.ToString();
                TinHoc.Text = a.Cells["TinHoc"].Value.ToString();
                GDTC.Text = a.Cells["GDTC"].Value.ToString();
                DiemTB.Text = a.Cells["DTB"].Value.ToString();
                idfake = Convert.ToInt32(a.Cells["ID"].Value.ToString());
                HoTen.Text = a.Cells["HoVaTen"].Value.ToString();
            }

        }

        public int idfake = 0;

        private void Save_Click(object sender, EventArgs e)
        {
            if (MaSVHien.Text == "" || TiengAnh.Text == "" || TinHoc.Text == "" || GDTC.Text == "")
            {
                MessageBox.Show("hay nhap day du thong tim");
            }
            else
            {
                {
                    var c = (from i in m.Students where i.MaSV == MaSVHien.Text select i.MaSV).FirstOrDefault();
                    if (c != null)
                    {
                        var checkdacodiem = (from i in m.Grades where i.MaSV == MaSVHien.Text select i).FirstOrDefault();
                        if (checkdacodiem != null)
                        {
                            MessageBox.Show("Sinh viên này dã có trong danh sách điểm ");
                        }
                        else
                        {
                            var d = MaSVHien.Text;
                            var check = m.Students.FirstOrDefault(s => s.MaSV == d.ToString());

                            var tin = Convert.ToInt32(TinHoc.Text);
                            var ta = int.Parse(TiengAnh.Text);
                            var gdtc = int.Parse(GDTC.Text);

                            var a = new Grade() { MaSV = MaSVHien.Text, TinHoc = tin, TA = ta, GDTC = gdtc };
                            m.Grades.Add(a);
                            MessageBox.Show("da them thanh cong");
                            m.SaveChanges();
                            loaddata();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Sinh viên này không tồn tại");
                    }
                }
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void New_Click(object sender, EventArgs e)
        {

            MaSVHien.Text = "";
            MaSV.Text = "";
            TiengAnh.Text = "";
            TinHoc.Text = "";
            GDTC.Text = "";
            DiemTB.Text = "";

            HoTen.Text = "";
            loaddata();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            var update = m.Grades.Find(idfake);
            if (update == null)
            {
                MessageBox.Show(" Sv nay khong ton tai");
            }
            else
            {
                var check = (from z in m.Students where z.MaSV == MaSVHien.Text select z.MaSV).FirstOrDefault();
                if (check != null)
                {
                    update.MaSV = MaSVHien.Text;
                    update.TinHoc = int.Parse(TinHoc.Text);
                    update.GDTC = int.Parse(GDTC.Text);
                    update.TA = int.Parse(TiengAnh.Text);

                    m.SaveChanges();
                    MessageBox.Show("đã cập nhật thành công thông tin của sinh viên");
                    loaddata();
                }
                else
                {
                    MessageBox.Show($"Không tồn tại sinh viên có mã số {MaSVHien.Text}");
                }
            }
        }

        private void TimKiem_Click(object sender, EventArgs e)
        {
            var timkiem = (from a in m.Students where a.MaSV == MaSV.Text select a).FirstOrDefault();
            if (timkiem == null)
            {
                MessageBox.Show("Mã sinh viên này không tồn tại ");


            }
            else
            {

                var timkiemdiem = (from a in m.Grades where a.MaSV == MaSV.Text select a).FirstOrDefault();
                if (timkiemdiem == null)
                {
                    MessageBox.Show("Sinh vien nay chua duoc nhap diem");
                }
                else
                {
                    var a = from i in m.Grades join n in m.Students on i.MaSV equals n.MaSV where i.MaSV == MaSV.Text select new { Id = i.Id, HoVaTen = n.HoTen, MaSV = i.MaSV, TA = i.TA, GDTC = i.GDTC, TinHoc = i.TinHoc, DTB = ((i.TA + i.TinHoc + i.GDTC) / 3) };
                    var htten = a.FirstOrDefault()?.HoVaTen;
                    HoTen.Text = htten;
                    var ht = a.FirstOrDefault()?.MaSV;
                    MaSVHien.Text = ht;
                    var htta = a.FirstOrDefault()?.TA;
                    TiengAnh.Text = htta.ToString();
                    var htth = a.FirstOrDefault()?.TinHoc;
                    TinHoc.Text = htth.ToString();
                    var htcdtc = a.FirstOrDefault()?.GDTC;
                    GDTC.Text = htcdtc.ToString();
                    dataGridView1.DataSource = a.ToList();
                    var dtb = a.FirstOrDefault()?.DTB;
                    DiemTB.Text = dtb.ToString();
                    MessageBox.Show("Đã tìm thành công ");
                    dataGridView1.DataSource = a.ToList();

                }
            }




        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
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

        private void DiemTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
