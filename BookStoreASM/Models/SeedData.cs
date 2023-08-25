using BookStoreASM.Data;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace BookStoreASM.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {

            ApplicationDbContext context = app.ApplicationServices
             .CreateScope().ServiceProvider.GetRequiredService<ApplicationDbContext>();
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.Book.Any())
            {
                context.Book.AddRange(
                    new Book
                    {
                        
                        Title = "Bröderna Lejonhjärta",
                        Language = "Swedish",
                        ISBN = "9789129688313",
                        DatePublished = DateTime.Parse("1975/01/29").ToString(),
                        Price = 139,
                        Author = "Astrid Lindgren",
                        ImageUrl = "/images/lejonhjärta.jpg"
                    },

                    new Book
                    {
                        Title = "The Fellowship of the Ring",
                        Language = "English",
                        ISBN = "9780261102354",
                        DatePublished = DateTime.Parse("1991-7-4").ToString(),
                        Price = 100,
                        Author = "J. R. R. Tolkien",
                        ImageUrl = "/images/lotr.jpg"
                    },

                    new Book
                    {
                        Title = "Mystic River",
                        Language = "English",
                        ISBN = "9780062068408",
                        DatePublished = DateTime.Parse("2011-6-1").ToString(),
                        Price = 91,
                        Author = "Dennis Lehane",
                        ImageUrl = "/images/mystic-river.jpg"
                    },

                    new Book
                    {
                        Title = "Of Mice and Men",
                        Language = "English",
                        ISBN = "9780062068408",
                        DatePublished = DateTime.Parse("1994-1-2").ToString(),
                        Price = 166,
                        Author = "John Steinbeck",
                        ImageUrl = "/images/of-mice-and-men.jpg"
                    },

                    new Book
                    {
                        Title = "The Old Man and the Sea",
                        Language = "English",
                        ISBN = "9780062068408",
                        DatePublished = DateTime.Parse("1994-8-18").ToString(),
                        Price = 84,
                        Author = "Ernest Hemingway",
                        ImageUrl = "/images/old-man-and-the-sea.jpg"
                    },

                    new Book
                    {
                        Title = "The Road",
                        Language = "English",
                        ISBN = "9780307386458",
                        DatePublished = DateTime.Parse("2007-5-1").ToString(),
                        Price = 95,
                        Author = "Cormac McCarthy",
                        ImageUrl = "/images/the-road.jpg"
                    }
                    );
                context.SaveChanges();
            }
        }

        internal static void Initialize(IServiceProvider services)
        {
            throw new NotImplementedException();
        }
    }
}
