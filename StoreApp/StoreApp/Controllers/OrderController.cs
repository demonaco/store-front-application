using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StoreApp.ModelLayer.Data.Interfaces;
using StoreApp.ModelLayer.Data.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Store.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderRepository _orderRepository;
        private readonly ShoppingCart _shoppingCart;


        public OrderController(IOrderRepository orderRepository, ShoppingCart shoppingCart)
        {
            _orderRepository = orderRepository;
            _shoppingCart = shoppingCart;
        }


        // GET: /<controller>/
        public IActionResult CheckoutItems()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CheckoutItems(Order order)
        {
            var items = _shoppingCart.GrabShoppingCartItems();
            _shoppingCart.ShoppingCartItem = items;

            if (_shoppingCart.ShoppingCartItem.Count == 0)
            {
                ModelState.AddModelError("", "Your cart is empty");
            }

            if (ModelState.IsValid)
            {
                _orderRepository.InitOrder(order);
                _shoppingCart.TrashCart();
                return RedirectToAction("Complete");
            }
            return View(order);

        }

        public IActionResult Complete()
        {
            ViewBag.CompleteMessage = "Thanks! Your order was processed.";
            return View();
        }
    }
}
