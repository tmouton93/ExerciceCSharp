using System;
using System.Collections.Generic;

namespace Vehicules
{
    enum Energies  {Aucune, Essence, Gazole, GPL, Electrique};


    class Program
    {
        static void Main(string[] args)
        {

            Voiture voiture = new Voiture("Voit", Energies.Electrique);

            Véhicule voiturette = new Voiture ("tuture", Energies.GPL);
            Véhicule moto = new Moto("Mob", Energies.Essence);


            // Console.WriteLine(voiturette.Description);
            // Console.WriteLine(moto.Description);
            //Console.WriteLine(voiture.Description);



             

            Véhicule mégane = new Voiture("Mégane", 19000);
            Véhicule intruder = new Moto("Intruder", 13000);
            Véhicule enzo = new Voiture("Enzo", 3800000);
            Véhicule yamaha = new Moto("Yamaha XJR1300", 11000);

            var liste1 = new SortedList<string,Véhicule>();
            liste1.Add(mégane.Nom, mégane);
            liste1.Add(intruder.Nom, intruder);
            liste1.Add(enzo.Nom, enzo);
            liste1.Add(yamaha.Nom, yamaha);

            foreach (var item in liste1)
            {
                Console.WriteLine($"{item.Key}:{item.Value.Prix}");
            }
            Console.WriteLine();
            var liste2 = new SortedList<Véhicule, string>();
        
            liste2.Add(mégane, mégane.Nom);
            liste2.Add(intruder, intruder.Nom);
            liste2.Add(enzo, enzo.Nom);
            liste2.Add(yamaha, yamaha.Nom);

            foreach (var item in liste1)
            {
                Console.WriteLine($"{item.Key}:{item.Value.Nom}");
            }
            Console.WriteLine();
            string[] recherche = new string[] { "Clio", "Mégane", "Golf", "Enzo", "Polo" };

            foreach (var item in recherche)
            {

                Véhicule voit;
                if (liste1.TryGetValue(item, out voit ))
                {
                    Console.WriteLine($"{voit.Nom}:{voit.Prix}");
                }

            }

        }


    }

    }
