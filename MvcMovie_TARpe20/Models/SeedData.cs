using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie_TARpe20.Data;
using MvcMovie_TARpe20.Models;
using System;
using System.Linq;

namespace MvcMovie_TARpe20
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovie_TARpe20Context(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovie_TARpe20Context>>()))
            {
                // Look for any movies.
                if (!context.Movie.Any())
                {

                    AddMovies(context);   // DB has been seeded
                }
                context.SaveChanges();

                if (!context.Actor.Any())
                {
                    AddActors(context);
                }

                context.SaveChanges();


            }
            
        }

        private static void AddMovies(MvcMovie_TARpe20Context context)
        {
            context.Movie.AddRange(
                 new Movie
                 {
                     Title = "When Harry Met Sally",
                     ReleaseDate = DateTime.Parse("1989-2-12"),
                     Genre = "Romantic Comedy",
                     Rating = "R",
                     Price = 7.99M
                 },

                 new Movie
                 {
                     Title = "Ghostbusters ",
                     ReleaseDate = DateTime.Parse("1984-3-13"),
                     Genre = "Comedy",
                     Rating = "E",
                     Price = 8.99M
                 },

                 new Movie
                 {
                     Title = "Ghostbusters 2",
                     ReleaseDate = DateTime.Parse("1986-2-23"),
                     Genre = "Comedy",
                     Rating = "PG",
                     Price = 9.99M

                 },

                 new Movie
                 {
                     Title = "Rio Bravo",
                     ReleaseDate = DateTime.Parse("1959-4-15"),
                     Genre = "Western",
                     Rating = "R",
                     Price = 3.99M
                 }

             );

        }

        public static void AddActors(MvcMovie_TARpe20Context context)
        {
            context.Actor.AddRange(
                  new Actor
                  {
                      FirstName = "Tom",
                      LastName = "Hanks",
                      DateOfBirth = DateTime.Parse("1956-7-9"),
                      NumberOfOscars = 6,
                      BirthPlace = "Concord",
                      NetWorth = 400000000


                  },

                  new Actor
                  {
                      FirstName = "Johnny",
                      LastName = "Depp",
                      DateOfBirth = DateTime.Parse("1963-6-9"),
                      NumberOfOscars = 3,
                      BirthPlace = "Owensboro",
                      NetWorth = 150000000

                  },


                  new Actor
                  {
                      FirstName = "Benedict",
                      LastName = "Cumberbatch",
                      DateOfBirth = DateTime.Parse("1976-7-19"),
                      NumberOfOscars = 1,
                      BirthPlace = "London",
                      NetWorth = 40000000
                  },

                  new Actor
                  {
                      FirstName = "Jason",
                      LastName = "Statham",
                      DateOfBirth = DateTime.Parse("1967-8-26"),
                      NumberOfOscars = 0,
                      BirthPlace = "Shirebrook",
                      NetWorth = 90000000
                  }
               );




        }
    }



    }



    
