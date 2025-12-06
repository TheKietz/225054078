using Lab04.Data;
using Microsoft.EntityFrameworkCore;

namespace Lab04.Models
{
    public class SeedData
    {
        public static void Initiallize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                if (context.Movie.Any())
                {
                    return;
                }
                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "When Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1999-2-12"),
                        Genre = "Comedy",
                        Price = 8.99M,
                        Rating = "R"
                    },
                    new Movie
                    {
                        Title = "Kasd Yord",
                        ReleaseDate = DateTime.Parse("1976-2-11"),
                        Genre = "Fantastic",
                        Price = 5.49M,
                        Rating = "R"
                    },
                    new Movie
                    {
                        Title = "Avenger",
                        ReleaseDate = DateTime.Parse("2020-2-9"),
                        Genre = "science fiction",
                        Price = 15.5M,
                        Rating = "R"
                    }
                    );
            }
        }
    }
}
