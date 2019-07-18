using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaAPI.Model
{
    public class Pizza
    {
        [Key]
        public int PizzaId { get; set; }
        public string PizzaName { get; set; }

        public Size Size { get; set; }
        public Crust Crust { get; set; }
        public Sauce Sauce { get; set; }
        public Topping Topping1 { get; set; }
        public Topping Topping2 { get; set; }
        public Topping Topping3 { get; set; }

        public double Total { get; set; }
        public DateTime OrderDate { get; set; }

        public Order Order { get; set; }

    }
}
