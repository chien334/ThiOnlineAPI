namespace ThiTracNghiemOnline.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ADMIN")]
    public partial class ADMIN
    {
        [Key]
        public int ADMIN_ID { get; set; }

        [StringLength(50)]
        public string ADMIN_NAME { get; set; }

        [StringLength(32)]
        public string ADMIN_PASSWORD { get; set; }

        public bool? STATUS { get; set; }
    }
}
