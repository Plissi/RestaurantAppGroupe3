using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Controleur
{
    class Program
    {

        static void Main(string[] args)
        {
            Restaurant restaurant = new Restaurant();
            Cuisine cuisine = new Cuisine(restaurant.cuisine);
            Console.WriteLine("L'équipe de la cuisine est prête");

            Thread t = new Thread(new ThreadStart(cuisine.StartServer));
            t.Start();

        }
    }
}
