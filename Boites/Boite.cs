using System;
using System.Collections.Generic;
using System.Text;

namespace Boites
{
    class Boite
    {
        private double _hauteur;
        private double _largeur;
        private double _longueur;
        private Matières _matière = Matières.Carton;
        private Couleurs _couleur;


        private Etiquette _etiquetteDest;
        private Etiquette _etiquetteFragile;
        


        public static int Compteur { get; private set; }

        

        public double Hauteur { get { return _hauteur; } }
        public double Largeur { get { return _largeur; } }
        public double Longueur { get { return _longueur; } }
        public Couleurs Couleur { get { return _couleur; } set { _couleur = value; } }
        public Matières Matière
        
        {
            get
            { return _matière; }
        }
        public double Volume
        {
            get
            {
                return _largeur * _hauteur * _longueur;

            }
        }

        public Boite(double longueur, double hauteur, double largeur)
        {
            _longueur = longueur;
            _hauteur = hauteur;
            _largeur = largeur;

            Compteur++;

        }

        public Boite(double longueur, double hauteur, double largeur, Matières mat) : this(longueur, hauteur, largeur)
        {
            _matière = mat;
        }

        public void Etiqueter(string destinataire)
        {
           
           
            _etiquetteDest = new Etiquette { couleur=Couleurs.Blanc, format=Format.L, texte=destinataire };

        }



        public void Etiqueter(string dest, bool fragile)
        {
            Etiqueter(dest);
            if (fragile==true)
            {
                _etiquetteFragile = new Etiquette { couleur = Couleurs.Rouge, format = Format.S, texte = "FRAGILE" };
            }
            
        }

        public void Etiqueter(Etiquette Edest, Etiquette Efra)
        {

          _etiquetteDest=Edest;
          _etiquetteFragile=Efra; 
        }


        public bool Compare(Boite b)
        {
            if (b._hauteur==_hauteur && b._largeur==_largeur && b._longueur==_longueur && b._matière==_matière)
            {
                return true;
            }

            else { return false; }
        }
    }

    class Etiquette
    {
        public string texte { get; set; }

        public  Couleurs couleur{ get; set; }

        public Format format { get; set; }

    }

}
