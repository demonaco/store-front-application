using System;
using StoreApp.ModelLayer.Data.Models;

namespace StoreApp.ModelLayer.ViewModels
{
    public class ShoppingCartViewModel
    {
        public ShoppingCart ShoppingCart { get; set; }

        public decimal ShoppingCartTotal { get; set; }
    }
}

