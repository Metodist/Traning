using System;

namespace Тренировка
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "#bug @I чини блять";
            string[] textobt = text.Split(' ');


            foreach (string i in textobt)
            {
                Console.WriteLine(i);
            }

            
             



            
        }
    }
}
