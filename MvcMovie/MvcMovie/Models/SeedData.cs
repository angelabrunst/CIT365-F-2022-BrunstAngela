﻿using Microsoft.EntityFrameworkCore;
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
                        Price = 7.99M
                    },

                    new Movie
                    {
                        Title = "The Other Side of Heaven",
                        ReleaseDate = DateTime.Parse("2001-3-13"),
                        Genre = "Biography",
                        Price = 8.99M
                    },

                    new Movie
                    {
                        Title = "The Best Two Years",
                        ReleaseDate = DateTime.Parse("2004-2-23"),
                        Genre = "Comedy",
                        Price = 9.99M
                    },

                    new Movie
                    {
                        Title = "The Singles Ward",
                        ReleaseDate = DateTime.Parse("2002-4-15"),
                        Genre = "Comedy",
                        Price = 3.99M
                    },
                    new Movie
                    {
                        Title = "17 Miracles",
                        ReleaseDate = DateTime.Parse("2011-4-15"),
                        Genre = "Drama",
                        Price = 4.99M
                    },
                    new Movie
                    {
                        Title = "Charly",
                        ReleaseDate = DateTime.Parse("2002-4-15"),
                        Genre = "Romance",
                        Price = 2.99M
                    },
                    new Movie
                    {
                        Title = "The Work and the Glory",
                        ReleaseDate = DateTime.Parse("2004-4-15"),
                        Genre = "Romance",
                        Price = 9.99M
                    },
                    new Movie
                    {
                        Title = "Sons of Provo",
                        ReleaseDate = DateTime.Parse("2004-4-15"),
                        Genre = "Comedy",
                        Price = 2.99M
                    },
                    new Movie
                    {
                        Title = "God's Army",
                        ReleaseDate = DateTime.Parse("2000-4-15"),
                        Genre = "Drama",
                        Price = 3.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
