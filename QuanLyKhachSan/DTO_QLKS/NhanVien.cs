using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLKS
{
    public class NhanVien
    {
        #region Properties
        private int manv;
        private string hoten, cmnd, noiCap, diaChi, nguyenQuan, email, chucVu;
        private string trinhDo, soDienThoai, hinhThucLamViec, maPhongBan;
        private bool gioiTinh;
        private DateTime ngaySinh, ngayLamViec, ngayNghiViec;
        #endregion

        #region Methods
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

        public string NoiCap
        {
            get
            {
                return noiCap;
            }

            set
            {
                noiCap = value;
            }
        }

        public string DiaChi
        {
            get
            {
                return diaChi;
            }

            set
            {
                diaChi = value;
            }
        }

        public string NguyenQuan
        {
            get
            {
                return nguyenQuan;
            }

            set
            {
                nguyenQuan = value;
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

        public string ChucVu
        {
            get
            {
                return chucVu;
            }

            set
            {
                chucVu = value;
            }
        }

        public string TrinhDo
        {
            get
            {
                return trinhDo;
            }

            set
            {
                trinhDo = value;
            }
        }

        public string SoDienThoai
        {
            get
            {
                return soDienThoai;
            }

            set
            {
                soDienThoai = value;
            }
        }

        public string HinhThucLamViec
        {
            get
            {
                return hinhThucLamViec;
            }

            set
            {
                hinhThucLamViec = value;
            }
        }

        public string MaPhongBan
        {
            get
            {
                return maPhongBan;
            }

            set
            {
                maPhongBan = value;
            }
        }

        public bool GioiTinh
        {
            get
            {
                return gioiTinh;
            }

            set
            {
                gioiTinh = value;
            }
        }

        public DateTime NgaySinh
        {
            get
            {
                return ngaySinh;
            }

            set
            {
                ngaySinh = value;
            }
        }

        public DateTime NgayLamViec
        {
            get
            {
                return ngayLamViec;
            }

            set
            {
                ngayLamViec = value;
            }
        }

        public DateTime NgayNghiViec
        {
            get
            {
                return ngayNghiViec;
            }

            set
            {
                ngayNghiViec = value;
            }
        }
        #endregion
    }
}
