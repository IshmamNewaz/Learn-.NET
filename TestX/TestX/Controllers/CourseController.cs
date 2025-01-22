using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestX.EF;

namespace TestX.Controllers
{
    public class CourseController : ApiController
    {
        Context db = new Context();
        [HttpGet]
        [Route("api/course/status")]
        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(HttpStatusCode.OK, "Get Method Called");
        }
        [HttpGet]
        [Route("api/course/getall")]
        public HttpResponseMessage GetAll()
        {
            var data = db.Courses.ToList();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/course/{id}")]
        public HttpResponseMessage Get(int id)
        {
            var data = db.Courses.Find(id);
            if (data != null)
                return Request.CreateResponse(HttpStatusCode.OK, data);
            else return Request.CreateResponse(HttpStatusCode.NotFound, data);
        }


    }
}
