using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controleur;

namespace SalleRestauration
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Restaurant restaurant = new Restaurant();
            //Cuisine cuisine = new Cuisine(restaurant.cuisine);
            Salle salle = new Salle(restaurant.salle);
            Console.WriteLine("L'équipe de la salle est prête");

            try
            {
                //cuisine.cuisineServer.Start();
                Console.WriteLine("Bienvenu dans la Salle...");
                Console.ReadLine();

            }
            catch (Exception e)
            {

                Console.WriteLine(e.ToString());
                Console.ReadLine();
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
