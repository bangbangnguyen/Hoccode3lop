using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class TaiKhoanBLL
    {
        TaiKhoanAccess tkAccess = new TaiKhoanAccess();
        public string CheckLogic(TaiKhoan taikhoan)
        { //kiểm tra nghiệp vụ
            if (taikhoan.sTaiKhoan == "")
            {
                return "required_taikhoan";
            }
            if (taikhoan.sMatKhau == "")
            {
                return "required_password";
            }
            string info = tkAccess.CheckLogic(taikhoan);
            return info;
        }


    }
}
