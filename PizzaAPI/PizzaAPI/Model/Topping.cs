using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaAPI.Model
{
    public class Topping
    {
        [Key]
        public int ToppingId { get; set; }
        public string ToppingName { get; set; }
        public double Price { get; set; }
    }
}
