namespace ThiTracNghiemOnline.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.Serialization;

    public partial class PHUONG_XA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHUONG_XA()
        {
            DIA_CHI = new HashSet<DIA_CHI>();
        }

        [Key]
        [StringLength(5)]
        public string MA_PHUONG_XA { get; set; }

        [StringLength(100)]
        public string TEN_PHUONG_XA { get; set; }

        [StringLength(30)]
        public string LOAI_PHUONG_XA { get; set; }

        [StringLength(3)]
        public string MA_QUAN_HUYEN { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIA_CHI> DIA_CHI { get; set; }

        public virtual QUAN_HUYEN QUAN_HUYEN { get; set; }
    }
}
