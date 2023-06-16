using Proje1.Enums;
using Proje1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje1.Helpers
{
    class Helper
    {
        public static List<Movie> createMovies()
        {
            string basePath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            return new List<Movie>()
            {
                new Movie()
                {
                    movieName = "Black Widow",
                    category = Category.bilimKurgu,
                    minute = "3 Saat 19 Dakika",
                    price = 50,
                    picturePath = basePath + "\\MV5BZGRlNTY3NGYtM2YzZS00N2YyLTg0ZDYtNmY2ZDg2NDM3N2JlXkEyXkFqcGdeQXVyNTI4MzE4MDU@._V1_FMjpg_UX1000_.jpg"
                },
                   new Movie()
                {
                    movieName = "Fantastik Dörtlü",
                    category = Category.macera,
                    minute = "2 Saat 10 Dakika",
                    price = 60,
                    picturePath = basePath + "\\42946.jpg"
                },
                new Movie()
                {
                    movieName = "Sucker Punch",
                    category = Category.bilimKurgu,
                    minute = "1 Saat 55 Dakika",
                    price = 20,
                    picturePath = basePath + "\\19647874.jpg"
                },
                new Movie()
                {
                    movieName = "Assassin's Creed",
                    category = Category.bilimKurgu,
                    minute = "2 Saat 1 Dakika",
                    price = 30,
                    picturePath = basePath + "\\2011824-628691747.jpg"
                },
                new Movie()
                {
                    movieName = "El Camino: A Breaking Bad Movie",
                    category = Category.komedi,
                    minute = "2 Saat 40 Dakika",
                    price = 50,
                    picturePath = basePath + "\\2011824-628691747.jpg"
                },

             new Movie()
                {
                    movieName = "Hz. Muhammed: Allah'ın Elçisi",
                    category = Category.bilimKurgu,
                    minute = "2 Saat 30 Dakika",
                    price = 200,
                    picturePath = basePath + "\\Muhammed-_Allah'ın_Elçisi_film_afişi.jpg"
                },


            };
        }
    }
}
