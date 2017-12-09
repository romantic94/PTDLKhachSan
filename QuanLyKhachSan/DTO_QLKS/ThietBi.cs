using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLKS
{
    public class ThietBi
    {
        #region Properties
        private string maThietBi, tenThietBi, xuatXu, hienTrang, mauSac, diaChiBH;
        private DateTime ngayMua, ngayNhap;
        private decimal giaSanPham;
        private float soNamBH;
        private int soLuong;
        #endregion

        #region Methods
        public string MaThietBi
        {
            get
            {
                return maThietBi;
            }

            set
            {
                maThietBi = value;
            }
        }

        public string TenThietBi
        {
            get
            {
                return tenThietBi;
            }

            set
            {
                tenThietBi = value;
            }
        }

        public string XuatXu
        {
            get
            {
                return xuatXu;
            }

            set
            {
                xuatXu = value;
            }
        }

        public string HienTrang
        {
            get
            {
                return hienTrang;
            }

            set
            {
                hienTrang = value;
            }
        }

        public string MauSac
        {
            get
            {
                return mauSac;
            }

            set
            {
                mauSac = value;
            }
        }

        public string DiaChiBH
        {
            get
            {
                return diaChiBH;
            }

            set
            {
                diaChiBH = value;
            }
        }

        public DateTime NgayMua
        {
            get
            {
                return ngayMua;
            }

            set
            {
                ngayMua = value;
            }
        }

        public DateTime NgayNhap
        {
            get
            {
                return ngayNhap;
            }

            set
            {
                ngayNhap = value;
            }
        }

        public decimal GiaSanPham
        {
            get
            {
                return giaSanPham;
            }

            set
            {
                giaSanPham = value;
            }
        }

        public float SoNamBH
        {
            get
            {
                return soNamBH;
            }

            set
            {
                soNamBH = value;
            }
        }

        public int SoLuong
        {
            get
            {
                return soLuong;
            }

            set
            {
                soLuong = value;
            }
        }
        #endregion
    }
}
