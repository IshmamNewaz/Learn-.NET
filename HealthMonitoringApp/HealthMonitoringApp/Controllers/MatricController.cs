using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HealthMonitoringApp.Controllers
{
    public class MatricController : ApiController
    {
        [HttpGet]
        [Route("api/matrics/all")]
        public HttpResponseMessage Get()
        {
            var data = MatricService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [HttpGet]
        [Route("api/matrics/{userId}")]
        public HttpResponseMessage Get(string userId)
        {
            var data = MatricService.Get(userId);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [HttpPost]
        [Route("api/matrics/create")]
        public HttpResponseMessage Create(MatricDTO c)
        {
            MatricService.Create(c);
            return Request.CreateResponse(HttpStatusCode.OK);
        }
        
    }
}
