using eTickets.Data.Enums;
using eTickets.Models;

namespace eTickets.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();

                //Cinema
                if (!context.cinemas.Any())
                {
                    context.cinemas.AddRange(new List<Cinema>()
                        {
                            new Cinema()
                            {
                                Name = "Cinema 1",
                                Logo = "http://dotnethow.net/images/cinemas/cinema-1.jpeg",
                                Description = "This is the description for cinema 1"
                            },
                            new Cinema()
                            {
                                Name = "Cinema 2",
                                Logo = "http://dotnethow.net/images/cinemas/cinema-2.jpeg",
                                Description = "This is the description for cinema 2"
                            },
                            new Cinema()
                            {
                                Name = "Cinema 3",
                                Logo = "http://dotnethow.net/images/cinemas/cinema-3.jpeg",
                                Description = "This is the description for cinema 3"
                            },
                            new Cinema()
                            {
                                Name = "Cinema 4",
                                Logo = "http://dotnethow.net/images/cinemas/cinema-4.jpeg",
                                Description = "This is the description for cinema 4"
                            },
                            new Cinema()
                            {
                                Name = "Cinema 5",
                                Logo = "http://dotnethow.net/images/cinemas/cinema-5.jpeg",
                                Description = "This is the description for cinema 5"
                            }
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
                            FullName = "Actor 1",
                            Bio = "This is the bio of Actor 1",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-1.jpeg"
                        },
                         new Actor()
                        {
                            FullName = "Actor 2",
                            Bio = "This is the bio of Actor 2",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-2.jpeg"
                        },
                          new Actor()
                        {
                            FullName = "Actor 3",
                            Bio = "This is the bio of Actor 3",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-3.jpeg"
                        },
                           new Actor()
                        {
                            FullName = "Actor 4",
                            Bio = "This is the bio of Actor 4",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-4.jpeg"
                        },
                            new Actor()
                        {
                            FullName = "Actor 5",
                            Bio = "This is the bio of Actor 5",
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
                            FullName = "Producer 1",
                            Bio = "This is the bio of Producer 1",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-1.jpeg"
                        },
                         new Producer()
                        {
                            FullName = "Producer 2",
                            Bio = "This is the bio of Producer 2",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-2.jpeg"
                        },
                          new Producer()
                        {
                            FullName = "Producer 3",
                            Bio = "This is the bio of Producer 3",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-3.jpeg"
                        },
                        new Producer()
                        {
                            FullName = "Producer 4",
                            Bio = "This is the bio of Producer 4",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-4.jpeg"
                        },
                        new Producer()
                        {
                            FullName = "Producer 5",
                            Bio = "This is the bio of Producer 5",
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
                            Name ="Life",
                            Description = "This is Life movie description",
                            Price = 19.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-3.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(10),
                            CinemaId = 1,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Documentary
                        },
                        new Movie()
                        {
                            Name ="The ShawShank Redemption",
                            Description = "This is the ShawShank Redemption",
                            Price = 29.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-7.jpeg",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(10),
                            CinemaId = 1,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Action
                        },
                        new Movie()
                        {
                            Name ="Ghost",
                            Description = "This is Ghost movie description",
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-4.jpeg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(7),
                            CinemaId = 1,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Horror
                        },
                        new Movie()
                        {
                            Name ="Race",
                            Description = "This is Race movie description",
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-6.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-5),
                            CinemaId = 1,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Documentary
                        },
                        new Movie()
                        {
                            Name ="Scoob",
                            Description = "This is Scoob movie description",
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-7.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Cartoon
                        },
                        new Movie()
                        {
                            Name ="Cold Soles",
                            Description = "This is Cold soles movie description",
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-8.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Drama
                        }

                    });
                    context.SaveChanges();

                }
                //Actors & Movies 
                if (!context.Actor_Movies.Any())
                {
                    context.Actor_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 1,

                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId= 4,
                        },
                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId= 3,
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId= 6,
                        },
                         new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId= 6,
                        },
                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId= 2,
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId= 5,
                        }
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
