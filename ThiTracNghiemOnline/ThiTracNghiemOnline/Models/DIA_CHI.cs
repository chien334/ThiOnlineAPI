namespace ThiTracNghiemOnline.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIA_CHI
    {
        [Key]
        public long MA_DC { get; set; }

        public long? MA_HS { get; set; }

        [StringLength(5)]
        public string MA_PHUONG_XA { get; set; }

        [StringLength(20)]
        public string MA_LOAI { get; set; }

        [StringLength(50)]
        public string SO_NHA { get; set; }

        public virtual HOC_SINH HOC_SINH { get; set; }

        public virtual LOAI_DC LOAI_DC { get; set; }

        public virtual PHUONG_XA PHUONG_XA { get; set; }
    }
}
