using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Vehicules
{
    class Véhicule:IComparable<Véhicule>
    {
        public string Nom { get;}
        public int NbRoues { get; }
        public Energies Energie { get; }
        public double Prix { get; set; }

        private string _description;

        public virtual string Description
        {
            get { return $"Vehicule {Nom} roule sur {NbRoues} roues et à l'énergie {Energie}"; }
            
        }
        public Véhicule(string nom, int nbRoues, Energies energie)
        {
            Nom = nom;
            NbRoues = nbRoues;
            Energie = energie;
        }

        public Véhicule(string nom, double prix)
        {
            Nom = nom;
            Prix = prix;
        }

       
        

        public int CompareTo([AllowNull] Véhicule other)
        {
          

            if (Prix < other.Prix)
            return -1;
            if (Prix == other.Prix)
                return 0;
            return 1;

        }
    }


    class Voiture : Véhicule
    {
        public Voiture(string nom, Energies energie) : base(nom, 4, energie)
        {

        }

        public override string Description=>"je suis une voiture :) \r\n" + base.Description;


        public Voiture(string nom, double prix): base( nom, prix)
        {

        }
    }

    class Moto : Véhicule
    {
       public Moto(string nom, Energies energie) : base(nom, 2, energie)
        {
        }


        public Moto(string nom, double prix) : base(nom, prix)
        {

        }


        public override string Description => "je suis une moto \r\n" + base.Description;


        
    }




}
