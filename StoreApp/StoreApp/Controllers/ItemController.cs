using System;
using Microsoft.AspNetCore.Mvc;
using PROJECTONE.ModelLayer.Data.Interfaces;
using PROJECTONE.ModelLayer.ViewModels;

namespace PROJECTONE.Controllers
{
    //Item Controller sends view of our list of products to the page
    public class ItemController : Controller
    {

        private readonly ICategoryRepository _categoryRepository;
        private readonly IItemRepository _itemRepository;

        public ItemController(ICategoryRepository categoryRepository, IItemRepository itemRepository)
        {

            _categoryRepository = categoryRepository;
            _itemRepository = itemRepository;
        }

        public ViewResult List()
        {

            ItemListViewModel il = new ItemListViewModel();
            il.Items = _itemRepository.Item;
            il.CurrentCategory = "ShoeCategory";

            return View(il);
        }
    }
}
