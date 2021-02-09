using System;
using System.Collections.Generic;
using StoreApp.ModelLayer.Data.Models;

namespace StoreApp.ModelLayer.ViewModels
{
    public class ItemListViewModel
    {

        public IEnumerable<Item> Items { get; set; }

        public string CurrentCategory { get; set; }



    }
}

