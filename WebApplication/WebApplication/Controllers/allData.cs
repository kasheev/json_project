using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class allData : ControllerBase
    {
        private serialiszer serialiszer = new serialiszer(); 
        
        [HttpGet]
        public string scan()
        {
            var res = serialiszer.GetParser();
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(res);
            return json;
        }
    }
}