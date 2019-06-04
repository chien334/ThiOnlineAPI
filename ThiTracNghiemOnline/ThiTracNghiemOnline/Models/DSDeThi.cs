namespace ThiTracNghiemOnline.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DSDeThi")]
    public partial class DSDeThi
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long MA_DT { get; set; }

        [StringLength(100)]
        public string TIEU_DE_DT { get; set; }

        [StringLength(50)]
        public string TEN_LOAI_DT { get; set; }

        [StringLength(100)]
        public string TEN_MH { get; set; }

        [StringLength(5)]
        public string TEN_LOP { get; set; }

        [StringLength(10)]
        public string TEN_KHOI { get; set; }
    }
}
