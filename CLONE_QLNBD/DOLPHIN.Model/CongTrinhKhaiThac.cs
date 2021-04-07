using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DOLPHIN.Model
{
    public class CongTrinhKhaiThac
    {
        [Key]
        public int Id { get; set; }

        public string TenCongTrinh { get; set; }

        public string LoaiCongTrinh { get; set; }

        public int MaViTri { get; set; }

        public int MaCanBoQuanLy { get; set; }

        public DateTime NgayThucHien { get; set; }

        public DateTime ThoiGianDuKien { get; set; }

        public int MaGiayPhep { get; set; }
    }
}
