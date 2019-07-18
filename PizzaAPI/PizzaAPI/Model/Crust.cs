using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaAPI.Model
{
    public class Crust
    {
        [Key]
        public int CrustId { get; set; }
        public string CrustName { get; set; }
        public double Price { get; set; }

    }
}
