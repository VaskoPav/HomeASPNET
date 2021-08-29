using SEDC.PizzaApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.Pizza.App.DataAccess.Repositories.StaticDbRepositories
{
    public class PizzaRepository : IRepository<Pizzas>
    {
        public List<Pizzas> GetAll()
        {
            return StaticDb.Pizzas;
        }

        public Pizzas GetById(int id)
        {
            var order = StaticDb.Pizzas.FirstOrDefault(x => x.Id == id);
            return order;
        }
    }
}
