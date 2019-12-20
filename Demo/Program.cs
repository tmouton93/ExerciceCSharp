using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Demo1();
            //Demo2();
            //Demo3();

          string rep=Demo4("Thomas", 31, "homme");
            Console.WriteLine(rep);
            rep = Demo4("Lala", 31, "femme");
            Console.WriteLine(rep);

           

           
             Console.ReadKey();
        }

        static void Demo1()
        {
            Console.Write("écriture");
            Console.Write(" de mots");
            Console.Write(" les uns à la suite des autres\n");

            Console.WriteLine("Ecriture avec retour à la ligne ");

            Console.WriteLine("Saisissez votre nom :");
            string nom = Console.ReadLine();
            Console.WriteLine("Bonjour " + nom + ". Quelle est votre année de naissance ?");
            string rep = Console.ReadLine();

            int annéeNais = int.Parse(rep);
            int age = 2019 - annéeNais;
            Console.WriteLine("Vous allez avoir " + age + " ans");
            // age est converti automatiquement en chaine par c#

            Console.WriteLine("Bonjour {0}, vous allez avoir {1} ans", nom, age);
            Console.WriteLine($"Bonjour {nom}, vous allez avoir {age} ans");

            if (annéeNais % 4 == 0)
                Console.WriteLine("Vous êtes né durant une année bissextile");
            else
                Console.WriteLine("Vous n'êtes pas né lors d'une année bissextile");


            string message;
            message = (annéeNais % 4 == 0) ? " est une année bissextile" : "nest pas une année bissexile";

            if (age < 25)
                Console.WriteLine("vous êtes dans la tranche d'âge : moins de 25 ans");
            else if (age >= 25 && age < 35)
                Console.WriteLine("Vous etes dans la tranche d'age 25-35 ans");
            else
                Console.WriteLine("vous avez plus de 35 ans");

            const int annéeMin = 1900;
            const int annéeMax = 2019;
            if (annéeNais < annéeMin || annéeNais > annéeMax)
                Console.WriteLine("date non valide");

        }

        static void Demo2()
        {

            string texte;
            string phrase;
            int nbPhrases, bnmots;

            phrase = "le c# est un langage moderne et puissant";
            texte = phrase;
            texte = texte + " il est utilisé pour toutes sortes d'applications \n";
            texte += " - application console\n";
            texte += " - application fenetrée avec Winforms et WPF\n";
            texte += " - application mobile avec Xamarin\n";

            Console.WriteLine(texte);


            char lettre;
            lettre = phrase[3];

            int[] tabPos = new int[3];
            tabPos[0] = 3;
            tabPos[1] = 4;
            tabPos[2] = 40;

            tabPos = new int[3] { 3, 4, 40 };
            Console.WriteLine(tabPos.Length);

            for (int i = 0; i < tabPos.Length; i++)
            {
                Console.WriteLine("Position {0} : {1}", i, tabPos[i]);
            }


            int j = 0;
            while (j < tabPos.Length)
            {
                Console.WriteLine("Position {0} : {1}", j, tabPos[j]);
                j++;

            }

            j = 0;
            do
            {
                Console.WriteLine("Position {0} : {1}", j, tabPos[j]);
                j++;
            } while (j < tabPos.Length);


            foreach (int item in tabPos)
            {
                Console.WriteLine("{0}", item);
            }

            nbPhrases = 0;
            for (int i = 0; i < texte.Length; i++)
            {
                if (texte[i] == '\n')
                    nbPhrases++;
            }

            Console.WriteLine("il y a {0} phrases dans le texte", nbPhrases);





        }

        static void Demo3()
        {
            string phrase = "le c# est un langage moderne et puissant";

            int n = CompterMots(phrase);
            Console.WriteLine("La phrase \"{0}\" comporte {1} mots", phrase, n);



        }

        static int CompterMots(string p)
        {
            int nbMots = 0;
            for (int i = 0; i < p.Length; i++)
            {
                if (p[i] == ' ' || p[i] == '\'' || p[i] == '\n')
                {
                    nbMots++;
                }
            }
            return nbMots + 1;
        }

        static string Demo4(string nom, int annee, string sexe)
        {
            string message;
            if (sexe == "femme")
            {
              message= "Bonjour Madame " + nom + ",vous avez "+ annee + " ans";

            }
            else  message= "Bonjour Monsieur " + nom + ",vous avez "+ annee + " ans";

            return message;
        }
    }
}
