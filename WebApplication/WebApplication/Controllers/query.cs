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
    public class query : ControllerBase
    {
        private serialiszer serialiszer = new serialiszer();
        [HttpGet("{check}")]
        public string queryInf()
        {
            var res = serialiszer.GetParser();
            int resutlTrue = 0, resultFalse = 0, i;

            var queryDto = new List<QueryDTO>();
            List<string> err = new List<string>();
            for (i = 0; i < res.files.Length; i++)
            {
                if (res.files[i].filename.ToLower().StartsWith("query_") == true)
                {
                    if (res.files[i].result == true) resutlTrue++;
                    if (res.files[i].result == false)
                    {
                        err.Add(res.files[i].filename);
                        resultFalse++;
                    }
                }
            }
            queryDto.Add(new QueryDTO() { total = i + 1, correct = resutlTrue, errors = resultFalse, filename = err });
            var serial = Newtonsoft.Json.JsonConvert.SerializeObject(queryDto);
            return serial;
        }
    }
}