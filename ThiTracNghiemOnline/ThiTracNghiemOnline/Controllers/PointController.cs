using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using ThiTracNghiemOnline.Models;
using ThiTracNghiemOnline.Models.Model_mod;

namespace ThiTracNghiemOnline.Controllers
{
    public class PointController : ApiController
    {
        private Model1 db = new Model1();
        //GET: api/Point
        public async Task<IHttpActionResult> Getbodethi(long idhs, long idmh)
        {
            var monhoc = from dt in db.DE_THI
                         join gv in db.GIAO_VIEN on dt.MA_GV equals gv.MA_GV
                         join mh in db.MON_HOC on dt.MA_MH equals mh.MA_MH
                         join k in db.KHOIs on mh.MA_KHOI equals k.MA_KHOI
                         join l in db.LOPs on k.MA_KHOI equals l.MA_KHOI
                         join lh in db.LOP_HOC on l.MA_LOP equals lh.MA_LOP
                         join hs in db.HOC_SINH on lh.MA_LOP_HOC equals hs.MA_LOP_HOC
                         join pc in db.PHAN_CONG_DAY on mh.MA_MH equals pc.MA_MH
                         join ctbt in db.BAI_THI on dt.MA_DT equals ctbt.MA_DT
                         where hs.MA_HS == idhs && mh.MA_MH == idmh && lh.MA_LOP_HOC == pc.MA_LOP_HOC && gv.MA_GV == pc.MA_GV
                         select new
                         {
                            dt.TIEU_DE_DT,
                            ctbt.NGAY_THI,
                            ctbt.THOI_GIAN_LAM,
                            ctbt.DIEM
                         };

            return Ok(monhoc);
        }

        //GET: api/Point/5
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
            bt.DIEM = (long)value.DIEM;
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
