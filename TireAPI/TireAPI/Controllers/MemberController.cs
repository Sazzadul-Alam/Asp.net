using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL.DTOs;
using BLL.Services;

namespace TireAPI.Controllers
{
    public class MemberController : ApiController
    {
        [HttpGet]
        [Route("api/member/all")]
        public HttpResponseMessage AllMember()
        {
            try
            {
                var data = ProjectService.GetAllMember();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }

        }
        [HttpPost]
        [Route("api/member/create")]
        public HttpResponseMessage AddMember(MemberDTO m)
        {
            try
            {
                var data = ProjectService.createMember(m);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
