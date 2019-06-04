namespace ThiTracNghiemOnline.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThongTinHS")]
    public partial class ThongTinH
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long MA_HS { get; set; }

        [StringLength(50)]
        public string HO_TEN_HS { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAY_SINH_HS { get; set; }

        [StringLength(10)]
        public string GIOI_TINH_HS { get; set; }

        public bool? TRANG_THAI_HS { get; set; }

        [StringLength(50)]
        public string SO_NHA { get; set; }

        [StringLength(100)]
        public string TEN_PHUONG_XA { get; set; }

        [StringLength(100)]
        public string TEN_QUAN_HUYEN { get; set; }

        [StringLength(60)]
        public string TEN_TINH_TP { get; set; }

        public long? MA_LOP_HOC { get; set; }

        [StringLength(10)]
        public string NIEN_KHOA { get; set; }

        [StringLength(5)]
        public string TEN_LOP { get; set; }

        [StringLength(10)]
        public string TEN_KHOI { get; set; }
    }
}
