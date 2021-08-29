using SEDC.PizzaApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.PizzaApp.Services.Interfaces
{
    public interface IPizzaService
    {
        Pizzas GetOrderById(int id);
        List<Pizzas> GetAll();
    }
}
