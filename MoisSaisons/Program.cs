using System;

namespace MoisSaisons
{

    [Flags]
    public enum Mois
    {
        Aucun = 0,
        Janvier = 1,
        Fevrier = 2,
        Mars = 4,
        Avril = 8,
        Mai = 16,
        Juin = 32,
        Juillet = 64,
        Aout = 128,
        Septembre = 256,
        Octobre = 512,
        Novembre = 1024,
        Decembre = 2048
    }

    [Flags]
    public enum Saisons
    {
        Aucun = 0,
        hiver = 1,
        Printemps = 2,
        Ete = 4,
        Automne = 8
    }
    class Program
    {
        
        static void Main(string[] args)
        {
         

        }

        static Saisons SaisonDuMois(Mois m)
        {
            Mois MoisHiver = Mois.Decembre | Mois.Janvier | Mois.Fevrier | Mois.Mars;
            Mois MoisPrintemps = Mois.Mars | Mois.Avril | Mois.Mai | Mois.Juin;
            Mois MoisEte = Mois.Juin | Mois.Juillet | Mois.Aout | Mois.Septembre;
            Mois MoisAutomne = Mois.Septembre | Mois.Octobre | Mois.Novembre | Mois.Decembre;



        }




    }
}
