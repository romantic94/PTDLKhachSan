using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLKS
{
    public class TiepTan
    {
        #region Properties
        private string maTiepTan, truongTiepTan, trangThai;
        private int manv;
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

        public string TruongTiepTan
        {
            get
            {
                return truongTiepTan;
            }

            set
            {
                truongTiepTan = value;
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
