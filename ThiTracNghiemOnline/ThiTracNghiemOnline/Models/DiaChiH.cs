namespace ThiTracNghiemOnline.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DiaChiHS")]
    public partial class DiaChiH
    {
        [Key]
        [Column("mã học sinh")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long mã_học_sinh { get; set; }

        [Column("họ và tên")]
        [StringLength(50)]
        public string họ_và_tên { get; set; }

        [Column("số nhà")]
        [StringLength(50)]
        public string số_nhà { get; set; }

        [Column("loại địa chỉ")]
        [StringLength(50)]
        public string loại_địa_chỉ { get; set; }

        [Column("phường xã")]
        [StringLength(100)]
        public string phường_xã { get; set; }

        [Column("quận huyện")]
        [StringLength(100)]
        public string quận_huyện { get; set; }

        [Column("tỉnh thành phố")]
        [StringLength(60)]
        public string tỉnh_thành_phố { get; set; }
    }
}
