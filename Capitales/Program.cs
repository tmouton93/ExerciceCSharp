using System;

namespace Capitales
{
    class Program
    {

        static string[] pays = new string[] { "Albanie", "Allemagne", "Andorre", "Autriche", "Belgique", "Biélorussie", "Bosnie - Herzégovine", "Bulgarie", "Chypre", "Croatie" };
        static string[] capitale = new string[] { "Tirana", "Berlin", "Andorre-la-Vieille", "Vienne", "Bruxelles", "Minsk", "Sarajevo", "Sofia", "Nicosie", "Zagreb" };




        static void Main(string[] args)
        {

            Console.Clear();
            // jouer();

            //  poserQuestion(2);
            jouer2();
        }

        static void jouer()

        {


            string rep2 = "o";

            while (rep2.ToLower() == "o")
            {



                int compteur = 0;
                //for (int i = 0; i < pays.Length; i+=2)
                for (int i = pays.Length - 1; i >= 0; i--)
                {
                    Console.WriteLine("Quelle est la capitale de " + pays[i] + " ?");
                    string rep = Console.ReadLine();

                    if (rep.ToLower() == capitale[i].ToLower())
                    {
                        Console.WriteLine("Bravo!");
                        compteur++;
                    }
                    else Console.WriteLine("Mauvaise Réponse. La bonne réponse était " + capitale[i]);
                }

                Console.WriteLine("Vous avez eu " + compteur + " points!");

                Console.WriteLine("Voulez-vous rejouer? o");
                rep2 = Console.ReadLine();
            }

            Console.WriteLine("Merci d'avoir joué!");
            Console.ReadKey();

        }


        static void poserQuestion(int num)
        {
            Console.WriteLine("Quelle est la capitale de " + pays[num] + " ?");
            string rep = Console.ReadLine();

            if (rep.ToLower() == capitale[num].ToLower())
            {
                Console.WriteLine("Bravo!");

            }
            else Console.WriteLine("Mauvaise Réponse. La bonne réponse était " + capitale[num]);

        }

        static void jouer2()

        {

            Console.WriteLine("Appuyer sur Echap pour arrêter le jeu");
            Random rd = new Random();
            int rand;




            do
            {
                rand = rd.Next(pays.Length - 1);
                poserQuestion(rand);

            } while (Console.ReadKey().Key != ConsoleKey.Escape);



                Console.WriteLine(" MMerci d'avoir joué! \n");
            
        }
    }
}

