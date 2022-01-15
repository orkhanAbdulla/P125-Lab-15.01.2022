using FiorelloP125.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiorelloP125.ViewModels
{
    public class HomeVM
    {
        public List<Flower> Flowers { get; set; }
        public List<Category> Categories { get; set; }
    }
}
