using System;

namespace CreationCompte
{
    class Program
    {
        static void Main(string[] args)
        {
            

            CreerCompte();

        }

        static void CreerCompte()
        {
            

            bool nlog=false;
            
            while (nlog==false)
            {
                Console.WriteLine(" Saisissez votre login");
            string login = Console.ReadLine();
                try
                {
                    VerifLogin(login);
                    nlog = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);

                }
            }


            
            bool nmdp = false;

            while (nmdp == false)
            {
                Console.WriteLine(" Saisissez votre mot de passe");
            string mdp = Console.ReadLine();
                try
                {
                    Verifmdp(mdp);
                    nmdp = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);

                }
            }




            Console.WriteLine(" Votre compte a bien été créé. Un message vient de vous être envoyé");
        }

        static void VerifLogin(string l)
        {
            int n = l.Length;
            if (n < 5)
            {
                throw new FormatException("Votre LogIn doit comprendre au moins 5 caractères!");
            }




        }

        static void Verifmdp(string m)
        { 
            bool chiffre=false;
            bool lettre = false;
            for (int i = 0; i < m.Length; i++)
            {
                int code = m[i];
                if (code >= 48 && code <= 57)
                {
                    chiffre = true;

                }
                if (chiffre == false )
                {
                    throw new FormatException("Choisissez un autre mdp");
                }
                
                if ((code >= 65 && code <= 90) || (code >= 97 && code <= 122))
                {
                    lettre= true;


                }
                if (lettre == false)
                {
                    throw new FormatException("Choisissez un autre mdp");
                }

            }
            }


        }

    }

