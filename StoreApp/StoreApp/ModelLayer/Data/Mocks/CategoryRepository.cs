using System;
using System.Collections.Generic;
using StoreApp.ModelLayer.Data.Interfaces;
using StoreApp.ModelLayer.Data.Models;

namespace StoreApp.ModelLayer.Data.Mocks
{
    public class CategoryRepository : ICategoryRepository
    {

        public IEnumerable<Category> Category
        {
            get
            {
                return new List<Category>
                {
                    new Category { CategoryName = "Athletic", Description = "Atheltic shoes to get you on the run or to play your favoite sport!" },
                    new Category { CategoryName = "Dance", Description = "From ballroom to ballet we have your feet covered for your favorite dance." },
                    new Category { CategoryName = "Loafers", Description = "From business casual to relaxing at home." },
                    new Category { CategoryName = "Sandals", Description = "Get ready to hit the beach! Our summer 2021 selection is now available!" },
                    new Category { CategoryName = "Boots", Description = "From winter boots to keep your feet warm to punk rock boots you can wear at the next show!" }
                };
            }


        }
    }
}

