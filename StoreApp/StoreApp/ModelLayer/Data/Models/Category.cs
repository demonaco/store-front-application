using System;
using System.Collections.Generic;


namespace PROJECTONE.ModelLayer.Data.Models
{
    public class Category
    {


        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public string Description { get; set; }
        public List<Item> Item { get; set; }

        internal static object Select(Func<object, object> p)
        {
            throw new NotImplementedException();
        }
    }
}
