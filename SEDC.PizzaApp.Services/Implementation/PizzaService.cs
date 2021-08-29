using SEDC.Pizza.App.DataAccess.Repositories;
using SEDC.Pizza.App.DataAccess.Repositories.StaticDbRepositories;
using SEDC.PizzaApp.Domain.Models;
using SEDC.PizzaApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.PizzaApp.Services.Implementation
{
    public class PizzaService : IPizzaService
    {
        private readonly IRepository<Pizzas> _pizzaRepository;

        public PizzaService()
        {
            _pizzaRepository = new PizzaRepository();
        }
        public List<Pizzas> GetAll()
        {
            return _pizzaRepository.GetAll();
        }

        public Pizzas GetOrderById(int id)
        {
            return _pizzaRepository.GetById(id);
        }
    }
}
