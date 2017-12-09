using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLKS
{
    public class TaiKhoanKhachHang
    {
        #region Properties
        private int idKhachHang;
        private string email, password;
        #endregion

        #region Methods
        public int IdKhachHang
        {
            get
            {
                return idKhachHang;
            }

            set
            {
                idKhachHang = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }
        #endregion
    }
}
