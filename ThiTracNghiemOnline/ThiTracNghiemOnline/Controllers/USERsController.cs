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
    public class USERsController : ApiController
    {
        private Model1 db = new Model1();

        // GET: api/USERs
        public IQueryable GetUSERs()
        {

            var users = from u in db.USERs
                        select new
                        {
                            u.USER_ID,
                            u.USER_NAME,
                            u.USER_PASSWORD
                        };
            return users;
        }

        // GET: api/USERs/5
        [ResponseType(typeof(USER))]
        public async Task<IHttpActionResult> GetUSER(String user, String pass)
        {
            var thongtinhs = from k in db.KHOIs
                             join l in db.LOPs on k.MA_KHOI equals l.MA_KHOI
                             join hs in db.HOC_SINH on l.MA_LOP equals hs.MA_LOP_HOC
                             join dc in db.DIA_CHI on hs.MA_HS equals dc.MA_HS
                             join ldc in db.LOAI_DC on dc.MA_LOAI equals ldc.MA_LOAI
                             join p in db.PHUONG_XA on dc.MA_PHUONG_XA equals p.MA_PHUONG_XA
                             join h in db.QUAN_HUYEN on p.MA_QUAN_HUYEN equals h.MA_QUAN_HUYEN
                             join t in db.TINH_TP on h.MA_TINH_TP equals t.MA_TINH_TP
                             join u in db.USERs on hs.USER_ID equals u.USER_ID
                             where u.USER_NAME==user && u.USER_PASSWORD==pass
                             select new
                             {
                                 u.USER_ID,
                                 hs.MA_HS,
                                 hs.HO_TEN_HS,
                                 hs.GIOI_TINH_HS,
                                 hs.NGAY_SINH_HS,
                                 l.TEN_LOP,
                                 k.TEN_KHOI,
                                 ldc.TEN_LOAI,
                                 dc.SO_NHA,
                                 p.TEN_PHUONG_XA,
                                 h.TEN_QUAN_HUYEN,
                                 t.TEN_TINH_TP,
                                 hs.TRANG_THAI_HS
                             };
            if(thongtinhs!=null)

                 return Ok(thongtinhs);
            return NotFound();
            
        }

        // POST: 
        public IHttpActionResult ChangePass([FromBody]DoiMatKhau doiMatKhau)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var user = (from us in db.USERs
                        where us.USER_ID == doiMatKhau.user_id
                        select us).ToList();
            foreach (var item in user)
            {
                item.USER_PASSWORD = doiMatKhau.NewPassword;
            }
            db.SaveChangesAsync();
            return Ok(user);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool USERExists(long id)
        {
            return db.USERs.Count(e => e.USER_ID == id) > 0;
        }
    }
}