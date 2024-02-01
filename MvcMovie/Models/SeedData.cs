using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

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
                    Title = "The Departed",
                    ReleaseDate = DateTime.Parse("2006-2-12"),
                    Genre = "CrimeThriller",
                    Price = 7.99M
                },
                new Movie
                {
                    Title = "The King's Speech",
                    ReleaseDate = DateTime.Parse("2010-3-13"),
                    Genre = "Drama",
                    Price = 8.99M
                },
                new Movie
                {
                    Title = "Ablaze",
                    ReleaseDate = DateTime.Parse("1986-2-23"),
                    Genre = "Detective",
                    Price = 9.99M
                },
                new Movie
                {
                    Title = "Titanic",
                    ReleaseDate = DateTime.Parse("1997-4-15"),
                    Genre = "Love",
                    Price = 3.99M
                }
            );
            context.SaveChanges();
        }
    }
}