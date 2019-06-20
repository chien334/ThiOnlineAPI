using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Dynamic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using ThiTracNghiemOnline.Models;
using ThiTracNghiemOnline.Models.Model_mod;

namespace ThiTracNghiemOnline.Controllers
{
    public class ExamTestController : ApiController
    {
        private Model1 db = new Model1();

        //GET: api/ExamTest
        public IQueryable GetCAU_HOI()
        {

            var monhoc = from mh in db.MON_HOC
                         join dt in db.DE_THI on mh.MA_MH equals dt.MA_MH
                         join ch in db.CAU_HOI on mh.MA_MH equals ch.MA_MH
                         where dt.MA_DT == 1
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

        // GET: api/ExamTest/5
        [ResponseType(typeof(CAU_HOI))]
        public async Task<IHttpActionResult> GetMonHoc(long id)
        {

            var MOnhoc = from pc in db.PHAN_CONG_DAY
                         join mh in db.MON_HOC on pc.MA_MH equals mh.MA_MH
                         join gv in db.GIAO_VIEN on pc.MA_GV equals gv.MA_GV
                         join lh in db.LOP_HOC on pc.MA_LOP_HOC equals lh.MA_LOP_HOC
                         join l in db.LOPs on lh.MA_LOP equals l.MA_LOP
                         join k in db.KHOIs on l.MA_KHOI equals k.MA_KHOI
                         join hs in db.HOC_SINH on lh.MA_LOP_HOC equals hs.MA_LOP_HOC
                         where hs.MA_HS == id && k.MA_KHOI == mh.MA_KHOI
                         select new
                         {
                             hs.MA_HS,
                             hs.HO_TEN_HS,
                             lh.MA_LOP_HOC,
                             lh.NIEN_KHOA,
                             mh.MA_MH,
                             mh.TEN_MH,
                             gv.MA_GV,
                             gv.HO_TEN_GV
                         };

            return Ok(MOnhoc);
        }
        [ResponseType(typeof(CAU_HOI))]
        public async Task<IHttpActionResult> GetDeThi(long idhs, long idmh)
        {
            var monhoc = from dt in db.DE_THI
                         join gv in db.GIAO_VIEN on dt.MA_GV equals gv.MA_GV
                         join mh in db.MON_HOC on dt.MA_MH equals mh.MA_MH
                         join k in db.KHOIs on mh.MA_KHOI equals k.MA_KHOI
                         join l in db.LOPs on k.MA_KHOI equals l.MA_KHOI
                         join lh in db.LOP_HOC on l.MA_LOP equals lh.MA_LOP
                         join hs in db.HOC_SINH on lh.MA_LOP_HOC equals hs.MA_LOP_HOC
                         join pc in db.PHAN_CONG_DAY on mh.MA_MH equals pc.MA_MH
                         where hs.MA_HS == idhs && mh.MA_MH == idmh && lh.MA_LOP_HOC == pc.MA_LOP_HOC && gv.MA_GV == pc.MA_GV
                         select new
                         {
                             dt.MA_DT,
                             dt.MA_LOAI_DT,
                             dt.TIEU_DE_DT,
                         };

            return Ok(monhoc);
        }



        // POST: api/ExamTest
        [HttpPost]
        public IHttpActionResult PostCAU_HOI([FromBody] DeThiAo dad)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            int dapandung = 0;
            var dapan = from mh in db.MON_HOC
                        join dt in db.DE_THI on mh.MA_MH equals dt.MA_MH
                        join ch in db.CAU_HOI on mh.MA_MH equals ch.MA_MH
                        join lc in db.LUA_CHON on ch.MA_CH equals lc.MA_CH
                        from ct in db.CT_DETHI 
                        where lc.LA_DAP_AN == true && dt.MA_DT == dad.made && ch.MA_CH == ct.MA_CH && ct.MA_DT==dad.made
                        select new
                        {
                            lc.MA_LC
                        };
            var arr = dapan.ToList();
            int[] vs = new int[dad.dapan.Count()];
            var ar = dad.dapan.ToList();


            for (int i = 0; i < ar.Count(); i++)
            {
                vs[i] = ar[i];
            }
            for(int i=0; i < vs.Count(); i++)
            {
                if (vs[i] == arr[i].MA_LC)
                {
                    dapandung++;
                }
            }
           // return Ok(dapan);
            return Ok(new { resu = dapandung });
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CAU_HOIExists(long id)
        {
            return db.CAU_HOI.Count(e => e.MA_CH == id) > 0;
        }
    }
}