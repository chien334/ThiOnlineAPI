namespace ThiTracNghiemOnline.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.Serialization;

    public partial class BAI_THI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BAI_THI()
        {
            CHI_TIET_BT = new HashSet<CHI_TIET_BT>();
        }

        [Key]
        public long MA_BT { get; set; }

        public long? MA_DT { get; set; }

        public long? MA_HS { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAY_THI { get; set; }

        public TimeSpan? THOI_GIAN_LAM { get; set; }

        public virtual DE_THI DE_THI { get; set; }

        public virtual HOC_SINH HOC_SINH { get; set; }
        [JsonIgnore]
        [IgnoreDataMember]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHI_TIET_BT> CHI_TIET_BT { get; set; }
    }
}
