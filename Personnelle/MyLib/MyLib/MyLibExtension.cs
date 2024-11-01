using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public static class MyLibExtension
    {
        public static void Write(this string subject, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(subject);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static int ReadInt(this string text)
        {
            while (true) {
                
                Console.Write(text);
                
                try
                {
                    int result = Convert.ToInt32(Console.ReadLine());
                    return result;
                    break;
                }
                catch
                {
                    Console.WriteLine("Pas un nombre");
                }
            }
        }
        public static double ToIntSafe(this string subject, int n = 0)
        {
            try
            {
                double result = Convert.ToDouble(subject);
                return result;
            }
            catch
            {
                return n;
            }
        }

        public static string RandomString(this Random random, int n)
        {

            var chars = "0123456789abcdefghijklmnopqrstuvwxyz";
            string value = "";
            for (int i = 0; i<n; i++) 
            {
                value += chars[random.Next(chars.Length)];
        }
            return value;
        }
        
        public static bool RandomBool(this Random random)
        {
            int value = random.Next(2);

            if (value == 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}
