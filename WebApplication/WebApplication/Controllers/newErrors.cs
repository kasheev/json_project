using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text.Json;
using WebApplication.Models;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;

namespace WebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class newErrors : ControllerBase
    {

        [HttpPost]
        void Desirilize() {
            var messages = new List<string>();
            var res = System.Text.Json.JsonSerializer.Serialize("data.json");

            var setings = new JsonSerializerSettings()
            {
                Error = (s, e) =>
                {
                    var depObj = e.CurrentObject as Parser;
                    if (depObj.scan != null)
                    {
                        messages.Add(string.Format("Obj:{0} Message: {1}", depObj.scan, e.ErrorContext.Error.Message));
                    }
                    else if (depObj.files != null)
                    {
                        messages.Add(string.Format("Obj:{0} Message: {1}", depObj.files, e.ErrorContext.Error.Message));
                    }
                    else {
                        messages.Add(e.ErrorContext.Error.Message);
                    }
                    
                }
            };
            string filename = DateTime.Now.ToString("dd-mm-yyyy-hh-mm-ss") + ".json";
            System.IO.File.WriteAllText(filename, res);
           
        }
    }
}