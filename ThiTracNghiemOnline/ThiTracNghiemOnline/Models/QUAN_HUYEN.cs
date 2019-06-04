namespace ThiTracNghiemOnline.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.Serialization;

    public partial class QUAN_HUYEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public QUAN_HUYEN()
        {
            PHUONG_XA = new HashSet<PHUONG_XA>();
        }

        [Key]
        [StringLength(3)]
        public string MA_QUAN_HUYEN { get; set; }

        [StringLength(100)]
        public string TEN_QUAN_HUYEN { get; set; }

        [StringLength(20)]
        public string LOAI_QUAN_HUYEN { get; set; }

        [StringLength(2)]
        public string MA_TINH_TP { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHUONG_XA> PHUONG_XA { get; set; }

        public virtual TINH_TP TINH_TP { get; set; }
    }
}
