using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StoreApp.ModelLayer.Data.Interfaces;
using StoreApp.ModelLayer.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StoreApp.Controllers
{
    public class ShoppingController : Controller
    {
        private readonly IItemRepository _itemRepository;

        public ShoppingController(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }


        // GET: /<controller>/
        public ViewResult Index()
        {
            var shoppingViewModel = new ShoppingViewModel
            {

                IsFavShoe = _itemRepository.IsFavShoe
            };

            return View(shoppingViewModel);

        }
    }
}
