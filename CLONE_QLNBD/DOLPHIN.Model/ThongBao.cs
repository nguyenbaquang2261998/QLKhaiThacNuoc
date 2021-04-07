using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Text.Json.Serialization;

namespace DOLPHIN.Model
{
    public class ThongBao
    {
        [Key]
        public int Id { get; set; }

        public string TenThongBao { get; set; }

        public DateTime NgayBanHanh { get; set; }

        public int LuuLuongKhaiThac { get; set; }

        public int MaToChuc { get; set; }

        public int MaLoaiChiPhi { get; set; }
    }
}
