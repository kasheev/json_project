using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class QueryDTO
    {
        public int total { get; set; }
        public int correct { get; set; }
        public int errors { get; set; }
        public List<string> filename { get; set; }
    }
}
