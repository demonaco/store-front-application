using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreApp.ModelLayer.Data.Models
{
    public class Order
    {
        public Order()
        {
        }

        //public string LocationId { get; set; }

        //public string CustomerId { get; set; }

        //public string ItemID { get; set; }

        public Item Item { get; set; }

        //public Customer customer { get; set; }



        //public Location Location { get; set; }
        //public string LocationId { get; set; }
        public string ItemId { get; set; }

        [Display(Name = "Address")]
        [StringLength(100)]
        [Required(ErrorMessage = "Enter your Address")]
        public string Address { get; set; }
        [Display(Name = "First Name")]
        [StringLength(70)]
        [Required(ErrorMessage = "Enter your first name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        [StringLength(70)]
        [Required(ErrorMessage = "Enter your Last name")]
        public string LastName { get; set; }
        public string OrderTotal { get; set; }
        public DateTime OrderPlaced { get; set; }

        [Display(Name = "CityName")]
        [StringLength(70)]
        [Required(ErrorMessage = "Please enter either SF, LA, or NYC as your location.")]
        public string CityName { get; set; }

        public List<OrderDetail> OrderDetail { get; set; }




        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int OrderId { get; set; }

        //public Order(Customer cust, Location loc, Item it, string qOrdered_ = "null")
        //{
        //    this.CustomerId = CustomerId;
        //    this.LocationId = LocationId;
        //    this.ItemID = ItemID;
        //    this.qOrdered = qOrdered_;
        //}

        public string orderQuantity;
        public string qOrdered
        {
            get { return orderQuantity; }
            set
            {
                if (value is string && value.Length < 10 && value.Length > 0)
                {
                    orderQuantity = value;
                }
                else
                {
                    throw new Exception("Please select a valid numerical value for the quantity you would like to order");
                }
            }
        }




    }
}
