using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiorelloP125.Models
{
    public class Compaign
    {
        public int Id { get; set; }
        public int Discount { get; set; }
        public List<Flower> Flowers  { get; set; }
    }
}
