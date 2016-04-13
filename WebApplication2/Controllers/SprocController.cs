using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class SprocController : ApiController
    {
        public IHttpActionResult Post()
        {
            var db = new MattoEntities();

            db.Procedure1();

            return Ok();
        }
    }
}
