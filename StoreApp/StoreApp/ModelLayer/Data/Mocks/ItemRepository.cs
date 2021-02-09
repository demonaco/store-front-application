using System;
using System.Collections.Generic;
using System.Linq;
using StoreApp.ModelLayer.Data.Models;
using StoreApp.ModelLayer.Data.Interfaces;

namespace StoreApp.ModelLayer.Data.Mocks
{
    public class ItemRepository : IItemRepository
    {
        private readonly ICategoryRepository _categoryRepository = new CategoryRepository();


        public IEnumerable<Item> Item
        {
            get
            {
                return new List<Item>
                {
                    new Item
                    {
                        ItemType = "Running Shoe",
                        Price = 19.99M,
                        Description = "Comfortable shoe for running. It's what the Pros where!",
                        Category = _categoryRepository.Category.First(),
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
                        Category = _categoryRepository.Category.First(),
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
                        Category = _categoryRepository.Category.First(),
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
                        Category = _categoryRepository.Category.First(),
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
                        Category = _categoryRepository.Category.First(),
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
                        Category = _categoryRepository.Category.First(),
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
                        Category = _categoryRepository.Category.First(),
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
                        Category = _categoryRepository.Category.First(),
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
                        Category = _categoryRepository.Category.First(),
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
                        Category = _categoryRepository.Category.First(),
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
                        Category = _categoryRepository.Category.First(),
                        ImgUrl = "https://i1.adis.ws/i/drmartens/14045001.80.jpg?$medium$",
                        InStock = true,
                        IsFavShoe = false,
                        //ImgThumbUrl 
                    }

                };

            }
        }

        public IEnumerable<Item> IsFavShoe { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Item GetItemById(int id)
        {
            throw new NotImplementedException();
        }
    }

}