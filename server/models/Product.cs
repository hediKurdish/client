using Microsoft.Identity.Client;
using server.models;
using System.ComponentModel.DataAnnotations.Schema;

namespace client.Server.models
{
    public class Product
    {
        public int Id { get; set; }

        public string? Name { get; set; }
        public string? Description { get; set; }


        public string? ImageUrl { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public int Rating{ get; set; }
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }

        public int? PhoneDetailId { get; set; }
        [ForeignKey("PhoneDetailId")]
        public PhoneDetail? PhoneDetail { get; set; }

        public int? LaptopDetailId { get; set; }
        [ForeignKey(" LaptopDetailId")]
        public LaptopDetails? LaptopDetail { get; set; }
        public int? AccessoriesId { get; set; }
        [ForeignKey(" AccessoriesId ")]
        public AccessoriesDetail? Accessories{ get; set; }

    }
}
