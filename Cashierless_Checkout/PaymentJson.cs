using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Cashierless_Checkout
{
    public class PaymentJson
    {
        public string Date {get; set; }
        public int TotalPrice { get; set; }
        public short[] ProductId { get; set; }
        public string[] ProductNames { get; set; }
        public string[] ProducerNames { get; set; }
        public int[] ProductTotalPrice { get; set; } 
        public int[] ProductTax { get; set; }

    }
}
