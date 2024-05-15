using QuanLySieuThi.quanly;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySieuThi
{
    public partial class main2 : Form
    {
        public main2()
        {
            InitializeComponent();
        }

        public void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public void tàiKhoảnNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tknhanvien a = new tknhanvien();
            a.Show();
        }

        public void mn_tkquanly_Click(object sender, EventArgs e)
        {
            tkquanly a = new tkquanly();
            a.Show();
        }

        private void mn_admin_Click(object sender, EventArgs e)
        {
            tkadmin a = new tkadmin();
            a.Show();    
        }

        private void mn_doimk_Click(object sender, EventArgs e)
        {
            TaiKhoan.DoiMk a = new TaiKhoan.DoiMk();
            a.Show();
        }

        private void mn_dx_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất không ?", "Thông báo ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Dangnhap a = new Dangnhap();
                a.Show();
                this.Hide();
            }
        }

        private void ql_ncc_Click(object sender, EventArgs e)
        {
            quanly.nhacungcap a = new quanly.nhacungcap();
            a.Show();
        }

        private void ql_khachhang_Click(object sender, EventArgs e)
        {
            quanly.khachhang a = new quanly.khachhang();
            a.Show();
        }

        private void ql_nhanvien_Click(object sender, EventArgs e)
        {
            quanly.nhanvien a = new quanly.nhanvien();
            a.Show();
        }

    /*    private void bh_phieunhap_Click(object sender, EventArgs e)
        {
            banhang.PhieuNhap a = new banhang.PhieuNhap();
            a.Show();
        }*/

        private void bh_nhapnhieu_Click(object sender, EventArgs e)
        {
            banhang.nhapnhieu a = new banhang.nhapnhieu();
            a.Show();
        }

        private void bh_xuatle_Click(object sender, EventArgs e)
        {
            banhang.PhieuXuat a = new banhang.PhieuXuat();
            a.Show();
        }

        private void bh_bannhieu_Click(object sender, EventArgs e)
        {
            banhang.banhang a = new banhang.banhang();
            a.Show();
        }

        private void thôngTinPhầnMềmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String tt = "";
            tt += "Phần mềm : Quản lý Siêu thị Emarket \n";

            tt += "\n ";
            tt += " ____Đồ án____ ";
            tt += "\nSinh viên thực hiện : - Nhóm 4";
            tt += "\n";
            MessageBox.Show((tt), "Thông tin", MessageBoxButtons.OK);
        }

        private void main2_Load(object sender, EventArgs e)
        {

        }

        private void quảnLýSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            quanly.sanpham a = new quanly.sanpham();
            a.Show();
        }

        private void ql_phieunhap_Click(object sender, EventArgs e)
        {
            quanly.qlphieunhap1 a = new quanly.qlphieunhap1();
            a.Show();
        }

        private void ql_phieuxuat_Click(object sender, EventArgs e)
        {
            quanly.qlphieuxuat a = new quanly.qlphieuxuat();
            a.Show();
        }

        private void lb_quyen_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            khachhang a  =  new khachhang();    
            a.Show();   
        }

        private void quảnLýNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nhacungcap a = new nhacungcap();
            a.Show(); 
        }

        private void quảnLýSảnPhẩmToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            sanpham a = new sanpham();
            a.Show(); 
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nhanvien a = new nhanvien();    
            a.Show();
        }
    }
}
