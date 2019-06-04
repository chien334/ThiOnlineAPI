namespace ThiTracNghiemOnline.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PHAN_CONG_DAY
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long MA_LOP_HOC { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long MA_GV { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MA_MH { get; set; }

        public bool? TINH_TRANG_PC { get; set; }

        public virtual GIAO_VIEN GIAO_VIEN { get; set; }

        public virtual LOP_HOC LOP_HOC { get; set; }

        public virtual MON_HOC MON_HOC { get; set; }
    }
}
