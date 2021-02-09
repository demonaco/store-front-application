using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreApp.ModelLayer.Data.Models
{
    public class Customer
    {
        public Customer()
        {
        }


        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }

        public Customer(string firstn = "null", string lastn = "null", string username = "null")
        {
            this.Firstn = firstn;
            this.Lastn = lastn;
            this.UserName = username;
        }

        public string FirstN;
        public string Firstn
        {
            get { return FirstN; }
            set
            {
                if (value is string && value.Length < 100 && value.Length > 0)
                {
                    FirstN = value;
                }
                else
                {
                    // throw new Exception("Please enter a first name!");
                }
            }
        }

        public string LastN;
        public string Lastn
        {
            get { return LastN; }
            set
            {
                if (value is string && value.Length < 100 && value.Length > 0)
                {
                    LastN = value;
                }
                else
                {
                    // throw new Exception("Please enter in a valid last name.");
                }
            }
        }


        public string UN;
        public string UserName
        {
            get { return UN; }
            set
            {
                if (value is string && value.Length < 20 && value.Length > 0)
                {
                    UN = value;
                }
                else
                {
                    // throw new Exception("Please enter a username!");
                }
            }
        }






    }
}
