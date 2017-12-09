using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLKS
{
    public class KhachHang
    {
        #region Properties
        private int makh;
        private string hoten, phai, diachi, email, sodienthoai;
        private string cmnd, quoctich, trangthai;
        private DateTime ns;
        #endregion

        #region Methods
        public int Makh
        {
            get
            {
                return makh;
            }

            set
            {
                makh = value;
            }
        }

        public string Hoten
        {
            get
            {
                return hoten;
            }

            set
            {
                hoten = value;
            }
        }

        public string Phai
        {
            get
            {
                return phai;
            }

            set
            {
                phai = value;
            }
        }

        public string Diachi
        {
            get
            {
                return diachi;
            }

            set
            {
                diachi = value;
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

        public string Sodienthoai
        {
            get
            {
                return sodienthoai;
            }

            set
            {
                sodienthoai = value;
            }
        }

        public string Cmnd
        {
            get
            {
                return cmnd;
            }

            set
            {
                cmnd = value;
            }
        }

        public string Quoctich
        {
            get
            {
                return quoctich;
            }

            set
            {
                quoctich = value;
            }
        }

        public string Trangthai
        {
            get
            {
                return trangthai;
            }

            set
            {
                trangthai = value;
            }
        }

        public DateTime Ns
        {
            get
            {
                return ns;
            }

            set
            {
                ns = value;
            }
        }
        #endregion
    }
}
