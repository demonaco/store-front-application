using System.Collections.Generic;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using RepositoryLayer;
using System.Linq;
using System;
using StoreApp.Data;

namespace StoreApp.ModelLayer.Data.Models
{
    public class DbInitializer
    {
        public static void Seed(IServiceProvider applicationBuilder)
        {

            ApplicationDbContext DbContext =
                applicationBuilder.GetRequiredService<ApplicationDbContext>();

            if (!DbContext.Category.Any())
            {
                DbContext.Category.AddRange(Categories.Select(z => z.Value));
            }

            if (!DbContext.Item.Any())
            {
                DbContext.AddRange
                    (

                    new Item
                    {
                        ItemType = "Running Shoe",
                        Price = 19.99M,
                        Description = "Comfortable shoe for running. It's what the Pros where!",
                        Category = Categories["Athletic"],
                        ImgUrl = "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/04cfa08e-6537-4475-9673-b5538eeaf170/flex-experience-run-9-womens-running-shoe-mSLxGh.jpg",
                        InStock = true,
                        IsFavShoe = false,
                        //ImgThumbUrl
                    },
                new Item
                {
                    ItemType = "Tennis Shoe",
                    Price = 39.99M,
                    Description = "Perfect for outdoor activites such as golfing or tennis.",
                    Category = Categories["Athletic"],
                    ImgUrl = "https://cdn.allbirds.com/image/fetch/q_auto,f_auto/w_1000,f_auto,q_auto,b_rgb:f5f5f5/https://cdn.shopify.com/s/files/1/1104/4168/products/Allbirds_WL_RN_SF_PDP_Natural_Grey_BTY_10b4c383-7fc6-4b58-8b3f-6d05cef0369c.png?v=1610061677",
                    InStock = true,
                    IsFavShoe = false,
                    //ImgThumbUrl
                },
                new Item
                {
                    ItemType = "Basketball Shoe",
                    Price = 49.99M,
                    Description = "You'll be the best on the court with these babies!",
                    Category = Categories["Athletic"],
                    ImgUrl = "https://www.famousfootwear.com/productimages/shoes_ib92896.jpg?trim.threshold=105&width=630&height=480&paddingWidth=60",
                    InStock = true,
                    IsFavShoe = false,
                    //ImgThumbUrl

                },
                new Item
                {
                    ItemType = "Dance Shoe",
                    Price = 29.99M,
                    Description = "Dance away the night with these beautiful ballroom dance shoes.",
                    Category = Categories["Dance"],
                    ImgUrl = "https://www.danceshoesstore.com/assets/images/Party%20Party%20Mens/PP301%20Black%20Leather_White%20Leather.jpg",
                    InStock = true,
                    IsFavShoe = false,
                    //ImgThumbUrl

                },
                new Item
                {
                    ItemType = "Ballet Slippers",
                    Price = 49.99M,
                    Description = "Ballet slippers for beginners to advance.",
                    Category = Categories["Dance"],
                    ImgUrl = "https://cdn.shopify.com/s/files/1/0352/7949/products/rosa_1_540x.jpg?v=1601565630",
                    InStock = true,
                    IsFavShoe = false,
                    //ImgThumbUrl

                },
                new Item
                {
                    ItemType = "Loungers",
                    Price = 19.99M,
                    Description = "These loafers are perfect for lounging around the house",
                    Category = Categories["Loafers"],
                    ImgUrl = "https://cdn.allbirds.com/image/fetch/q_auto,f_auto/w_1000,f_auto,q_auto,b_rgb:f5f5f5/https://cdn.shopify.com/s/files/1/1104/4168/products/WL2MNCW_SHOE_RIGHT_GLOBAL_MENS_WOOL_LOUNGER_2_NATURAL_GREY_4be9e2f0-8046-45fe-9a86-3ac43fd7d1a2.png?v=1598993465",
                    InStock = true,
                    IsFavShoe = false,
                    //ImgThumbUrl

                },
                new Item
                {
                    ItemType = "Business Loafers",
                    Price = 59.99M,
                    Description = "These loafers mean business.",
                    Category = Categories["Loafers"],
                    ImgUrl = "https://images-na.ssl-images-amazon.com/images/I/51tUYvlekiL._AC_UY395_.jpg",
                    InStock = true,
                    IsFavShoe = false,
                    //ImgThumbUrl 

                },
                     new Item
                     {
                         ItemType = "Beach Sandals",
                         Price = 49.99M,
                         Description = "The perfect pair of flops to wear to your favorite beach.",
                         Category = Categories["Sandals"],
                         ImgUrl = "https://cdn.shopify.com/s/files/1/0105/8055/7883/products/Beek_Seabird_Tan_Angle_jpg_900x.jpg?v=1604385821",
                         InStock = true,
                         IsFavShoe = false,
                         //ImgThumbUrl

                     },
                      new Item
                      {
                          ItemType = "Birkenstock",
                          Price = 49.99M,
                          Description = "Wear these while strolling through the neighborhood or if you want to remember all those memories from Woodstock.",
                          Category = Categories["Sandals"],
                          ImgUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ8IsvYh245xIjMK_8QMBpa5YBQQYmf7MsHjcYhasKix5dxvAGsL3u3-XVLHO4NkSpjlM52u_M&usqp=CAc",
                          InStock = true,
                          IsFavShoe = false,
                          //ImgThumbUrl

                      },
                new Item
                {
                    ItemType = "Ugg boots",
                    Price = 49.99M,
                    Description = "Your favorite pair of Uggs to wear in the winter.",
                    Category = Categories["Boots"],
                    ImgUrl = "https://images.bloomingdalesassets.com/is/image/BLM/products/2/optimized/9164982_fpx.tif?op_sharpen=1&wid=700&fit=fit,1&$filtersm$",
                    InStock = true,
                    IsFavShoe = false,
                    //ImgThumbUrl

                },
                new Item
                {
                    ItemType = "Doc Martens",
                    Price = 59.99M,
                    Description = "Get a pair of Doc Martens for you next punk rock show!",
                    Category = Categories["Boots"],
                    ImgUrl = "https://i1.adis.ws/i/drmartens/14045001.80.jpg?$medium$",
                    InStock = true,
                    IsFavShoe = false,
                    //ImgThumbUrl 
                }


                );

            }

            DbContext.SaveChanges();

        }


        private static Dictionary<string, Category> categories;
        private object applicationBuilder;

        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (categories == null)
                {
                    var catList = new Category[]
                    {
                    new Category { CategoryName = "Athletic", Description = "Atheltic shoes to get you on the run or to play your favoite sport!" },
                    new Category { CategoryName = "Dance", Description = "From ballroom to ballet we have your feet covered for your favorite dance." },
                    new Category { CategoryName = "Loafers", Description = "From business casual to relaxing at home." },
                    new Category { CategoryName = "Sandals", Description = "Get ready to hit the beach! Our summer 2021 selection is now available!" },
                    new Category { CategoryName = "Boots", Description = "From winter boots to keep your feet warm to punk rock boots you can wear at the next show!" }

                    };

                    categories = new Dictionary<string, Category>();

                    foreach (Category cat in catList)
                    {
                        categories.Add(cat.CategoryName, cat);
                    }
                }

                return categories;
            }
        }

    }
}