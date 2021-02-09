using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using StoreApp.ModelLayer.Data.Interfaces;
using StoreApp.ModelLayer.Data.Models;
using StoreApp.ModelLayer.ViewModels;

namespace StoreApp.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IItemRepository _itemRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IItemRepository itemRepository, ShoppingCart shoppingCart)
        {
            _itemRepository = itemRepository;
            _shoppingCart = shoppingCart;

        }


        public ViewResult Index()
        {
            var item = _shoppingCart.GrabShoppingCartItems();
            _shoppingCart.ShoppingCartItem = item;

            var sCVM = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GrabShoppingCartTotal()
            };
            return View(sCVM);
        }

        public RedirectToActionResult AddToShoppingCart(int itemId)
        {
            var itemSelected = _itemRepository.Item.FirstOrDefault(z => z.Id == itemId);
            if (itemSelected != null)
            {
                _shoppingCart.AddToACart(itemSelected, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int itemId)
        {
            var itemSelected = _itemRepository.Item.FirstOrDefault(z => z.Id == itemId);
            if (itemSelected != null)
            {
                _shoppingCart.RemoveFromACart(itemSelected);
            }
            return RedirectToAction("Index");
        }
    }
}
