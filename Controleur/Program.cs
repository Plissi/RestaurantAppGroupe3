using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controleur
{
    class Program
    {
        static void Main(string[] args)
        {
            Restaurant restaurant = new Restaurant();
            Cuisine cuisine = new Cuisine(restaurant.cuisine);

            try
            {
                cuisine.cuisineServer.Start();
                Console.WriteLine("Bienvenu dans la Cuisine...");
                Console.ReadLine();

            }
            catch (Exception e)
            {

                Console.WriteLine(e.ToString());
                Console.ReadLine();
            }
        }
    }
}
