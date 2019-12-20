﻿using System;

namespace Pendu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jouez au pendu!");
            Console.WriteLine("Saisissez un mot");
            //--------------------------------------------------------------------------
            // 1. Les étapes ci-desous consistent à faire saisir un mot valide au 1er joueur

            string mot = string.Empty;
            bool motValide = false;
            // Tant que le mot saisi n'est pas valide
            while (!motValide)
            {
                // On fait saisir le mot
                
                mot =Console.ReadLine();
                // On vérifie son format (appeler la méthode statique VerifierMot)
                try
                {
                    Jeu.VerifierMot(mot);
                    motValide = true;
                }   
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                  
                }

            }
            
            //--------------------------------------------------------------------------
            // 2. les étapes suivantes consistent à faire deviner le mot au 2d joueur

                // On vide l'écran
            Console.Clear();

            // On crée un jeu et on l'initialise avec le mot saisi
            Jeu jeu = new Jeu();
            jeu.InitialiserJeu(mot);

            // Tant que le jeu n'est pas fini
            while (jeu.GetEtatPartie() == EtatsPartie.EnCours)
            {
                // On affiche le dessin et l'état du mot en cours
                
                    Console.WriteLine(jeu.GetDessinPendu() );
                    Console.WriteLine(jeu.GetMotEnCours());


                // On demande une lettre et on la teste
                Console.WriteLine("Veuillez saisir une lettre");
                char lettre=Console.ReadKey().KeyChar;
                jeu.TesterLettre(lettre);
                // Si la partie est gagnée, on affiche un message en vert
                // Si elle est perdue on affiche un message en rouge avec la solution
                
            }
            if (jeu.GetEtatPartie() == EtatsPartie.Gagnee)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(jeu.GetEtatPartie());
            }
            else Console.ForegroundColor = ConsoleColor.Red;
                   Console.WriteLine(jeu.GetEtatPartie() + "le mot était " + mot);

            Console.ReadKey();
        }
    }
}
