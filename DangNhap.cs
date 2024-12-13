using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace Hoccode3lop
{
    public partial class DangNhap : Form
    {
        TaiKhoan taikhoan = new TaiKhoan();
        TaiKhoanBLL TKBLL = new TaiKhoanBLL();
        public DangNhap()
        {
            InitializeComponent();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void txtmatkhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            taikhoan.sTaiKhoan = txttaikhoan.Text;
            taikhoan.sMatKhau = txtmatkhau.Text;

            string getuser = TKBLL.CheckLogic(taikhoan);
            //thể hiện trả lại kết quả nếu nghiệp vụ không đúng
            switch (getuser)
            {
                case "required_taikhoan":
                    MessageBox.Show("Tài khoản không được để trống");
                    return;
                case "required_password":
                    MessageBox.Show("Mật khẩu không được để trống");
                    return;
                case "Tài khoản hoặc mật khẩu không chính xác":
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác");
                    return;
            }
            MessageBox.Show("Đăng nhập thành công");
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
