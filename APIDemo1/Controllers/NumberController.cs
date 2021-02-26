using APIDemo.Service.Models;
using APIDemo1.Interface;
using APIDemo1.Models;
using APIDemo1.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APIDemo1.Controllers
{
    [RoutePrefix("api/Number")]
    public class NumberController : ApiController
    {
        private readonly INumber _number;
        public NumberController(INumber number)
        {
            _number = number;
        }
       
        [HttpGet]
        [Route("GetDetails")]
        public IHttpActionResult GetDetails([FromUri]NumberEntity item)
        {
            //NumberEntity obj = new NumberEntity();

            try
            {
                item.Result = _number.GetDetails(item);
                
            }
            catch (Exception ex)
            {

                return BadRequest("Error in program" + ex.Message.ToString());
            }
            return Ok(item);
        }
    }
}
