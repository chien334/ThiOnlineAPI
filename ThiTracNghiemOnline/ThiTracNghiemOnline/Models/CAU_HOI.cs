namespace ThiTracNghiemOnline.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.Serialization;

    public partial class CAU_HOI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CAU_HOI()
        {
            CHI_TIET_BT = new HashSet<CHI_TIET_BT>();
            LUA_CHON = new HashSet<LUA_CHON>();
            DE_THI = new HashSet<DE_THI>();
        }

        [Key]
        public long MA_CH { get; set; }

        public int? MA_MH { get; set; }

        [Column(TypeName = "ntext")]
        public string NOI_DUNG_CH { get; set; }

        public virtual MON_HOC MON_HOC { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHI_TIET_BT> CHI_TIET_BT { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LUA_CHON> LUA_CHON { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DE_THI> DE_THI { get; set; }
    }
}
