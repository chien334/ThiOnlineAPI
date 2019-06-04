namespace ThiTracNghiemOnline.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CHI_TIET_BT
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long MA_BT { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long MA_CH { get; set; }

        public long? MA_LC { get; set; }

        public virtual BAI_THI BAI_THI { get; set; }

        public virtual CAU_HOI CAU_HOI { get; set; }

        public virtual LUA_CHON LUA_CHON { get; set; }
    }
}
