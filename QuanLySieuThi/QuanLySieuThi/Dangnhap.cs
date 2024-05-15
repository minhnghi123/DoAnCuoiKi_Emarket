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

namespace QuanLySieuThi
{
    public partial class Dangnhap : Form
    {
        public static string sqlcon = @"Data Source=ALIEN\SQLEXPRESS;Initial Catalog=QuanLySieuThi;Integrated Security=True;";
        public static SqlConnection mycon;
        public static SqlCommand com;
        public static SqlDataAdapter ad;
        public static DataTable dt;
        public static SqlCommandBuilder bd;
        public Dangnhap()
        {
            InitializeComponent();
        }
        public static void Chuoiketnoi(string chuoi, DataGridView db1)
        {
            try
            {

                ad = new SqlDataAdapter(chuoi, sqlcon);
                dt = new DataTable();
                bd = new SqlCommandBuilder(ad);
                ad.Fill(dt);
                db1.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể kết nối " + ex, "Thông báo ! ");

            }
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox1.Checked)
            {
                txt_mk.UseSystemPasswordChar = true;

            }
            else
                txt_mk.UseSystemPasswordChar = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sai = 5;
            string sql1 = "Select count(*) from Admin where tk='" + txt_tk.Text.Trim() + "' and mk='" + txt_mk.Text.Trim() + "' ";
            string sql2 = "Select count(*) from tknhanvien where tk ='" + txt_tk.Text + "'and mk ='" + txt_mk.Text + "'";
            string sql3 = "Select count(*) from tkquanly where tk='" + txt_tk.Text + "' and mk ='" + txt_mk.Text + "' ";
            if (txt_tk.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên tài khoản ", "Thông báo", MessageBoxButtons.OK);
            }
            else if (txt_mk.Text == "")
                MessageBox.Show("Bạn chưa nhập Mật khẩu  ", "Thông báo", MessageBoxButtons.OK);
            else
            {

                int a = 0, b = 0, c = 0;
                mycon = new SqlConnection(sqlcon);
                mycon.Open();

           
                com = new SqlCommand(sql1, mycon);
                a = (int)com.ExecuteScalar();
              
                SqlCommand com1 = new SqlCommand(sql2, mycon);
                
                b = (int)com1.ExecuteScalar();
                
                SqlCommand com2 = new SqlCommand(sql3, mycon);
                c = (int)com2.ExecuteScalar();

                if (sai > 0)
                {
                    if (a > 0)
                    {
                        MessageBox.Show("Ban dang nhap vao tai khoan Admin", "Thong bao ", MessageBoxButtons.OK);
                        main2 a1 = new main2();
                        a1.Show();
                        this.Hide();
                        a1.lb_quyen.Text = "Quyền Admin";
                        a1.label2.Text = txt_tk.Text; 
                        a1.mn_quanly.Visible = false;
                        a1.mn_banhang.Visible = false; 


                    }
                    else if (b > 0)
                    {
                        MessageBox.Show("Ban dang nhap vao tai khoan Nhân Vien", "Thong bao ", MessageBoxButtons.OK);
                        main2 a2 = new main2();
                        a2.Show();
                        this.Hide();
                        a2.lb_quyen.Text = "Quyền Nhân viên";
                        a2.label2.Text = txt_tk.Text;
                        a2.mn_admin.Visible = false;
                        a2.mn_tkquanly.Visible = false;
                        a2.mn_nhanvien.Visible = false;
                        a2.ql_phieunhap.Visible = false;
                        a2.ql_phieuxuat.Visible = false;
                        a2.ql_nhanvien.Visible = false;
                        a2.mn_quanly.Visible = false; 

                    }
                    else if (c > 0)
                    {
                        MessageBox.Show("Ban dang nhap vao tai khoan quanly ", "Thong bao ", MessageBoxButtons.OK);
                        main2 a2 = new main2();

                        a2.Show();
                        this.Hide();
                        a2.lb_quyen.Text = "Quyền Quản Lý";
                        a2.label2.Text = txt_tk.Text;
                        a2.mn_banhang.Visible = false;
                        a2.mn_admin.Visible = false;
                        a2.mn_tkquanly.Visible = false;
                        a2.mn_nhanvien.Visible = false;
                        


                    }
                    if (a == 0 && b == 0 && c == 0)
                    {


                        string t = "Username hoặc password sai !,Bạn vui lòng kiểm tra lại ";
                        MessageBox.Show((t), "thong báo", MessageBoxButtons.OK);


                    }




                }




            }
            // this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không ?", "Thông báo ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                main1 a = new main1();
                a.Show();
                this.Hide();
            }
        }

        private void Dangnhap_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DangKy d = new DangKy(); 
            d.Show();   
            this.Hide();    
        }
    }
}
