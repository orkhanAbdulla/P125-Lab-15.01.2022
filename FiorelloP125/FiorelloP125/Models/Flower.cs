using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FiorelloP125.Models
{
    public class Flower
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength:50)]
        public string Name { get; set; }
        [Required]
        public double Price { get; set; }
        [StringLength(maximumLength:200)]
        public string Description { get; set; }
        public List<FlowerImage> FlowerImages { get; set; }
        public int? CompaignId { get; set; }
        public Compaign Compaign { get; set; }
        public List<FlowerCategory> FlowerCategories { get; set; }


    }
}
