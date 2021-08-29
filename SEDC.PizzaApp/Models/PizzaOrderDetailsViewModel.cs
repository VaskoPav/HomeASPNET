using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.PizzaApp.Models
{
    public class PizzaOrderDetailsViewModel
    {
        public int OrderId { get; set; }
        public string User { get; set; }
        public string PizzaName { get; set; }
        public bool IsGood { get; set; }
    }
}
