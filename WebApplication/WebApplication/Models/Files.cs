using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class Files
    {
        public string filename {get; set;}
        public bool result {get; set;}
        public Errors[] errors {get; set;}
        public DateTime scantime { get; set;} 
}
}
