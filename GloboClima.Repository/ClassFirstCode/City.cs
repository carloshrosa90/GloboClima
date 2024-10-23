using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboClima.Repository.ClassFirstCode
{
    public class City
    {
        
        public int id { get; set; }
        public string name { get; set; }
    }
}
