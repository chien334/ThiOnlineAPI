namespace ThiTracNghiemOnline.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.Serialization;

    public partial class LUA_CHON
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LUA_CHON()
        {
            CHI_TIET_BT = new HashSet<CHI_TIET_BT>();
        }

        [Key]
        public long MA_LC { get; set; }

        public long? MA_CH { get; set; }

        [StringLength(100)]
        public string NOI_DUNG_LC { get; set; }

        public bool? LA_DAP_AN { get; set; }

        public virtual CAU_HOI CAU_HOI { get; set; }
        [JsonIgnore]
        [IgnoreDataMember]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHI_TIET_BT> CHI_TIET_BT { get; set; }
    }
}
