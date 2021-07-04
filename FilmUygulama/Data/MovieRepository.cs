using FilmUygulama.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmUygulama.Data
{
    public static class MovieRepository
    {
        private static List<Movie> _movies = null;

        static MovieRepository()
        {
            _movies = new List<Movie>()
            {
                new Movie()
                {
                    Id=1,
                    Name="Avengers: Endgame",
                    Description="<p>After the devastating events of Avengers: Infinity War (2018), the universe is in ruins. With the help of remaining allies, the Avengers assemble once more in order to reverse Thanos' actions and restore balance to the universe.</p>",
                    ShortDescription="Actors: Robert Downey Jr., Chris Evans, Scarlett Johansson, Chris Hemsworth, Brie Larson, Mark Ruffalo, Karen Gillan, Benedict Cumberbatch",
                    ImageUrl="marvel.jpg",
                    ReleaseDate="19/04/2019",
                    CategoryId=3
                },
                new Movie()
                {
                    Id=2,
                    Name="Harry Potter and the Goblet of Fire",
                    Description="<p>Harry Potter finds himself competing in a hazardous tournament between rival schools of magic, but he is distracted by recurring nightmares.</p>",
                    ShortDescription="Actors: Daniel Radcliffe, Emma Watson, Rupert Grint, Alan Rickman, Michael Gambon, Ralph Fiennes, Maggie Smith, Frances de la Tour",
                    ImageUrl="harry.jpg",
                    ReleaseDate="18/11/2005",
                    CategoryId=1
                },
                new Movie()
                {
                    Id=3,
                    Name="Inception",
                    Description="<p>A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a C.E.O.</p>",
                    ShortDescription="Actors: Leonardo DiCaprio, Marion Cotillard,Tom Hardy, Joseph Gordon-Levitt, Taylor Geare",
                    ImageUrl="inception.jpg",
                    ReleaseDate="30/07/2010",
                    CategoryId=3
                },
                new Movie()
                {
                    Id=4,
                    Name="Up",
                    Description="<p>78-year-old Carl Fredricksen travels to Paradise Falls in his house equipped with balloons, inadvertently taking a young stowaway.</p>",
                    ShortDescription="Actors: Christopher Plummer, Delroy Lindo, Bob Peterson, John Ratzenberger, Edward Asner",
                    ImageUrl="up.jpg",
                    ReleaseDate="16/10/2009",
                    CategoryId=5
                },
                new Movie()
                {
                    Id=5,
                    Name="Interstellar",
                    Description="<p>A team of explorers must find the human race a new home after Earth is struck with worldwide food shortages and corn is the most valuable food. Utilizing a mysterious wormhole, they explore strange new worlds and could find a home to save the human race. </p>",
                    ShortDescription="Actors: Matthew McConaughey, Anne Hathaway, Jessica Chastain, Elyes Gabel, Wes Bentley",
                    ImageUrl="ınterstellar.jpg",
                    ReleaseDate="07/11/2014",
                    CategoryId=3
                },

                  new Movie()
                {
                    Id=6,
                    Name="Frozen",
                    Description="<p>When the newly crowned Queen Elsa accidentally uses her power to turn things into ice to curse her home in infinite winter, her sister Anna teams up with a mountain man, his playful reindeer, and a snowman to change the weather condition.</p>",
                    ShortDescription="Actors: Kristen Bell, Josh Gad, Jonathan Groff, Idina Menzel, Alan Tudyk",
                    ImageUrl="frozen.jpg",
                    ReleaseDate="17/01/2014",
                    CategoryId=5
                },
                   new Movie()
                {
                    Id=7,
                    Name="Once Upon A Time In Hollywood",
                    Description="<p>A faded television actor and his stunt double strive to achieve fame and success in the final years of Hollywood's Golden Age in 1969 Los Angeles.</p>",
                    ShortDescription="Actors: Leonardo DiCaprio, Brad Pitt, Margot Robbie",
                    ImageUrl="once.jpg",
                    ReleaseDate="23/08/2019",
                    CategoryId=4
                },
                    new Movie()
                {
                    Id=8,
                    Name="3 Idiots",
                    Description="<p>From the moment Ranco arrives at India's most prestigious university, his outlandish schemes turn the campus upside down--along with the lives of his two newfound best friens</p>",
                    ShortDescription="Actors: Aamir Khan, Madhavan, Kareena Kapoor, Boman Irani",
                    ImageUrl="idiots.jpg",
                    ReleaseDate="23/12/2009",
                    CategoryId=4
                },
                    new Movie()
                {
                    Id=9,
                    Name="The Grand Budapest Hotel",
                    Description="<p>A writer encounters the owner of an aging high-class hotel, who tells him of his early years serving as a lobby boy in the hotel's glorious years under an exceptional concierge.</p>",
                    ShortDescription="Actors: Ralph Fiennes, Tony Revolori, F. Murray Abraham, Mathieu Amalric",
                    ImageUrl="grand.jpg",
                    ReleaseDate="11/04/2014",
                    CategoryId=4
                },
                     new Movie()
                {
                    Id=10,
                    Name="Ice Age",
                    Description="<p>The story revolves around sub-zero heroes: a woolly mammoth, a saber-toothed tiger, a sloth and a prehistoric combination of a squirrel and rat, known as Scrat.</p>",
                    ShortDescription="Actors: Ray Romano, Denis Leary, Chris Wedge, Jack Black",
                    ImageUrl="ice.jpg",
                    ReleaseDate="31/01/2003",
                    CategoryId=5
                },
                     new Movie()
                {
                    Id=11,
                    Name="Pirates of the Caribbean: The Curse of the Black Pearl",
                    Description="<p>Blacksmith Will Turner teams up with eccentric pirate Captain Jack Sparrow to save his love, the governor's daughter, from Jack's former pirate allies, who are now undead. </p>",
                    ShortDescription="Actors: Johnny Depp, Geoffrey Rush, Keira Knightley, Orlando Bloom",
                    ImageUrl="pirates.jpg",
                    ReleaseDate="29/10/2003",
                    CategoryId=1
                },
                        new Movie()
                {
                    Id=12,
                    Name="The Lord of the Rings: The Fellowship of the Ring",
                    Description="<p>A meek Hobbit from the Shire and eight companions set out on a journey to destroy the powerful One Ring and save Middle-earth from the Dark Lord Sauron. </p>",
                    ShortDescription="Actors: Elijah Wood, Sean Astin, Ian McKellen, Sala Baker",
                    ImageUrl="lord.jpg",
                    ReleaseDate="21/12/2001",
                    CategoryId=1
                },
                        new Movie()
                {
                    Id=13,
                    Name="The Notebook",
                    Description="<p>A poor yet passionate young man falls in love with a rich young woman, giving her a sense of freedom, but they are soon separated because of their social differences. </p>",
                    ShortDescription="Actors: Ryan Gosling, Rachel McAdams, James Garner, Gena Rowlands",
                    ImageUrl="notebook.jpg",
                    ReleaseDate="25/06/2004",
                    CategoryId=2
                },
                              new Movie()
                {
                    Id=14,
                    Name="The Fault In Our Stars",
                    Description="<p>Two teenage cancer patients begin a life-affirming journey to visit a reclusive author in Amsterdam. </p>",
                    ShortDescription="Actors: Shailene Woodley, Ansel Elgort, Nat Wolff, Willem Dafoe",
                    ImageUrl="star.jpg",
                    ReleaseDate="27/06/2014",
                    CategoryId=2
                },
                                         new Movie()
                {
                    Id=15,
                    Name="Titanic",
                    Description="<p>A seventeen-year-old aristocrat falls in love with a kind but poor artist aboard the luxurious, ill-fated R.M.S. Titanic. </p>",
                    ShortDescription="Actors: Leonardo DiCaprio, Kate Winslet, Billy Zane, Kathy Bates",
                    ImageUrl="titanic.jpg",
                    ReleaseDate="18/11/1997",
                    CategoryId=2
                },


            };
        }

        public static List<Movie> Movies
        {
            get
            {
                return _movies;
            }
        }
        public static void AddMovie(Movie entity)
        {
            _movies.Add(entity);
        }

        public static Movie GetById(int id)
        {
            return _movies.FirstOrDefault(x => x.Id == id);
        }
    }
}
