using System;
using System.Collections.Generic;
using StoreApp.ModelLayer.Data.Models;

namespace StoreApp.ModelLayer.Data.Interfaces
{
    public interface IItemRepository
    {
        IEnumerable<Item> Item { get; }
        IEnumerable<Item> IsFavShoe { get; }

        Item GetItemById(int id);

    }
}
