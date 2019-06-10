using System;
using System.Collections;
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
using System.Web.Mvc;
using ThiTracNghiemOnline.Models;

namespace ThiTracNghiemOnline.Controllers
{
    public class StudentController : ApiController
    {
        private Model1 db = new Model1();

        // GET: api/Student
        public IEnumerable GetThongTinHS()
        {
            var thongtin = from s in db.ThongTinHS select s; 
            return thongtin;
        }

        // GET: api/Student/5
        [ResponseType(typeof(ThongTinH))]
        public async Task<IHttpActionResult> GetThongTinH(long id)
        {
            ThongTinH thongTinH = await db.ThongTinHS.FindAsync(id);
            if (thongTinH == null)
            {
                return NotFound();
            }

            return Ok(thongTinH);
        }

        //// PUT: api/Student/5
        //[ResponseType(typeof(void))]
        //public async Task<IHttpActionResult> PutThongTinH(long id, ThongTinH thongTinH)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != thongTinH.MA_HS)
        //    {
        //        return BadRequest();
        //    }

        //    db.Entry(thongTinH).State = EntityState.Modified;

        //    try
        //    {
        //        await db.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!ThongTinHExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return StatusCode(HttpStatusCode.NoContent);
        //}

        // POST: api/Student
        //[ResponseType(typeof(ThongTinH))]
        //public async Task<IHttpActionResult> PostThongTinH(ThongTinH thongTinH)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    db.ThongTinHS.Add(thongTinH);

        //    try
        //    {
        //        await db.SaveChangesAsync();
        //    }
        //    catch (DbUpdateException)
        //    {
        //        if (ThongTinHExists(thongTinH.MA_HS))
        //        {
        //            return Conflict();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return CreatedAtRoute("DefaultApi", new { id = thongTinH.MA_HS }, thongTinH);
        //}

        // DELETE: api/Student/5
        //[ResponseType(typeof(ThongTinH))]
        //public async Task<IHttpActionResult> DeleteThongTinH(long id)
        //{
        //    ThongTinH thongTinH = await db.ThongTinHS.FindAsync(id);
        //    if (thongTinH == null)
        //    {
        //        return NotFound();
        //    }

        //    db.ThongTinHS.Remove(thongTinH);
        //    await db.SaveChangesAsync();

        //    return Ok(thongTinH);
        //}

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ThongTinHExists(long id)
        {
            return db.ThongTinHS.Count(e => e.MA_HS == id) > 0;
        }
    }
}