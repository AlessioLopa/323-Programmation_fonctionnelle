namespace ex_filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "bonjour", "hello", "monde", "vert", "rouge", "bleu", "jaune" };

            //List<string> wordsWithoutX = words.Where(w => !w.Contains("x") &&  w.Length <= 4 && {
            //    int count = 0;
            //    int lenght = 0;
            //    foreach (string word in words)
            //    {
            //        count++;
            //        lenght += word.Length;

            //    }

            //    int avg = lenght / count;

            //})

            words.Where(w => !w.Contains("x") && w.Length <= 4).ToList();
            var result =words.Where(w =>
            {
                int count = 0;
                int lenght = 0;
                foreach (string word in words)
                {
                    count++;
                    lenght += word.Length;

                }

                int avg = lenght / count;
                return w.Length == avg;

            });

            foreach (string word in result)
            {
                Console.WriteLine( word);
            }
        }

    }
}
