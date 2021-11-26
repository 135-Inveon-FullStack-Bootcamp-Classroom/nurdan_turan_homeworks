using Microsoft.EntityFrameworkCore;

namespace ImdbWebApi.DBOperations
{
    public class DataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ImdbStoreDBContext(serviceProvider.GetRequiredService<DbContextOptions<ImdbStoreDBContext>>()))
            {
                if (context.Imdbs.Any())
                {
                    return;   // DB has been seeded
                }
                context.Imdbs.AddRange(
                    new Imdb
                    {
                        Title = "The Shawshank Redemption",
                        Rated = "R",
                        ReleasedDate = "14 Oct 1994",
                        Genre = "Crime, Drama",
                        Director = "Frank Darabont",
                        Writer = "Stephen King (short story \"Rita Hayworth and Shawshank Redemption\"), Frank Darabont (screenplay)",
                        Actors = "Tim Robbins, Morgan Freeman, Bob Gunton, William Sadler",
                        imdbRating = "9.3",
                        imdbVotes = "9,876",
                        imdbID = "tt0111161",
                        Type = "movie",
                        Language = "English",
                        Country = "USA"
                    },
                    new Imdb
                    {
                        Title = "The Godfather",
                        Rated = "R",
                        ReleasedDate = "24 Mar 1972",
                        Genre = "Crime, Drama",
                        Director = "Francis Ford Coppola",
                        Writer = "Mario Puzo (screenplay by), Francis Ford Coppola (screenplay by), Mario Puzo (novel)",
                        Actors = "Marlon Brando, Al Pacino, James Caan, Richard S. Castellano",
                        imdbRating = "9.2",
                        imdbVotes = "1,846,937",
                        imdbID = "tt0068646",
                        Type = "movie",
                        Language = "English",
                        Country = "USA"
                    },
                    new Imdb
                    {
                        Title = "The Godfather: Part II",
                        Rated = "R",
                        ReleasedDate = "20 Dec 1974",
                        Genre = "Crime, Drama",
                        Director = "Francis Ford Coppola",
                        Writer = "Mario Puzo (screenplay by), Francis Ford Coppola (screenplay by), Mario Puzo (novel)",
                        Actors = "Al Pacino, Robert De Niro, Robert Duvall, Diane Keaton",
                        imdbRating = "9.0",
                        imdbVotes = "1,846,937",
                        imdbID = "tt0071562",
                        Type = "movie",
                        Language = "English",
                        Country = "USA"
                    },
                    new Imdb
                    {
                        Title = "The Dark Knight",
                        Rated = "PG-13",
                        ReleasedDate = "18 Jul 2008",
                        Genre = "Action, Crime, Drama",
                        Director = "Christopher Nolan",
                        Writer = "Jonathan Nolan (screenplay), Christopher Nolan (screenplay), Christopher Nolan (story), David S. Goyer (story), Bob Kane (characters)",
                        Actors = "Christian Bale, Heath Ledger, Aaron Eckhart, Michael Caine",
                        imdbRating = "9.0",
                        imdbVotes = "1,846,937",
                        imdbID = "tt0468569",
                        Type = "movie",
                        Language = "English",
                        Country = "USA"
                    },
                    new Imdb
                    {
                        Title = "The Dark Knight Rises",
                        Rated = "PG-13",
                        ReleasedDate = "20 Jul 2012",
                        Genre = "Action, Thriller",
                        Director = "Christopher Nolan",
                        Writer = "Jonathan Nolan (screenplay), Christopher Nolan (screenplay), Christopher Nolan (story), David S. Goyer (story), Bob Kane (characters)",
                        Actors = "Christian Bale, Heath Ledger, Aaron Eckhart, Michael Caine",
                        imdbRating = "9.0",
                        imdbVotes = "1,846,937",
                        imdbID = "tt1345836",
                        Type = "movie",
                        Language = "English",
                        Country = "USA"
                    },
                    new Imdb
                    {
                        Title = "The Lord of the Rings: The Return of the King",
                        Rated = "PG-13",
                        ReleasedDate = "17 Dec 2003",
                        Genre = "Adventure, Drama, Fantasy",
                        Director = "Peter Jackson",
                        Writer = "J.R.R. Tolkien (novel), Fran Walsh (screenplay), Philippa Boyens (screenplay), Peter Jackson (screenplay)",
                        Actors = "Elijah Wood, Viggo Mortensen, Ian McKellen, Orlando Bloom",
                        imdbRating = "9.0",
                        imdbVotes = "1,846,937",
                        imdbID = "tt0167260",
                        Type = "movie",
                        Language = "English",
                        Country = "USA"
                    },
                    new Imdb
                    {
                        Title = "The Lord of the Rings: The Two Towers",
                        Rated = "PG-13",
                        ReleasedDate = "18 Dec 2002",
                        Genre = "Adventure, Drama, Fantasy",
                        Director = "Peter Jackson",
                        Writer = "J.R.R. Tolkien (novel), Fran Walsh (screenplay), Philippa Boyens (screenplay), Peter Jackson (screenplay)",
                        Actors = "Elijah Wood, Viggo Mortensen, Ian McKellen, Orlando Bloom",
                        imdbRating = "9.0",
                        imdbVotes = "1,846,937",
                        imdbID = "tt0167261",
                        Type = "movie",
                        Language = "English",
                        Country = "USA"
                    },
                    new Imdb
                    {
                        Title = "The Lord of the Rings: The Fellowship of the Ring",
                        Rated = "PG-13",
                        ReleasedDate = "19 Dec 2001",
                        Genre = "Adventure, Drama, Fantasy",
                        Director = "Peter Jackson",
                        Writer = "J.R.R. Tolkien (novel), Fran Walsh (screenplay), Philippa Boyens (screenplay), Peter Jackson (screenplay)",
                        Actors = "Elijah Wood, Viggo Mortensen, Ian McKellen, Orlando Bloom",
                        imdbRating = "9.0",
                        imdbVotes = "1,846,937",
                        imdbID = "tt0167261",
                        Type = "movie",
                        Language = "English",
                        Country = "USA"
                    },
                    new Imdb
                    {
                        Title = "The Lord of the Rings: The Return of the King",
                        Rated = "PG-13",
                        ReleasedDate = "17 Dec 2003",
                        Genre = "Adventure, Drama, Fantasy",
                        Director = "Peter Jackson",
                        Writer = "J.R.R. Tolkien (novel), Fran Walsh (screenplay), Philippa Boyens (screenplay), Peter Jackson (screenplay)",
                        Actors = "Elijah Wood, Viggo Mortensen, Ian McKellen, Orlando Bloom",
                        imdbRating = "9.0",
                        imdbVotes = "1,846,937",
                        imdbID = "tt0120737",
                        Type = "movie",
                        Language = "English",
                        Country = "USA"
                    }
                   
                );
                context.SaveChanges();

            }
        }
    }
}