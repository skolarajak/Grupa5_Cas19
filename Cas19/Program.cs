using System;

namespace Cas19
{
    class Program
    {
        static void Main(string[] args)
        {
            //int cntr = 1;
            //int a = 0;
            //while(cntr > 0)
            //{
            //    Console.Write("Unesi vrednost, za kraj, unesi vrednost manju od 1 >");
            //    cntr = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Value of cntr: {0}", cntr);
            //    if (a > 10)
            //    {
            //        break;
            //    }
            //    a++;
            //}

            //for(int c = 1; c <= 20; c = c + 2)
            //{
            //    Console.WriteLine("Value of c: {0}", c);
            //}
            //int c = 1;
            //do
            //{
            //    Console.WriteLine("do-while: Value of c: {0}", c);
            //} while (c < 0);

            //while(c < 0)
            //{
            //    Console.WriteLine("while: Value of c: {0}", c);
            //}
            //for(int a = 1; a <= 10; a++)
            //{
            //    Console.Write("{0}: ", a);
            //    for (int b = 1; b <= 5; b++)
            //    {
            //        Console.Write("{0} ", b);
            //    }
            //    Console.WriteLine();
            //}

            int zbir = 0;
            for (int a = 1; a <= 10; a++)
            {
                zbir = zbir + a;
            }
            Console.WriteLine("Zbir brojeva od 1 do 10 je: " + zbir);
            

            Console.ReadKey();
        }
    }
}
