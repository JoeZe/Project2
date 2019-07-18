using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaAPI.Model
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public string PhoneNo { get; set; }
        public string Address { get; set; }
        public string AptNo { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }

        public Payment Payment { get; set; }
    }
}
