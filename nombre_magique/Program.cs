using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace nombre_magique
{

    class Program
    {
        static int DemanderNombre(int min,int max)
        {
            

            int nombreUtilisateur = min  -1;
            
            while ((nombreUtilisateur < min || nombreUtilisateur > max))
            {
                Console.Write("Veuillez entrer un nombre entre "+min+" et " +max+ " s'il vous plaît\n");
                string reponse = Console.ReadLine();

                try
                {
                    nombreUtilisateur = int.Parse(reponse);
                    if ((nombreUtilisateur < min || nombreUtilisateur > max)){

                        Console.WriteLine("Erreur : le nombre doit être entre " +min+ " et " +max);
                     
                    }
                    
                }
                catch
                {
                    Console.WriteLine("Nombre invalide");
                }
            }

            return nombreUtilisateur;

        }
        private static void Main(string[] args)
        {
            const int NOMBRE_MIN = 1;
            const int NOMBRE_MAX = 10;
            

            int nombre = NOMBRE_MIN-1;
            Random rand = new Random();
            int NOMBRE_MAGIQUE = rand.Next(NOMBRE_MIN, NOMBRE_MAX + 1);

            int nbVies = 4;

            while (nbVies > 0)
            {
                Console.WriteLine();
                Console.WriteLine("Votre nombre de vie:" + nbVies);
                nombre = DemanderNombre(NOMBRE_MIN, NOMBRE_MAX);
                if (NOMBRE_MAGIQUE > nombre)
                {
                    Console.WriteLine("Le nombre magique est plus grand");
                    
                }
                else if (NOMBRE_MAGIQUE < nombre)
                {
                    Console.WriteLine("Le nombre magique est plus petit");
                    
                }
                else
                {
                    break;
                }
                nbVies--;
            }
           
            if (nombre==NOMBRE_MAGIQUE)
                {
                    Console.WriteLine("Bravo vous avez trouvé le nombre magique");
                }
            else 
                {
                    Console.WriteLine("Désolé vous avez perdu, le nombre magique était : "+NOMBRE_MAGIQUE);
                }
            
            
        }
    }
}