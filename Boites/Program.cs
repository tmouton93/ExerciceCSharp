using System;

namespace Boites
{

    enum Couleurs { Blanc, Bleu, Vert, Jaune, Orange, Rouge, Marron }
    enum Matières { Carton, Plastique, Bois, Métal }

    enum Format { XS, S, M, L, XL}

    class Program
    {
        static void Main(string[] args)
        {

            Boite boite1 = new Boite(10, 15, 20);
            Boite boite2 = new Boite(10, 15, 20, Matières.Carton);
           bool reponse= boite2.Compare(boite1);

            Console.WriteLine(reponse);
            Console.WriteLine("il y a {0} boites", Boite.Compteur);

            Boite boite3 = new Boite(10, 15, 20, Matières.Carton);
            boite3.Etiqueter("Totodenoel", true);

            Boite boite4 = new Boite(30, 40, 50 );



            Etiquette e1 = new Etiquette {couleur=Couleurs.Blanc, format=Format.S, texte="Destinataire" };
            Etiquette e2 = new Etiquette {couleur=Couleurs.Rouge, format = Format.S, texte = "FRAGILE" };
            boite4.Etiqueter(e1, e2);



        }

        



    }
}
