using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLKS
{
    public class HoaDonDichVu
    {
        #region Properties
        private int maHoaDon, maDichVu, maKhachHang;
        private decimal giaDichVu;
        private float uuDai;
        private DateTime ngayLap;
        private string thongTinHD;
        #endregion

        #region Methods
        public int MaHoaDon
        {
            get
            {
                return maHoaDon;
            }

            set
            {
                maHoaDon = value;
            }
        }

        public int MaDichVu
        {
            get
            {
                return maDichVu;
            }

            set
            {
                maDichVu = value;
            }
        }

        public int MaKhachHang
        {
            get
            {
                return maKhachHang;
            }

            set
            {
                maKhachHang = value;
            }
        }

        public decimal GiaDichVu
        {
            get
            {
                return giaDichVu;
            }

            set
            {
                giaDichVu = value;
            }
        }

        public float UuDai
        {
            get
            {
                return uuDai;
            }

            set
            {
                uuDai = value;
            }
        }

        public DateTime NgayLap
        {
            get
            {
                return ngayLap;
            }

            set
            {
                ngayLap = value;
            }
        }

        public string ThongTinHD
        {
            get
            {
                return thongTinHD;
            }

            set
            {
                thongTinHD = value;
            }
        }
        #endregion
    }
}
