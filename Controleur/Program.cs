using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Controleur
{
    class Program
    {
        private static TcpListener serveur;
        private static TcpClient client;

        static void Main(string[] args)
        {
            Restaurant restaurant = new Restaurant();
            Cuisine cuisine = new Cuisine(restaurant.cuisine);
            serveur = cuisine.cuisineServer;
            client = cuisine.salleClient;

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

            while (true)
            {
                client = serveur.AcceptTcpClient();
                Console.WriteLine("Salle connectée");

            }
        }
    }
}
