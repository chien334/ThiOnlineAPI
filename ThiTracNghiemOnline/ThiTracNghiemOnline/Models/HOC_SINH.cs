namespace ThiTracNghiemOnline.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.Serialization;

    public partial class HOC_SINH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOC_SINH()
        {
            BAI_THI = new HashSet<BAI_THI>();
            DIA_CHI = new HashSet<DIA_CHI>();
        }

        [Key]
        public long MA_HS { get; set; }

        public long? MA_LOP_HOC { get; set; }

        public long? USER_ID { get; set; }

        [StringLength(50)]
        public string HO_TEN_HS { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAY_SINH_HS { get; set; }

        [StringLength(10)]
        public string GIOI_TINH_HS { get; set; }

        public bool? TRANG_THAI_HS { get; set; }
        [JsonIgnore]
        [IgnoreDataMember]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BAI_THI> BAI_THI { get; set; }
        [JsonIgnore]
        [IgnoreDataMember]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIA_CHI> DIA_CHI { get; set; }

        public virtual LOP_HOC LOP_HOC { get; set; }

        public virtual USER USER { get; set; }
    }
}
