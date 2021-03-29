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
    public class scan : ControllerBase
    {
        private serialiszer serialiszer = new serialiszer();

        [HttpGet]
        public string scanInfo()
        {
            var res = serialiszer.GetParser();
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(res.scan);
            return json;
        }
    }
}