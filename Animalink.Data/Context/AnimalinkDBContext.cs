using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Animalink.Data.Context
{
    public class AnimalinkDBContext : DbContext
    {
        private readonly string _connectionString = string.Empty;

        public AnimalinkDBContext()
        {

        }

        public AnimalinkDBContext(DbContextOptions<AnimalinkDBContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                if (_connectionString == string.Empty)
                {
                    optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=AnimalinkDB;Trusted_Connection=True;");
                }
                else
                {
                    optionsBuilder.UseSqlServer(_connectionString);
                }
            }
        }


        public DbSet<Admin> Admins { get; set; }
        public DbSet<AdminStatistic> AdminStatistics { get; set; }
        public DbSet<Animal> Animals { get; set; }
        public DbSet<Collection> Collections { get; set; }
        public DbSet<GeneralStatistic> GeneralStatistics { get; set; }
        public DbSet<Partner> Partners { get; set; }
        public DbSet<Rarity> Rarities { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Schema> Schemas { get; set; }
        public DbSet<Template> Templates { get; set; }
        public DbSet<TemplateType> TemplateTypes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserStatistic> UserStatistics { get; set; }
        
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            #region DataBaseSeed


            #region Animals

            //modelBuilder.Entity<Animal>().HasData 
            //    (
            //        new Animal
            //        {
            //            Id = new Guid("a76492d7-f83b-465f-bbd6-de0338a284ab"),
            //            Name = "Tiger",
            //            Taxonomy = "Animal, Mammal, Tiger",
            //            Species = "Panthera tigris sumatrae",
            //            Habitat = "Sumatra",
            //            IUCN = "Endangered",
            //            IUCNAcronym = "EN",
            //        },
            //        new Animal
            //        {
            //            Id = new Guid("87759b7e-f2cc-44eb-a87d-98de9b5bd087"),
            //            Name = "Tropical Frog",
            //            Taxonomy = "Animal, Amphibian, Frog",
            //            Species = "Bolivian Tree Frog",
            //            Habitat = "Bolivia",
            //            IUCN = "Vulnerable",
            //            IUCNAcronym = "VU",
            //        }, new Animal
            //        {
            //            Id = new Guid("41678cf9-bb3b-4a9f-976e-33b57a3af390"),
            //            Name = "Golden Eagle",
            //            Taxonomy = "Animal, Bird, Eagle",
            //            Species = "Apanea Ittis",
            //            Habitat = "Philipines",
            //            IUCN = "Least Concerned",
            //            IUCNAcronym = "LC",
            //        }, new Animal
            //        {
            //            Id = new Guid("8ac63722-756c-4822-90a1-75c5a2fd2a30"),
            //            Name = "Iberian Lynx",
            //            Taxonomy = "Animal, Mammal, Lynx",
            //            Species = "Lynx pardinus",
            //            Habitat = "Iberian Peninsula",
            //            IUCN = "Critically Endangered",
            //            IUCNAcronym = "CR",
            //        }

            //    );

            #endregion

            #region Templates

            //modelBuilder.Entity<Template>().HasData  // Rarities - very Common-0, Common-1, Uncommon-2, Rare-3, Super Rare-4, Epic-5, Legendary-6, Mythic-7, Special.
            //    (
            //        new Template
            //        {
            //            IsPublished = true,
            //            PublishedAt = DateTime.UtcNow,
            //            Name = "Tropical Frog",
            //            Description = "Its a frog",
            //            CollectionId = "",
            //            SchemaId = "",
            //            Price = 25,
            //            MaxSupply = 400,
            //            ImageReference = "www.website.com",
            //            IsTransferable = true,
            //            IsBurnable = true,
            //            NumberAvailable = 57,
            //            AnimalId = Guid.Parse("87759b7e-f2cc-44eb-a87d-98de9b5bd087"),
            //            TemplateTypeId = "",
            //            RarityId = "",
            //        },
            //        new Template
            //        {
            //            IsPublished = true,
            //            PublishedAt = DateTime.UtcNow,
            //            Name = "Golden Eagle",
            //            Description = "Its an eagle",
            //            Collection = "Animalink",
            //            Schema = "East Asia",
            //            Price = 5,
            //            MaxSupply = 1000,
            //            ImageReference = "www.website.com",
            //            IsTransferable = true,
            //            IsBurnable = true,
            //            NumberAvailable = 250,
            //            NftType = "Animal",
            //            Rarity = "Common",
            //            RarityLevel = 1,
            //            AnimalId = Guid.Parse("41678cf9-bb3b-4a9f-976e-33b57a3af390"),
            //        },
            //        new Template
            //        {
            //            IsPublished = true,
            //            PublishedAt = DateTime.UtcNow,
            //            Name = "Sumatran Tiger",
            //            Description = "Its a tiger",
            //            Collection = "Animalink",
            //            Schema = "East Asia",
            //            Price = 99,
            //            MaxSupply = 10,
            //            ImageReference = "www.website.com",
            //            IsTransferable = true,
            //            IsBurnable = false,
            //            NumberAvailable = 0,
            //            NftType = "Animal",
            //            Rarity = "Super Rare",
            //            RarityLevel = 4,
            //            AnimalId = Guid.Parse("a76492d7-f83b-465f-bbd6-de0338a284ab")
            //        },
            //        new Template
            //        {
            //            IsPublished = false,
            //            PublishedAt = DateTime.UtcNow,
            //            Name = "Iberian Lynx",
            //            Description = "Its a Lynx",
            //            Collection = "Animalink",
            //            Schema = "European",
            //            Price = 120,
            //            MaxSupply = 5,
            //            ImageReference = "www.website.com",
            //            IsTransferable = true,
            //            IsBurnable = false,
            //            NumberAvailable = 7,
            //            NftType = "Animal",
            //            Rarity = "Epic",
            //            RarityLevel = 5,
            //            AnimalId = Guid.Parse("8ac63722-756c-4822-90a1-75c5a2fd2a30")
            //        },
            //        new Template
            //        {
            //            IsPublished = false,
            //            PublishedAt = DateTime.UtcNow,
            //            Name = "Earth Day",
            //            Description = "Celebrate Earth Day",
            //            Collection = "Animalink",
            //            Schema = "Events",
            //            Price = 120,
            //            MaxSupply = 5,
            //            ImageReference = "www.website.com",
            //            IsTransferable = true,
            //            IsBurnable = false,
            //            NumberAvailable = 28,
            //            NftType = "Event",
            //            Rarity = "Special",
            //            RarityLevel = null,
            //        }
            //    );

            #endregion

            #region Partners

            //modelBuilder.Entity<Partner>().HasData
            //    (
            //        new Partner
            //        {
            //            Name = "Zoo de Guarulhos, Brasil",
            //            Description = "A description of the place in question",
            //            ImageReference = "link to the Partner logo",
            //            WebsiteURL = "www.site.com"
            //        },
            //        new Partner
            //        {
            //            Name = "Borneo Orangutan Rescue",
            //            Description = "A description of the place in question",
            //            ImageReference = "link to the Partner logo",
            //            WebsiteURL = "www.site.com"
            //        },
            //        new Partner
            //        {
            //            Name = "Iberian Lynx Conservation",
            //            Description = "A description of the place in question",
            //            ImageReference = "link to the Partner logo",
            //            WebsiteURL = "www.site.com"
            //        }
            //    );

            #endregion

            #region Admin

            modelBuilder.Entity<Admin>().HasData
               (
                   new Admin
                   {
                       Id = new Guid ("E68353EA-91FB-4A2E-B29E-B75C10DEFA4F"),
                       UserName = "Admin1",
                       Password = "123456"
                   }
               );

            #endregion

            #region Admin Statistics

            //modelBuilder.Entity<AdminStatistic>().HasData
            //    (
            //        new AdminStatistic
            //        {
            //            Statistic = "",
            //            StatisticType = "Total Number of NFTs",
            //            AdminId = Guid.Parse("E68353EA-91FB-4A2E-B29E-B75C10DEFA4F")
            //        },
            //        new AdminStatistic
            //        {
            //            Statistic = "",
            //            StatisticType = "Total Number of NFTs Sold",
            //            AdminId = Guid.Parse("E68353EA-91FB-4A2E-B29E-B75C10DEFA4F")
            //        },
            //        new AdminStatistic
            //        {
            //            Statistic = "",
            //            StatisticType = "Total Value Made",
            //            AdminId = Guid.Parse("E68353EA-91FB-4A2E-B29E-B75C10DEFA4F")
            //        },
            //        new AdminStatistic
            //        {
            //            Statistic = "",
            //            StatisticType = "Total Number of Animals",
            //            AdminId = Guid.Parse("E68353EA-91FB-4A2E-B29E-B75C10DEFA4F")
            //        },
            //        new AdminStatistic
            //        {
            //            Statistic = "",
            //            StatisticType = "Total Number of Species",
            //            AdminId = Guid.Parse("E68353EA-91FB-4A2E-B29E-B75C10DEFA4F")
            //        },
            //        new AdminStatistic
            //        {
            //            Statistic = "",
            //            StatisticType = "Total Value Donated",
            //            AdminId = Guid.Parse("E68353EA-91FB-4A2E-B29E-B75C10DEFA4F")
            //        },
            //        new AdminStatistic
            //        {
            //            Statistic = "",
            //            StatisticType = "Value Donated by Partner",
            //            AdminId = Guid.Parse("E68353EA-91FB-4A2E-B29E-B75C10DEFA4F")
            //        },
            //        new AdminStatistic
            //        {
            //            Statistic = "",
            //            StatisticType = " Total Number of Users ",
            //            AdminId = Guid.Parse("E68353EA-91FB-4A2E-B29E-B75C10DEFA4F" )
            //        }
            //    );

            #endregion

            #region Users

            modelBuilder.Entity<User>().HasData
               (
                   new User
                   {
                       UserName = "User1",
                       ImageReference = "image link"
                   },
                   new User
                   {
                       UserName = "User2",
                       ImageReference = "image link"
                   },
                   new User
                   {
                       UserName = "User3",
                       ImageReference = "image link"
                   }, 
                   new User
                   {
                       UserName = "User4",
                       ImageReference = "image link"
                   },
                   new User
                   {
                       UserName = "User5",
                       ImageReference = "image link"
                   }
               );


            #endregion


         #endregion

        }


    }
}
