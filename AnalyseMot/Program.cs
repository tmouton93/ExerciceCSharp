using System;

namespace AnalyseMot
{
    class Program
    {
        static void Main(string[] args)
        {
            int l;
            int v ;
            int c;

            Console.WriteLine("Veuillez saisir un mot");
            string saisi = Console.ReadLine();
            CompterLettres(saisi, out l, out v, out c);
            Console.WriteLine("\"saisi\"" + " comporte " + l + " lettres, " + v + " consonnes et " + c + " voyelles");
                        
        }
        


        static void CompterLettres(string mot, out int lettres, out int consonnes, out int voyelles) 
        {
            lettres = mot.Length;

            consonnes = 0;
            voyelles = 0;

            for (int i = 0; i < mot.Length; i++)
            {
                if (mot[i] == 'a' || mot[i] == 'e' || mot[i] == 'i' || mot[i] == 'o' || mot[i] == 'u' || mot[i] == 'y')
                {
                    voyelles++;
                }
                else consonnes++;
            }
            
        }
    }
}
