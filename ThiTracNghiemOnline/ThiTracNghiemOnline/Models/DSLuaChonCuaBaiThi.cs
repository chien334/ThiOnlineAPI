namespace ThiTracNghiemOnline.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DSLuaChonCuaBaiThi")]
    public partial class DSLuaChonCuaBaiThi
    {
        [Key]
        [Column("mã học sinh", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long mã_học_sinh { get; set; }

        [Column("họ và tên")]
        [StringLength(50)]
        public string họ_và_tên { get; set; }

        [Key]
        [Column("mã bài thi", Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long mã_bài_thi { get; set; }

        [Column("mã đề thi")]
        public long? mã_đề_thi { get; set; }

        [Column("mã câu hỏi")]
        public long? mã_câu_hỏi { get; set; }

        [Key]
        [Column("mã lựa chọn", Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long mã_lựa_chọn { get; set; }

        [Column("nội dung lựa chọn")]
        [StringLength(100)]
        public string nội_dung_lựa_chọn { get; set; }
    }
}
