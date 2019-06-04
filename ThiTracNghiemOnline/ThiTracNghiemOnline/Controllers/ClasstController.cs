using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ThiTracNghiemOnline.Controllers
{
    public class ClasstController : ApiController
    {
        // GET: api/Classt
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Classt/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Classt
        public void Post([FromBody]string value)
        {
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
