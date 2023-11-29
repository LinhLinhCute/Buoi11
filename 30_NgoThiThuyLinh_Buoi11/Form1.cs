using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Imaging;

namespace _30_NgoThiThuyLinh_Buoi11
{
    public partial class Form1 : Form
    {
        Connect cont = new Connect();
        SqlConnection consql;
        DataSet ds_QL;
        DataColumn[] key = new DataColumn[1];
        public Form1()
        {
            InitializeComponent();
            consql = cont.connect;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               
               if(consql.State == ConnectionState.Closed)
               {
                   consql.Open();
               }
                string Insert;
                Insert = "insert into SinhVien values("+txt_MaSV.Text+",N'"+txt_Ten.Text+"',"+txt_Lop.Text+",'"+txt_NgaySinh.Text+"',N'"+txt_DiaChi.Text +"')";
                SqlCommand cmd = new SqlCommand(Insert, consql);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công!");
                if (consql.State == ConnectionState.Open)
                {
                    consql.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            

        }

        private void btn_Hien_Click(object sender, EventArgs e)
        {
            try
            {
               
                string read;
                read = "select * from SinhVien";
                DataSet ds = new DataSet();
                // tạo dataAdapter
                SqlDataAdapter da = new SqlDataAdapter(read, consql);
                // đổ dữ liệu vào dataset
                da.Fill(ds, "SinhVien");
                //Gán dữ liệu vào datagridview
                dgv_SinhVien.DataSource = ds.Tables["SinhVien"];
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_MaSV_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Length > 0 && !Char.IsDigit(ctr.Text[ctr.Text.Length - 1]))
            {
                this.errorProvider1.SetError(ctr, "Bạn phải nhập số");
            }
            else
                this.errorProvider1.Clear();
        }

        private void txt_Lop_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Length > 0 && !Char.IsDigit(ctr.Text[ctr.Text.Length - 1]))
            {
                this.errorProvider1.SetError(ctr, "Bạn phải nhập số");
            }
            else
                this.errorProvider1.Clear();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {

                if (consql.State == ConnectionState.Closed)
                {
                    consql.Open();
                }
                string Delete;
                Delete = "Delete SinhVien where MaSV="+txt_MaSV.Text+"";
                
                SqlCommand cmd = new SqlCommand(Delete, consql);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công!");
                if (consql.State == ConnectionState.Open)
                {
                    consql.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {

                if (consql.State == ConnectionState.Closed)
                {
                    consql.Open();
                }
                string Update;
                Update = "Update SinhVien set TenSV=N'"+txt_Ten.Text+"', MaLop="+txt_Lop.Text+",NgaySinh='"+txt_NgaySinh.Text+"',DiaChi=N'"+txt_DiaChi.Text+"' where MaSV="+txt_MaSV.Text+"";
                SqlCommand cmd = new SqlCommand(Update, consql);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thành công!");
                if (consql.State == ConnectionState.Open)
                {
                    consql.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dgv_SinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgv_SinhVien.Rows[e.RowIndex];
            pictureBox1.Image = Image.FromFile(@"HinhAnh\" + row.Cells["HinhAnh"].Value.ToString());
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        
    }
}
