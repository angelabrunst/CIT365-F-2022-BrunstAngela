using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "Saints and Soilders",
                        ReleaseDate = DateTime.Parse("2003-2-12"),
                        Genre = "Drama",
                        Rating = "PG-13",
                        Price = 7.99M,
                        PhotoPath = "saintsAndSoldiers.jpg"
                    },

                    new Movie
                    {
                        Title = "The Other Side of Heaven",
                        ReleaseDate = DateTime.Parse("2001-3-13"),
                        Genre = "Biography",
                        Rating = "PG",
                        Price = 8.99M,
                        PhotoPath = "otherSideOfHeaven.jpg"
                    },

                    new Movie
                    {
                        Title = "The Best Two Years",
                        ReleaseDate = DateTime.Parse("2004-2-23"),
                        Genre = "Comedy",
                        Rating = "PG",
                        Price = 9.99M,
                        PhotoPath = "bestTwoYears.jpg"
                    },

                    new Movie
                    {
                        Title = "The Singles Ward",
                        ReleaseDate = DateTime.Parse("2002-4-15"),
                        Genre = "Comedy",
                        Rating = "PG",
                        Price = 3.99M,
                        PhotoPath = "singlesWard.jpg"
                    },
                    new Movie
                    {
                        Title = "17 Miracles",
                        ReleaseDate = DateTime.Parse("2011-4-15"),
                        Genre = "Drama",
                        Rating = "PG",
                        Price = 4.99M,
                        PhotoPath = "seventeenMiracles.jpg"
                    },
                    new Movie
                    {
                        Title = "Charly",
                        ReleaseDate = DateTime.Parse("2002-4-15"),
                        Genre = "Romance",
                        Rating = "PG",
                        Price = 2.99M,
                        PhotoPath = "charly.jpg"
                    },
                    new Movie
                    {
                        Title = "The Work and the Glory",
                        ReleaseDate = DateTime.Parse("2004-4-15"),
                        Genre = "Romance",
                        Rating = "PG",
                        Price = 9.99M,
                        PhotoPath = "workAndTheGlory.jpg"
                    },
                    new Movie
                    {
                        Title = "Sons of Provo",
                        ReleaseDate = DateTime.Parse("2004-4-15"),
                        Genre = "Comedy",
                        Rating = "PG",
                        Price = 2.99M,
                        PhotoPath = "sonsOfProvo.jpg"
                    },
                    new Movie
                    {
                        Title = "God's Army",
                        ReleaseDate = DateTime.Parse("2000-4-15"),
                        Genre = "Drama",
                        Rating = "PG",
                        Price = 3.99M,
                        PhotoPath = "godsArmy.jpg"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
