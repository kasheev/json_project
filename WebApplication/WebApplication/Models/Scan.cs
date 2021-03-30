using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class Scan
    {
        public DateTime scanTime{ get; set;}
        public string db { get; set; }
        public string server { get; set; }
        public int errorCount { get; set; }
    }
}
