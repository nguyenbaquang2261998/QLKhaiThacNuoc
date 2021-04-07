using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DOLPHIN.Model
{
    public class ToTrinh
    {
        [Key]
        public int Id { get; set; }

        public string TenToTrinh { get; set; }

        public DateTime NgayTao { get; set; }

        public int MaToChuc { get; set; }

        public int MaDonViHanhChinh { get; set; }

        public string MucDichKhaiThac { get; set; }

        public int MaViTriKhaiThac { get; set; }

        public int TangChuaNuocKhaiThac { get; set; }

        public int SoGieng { get; set; }

        public int LuongNuocKhaiThac { get; set; }

        public DateTime ThoiHanCapPhep { get; set; }

        public int MaQuanTrac { get; set; }

        public int SoLanCapNhat { get; set; }

        public DateTime  NgayBanHanh { get; set; }

        public int TrangThai { get; set; }

        /// <summary>
        /// Gets or sets type: to trinh / giay phep
        /// </summary>
        public int Type { get; set; }
    }
}
