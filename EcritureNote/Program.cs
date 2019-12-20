using System;
using System.IO;

namespace EcritureNote
{
    class Program
    {
        static void Main(string[] args)
        {
            SaisirNote();



        }


        static void SaisirNote()
        {

            Console.WriteLine("Saisir un texte");
            string texte = Console.ReadLine();
            Console.WriteLine("Saisir un chemin de fichier");
            string chemin = Console.ReadLine();
            EnregistrerNote(texte, chemin);
        }

        static void EnregistrerNote(string texte, string chemin)
        {


            StreamWriter outputFile = null;
            try
            {
                outputFile = new StreamWriter(chemin, true);
                outputFile.WriteLine(texte);
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Le répertoire spécifié n'existe pas");
            }
            catch (System.UnauthorizedAccessException)
            {
                Console.WriteLine("Le fichier est en lecture seule!");
            }


            finally
            {
                Console.WriteLine("Libération de la ressource");
                if (outputFile != null) outputFile.Close();
            }

        }


    }
}








