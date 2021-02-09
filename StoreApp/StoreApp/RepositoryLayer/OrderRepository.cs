using System;
using StoreApp.ModelLayer.Data.Interfaces;
using StoreApp.ModelLayer.Data.Models;
using RepositoryLayer;

namespace StoreApp.RepositoryLayer
{
    public class OrderRepository : IOrderRepository
    {

        private readonly ApplicationDbContext _applicationDbContext;
        private readonly ShoppingCart _shoppingcart;

        public OrderRepository(ApplicationDbContext applicationDbContext, ShoppingCart shoppingCart)
        {
            _applicationDbContext = applicationDbContext;
            _shoppingcart = shoppingCart;

        }


        public void InitOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;
            _applicationDbContext.Order.Add(order);

            var shoppingCartItems = _shoppingcart.ShoppingCartItem;

            foreach (var it in shoppingCartItems)
            {
                var details = new OrderDetail()
                {
                    Amount = it.Amount,
                    ItemId = it.Item.Id,
                    OrderId = order.OrderId,
                    Price = it.Item.Price
                };
                _applicationDbContext.OrderDetail.Add(details);
            }
            _applicationDbContext.SaveChanges();
        }
    }
}
