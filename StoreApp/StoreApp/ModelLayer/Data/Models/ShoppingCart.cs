using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RepositoryLayer;
using StoreApp.Data;

namespace StoreApp.ModelLayer.Data.Models
{
    public class ShoppingCart
    {
        private readonly ApplicationDbContext _applicationDbContext;

        private ShoppingCart(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public string ShoppingCartId { get; set; }

        public List<ShoppingCartItem> ShoppingCartItem { get; set; }

        public static ShoppingCart GetCart(IServiceProvider service)
        {
            ISession session = service.GetRequiredService<IHttpContextAccessor>()?
                .HttpContext.Session;

            var DbContext = service.GetService<ApplicationDbContext>();

            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", cartId);

            return new ShoppingCart(DbContext) { ShoppingCartId = cartId };
        }

        public void AddToACart(Item item, int amount)
        {
            var cartItem =
                _applicationDbContext.ShoppingCartItem.SingleOrDefault(
                    z => z.Item.Id == item.Id && z.ShoppingCartId == ShoppingCartId);

            if (cartItem == null)
            {
                cartItem = new ShoppingCartItem
                {
                    ShoppingCartId = ShoppingCartId,
                    Item = item,
                    Amount = 1
                };

                _applicationDbContext.ShoppingCartItem.Add(cartItem);
            }
            else
            {
                cartItem.Amount++;
            }
            _applicationDbContext.SaveChanges();
        }

        public int RemoveFromACart(Item item)
        {
            var cartItem = _applicationDbContext.ShoppingCartItem.SingleOrDefault(z => z.Item.Id == item.Id && z.ShoppingCartId == ShoppingCartId);

            var localAmount = 0;

            if (cartItem != null)
            {
                if (cartItem.Amount > 1)
                {
                    cartItem.Amount--;
                    localAmount = cartItem.Amount;
                }
                else
                {
                    _applicationDbContext.ShoppingCartItem.Remove(cartItem);
                }
            }

            _applicationDbContext.SaveChanges();

            return localAmount;

        }

        public List<ShoppingCartItem> GrabShoppingCartItems()
        {
            return ShoppingCartItem ??
                (ShoppingCartItem = _applicationDbContext.ShoppingCartItem.Where(z => z.ShoppingCartId == ShoppingCartId).Include(z => z.Item).ToList());
        }

        public void TrashCart()
        {
            var cartItem = _applicationDbContext.ShoppingCartItem.Where(cart => cart.ShoppingCartId == ShoppingCartId);

            _applicationDbContext.ShoppingCartItem.RemoveRange(cartItem);

            _applicationDbContext.SaveChanges();
        }

        public decimal GrabShoppingCartTotal()
        {
            var total = _applicationDbContext.ShoppingCartItem.Where(z => z.ShoppingCartId == ShoppingCartId).Select(z => z.Item.Price * z.Amount).Sum();
            return total;
        }
    }
}
