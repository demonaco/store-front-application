using System;
using System.Collections.Generic;
using StoreApp.ModelLayer.Data.Models;

namespace StoreApp.ModelLayer.Data.Interfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> Category { get; }
    }


}