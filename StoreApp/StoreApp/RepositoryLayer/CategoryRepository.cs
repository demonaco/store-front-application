using System;
using System.Collections.Generic;
using StoreApp.ModelLayer.Data.Interfaces;
using StoreApp.ModelLayer.Data.Models;
using RepositoryLayer;

namespace StoreApp.RepositoryLayer
{
    public class CategoryRepository : ICategoryRepository
    {

        private readonly ApplicationDbContext _applicationDbContext;

        public CategoryRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }



        public IEnumerable<Category> Category => _applicationDbContext.Category;
    }
}
