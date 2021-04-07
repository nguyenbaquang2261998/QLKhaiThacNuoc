using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Text.Json.Serialization;

namespace DOLPHIN.Model
{
    public class HoSoQuet
    {
        [Key]
        public int Id { get; set; }

        public string TenHoSo { get; set; }

        public int MaCanBoThucHien { get; set; }

        public string NoiDung { get; set; }

        public DateTime NgayThucHien { get; set; }

        public DateTime NgayCapNhat { get; set; }
    }
}
