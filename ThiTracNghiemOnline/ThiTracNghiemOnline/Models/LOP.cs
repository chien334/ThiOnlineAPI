namespace ThiTracNghiemOnline.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.Serialization;

    [Table("LOP")]
    public partial class LOP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOP()
        {
            LOP_HOC = new HashSet<LOP_HOC>();
        }

        [Key]
        public int MA_LOP { get; set; }

        [StringLength(6)]
        public string MA_KHOI { get; set; }

        [StringLength(5)]
        public string TEN_LOP { get; set; }

        public virtual KHOI KHOI { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LOP_HOC> LOP_HOC { get; set; }
    }
}
