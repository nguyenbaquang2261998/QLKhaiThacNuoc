using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DOLPHIN.Model
{
    public class HoSo
    {
        [Key]
        public int Id { get; set; }

        public string TenHoSo { get; set; }

        public int KhoiLuong { get; set; }

        public string NoiDung { get; set; }

        public int MaToChuc { get; set; }

        public DateTime NgayThucHienQuyDinh { get; set; }

        public DateTime NgayThucHienThucTe { get; set; }

        public int SoLanCapNhat { get; set; }

        public DateTime NgayBanHanh { get; set; }

        public int TrangThai { get; set; }
    }
}
