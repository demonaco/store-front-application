﻿using System;
using Microsoft.AspNetCore.Mvc;
using StoreApp.ModelLayer.Data.Models;
using StoreApp.ModelLayer.ViewModels;

namespace StoreApp.Componets
{
    public class ShoppingCartTotal : ViewComponent
    {
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartTotal(ShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;
        }

        public IViewComponentResult Invoke()
        {
            var items = _shoppingCart.GrabShoppingCartItems();
            _shoppingCart.ShoppingCartItem = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GrabShoppingCartTotal()
            };

            return View(shoppingCartViewModel);
        }

    }
}
