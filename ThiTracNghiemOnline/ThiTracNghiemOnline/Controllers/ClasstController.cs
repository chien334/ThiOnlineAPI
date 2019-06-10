using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Mvc;
using ThiTracNghiemOnline.Models;


namespace ThiTracNghiemOnline.Controllers
{
    public class ClasstController : ApiController
    {
        private Model1 db = new Model1();
        // GET: api/Classt
        public IEnumerable<LOP> GetInfoST()
        {
            return db.LOPs;
        }

        // GET: api/Classt/5
        public async Task <IHttpActionResult>  GetInfoST(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var infoST = await db.LOPs.FindAsync(id);

            if (infoST == null)
            {
                return NotFound();
            }

            return Ok(infoST.TEN_LOP);
        }

        // POST: api/Classt
        [ResponseType(typeof(LOP))]
        public async Task<IHttpActionResult> PostClass ([FromBody]LOP lop)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.LOPs.Add(lop);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = lop.MA_LOP }, lop);
        }

        // PUT: api/Classt/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Classt/5
        public void Delete(int id)
        {
        }
    }
}
