using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaAPI.Model
{
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }
        public string CardNo { get; set; }
        public string Expiration { get; set; }
        public string CVV { get; set; }   
    }
}
