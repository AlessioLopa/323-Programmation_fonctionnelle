namespace Ex_Epsilon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, double> caracteres = new Dictionary<char, double>()
            {
                {'e', 12.10 / 100 },
                {'a', 7.11 / 100 },
                {'i', 6.59 / 100 },
                {'s', 6.51 / 100 },
                {'n', 6.39 / 100 },
                {'r', 6.07 / 100 },
                {'t', 5.92 / 100 },
                {'o', 5.02 / 100 },
                {'l', 4.96 / 100 },
                {'u', 4.49 / 100 },
                {'d', 3.67 / 100 },
                {'c', 3.18 / 100 },
                {'m', 2.62 / 100 },
                {'p', 2.49 / 100 },
                {'é', 1.94 / 100 },
                {'g', 1.23 / 100 },
                {'b', 1.14 / 100 },
                {'v', 1.11 / 100 },
                {'h', 1.11 / 100 },
                {'f', 1.11 / 100 },
                {'q', 0.65 / 100 },
                {'y', 0.46 / 100 },
                {'x', 0.38 / 100 },
                {'j', 0.34 / 100 },
                {'è', 0.31 / 100 },
                {'à', 0.31 / 100 },
                {'k', 0.29 / 100 },
                {'w', 0.17 / 100 },
                {'z', 0.15 / 100 },
                {'ê', 0.08 / 100 },
                {'ç', 0.06 / 100 },
                {'ô', 0.04 / 100 },
                {'â', 0.03 / 100 },
                {'î', 0.03 / 100 },
                {'û', 0.02 / 100 },
                {'ù', 0.02 / 100 },
                {'ï', 0.01 / 100 },
                {'á', 0.01 / 100 },
                {'ü', 0.01 / 100 },
                {'ë', 0.01 / 100 },
                {'ö', 0.01 / 100 },
                {'í', 0.01 / 100 }
             };

            Console.Write("Entrer un mot à tester : ");
            string word = Console.ReadLine();

            Dictionary<char, int> chars = new Dictionary<char, int>();

            double epsilon = 0;

            foreach (var x in word)
            {
                if(chars.ContainsKey(x))
                {
                    chars[x] += 1;
                }
                else
                {
                    chars.Add(x, 1);
                }
            }

            foreach (var x in chars)
            {
                if (caracteres.ContainsKey(x.Key))
                {
                    epsilon += caracteres[x.Key] / x.Value; 
                }
            }

            Console.WriteLine($"{word} à comme valeur Epsilon : {epsilon}");
         }
     }
 }
