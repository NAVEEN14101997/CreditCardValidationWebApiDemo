using BusinessLayer;
using BusinessLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace CreditCardValidationWebApiDemo.Controllers
{
    public class ValuesController : ApiController
    {
        private readonly IDecrypt _decrypt;
        private readonly IValidateCardDetails _validateCardDetails;
        public ValuesController(IDecrypt decrypt, IValidateCardDetails validateCardDetails)
        {
            _decrypt = decrypt;
            _validateCardDetails = validateCardDetails;
        }
       

        [HttpPost]
        public IHttpActionResult ValidateCreditCardDetails(CreditCardDetails creditCardDetails)
        {
            if (_validateCardDetails.Validate(creditCardDetails))
            {

                return Ok("Validation Succeeded");
            }
            else
            {
                return BadRequest("Validation Failed");
            }
        }
        /*
        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }*/
    }
}
