namespace ThiTracNghiemOnline.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.Serialization;

    [Table("USER")]
    public partial class USER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public USER()
        {
            GIAO_VIEN = new HashSet<GIAO_VIEN>();
            HOC_SINH = new HashSet<HOC_SINH>();
        }

        [Key]
        public long USER_ID { get; set; }

        [StringLength(20)]
        public string GROUP_ID { get; set; }

        [StringLength(100)]
        public string USER_NAME { get; set; }

        [StringLength(32)]
        public string USER_PASSWORD { get; set; }

        public bool? STATUS { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GIAO_VIEN> GIAO_VIEN { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOC_SINH> HOC_SINH { get; set; }

        public virtual USER_GROUP USER_GROUP { get; set; }
    }
}
