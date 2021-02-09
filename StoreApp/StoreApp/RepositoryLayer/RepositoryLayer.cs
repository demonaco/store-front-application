using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using StoreApp.ModelLayer.Data.Models;

namespace RepositoryLayer
{
    public class Repository
    {

        private readonly ILogger<Repository> _logger;

        private readonly ApplicationDbContext _DbContext;
        DbSet<Item> Item;
        DbSet<Order> Order;
        DbSet<Location> Location;
        DbSet<Customer> Customer;
        DbSet<Category> Category;

        //IEnumerable<Item> Item { get; set; }
        //IEnumerable <Item> IsFavShoe { get; set; }


        public Repository(ApplicationDbContext applicationDbContext, ILogger<Repository> logger)
        {
            _DbContext = applicationDbContext;
            this.Item = _DbContext.Item;
            this.Order = _DbContext.Order;
            this.Location = _DbContext.Location;
            this.Customer = _DbContext.Customer;
            this.Category = _DbContext.Category;
            _logger = logger;
        }


        public Customer AddCustomer(string FirstN = "null", string LastN = "null", string UN = "null")
        {
            Customer cust = new Customer();
            cust = _DbContext.Customer.Where(z => z.Firstn == FirstN && z.Lastn == LastN).FirstOrDefault();

            if (cust == null)
            {
                cust = new Customer()
                {
                    Firstn = FirstN,
                    Lastn = LastN,
                    UserName = UN
                };
                _DbContext.Customer.Add(cust);
                _DbContext.SaveChanges();
            }
            return cust;

        }


        public Location AddLocation(string NameCity = "null")
        {
            Location loc = new Location();
            loc = _DbContext.Location.Where(z => z.CityName == NameCity).FirstOrDefault();
            if (loc == null)
            {
                loc = new Location()
                {
                    CityName = NameCity
                };
                _DbContext.Location.Add(loc);
                _DbContext.SaveChanges();
            }
            return loc;
        }

        public Item AddItem(string ITEMTYPEHYPE = "null", string AMTPURCHASE = "null")
        {
            Item it = new Item();
            it = _DbContext.Item.Where(z => z.ItemType == ITEMTYPEHYPE).FirstOrDefault();

            if (it == null)
            {
                it = new Item()
                {
                    ItemType = ITEMTYPEHYPE,
                };
                _DbContext.Item.Add(it);
                _DbContext.SaveChanges();
            }
            return it;

        }

        //public Order AddOrder(string CustomerId, string LocationId, string ItemID, string orderQuantity = "null")
        //{
        //    Order or = new Order()
        //    {
        //        qOrdered = orderQuantity,
        //        CustomerId = CustomerId,
        //        LocationId = LocationId,
        //        ItemID = ItemID
        //    };
        //    _DbContext.Order.Add(or);
        //    _DbContext.SaveChanges();
        //    return or;

        //}

        public Customer GrabCustomer(string UserName)
        {
            Customer custo = new Customer();
            custo = _DbContext.Customer.Where(x => x.UserName == UserName).FirstOrDefault();


            return custo;

        }

        //public List<Order> GrabOrderByLocation(string LocationInput)
        //{

        //    string id = _DbContext.Location.Where(x => x.CityName == LocationInput).SingleOrDefault().Id;


        //    List<Order> orderSet = _DbContext.Order.Where(x => x.LocationId == id).ToList();

        //    return orderSet;

        //}

        //public List<Order> GrabOrderByCustomer(string CustomerInput)
        //{
        //    string id = _DbContext.Customer.Where(x => x.UserName == CustomerInput).SingleOrDefault().Id;

        //    List<Order> orderSet = _DbContext.Order.Where(x => x.CustomerId == id).ToList();

        //    return orderSet;
        //}

        //Item GetItemById(int Id);

        public List<Customer> RetreiveCustomers()
        {
            return Customer.ToList();
        }

        public List<Location> RetreiveLocation()
        {
            return Location.ToList();
        }

        public List<Item> RetreiveItem()
        {

            return Item.ToList();
        }

        public List<Order> RetreiveOrder()
        {

            return Order.ToList();
        }

        ///possibly need this method
        ///
        //public Customer GetCustomerById (Customer Id)
        //{
        //    Customer customer = 
        //}







    }


}
