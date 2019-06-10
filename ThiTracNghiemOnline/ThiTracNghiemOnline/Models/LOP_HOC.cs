namespace ThiTracNghiemOnline.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.Serialization;

    public partial class LOP_HOC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOP_HOC()
        {
            HOC_SINH = new HashSet<HOC_SINH>();
            PHAN_CONG_DAY = new HashSet<PHAN_CONG_DAY>();
            DE_THI = new HashSet<DE_THI>();
        }

        [Key]
        public long MA_LOP_HOC { get; set; }

        public int? MA_LOP { get; set; }

        [StringLength(10)]
        public string NIEN_KHOA { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOC_SINH> HOC_SINH { get; set; }

        public virtual LOP LOP { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHAN_CONG_DAY> PHAN_CONG_DAY { get; set; }
        [JsonIgnore]
        [IgnoreDataMember]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DE_THI> DE_THI { get; set; }
    }
}
