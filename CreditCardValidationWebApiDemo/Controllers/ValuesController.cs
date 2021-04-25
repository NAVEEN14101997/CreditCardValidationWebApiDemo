﻿using BusinessLayer.Interface;
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
        public ValuesController(IDecrypt decrypt)
        {
            _decrypt = decrypt;
        }
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        
        public IHttpActionResult Validate(string creditCardNumber)
        {


            return Ok("Validation Succeeded");
        }

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
        }
    }
}