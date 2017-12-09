using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLKS
{
    public class TuVanKhachHang
    {
        #region Properties
        private string maTiepTan, trangThai;
        private int manv;
        private bool lienHe;
        private DateTime ngayCapNhat;
        #endregion

        #region Methods
        public string MaTiepTan
        {
            get
            {
                return maTiepTan;
            }

            set
            {
                maTiepTan = value;
            }
        }

        public string TrangThai
        {
            get
            {
                return trangThai;
            }

            set
            {
                trangThai = value;
            }
        }

        public int Manv
        {
            get
            {
                return manv;
            }

            set
            {
                manv = value;
            }
        }

        public bool LienHe
        {
            get
            {
                return lienHe;
            }

            set
            {
                lienHe = value;
            }
        }

        public DateTime NgayCapNhat
        {
            get
            {
                return ngayCapNhat;
            }

            set
            {
                ngayCapNhat = value;
            }
        }
        #endregion
    }
}
