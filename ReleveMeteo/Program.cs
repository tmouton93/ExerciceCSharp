using System;
using System.IO;
using System.Text;

namespace ReleveMeteo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"..\..\..\DonnéesMétéoParis.txt";

            String[] readText = File.ReadAllLines(path);

            Console.OutputEncoding = Encoding.UTF8;


            Console.WriteLine(" Mois| T° min|T° max | Précip (mm)|Ensol (H)");
            RelevéMensuel[] TableauMois = new RelevéMensuel[readText.Length];
            
            for (int i = 1; i < readText.Length; i++)
            {

                
                Console.WriteLine(TableauMois.ToString());




            }
            

        }
    }
}
