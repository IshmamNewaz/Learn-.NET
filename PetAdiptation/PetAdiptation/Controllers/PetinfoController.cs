using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PetAdiptation.Controllers
{
    public class PetinfoController : ApiController
    {
        [HttpGet]
        [Route("api/pets/all")]
        public HttpResponseMessage Get()
        {
            var data = PetinfoService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [HttpGet]
        [Route("api/pets/{id}")]
        public HttpResponseMessage Get(string id)
        {
            var data = PetinfoService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [HttpPost]
        [Route("api/pets/create")]
        public HttpResponseMessage Create(PetinfoDTO c)
        {
            PetinfoService.Create(c);
            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}
