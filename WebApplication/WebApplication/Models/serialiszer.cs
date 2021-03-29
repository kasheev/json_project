using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WebApplication.Models
{
    public class serialiszer
    {
        public Parser GetParser() {

            var res = JsonConvert.DeserializeObject<Parser>(File.ReadAllText("data.json"));
            Console.WriteLine(res);
            return res;
        }
    }
}

