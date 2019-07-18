using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaAPI.Model
{
    public class Size
    {
        [Key]
        public int SizeId { get; set; }
        public string SizeName { get; set; }
        public double Price { get; set; }
    }
}
