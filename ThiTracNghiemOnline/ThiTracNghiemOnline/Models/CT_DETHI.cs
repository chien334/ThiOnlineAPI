namespace ThiTracNghiemOnline.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CT_DETHI
    {
        public long ID { get; set; }

        public long? MA_DT { get; set; }

        public long? MA_CH { get; set; }
    }
}
