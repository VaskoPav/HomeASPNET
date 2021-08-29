using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.PizzaApp.Domain.Models
{
    public class Pizzas
    {
        public int Id { get; set; }
        public string User { get; set; }
        public string NamePizza { get; set; }
        public bool IsGood { get; set; }
    }
}
