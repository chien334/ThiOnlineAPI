namespace ThiTracNghiemOnline.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.Serialization;

    public partial class LOAI_DC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOAI_DC()
        {
            DIA_CHI = new HashSet<DIA_CHI>();
        }

        [Key]
        [StringLength(20)]
        public string MA_LOAI { get; set; }

        [StringLength(50)]
        public string TEN_LOAI { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIA_CHI> DIA_CHI { get; set; }
    }
}
