using SEDC.PizzaApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Pizza.App.DataAccess
{
    public static class StaticDb
    {
        public static List<Pizzas> Pizzas;

        static StaticDb()
        {
            Pizzas = new List<Pizzas>()
            {
                new Pizzas()
                {
                    Id=1,
                    User="James Bond",
                    NamePizza="Capri",
                    IsGood=false
                },
                new Pizzas()
                {
                    Id=2,
                    User="John Snow",
                    NamePizza="Makedonska",
                    IsGood=true

                }
            };
                
           
        }
    }
}
