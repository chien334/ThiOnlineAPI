namespace ThiTracNghiemOnline.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.Serialization;

    public partial class GIAO_VIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GIAO_VIEN()
        {
            DE_THI = new HashSet<DE_THI>();
            PHAN_CONG_DAY = new HashSet<PHAN_CONG_DAY>();
        }

        [Key]
        public long MA_GV { get; set; }

        public long? USER_ID { get; set; }

        [StringLength(50)]
        public string HO_TEN_GV { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAY_SINH_GV { get; set; }

        [StringLength(10)]
        public string GIOI_TINH_GV { get; set; }

        public bool? TRANG_THAI_GV { get; set; }
        [JsonIgnore]
        [IgnoreDataMember]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DE_THI> DE_THI { get; set; }

        public virtual USER USER { get; set; }
        [JsonIgnore]
        [IgnoreDataMember]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHAN_CONG_DAY> PHAN_CONG_DAY { get; set; }
    }
}
