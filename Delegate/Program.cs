using System;

namespace Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo input;
            ConsoleKeyInfo s;
            
           
            do
            {
                Console.WriteLine("Bitte geben sie eiine zahl ein");
                //int zahl = Convert.ToInt32(Console.ReadLine());
                bool res;
                int a;
                string myStr = Console.ReadLine();
                res = int.TryParse(myStr, out a);

                bool res2;
                int b;
               

                Console.WriteLine("Bitte eine zweite");
                string myStr2 = Console.ReadLine();
                res2 = int.TryParse(myStr2, out b);

                // int zahl2 = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("S oder a");
                s = Console.ReadKey();
              
                if (s.Key==ConsoleKey.S)
                {
                    
                    Console.Clear();
                    int ergebnis = a - b;
                    Console.WriteLine("Das Ergebnis lautet: "+ergebnis);
                }
                else if (s.Key == ConsoleKey.A)
                {
                    Console.Clear();
                    int ergebnis2 = a + b;
                    Console.WriteLine("Das Ergebnis lautet: " + ergebnis2);
                }




                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("um das programm zuschließen bitte F12");
                input = Console.ReadKey();
            } while (input.Key != ConsoleKey.F12);
        }
    }
}
