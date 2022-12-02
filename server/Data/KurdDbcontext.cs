using client.Server.models;
using Microsoft.EntityFrameworkCore;
using server.models;
using static System.Net.Mime.MediaTypeNames;

namespace server.Data
{
    public class KurdDbcontext:DbContext
    {
        public KurdDbcontext(DbContextOptions<KurdDbcontext> opt) : base(opt)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //PhoneDetail
            modelBuilder.Entity<PhoneDetail>().HasData(new PhoneDetail
            {
                Id = 1,
                CPU = "Apple A15 Bionic",
                GPU = "Apple GPU",
                RAM = "6GB",
                ROM = "256GB",
                Announced = "Nov 2021",
                Battery_FastCharge = "25 watt",
                Color = "White",

            });
        
            modelBuilder.Entity<Category>().HasData(new Category
            {
                Id = 1,
                Name = "مۆبایل",
                Icon = "@Icons.Filled.PhoneIphone"
            });
            modelBuilder.Entity<Category>().HasData(new Category
            {
                Id = 2,
                Name = "تابلێت",
                Icon = "@Icons.Filled.Tablet"
            });
            modelBuilder.Entity<Category>().HasData(new Category
            {
                Id = 3,
                Name = "ئێکسسوارات",
                Icon = "@Icons.Filled.EarbudsBattery"
            });
            modelBuilder.Entity<Category>().HasData(new Category
            {
                Id = 4,
                Name = "بیستۆک",
                Icon = "@Icons.Filled.Headphones"
            });
            modelBuilder.Entity<Category>().HasData(new Category
            {
                Id = 5,
                Name = "لاپتۆپ",
                Icon = "@Icons.Filled.Laptop"
            });
            // Phone Data
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 1,
                Name = "Iphone 14 Pro max",
                Description = "بەرهەمی کۆمپانیای ئەپڵ",
                ImageUrl = "/images/Phone/IPhone14ProMax.png",
                Price = 1300,
                Quantity = 100,
                Rating = 5,
                CategoryId = 1,
                PhoneDetailId = 1

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 2,
                Name = "Iphone 13 Pro max",
                Description = "بەرهەمی کۆمپانیای ئەپڵ",
                ImageUrl = "/images/Phone/IPhone13ProMax.png",
                Price = 1200,
                Quantity = 90,
                Rating = 4,
                CategoryId = 1

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 3,
                Name = "Infinx Zero Ultra",
                Description = "بەرهەمی کۆمپانیای ئینفینیکس",
                ImageUrl = "/ images / Phone /InfinixZeroUltra.png",
                Price = 300,
                Quantity = 100,
                Rating = 3,
                CategoryId = 1

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 4,
                Name = "Galaxy S22 Ultra",
                Description = "بەرهەمی کۆمپانیای سامسونگ",
                ImageUrl = "/images/Phone/GalaxyS22Ultra.png",
                Price = 1350,
                Quantity = 15,
                Rating = 5,
                CategoryId = 1

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 5,
                Name = "F11 Pro",
                Description = "بەرهەمی کۆمپانیای ئۆپۆ",
                ImageUrl = "/images/Phone/F11Pro.png",
                Price = 700,
                Quantity = 115,
                Rating = 3,
                CategoryId = 1

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 6,
                Name = "One Plus9 Pro",
                Description = "بەرهەمی کۆمپانیای وەنپلەس ",
                ImageUrl = "/images/Phone/OnePlus9Pro.png",
                Price = 450,
                Quantity = 10,
                Rating = 4,
                CategoryId = 1

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 7,
                Name = "Pixel 6 Pro",
                Description = "بەرهەمی کۆمپانیای گوگڵ ",
                ImageUrl = "/images/Phone/Pixel6Pro.png",
                Price = 400,
                Quantity = 40,
                Rating = 3,
                CategoryId = 1

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 8,
                Name = "Redmi Note 12 Pro",
                Description = "بەرهەمی کۆمپانیای ریدمی ",
                ImageUrl = "/images/Phone/RedmiNote12Pro.png",
                Price = 350,
                Quantity = 30,
                Rating = 3,
                CategoryId = 1

            });
            //Laptop Data
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 9,
                Name = "Dell Xps 17",
                Description = "بەرهەمی کۆمپانیای ئەپڵ",
                ImageUrl = "/images/Laptops/DellXps17.jpg",
                Price = 700,
                Quantity = 10,
                Rating = 3,
                CategoryId = 5

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 10,
                Name = "Hp Omen",
                Description = "بەرهەمی کۆمپانیای ئێچ پی",
                ImageUrl = "/images/Laptops/HpOmen.jpg",
                Price = 800,
                Quantity = 9,
                Rating = 3,
                CategoryId = 5

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 11,
                Name = "Lenovo Idea Pad",
                Description = "بەرهەمی کۆمپانیای لینۆڤۆ",
                ImageUrl = "/images/Laptops/LenovoIdeaPad.jpg",
                Price = 900,
                Quantity = 15,
                Rating = 4,
                CategoryId = 5

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 12,
                Name = "Macbook AirM1",
                Description = "بەرهەمی کۆمپانیای ئەپڵ",
                ImageUrl = "/images/Laptops/MacbookAirM1.jpg",
                Price = 1000,
                Quantity = 5,
                Rating = 4,
                CategoryId = 5

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 13,
                Name = "Macbook AirM2",
                Description = "بەرهەمی کۆمپانیای ئەپڵ",
                ImageUrl = "/images/Laptops/MacbookAirM2.jpg",
                Price = 1100,
                Quantity = 6,
                Rating = 4,
                CategoryId = 5

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 14,
                Name = "Macbook Pro",
                Description = "بەرهەمی کۆمپانیای ئەپڵ",
                ImageUrl = "/images/Laptops/MacbookPro.jpg",
                Price = 1200,
                Quantity = 5,
                Rating = 4,
                CategoryId = 5

            });
            //tablet data
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 15,
                Name = "Ipad Pro 12.9",
                Description = "بەرهەمی کۆمپانیای ئەپڵ",
                ImageUrl = "/images/Laptops/IPadPro12.9.png",
                Price = 950,
                Quantity = 10,
                Rating = 4,
                CategoryId = 2

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 16,
                Name = "Samsung Tab S8 Ultra",
                Description = "بەرهەمی کۆمپانیای سامسونگ",
                ImageUrl = "/images/Laptops/SamsungTabS8Ultra.png",
                Price = 950,
                Quantity = 10,
                Rating = 4,
                CategoryId = 2

            });
            //HeadPhones Data
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 17,
                Name = "Air Pods Pro2",
                Description = "بەرهەمی کۆمپانیای ئەپڵ",
                ImageUrl = "/images/Laptops/AirPodsPro2.png",
                Price = 100,
                Quantity = 40,
                Rating = 4,
                CategoryId = 4

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 18,
                Name = "Apple Air Pods Max",
                Description = "بەرهەمی کۆمپانیای ئەپڵ",
                ImageUrl = "/images/Laptops/AppleAirPodsMax.png",
                Price = 110,
                Quantity = 35,
                Rating = 4,
                CategoryId = 4

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 19,
                Name = "Hyperx Cloud2",
                Description = "بەرهەمی کۆمپانیای هایپەر ئێکس",
                ImageUrl = "/images/Laptops/HyperxCloud2.png",
                Price = 99,
                Quantity = 33,
                Rating = 4,
                CategoryId = 4

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 20,
                Name = "KrakenX",
                Description = "بەرهەمی کۆمپانیای ڕەیزەر",
                ImageUrl = "/images/Laptops/KrakenX.png",
                Price = 120,
                Quantity = 32,
                Rating = 4,
                CategoryId = 4

            });    
            modelBuilder.Entity<Product>().HasData(new Product
                {
                    Id = 21,
                    Name = "WF1000XM4",
                    Description = "بەرهەمی کۆمپانیای سۆنی",
                    ImageUrl = "/images/Laptops/WF1000XM4.png",
                    Price = 130,
                    Quantity = 30,
                    Rating = 4,
                    CategoryId = 4

                });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 22,
                Name = "WH1000XM4",
                Description = "بەرهەمی کۆمپانیای سۆنی",
                ImageUrl = "/images/Laptops/WH1000XM4.png",
                Price = 140,
                Quantity = 30,
                Rating = 4,
                CategoryId = 4

            });
            //Accessories
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 23,
                Name = "Apple Mag Safe",
                Description = "بەرهەمی کۆمپانیای ئەپڵ",
                ImageUrl = "/images/Laptops/AppleMagSafe.jpg",
                Price = 70,
                Quantity = 30,
                Rating = 4,
                CategoryId = 3

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 24,
                Name = "Apple Multi Port",
                Description = "بەرهەمی کۆمپانیای ئەپڵ",
                ImageUrl = "/images/Laptops/AppleMultiPort.jpg",
                Price = 40,
                Quantity = 30,
                Rating = 4,
                CategoryId = 3

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 25,
                Name = "Apple Tag",
                Description = "بەرهەمی کۆمپانیای ئەپڵ",
                ImageUrl = "/images/Laptops/AppleTag.jpg",
                Price = 50,
                Quantity = 30,
                Rating = 4,
                CategoryId = 3

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 26,
                Name = "Apple USBCPower Adapter",
                Description = "بەرهەمی کۆمپانیای ئەپڵ",
                ImageUrl = "/images/Laptops/AppleUSBCPowerAdapter.jpg",
                Price = 60,
                Quantity = 30,
                Rating = 4,
                CategoryId = 3

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 27,
                Name = "Apple USBPower Cable",
                Description = "بەرهەمی کۆمپانیای ئەپڵ",
                ImageUrl = "/images/Laptops/AppleUSBPowerCable.jpg",
                Price = 40,
                Quantity = 30,
                Rating = 4,
                CategoryId = 3

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 28,
                Name = "Galaxy Tag",
                Description = "بەرهەمی کۆمپانیای سامسونگ",
                ImageUrl = "/images/Laptops/GalaxyTag.jpg",
                Price = 20,
                Quantity = 30,
                Rating = 4,
                CategoryId = 3

            });
            modelBuilder.Entity<Product>().HasData(new Product
             {
                 Id = 29,
                 Name = "Samsung Portable Projector",
                 Description = "بەرهەمی کۆمپانیای سامسونگ",
                 ImageUrl = "/images/Laptops/SamsungPortableProjector.jpg",
                 Price = 20,
                 Quantity = 30,
                 Rating = 4,
                 CategoryId = 3

             });

        }
    }
}
