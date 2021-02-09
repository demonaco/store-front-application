using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using StoreApp.ModelLayer.Data.Models;

namespace StoreApp.ModelLayer.Data.Models
{
    public class Item
    {
        //{
        //    public Item(object p)
        //    {
        //    }


        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public string ImgUrl { get; set; }

        public string ImgThumbUrl { get; set; }

        public bool InStock { get; set; }

        public bool IsFavShoe { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }






        //public Item(string ItemType_ = "null")
        //{
        //    this.ItemType = ItemType_;
        //}


        public string ITEMTYPEHYPE;
        //internal string id;

        public string ItemType
        {
            get { return ITEMTYPEHYPE; }
            set
            {
                if (value is string && value.Length < 100 && value.Length > 0)
                {
                    ITEMTYPEHYPE = value;
                }
                else
                {
                    throw new Exception("Please enter in an item exactly as you see it on your screen.");
                }
            }
        }



    }
}
