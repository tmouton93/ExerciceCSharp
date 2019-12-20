using System;

namespace TriTableau
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Tableau0 = new int[] { 12, 5, 3, 9, 30 };
            int[] Tableau1 = new int[] { 12, 5, 4, 9, 30 };
            int[] Tableau2 = new int[] { 12, 5, 5, 9, 30 };
            int[] Tableau3 = new int[] { 12, 5, 6, 9, 30 };
            int[][] tableauTableau = { Tableau0, Tableau1, Tableau2, Tableau3 };
            foreach (var item in tableauTableau)
            {

                AfficherTableau(item);
            }


        }


        static void AfficherTableau(int[] tab)
        {

            string x = "";

            for (int i = 0; i < tab.Length; i++)
            {
                x = x + " " + tab[i];
            }
            Console.WriteLine(x); ;
        }


    }
}
