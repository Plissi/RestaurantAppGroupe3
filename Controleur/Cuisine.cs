using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using Modèle.Cuisine;

namespace Controleur
{
    public class Cuisine
    {
        CuisineControleur cuisine;
        int port = 5050; 
        public IPAddress ip = Dns.GetHostEntry(Dns.GetHostName()).AddressList[0];
        public IPEndPoint endPoint;
        public Socket s ;


        public Cuisine(CuisineControleur cuisine)
        {
            this.cuisine = cuisine;
        }

        public void StartServer()
        {
            try
            {
                endPoint = new IPEndPoint(ip, port);
                s = new Socket(ip.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                s.Bind(endPoint);
                s.Listen(10);

                while (true)
                {
                    Console.WriteLine("En attente de la salle");
                    Socket handler = s.Accept();
                    Console.WriteLine("Salle connectée");
                    Console.ReadLine();
                }

            }
            catch (Exception e)
            {

                Console.WriteLine(e.ToString());
                Console.ReadLine();
            }
        }
    }
}
