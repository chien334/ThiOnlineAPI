using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
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

        // GET: api/ExamTest
        public IQueryable GetCAU_HOI()
        {
            var cauhoi = from ch in db.CAU_HOI
                         join tl in db.LUA_CHON on ch.MA_CH equals tl.MA_CH
                         select new
                         {
                            MaCH = ch.MA_CH,
                            noidung= ch.NOI_DUNG_CH,
                            cautraloi= tl.NOI_DUNG_LC,
                            LaDapAn= tl.LA_DAP_AN
                         };
            return  cauhoi;
        }

        // GET: api/ExamTest/5
        [ResponseType(typeof(CAU_HOI))]
        public async Task<IHttpActionResult> GetCAU_HOI(long id)
        {

            var cAU_HOI = from ch in db.CAU_HOI
                          join dt in db.DE_THI on ch.MA_MH equals dt.MA_MH
                          join da in db.LUA_CHON on ch.MA_CH equals da.MA_CH
                          where dt.MA_DT==id
                          select new
                          {
                              dt.MA_DT,
                              ch.MA_CH,
                              ch.NOI_DUNG_CH,
                              da.MA_LC,
                              da.NOI_DUNG_LC,
                              da.LA_DAP_AN
                          };

            return Ok(cAU_HOI);
        }

        // PUT: api/ExamTest/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutCAU_HOI(long id, CAU_HOI cAU_HOI)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != cAU_HOI.MA_CH)
            {
                return BadRequest();
            }

            db.Entry(cAU_HOI).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CAU_HOIExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/ExamTest
        [ResponseType(typeof(CAU_HOI))]
        public async Task<IHttpActionResult> PostCAU_HOI(IEnumerable<DeThiAo> cAU_HOI)
        {
             if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            int dapandung = 0;
            List<DSLuaChonCuaDeThi> de = db.DSLuaChonCuaDeThis.ToList();

            foreach (var t in cAU_HOI)
            {
                if (t.Ma_dt != null)
                {
                   for(int i = 0; i < de.Count(); i++)
                    {
                        if (t.Ma_cauhoi == de[i].mã_câu_hỏi && t.Ma_lc==de[i].Ma_LC && de[i].là_đáp_án==true)
                        {
                            dapandung++;
                        }
                    }
                }

                
            }

            return Ok(dapandung+"/"+cAU_HOI.Count());
        }

        // DELETE: api/ExamTest/5
        [ResponseType(typeof(CAU_HOI))]
        public async Task<IHttpActionResult> DeleteCAU_HOI(long id)
        {
            CAU_HOI cAU_HOI = await db.CAU_HOI.FindAsync(id);
            if (cAU_HOI == null)
            {
                return NotFound();
            }

            db.CAU_HOI.Remove(cAU_HOI);
            await db.SaveChangesAsync();

            return Ok(cAU_HOI);
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