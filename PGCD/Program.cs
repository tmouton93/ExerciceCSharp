using System;

namespace PGCD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrez le premier nombre : ");
            string nombrep = Console.ReadLine();
            Console.WriteLine("Entrez le second nombre : ");
            string nombreq = Console.ReadLine();

            int p = int.Parse(nombrep);
            int q = int.Parse(nombreq);


            while (p != q)
            {
                if (p > q)
                {
                    p = p - q;
                }
                else q = q - p;


            }
            Console.WriteLine("Le PGCD de " + nombrep + " et " + nombreq + " est : " + p);





        }
    }
}
