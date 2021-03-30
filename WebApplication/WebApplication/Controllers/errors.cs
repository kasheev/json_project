using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    
    public class errors : ControllerBase
    {
        private serialiszer serialiszer = new serialiszer();
        string error = "";
        [HttpGet]
        public string errosInf() {
            var res = serialiszer.GetParser();

            return error;
        }

        [HttpGet("count")]
        public string countInf() {
            var res = serialiszer.GetParser();
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(res.scan.errorCount);
            return json;
        }
    }
}