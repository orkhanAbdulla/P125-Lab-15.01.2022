using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiorelloP125.Models
{
    public class FlowerImage
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public bool IsMain { get; set; }
        public int FlowerId { get; set; }
        public Flower flower { get; set; }
    }
}
