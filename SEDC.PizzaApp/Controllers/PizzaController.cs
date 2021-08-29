using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.Models;
using SEDC.PizzaApp.Services.Implementation;
using SEDC.PizzaApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.PizzaApp.Controllers
{
    public class PizzaController : Controller
    {
        private readonly IPizzaService _pizzaService;

        public PizzaController()
        {
            _pizzaService = new PizzaService();
        }
        [HttpGet]
        public IActionResult Index()
        {
            var orders = _pizzaService.GetAll();
            var orderItems = new List<PizzaItemViewModel>();

            foreach(var order in orders)
            {
                orderItems.Add(new PizzaItemViewModel()
                {
                    Id=order.Id,
                    PizzaName=order.NamePizza,
                    User=order.User,
                   
                    
                });
            }
            return View(orderItems);
                                    
        }
        [HttpGet("menu/{id}")]
        public IActionResult OrderDetails(int id)
        {
            var order = _pizzaService.GetOrderById(id);
            var pizzaOrderDetailsViewModel = new PizzaOrderDetailsViewModel()
            {
                OrderId = order.Id,
                User = order.User,
                PizzaName = order.NamePizza

            };
            return View(pizzaOrderDetailsViewModel);

        }
    }
}
