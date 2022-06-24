using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cleanAf.Domain.Entitites
{
    public class Adress : BaseEntity
    {
        public string street { get; set; }
        public string zipcode { get; set; }
        public string country { get; set; }
        public string city { get; set; }
    }
}
