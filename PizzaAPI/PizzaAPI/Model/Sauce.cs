using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaAPI.Model
{
    public class Sauce
    {
        [Key]
        public int SauceId { get; set; }
        public string SauceName { get; set; }
    }
}
