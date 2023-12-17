using System;
using System.ComponentModel.DataAnnotations;

namespace EddiesHikingStore.Models
{
    public class ProductModel
    {
        [Key]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Product Name is required.")]
        [StringLength(255)] // You can adjust the maximum length as needed
        public string ProductName { get; set; }

        [Required(ErrorMessage = "Product Description is required.")]
        public string ProductDescription { get; set; }

        [Required(ErrorMessage = "Product Image is required.")]
        public string ProductImage { get; set; }

        [Required(ErrorMessage = "Product Price is required.")]
        [Range(0.01, 10000.00, ErrorMessage = "Product Price must be between 0.01 and 10,000.00")]
        public decimal ProductPrice { get; set; }

        // If you have a constructor with default values, you can set them here
        public ProductModel()
        {
            ProductName = "Default Name";
            ProductDescription = "Default Description";
            ProductImage = "Default Image";
            ProductPrice = 0.01M; // Adjust the default price as needed
        }
    }
}
