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
                    else{
                        Console.WriteLine("Votre nombre est valide");
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
            const int NOMBRE_MAGIQUE = 5;

            int nombre = NOMBRE_MIN-1;

            while (nombre != NOMBRE_MAGIQUE)
            {
                nombre = DemanderNombre(NOMBRE_MIN, NOMBRE_MAX);
                if (NOMBRE_MAGIQUE > nombre){
                Console.WriteLine("Le nombre magique est plus grand");
                }else
                    if (NOMBRE_MAGIQUE < nombre)
                {
                    Console.WriteLine("Le nombre magique est plus petit");
                }else 
                {
                Console.WriteLine("Bravo vous avez trouvé le nombre magique");
                }
            }
        }
    }
}