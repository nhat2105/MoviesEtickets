using Microsoft.EntityFrameworkCore;
using MoviesEtickets.Data.Enums;
using MoviesEtickets.Models;

namespace MoviesEtickets.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();


                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();

                //Cinema
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Id = 1,
                            Name = "Cinema 1",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-1.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                            Id = 2,
                            Name = "Cinema 2",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-2.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                            Id = 3,
                            Name = "Cinema 3",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-3.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                            Id = 4,
                            Name = "Cinema 4",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-4.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                            Id = 5,
                            Name = "Cinema 5",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-5.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                    });
                    context.SaveChanges();
                }
                //Actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            Id = 1,
                            FullName = "Actor 1",
                            Bio = "This is the Bio of the first actor",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-1.jpeg"

                        },
                        new Actor()
                        {
                            Id = 2,
                            FullName = "Actor 2",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-2.jpeg"
                        },
                        new Actor()
                        {
                            Id = 3,
                            FullName = "Actor 3",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-3.jpeg"
                        },
                        new Actor()
                        {
                            Id = 4,
                            FullName = "Actor 4",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-4.jpeg"
                        },
                        new Actor()
                        {
                            Id = 5,
                            FullName = "Actor 5",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-5.jpeg"
                        }
                    });
                    context.SaveChanges();
                }
                //Producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            Id = 1,
                            FullName = "Producer 1",
                            Bio = "This is the Bio of the first actor",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-1.jpeg"

                        },
                        new Producer()
                        {
                            Id = 2,
                            FullName = "Producer 2",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-2.jpeg"
                        },
                        new Producer()
                        {
                            Id = 3,
                            FullName = "Producer 3",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-3.jpeg"
                        },
                        new Producer()
                        {
                            Id = 4,
                            FullName = "Producer 4",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-4.jpeg"
                        },
                        new Producer()
                        {
                            Id = 5,
                            FullName = "Producer 5",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-5.jpeg"
                        }
                    });
                    context.SaveChanges();
                }
                //Movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Id = 1,
                            Name = "Forrest Gump",
                            Description = "Life is like a box of chocolates, you don't know what you're gonna get. " +
                            "Just my favorite film ever",
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-3.jpeg",
                            Released = DateTime.Now.AddDays(-10),
                            Category = MovieCategory.Documentary,
                            CinemaId = 3,
                            ProducerId = 3,
                        },
                        new Movie()
                        {
                            Id = 2,
                            Name = "Mulholland Drive",
                            Description = "A young aspiring actress who meets an amnesia woman upon her arrival to LA." +
                            "A completely game changer. ",
                            Price = 29.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-1.jpeg",
                            Released = DateTime.Now,
                            Category = MovieCategory.Action,
                            CinemaId = 1,
                            ProducerId = 1,
                        },
                        new Movie()
                        {
                            Id = 3,
                            Name = "Vertigo",
                            Description = "Voyeurism - falling in love with something not real. This is what it is about. ",
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-4.jpeg",
                            Released = DateTime.Now,
                            Category = MovieCategory.Horror,
                            CinemaId = 4,
                            ProducerId = 4,
                        },
                        new Movie()
                        {
                            Id = 4,
                            Name = "Race",
                            Description = "This is the Race movie description",
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-6.jpeg",
                            Released = DateTime.Now.AddDays(-10),
                            Category = MovieCategory.Documentary,
                            CinemaId = 1,
                            ProducerId = 2,
                        },
                        new Movie()
                        {
                            Id = 5,
                            Name = "Scoob",
                            Description = "This is the Scoob movie description",
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-7.jpeg",
                            Released = DateTime.Now.AddDays(-10),
                            Category = MovieCategory.Documentary,
                            CinemaId = 1,
                            ProducerId = 3,
                        },
                        new Movie()
                        {
                            Id = 6,
                            Name = "Cold Soles",
                            Description = "This is the Cold Soles movie description",
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-8.jpeg",
                            Released = DateTime.Now.AddDays(3),      
                            CinemaId = 1,
                            ProducerId = 5,
                            Category = MovieCategory.Drama
                        }
                    });
                    context.SaveChanges();
                }

                //Actors & Movies
                if (!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie() { ActorId = 1, MovieId = 4 },
                        new Actor_Movie() { ActorId = 1, MovieId = 5 },
                        new Actor_Movie() { ActorId = 2, MovieId = 6 },
                        new Actor_Movie() { ActorId = 2, MovieId = 7 },
                        new Actor_Movie() { ActorId = 3, MovieId = 8 },
                        new Actor_Movie() { ActorId = 3, MovieId = 3 },
                        new Actor_Movie() { ActorId = 4, MovieId = 5 },
                        new Actor_Movie() { ActorId = 5, MovieId = 6 },
                    });

                    context.SaveChanges();
                }
            }
        }
    }
}
