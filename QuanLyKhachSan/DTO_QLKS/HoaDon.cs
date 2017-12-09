using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLKS
{
    public class HoaDon
    {
        #region Properties
        private int maHoaDon, maDichVu, maPhong, soNgay;
        private bool hinhThucThanhToan;
        private decimal giaTriThanhToan;
        private string thongTin;
        private float thue, uuDai;
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

        public int SoNgay
        {
            get
            {
                return soNgay;
            }

            set
            {
                soNgay = value;
            }
        }

        public bool HinhThucThanhToan
        {
            get
            {
                return hinhThucThanhToan;
            }

            set
            {
                hinhThucThanhToan = value;
            }
        }

        public decimal GiaTriThanhToan
        {
            get
            {
                return giaTriThanhToan;
            }

            set
            {
                giaTriThanhToan = value;
            }
        }

        public string ThongTin
        {
            get
            {
                return thongTin;
            }

            set
            {
                thongTin = value;
            }
        }

        public float Thue
        {
            get
            {
                return thue;
            }

            set
            {
                thue = value;
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
        #endregion
    }
}
