using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        /// <summary>
        /// Gets or sets.
        /// </summary>
        [ForeignKey("MaCanBoQuanLy")]
        public virtual CanBo CanBo { get; set; }

        public DateTime NgayThucHien { get; set; }

        public DateTime ThoiGianDuKien { get; set; }

        /// <summary>
        /// Gets or sets.
        /// </summary>
        [ForeignKey("MaGiayPhep")]
        public virtual ToTrinh ToTrinh { get; set; }
    }
}
