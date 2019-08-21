namespace ThiTracNghiemOnline.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.Serialization;

    public partial class TINH_TP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TINH_TP()
        {
            QUAN_HUYEN = new HashSet<QUAN_HUYEN>();
        }

        [Key]
        [StringLength(2)]
        public string MA_TINH_TP { get; set; }

        [StringLength(60)]
        public string TEN_TINH_TP { get; set; }

        [StringLength(60)]
        public string LOAI { get; set; }
        [JsonIgnore]
        [IgnoreDataMember]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QUAN_HUYEN> QUAN_HUYEN { get; set; }
    }
}
