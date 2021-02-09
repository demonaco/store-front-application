using System;
namespace StoreApp.ModelLayer.Data.Models
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int ItemId { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }
        public virtual Item Item { get; set; }
        public virtual Order Order { get; set; }
        public string CityName { get; set; }

    }
}

