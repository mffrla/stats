using MFFStats.Models.Domain;
using MFFStats.Models.Requests;
using MFFStats.Models.Responses;
using MFFStats.Services;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MFFStats.Web.Controllers.Api
{
    [RoutePrefix("api/character")]
    public class CharacterApiController : ApiController
    {
        CharacterService svc = new CharacterService();

        // GET api/character
        [Route, HttpGet]
        public HttpResponseMessage Get()
        {
            try
            {
                ItemsResponse<Character> response = new ItemsResponse<Character>();
                response.Items = svc.SelectAll();
                return Request.CreateResponse(HttpStatusCode.OK, response);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        // GET api/character/<id>
        [Route("{id:int}"), HttpGet]
        public HttpResponseMessage Get(int id)
        {
            try
            {
                ItemResponse<Character> response = new ItemResponse<Character>();
                response.Item = svc.SelectById(id);
                return Request.CreateResponse(HttpStatusCode.OK, response);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        // POST api/character
        [Route, HttpPost]
        public HttpResponseMessage Post(CharacterAddRequest model)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }
            try
            {
                ItemResponse<int> response = new ItemResponse<int>();
                response.Item = svc.Insert(model);
                return Request.CreateResponse(HttpStatusCode.OK, response);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        // PUT api/character/<id>
        [Route("{id:int}"), HttpPut]
        public HttpResponseMessage Put(CharacterUpdateRequest model)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }
            try
            {
                svc.Update(model);
                return Request.CreateResponse(HttpStatusCode.OK, new SuccessResponse());
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        // DELETE api/character/<id>
        [Route("{id:int}"), HttpDelete]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                svc.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, new SuccessResponse());
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
    }
}