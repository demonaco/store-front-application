using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreApp.ModelLayer.Data.Models
{
    public class Location
    {
        public Location()
        {
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }


        public string NameCity;
        public string CityName
        {
            get { return NameCity; }
            set
            {
                if (value is string && value.Length < 100 && value.Length > 0)
                {
                    NameCity = value;
                }
                else
                {
                    throw new Exception("Please enter the correct city name");
                }
            }
        }



    }
}
