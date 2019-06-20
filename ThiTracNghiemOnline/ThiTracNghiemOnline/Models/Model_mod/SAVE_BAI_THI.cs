using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ThiTracNghiemOnline.Models.Model_mod
{
    public class SAVE_BAI_THI
    {
        public int MA_HS { get; set; }
        public int MA_DT { get; set; }
        public DateTime NGAY_THI{ get; set; }
        public TimeSpan THOI_GIAN_LAM { get; set; }
        public Double DIEM { get; set; }

    }
}