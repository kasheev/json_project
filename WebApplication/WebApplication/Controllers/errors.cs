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
        string filenameDto;
        [HttpGet]
        public string errosInf() {
            var res = serialiszer.GetParser();

            var ErrorDto = new List<ErrorDTO>();

            for (int i = 0; i < res.files.Length; i++)
            {
                if (res.files[i].result == false)
                {


                    filenameDto = Newtonsoft.Json.JsonConvert.SerializeObject(res.files[i].filename);
                    List<string> erDto = new List<string>();
                    for (int j = 0; j < res.files[i].errors.Length; j++) {
                        erDto.Add(res.files[i].errors[j].error);
                    }

                    ErrorDto.Add(new ErrorDTO() { filename = filenameDto, errors = erDto });
                }

            }

            var serial = Newtonsoft.Json.JsonConvert.SerializeObject(ErrorDto);
            return serial;
        }

        [HttpGet("count")]
        public string countInf() {
            var res = serialiszer.GetParser();
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(res.scan.errorCount);
            return json;
        }
    }
}