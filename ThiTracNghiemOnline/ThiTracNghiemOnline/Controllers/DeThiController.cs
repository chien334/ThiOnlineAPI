using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ThiTracNghiemOnline.Models;

namespace ThiTracNghiemOnline.Controllers
{
    public class DeThiController : ApiController
    {
        private Model1 db = new Model1();
        // GET: api/DeThi
        public IQueryable Getdethi(long madethi
            )
        {
            var monhoc = from mh in db.MON_HOC
                         join dt in db.DE_THI on mh.MA_MH equals dt.MA_MH
                         join ch in db.CAU_HOI on mh.MA_MH equals ch.MA_MH
                         where dt.MA_DT == madethi
                         select new
                         {
                             dt.MA_DT,
                             ch.MA_CH,
                             ch.NOI_DUNG_CH,
                             luachon = from lc in db.LUA_CHON
                                       where lc.MA_CH == ch.MA_CH
                                       select new
                                       {
                                           lc.MA_CH,
                                           lc.MA_LC,
                                           lc.NOI_DUNG_LC,
                                           lc.LA_DAP_AN
                                       }
                         };

            return monhoc;
        }

    }
}
