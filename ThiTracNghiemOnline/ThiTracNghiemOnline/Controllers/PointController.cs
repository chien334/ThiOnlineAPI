using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ThiTracNghiemOnline.Models;
using ThiTracNghiemOnline.Models.Model_mod;

namespace ThiTracNghiemOnline.Controllers
{
    public class PointController : ApiController
    {
        private Model1 db = new Model1();
        // GET: api/Point
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET: api/Point/5
        public IQueryable Get_DIEMTHI(int id)
        {
            var diemthi = from bt in db.BAI_THI
                          join hs in db.HOC_SINH on bt.MA_HS equals hs.MA_HS
                          join dt in db.DE_THI on bt.MA_DT equals dt.MA_DT
                          where bt.MA_BT == id
                          select new
                          {
                              bt.MA_BT,
                              bt.NGAY_THI,
                              bt.THOI_GIAN_LAM,
                              bt.DIEM       
                          };
            return diemthi;
        }

        // POST: api/Point
        public IHttpActionResult PostBaiThi([FromBody]SAVE_BAI_THI value)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var bt = new BAI_THI();
            bt.MA_DT = value.MA_DT;
            bt.MA_HS = value.MA_HS;
            bt.NGAY_THI = value.NGAY_THI;
            bt.THOI_GIAN_LAM = value.THOI_GIAN_LAM;
            db.BAI_THI.Add(bt);
            db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = bt.MA_BT }, bt);
        }

        // PUT: api/Point/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Point/5
        public void Delete(int id)
        {
        }
    }
}
