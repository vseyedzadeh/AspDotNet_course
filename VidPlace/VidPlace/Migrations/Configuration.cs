namespace VidPlace.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using VidPlace.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<VidPlace.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(VidPlace.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.Medias.AddOrUpdate(              
              new Media { Name = "Jurrassic Park",
                  MediaType = context.MediaTypes.First(m => m.TypeName == "Movie"),
                  Genre = context.Genres.Where(g => g.Name == "Thriller").First(),
                  DateAdded = DateTime.Now,
                  NumberInStock = 1,
                  ReleaseDate = DateTime.Now
              },
              new Media
              {
                  Name = "Mother",
                  MediaType = context.MediaTypes.First(m => m.TypeName == "Movie"),
                  Genre = context.Genres.Where(g => g.Name == "Family").First(),
                  DateAdded = DateTime.Now,
                  NumberInStock = 12,
                  ReleaseDate = DateTime.Now
              }
            );

            context.Customers.AddOrUpdate(
                new Customer { Name = "Vaji", Address = "2345 herry street", BirthDate = DateTime.Now, 
                MembershipTypeId = 2, IsSubscribedToNewsLetter = true
                },
                 new Customer
                 {
                     Name = "Mehrshad",
                     Address = "7654 jerry street",
                     BirthDate = DateTime.Now,
                     MembershipTypeId = 3,
                     IsSubscribedToNewsLetter = true
                 }
                );

        }
    }
}
