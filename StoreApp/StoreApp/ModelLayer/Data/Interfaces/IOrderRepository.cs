using System;
using StoreApp.ModelLayer.Data.Models;

namespace StoreApp.ModelLayer.Data.Interfaces
{
    public interface IOrderRepository
    {
        void InitOrder(Order order);

    }
}

