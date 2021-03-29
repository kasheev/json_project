using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class filename : ControllerBase
    {

        private serialiszer serialiszer = new serialiszer();
        [HttpGet]
        public string filenameInf(bool correct) {

            string json = "";
            var res = serialiszer.GetParser();
            for (int i = 0; i < res.files.Length; i++)
            {
               if (res.files[i].result == correct)
                {
                    continue;
               }
                json += JsonConvert.SerializeObject(res.files[i].filename);
            }
            return json;
        }

    }
}