using System.Runtime.CompilerServices;

namespace MyLib
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Entrées
            int year = "Année de naissance: ".ReadInt();
            $"Vous avez {DateTime.Now.Year - year} ans".Write(ConsoleColor.Green);

            // Conversions
            string input = "12.23234";
            double number = input.ToIntSafe();
            Console.WriteLine($"Nombre converti : {number}");
            Console.WriteLine($"Pas un nombre, valeur par défaut : {"notANumber".ToIntSafe()}");
            Console.WriteLine($"Pas un nombre, valeur par défaut spécifique : {"notANumber".ToIntSafe(-1)}");

            //Random
            var random = new Random();
            string randomStr = random.RandomString(8);
            Console.WriteLine($"Chaîne aléatoire : {randomStr}");
            bool randomBool = random.RandomBool();
            Console.WriteLine($"Booléen aléatoire: {randomBool}");

        }
        
    }
}
