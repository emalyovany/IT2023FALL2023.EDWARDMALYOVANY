namespace EddiesHikingStore.Models
{
    using System.Collections.Generic;

    public class ProductData
    {
        public static List<ProductModel> GetProducts()
        {
            var products = new List<ProductModel>
    {
        new ProductModel
        {
            ProductId = 1,
            ProductName = "Hiking Socks",
            ProductDescription = "Anti Blister Hiking Socks (2 PACK)",
            ProductImage = "/images/hikingsocks.jfif",
            ProductPrice = 19.99m
        },
        new ProductModel
        {
            ProductId = 3,
            ProductName = "Boots",
            ProductDescription = "Water Resistant Hiking Boots.",
            ProductImage = "/images/hikingboots.jpg",
            ProductPrice = 79.99m
        },
        new ProductModel
        {
            ProductId = 4,
            ProductName = "Coat",
            ProductDescription = "Waterproof Hiking Coat.",
            ProductImage = "/images/hikingcoat.jpg",
            ProductPrice = 79.99m
        },
        new ProductModel
        {
            ProductId = 5,
            ProductName = "Gloves",
            ProductDescription = "Artic Hiking Gloves.",
            ProductImage = "/images/gloves.jpg",
            ProductPrice = 29.99m
        },
        new ProductModel
        {
            ProductId = 6,
            ProductName = "Hiking Food",
            ProductDescription = "A meal full of nutrition for your adventures.",
            ProductImage = "/images/food.webp",
            ProductPrice = 19.99m
        },
        new ProductModel
        {
            ProductId = 9,
            ProductName = "Hiking Backpack",
            ProductDescription = "50L Hiking Backpack",
            ProductImage = "/images/backpack.webp",
            ProductPrice = 129.99m
        },
        new ProductModel
        {
            ProductId = 10,
            ProductName = "Trekking Poles",
            ProductDescription = "Carbon Trekking Poles",
            ProductImage = "/images/poles.jfif",
            ProductPrice = 45.99m
        }
    };

            return products;
        }

        public static ProductModel GetProduct(int id)
        {
            var products = GetProducts();
            var product = products.FirstOrDefault(p => p.ProductId == id);
            return product ?? new ProductModel();
        }
    }


}
