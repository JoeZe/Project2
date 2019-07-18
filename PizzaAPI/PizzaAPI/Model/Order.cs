using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaAPI.Model
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public double TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }

        public Customer Customer { get; set; }
    }
}
