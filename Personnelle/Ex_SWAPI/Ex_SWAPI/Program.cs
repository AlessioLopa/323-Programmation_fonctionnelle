using StarWarsApiCSharp;
using StarWarsApiCSharp;
using System.Threading.Tasks.Sources;

namespace Ex_SWAPI
{
    internal class Program
    {
        static void Main(string[] args)
       {
            // Ex 1 ----------------------------------------

            Repository<Film> filmRepo = new Repository<Film>();

            var films = filmRepo.GetEntities();

            // Aggégation
            var v2 = films.Aggregate((f1, f2) => f1.Title.Length>f2.Title.Length?f1:f2);

            // OrderBy
            var v3 = films.OrderBy(f=>f.Title.Length).Last();

            // Where
            var v4 = films.Where(f=>f.Title.Length==films.Max(film => film.Title.Length)).First();

            Console.WriteLine(v2.Title);

            // Ex 2 -------------------------------------------

            Repository<Person> personRepo = new Repository<Person>();

            var persons= personRepo.GetEntities();

            // Obiwan
            var mostPopularCaracter = persons.OrderBy(c => c.Films.Count()).Last();

            // C3-PO
            var mostPopularCaracter2 = persons.OrderByDescending(c=>c.Films.Count()).First();
            Console.WriteLine(mostPopularCaracter.Name);

            // Ex ----------------------------------------------

            Repository<Planet> planetRepo = new Repository<Planet>();

            var planets = planetRepo.GetEntities();

            var mostPopuled = planets.OrderBy(p => p.Residents.Count()).Last();
            Console.WriteLine(mostPopuled.Name);


        }
    }
}
