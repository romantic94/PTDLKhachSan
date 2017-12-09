using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLKS
{
    public class HoaDonPhong
    {
        #region Properties
        private int maHoaDonPhong, maPhong, maKhachHang;
        private DateTime ngayNhan, ngayTra, ngayLapHD;
        private float uuDai;
        private decimal thanhTien;
        private string thongTinHD;
        #endregion

        #region Methods
        public int MaHoaDonPhong
        {
            get
            {
                return maHoaDonPhong;
            }

            set
            {
                maHoaDonPhong = value;
            }
        }

        public int MaPhong
        {
            get
            {
                return maPhong;
            }

            set
            {
                maPhong = value;
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

        public DateTime NgayNhan
        {
            get
            {
                return ngayNhan;
            }

            set
            {
                ngayNhan = value;
            }
        }

        public DateTime NgayTra
        {
            get
            {
                return ngayTra;
            }

            set
            {
                ngayTra = value;
            }
        }

        public DateTime NgayLapHD
        {
            get
            {
                return ngayLapHD;
            }

            set
            {
                ngayLapHD = value;
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

        public decimal ThanhTien
        {
            get
            {
                return thanhTien;
            }

            set
            {
                thanhTien = value;
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
