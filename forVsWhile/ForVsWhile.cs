using System;

namespace Vsite.CSharp
{
    public class ForVsWhile
    {
        public static void PetljaFor(int n)
        {
            // TODO: Napisati petlju for koja će ispisati brojeve od 0 do (uključivo) n
            for(int i=0; i<= n; ++i)
            {
                Console.WriteLine(i);
            } 
        }

        public static void PetljaWhile(int n)
        {
            int i = 0;
            while (i <= n)
            {
                Console.WriteLine(i);
                i++;
            }
        }

        static void Main(string[] args)
        {
            PetljaFor(10);

            PetljaWhile(10);

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
