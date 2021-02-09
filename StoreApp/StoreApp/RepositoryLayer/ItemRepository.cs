using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using StoreApp.ModelLayer.Data.Interfaces;
using StoreApp.ModelLayer.Data.Models;
using RepositoryLayer;

namespace StoreApp.RepositoryLayer
{
    public class ItemRepository : IItemRepository
    {

        private readonly ApplicationDbContext _applicationDbContext;

        public ItemRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public IEnumerable<Item> Item => _applicationDbContext.Item.Include(x => x.Category);

        public IEnumerable<Item> IsFavShoe => _applicationDbContext.Item.Where(x => x.IsFavShoe).Include(x => x.Category);

        public Item GetItemById(int id) => _applicationDbContext.Item.FirstOrDefault(x => x.Id == x.Id);
    }
}
