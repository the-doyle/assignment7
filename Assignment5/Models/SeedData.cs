using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

//SeedData.cs provides the logic for populating the database initially, if needed. 


namespace Assignment5.Models
{
    public class SeedData
    {
        public static void EnsurePopulated (IApplicationBuilder application)
        {
            BookDBContext context = application.ApplicationServices.
                CreateScope().ServiceProvider.GetRequiredService<BookDBContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Books.Any())
            {
                context.Books.AddRange(

                    new Book
                    {
                        ISBN = "978-0451419439",
                        BookTitle = "Les Miserables",
                        Author = "Victor Hugo",
                        Publisher = "Signet",
                        Classification = "Fiction",
                        Category = "Classic",
                        BookPrice = 9.95,
                        PageCount = 1488
                    },

                    new Book
                    {
                        ISBN = "978-0743270755",
                        BookTitle = "Team of Rivals",
                        Author = "Doris Kearns Goodwin",
                        Publisher = "Simon & Schuster",
                        Classification = "Non-fiction",
                        Category = "Biography",
                        BookPrice = 14.58,
                        PageCount = 944
                    },

                    new Book
                    {
                        ISBN = "978-0553384611 ",
                        BookTitle = "The Snowball",
                        Author = "Alice Schroeder",
                        Publisher = "Bantam",
                        Classification = "Non-fiction",
                        Category = "Biography",
                        BookPrice = 21.54,
                        PageCount = 832
                    },

                    new Book
                    {
                        ISBN = "978-0812981254",
                        BookTitle = "American Ulysses",
                        Author = "Ronald C White",
                        Publisher = "Random House",
                        Classification = "Non-fiction",
                        Category = "Biography",
                        BookPrice = 11.61,
                        PageCount = 864
                    },

                    new Book
                    {
                        ISBN = "978-0812974492",
                        BookTitle = "Unbroken",
                        Author = "Laura Hillenbrand",
                        Publisher = "Random House",
                        Classification = "Non-fiction",
                        Category = "Historical",
                        BookPrice = 13.33,
                        PageCount = 528
                    },

                    new Book
                    {
                        ISBN = "978-0804171281",
                        BookTitle = "The Great Train Robbery",
                        Author = "Michael Chrichton",
                        Publisher = "Vintage",
                        Classification = "Non-fiction",
                        Category = "Self-Help",
                        BookPrice = 15.95,
                        PageCount = 288
                    },

                    new Book
                    {
                        ISBN = "978-1455586691",
                        BookTitle = "Deep Work",
                        Author = "Cal Newport",
                        Publisher = "Grand Central Publishing",
                        Classification = "Non-fiction",
                        Category = "Self-Help",
                        BookPrice = 14.99,
                        PageCount = 304
                    },

                    new Book
                    {
                        ISBN = "978-1455523023",
                        BookTitle = "It's Your Ship",
                        Author = "Michael Abrashoff",
                        Publisher = "Grand Central Publishing",
                        Classification = "Non-fiction",
                        Category = "Self-Help",
                        BookPrice = 21.66,
                        PageCount = 240
                    },

                    new Book
                    {
                        ISBN = "978-1591847984",
                        BookTitle = "The Virgin Way",
                        Author = "Richard Branson",
                        Publisher = "Portfolio",
                        Classification = "Non-fiction",
                        Category = "Business",
                        BookPrice = 29.16,
                        PageCount = 400
                    },

                    new Book
                    {
                        ISBN = "978-0553393613",
                        BookTitle = "Sycamore Row",
                        Author = "John Grisham",
                        Publisher = "Bantam",
                        Classification = "Fiction",
                        Category = "Thrillers",
                        BookPrice = 15.03,
                        PageCount = 642
                    },

                    new Book
                    {
                        ISBN = "978-0765326355",
                        BookTitle = "The Way Of Kings",
                        Author = "Brandon Sanderson",
                        Publisher = "Tor Books",
                        Classification = "Fiction",
                        Category = "Fantasy",
                        BookPrice = 9.59,
                        PageCount = 1007
                    },

                    new Book
                    {
                        ISBN = "978-0765326362",
                        BookTitle = "Words Of Radiance",
                        Author = "Brandon Sanderson",
                        Publisher = "Tor Books",
                        Classification = "Fiction",
                        Category = "Fantasy",
                        BookPrice = 16.99,
                        PageCount = 1104
                    },

                    new Book
                    {
                        ISBN = "978-0765326379",
                        BookTitle = "Oathbringer",
                        Author = "Brandon Sanderson",
                        Publisher = "Tor Books",
                        Classification = "Fiction",
                        Category = "Fantasy",
                        BookPrice = 18.49,
                        PageCount = 1248
                    }

                );

                context.SaveChanges();
            }
        }
    }
}
