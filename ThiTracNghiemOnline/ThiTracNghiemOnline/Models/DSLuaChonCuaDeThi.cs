namespace ThiTracNghiemOnline.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DSLuaChonCuaDeThi")]
    public partial class DSLuaChonCuaDeThi
    {
        [Key]
        [Column("mã đề thi", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long mã_đề_thi { get; set; }

        [Key]
        [Column("mã câu hỏi", Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long mã_câu_hỏi { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Ma_LC { get; set; }

        [Column("nội dung lựa chọn")]
        [StringLength(100)]
        public string nội_dung_lựa_chọn { get; set; }

        [Column("là đáp án")]
        public bool? là_đáp_án { get; set; }
    }
}
