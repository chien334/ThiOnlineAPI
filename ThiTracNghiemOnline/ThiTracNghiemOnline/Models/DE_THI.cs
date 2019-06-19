namespace ThiTracNghiemOnline.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.Serialization;

    public partial class DE_THI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DE_THI()
        {
            BAI_THI = new HashSet<BAI_THI>();
            LOP_HOC = new HashSet<LOP_HOC>();
        }

        [Key]
        public long MA_DT { get; set; }

        [StringLength(20)]
        public string MA_LOAI_DT { get; set; }

        public long? MA_GV { get; set; }

        public int? MA_MH { get; set; }

        [StringLength(100)]
        public string TIEU_DE_DT { get; set; }
        [JsonIgnore]
        [IgnoreDataMember]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BAI_THI> BAI_THI { get; set; }

        public virtual GIAO_VIEN GIAO_VIEN { get; set; }

        public virtual MON_HOC MON_HOC { get; set; }

        public virtual LOAI_DE_THI LOAI_DE_THI { get; set; }
        [JsonIgnore]
        [IgnoreDataMember]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LOP_HOC> LOP_HOC { get; set; }
    }
}
