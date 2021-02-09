using System;
using Microsoft.AspNetCore.Identity;

namespace StoreApp.ModelLayer.Data.Models
{
    public class AppUser : IdentityUser
    {
        public String DefaultLocation { get; set; }

    }
}
