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
        IPAddress ip = Dns.GetHostEntry("localhost").AddressList[0];
        public TcpListener cuisineServer;
        public TcpClient salleClient;


        public Cuisine(CuisineControleur cuisine)
        {
            this.cuisine = cuisine;
            cuisineServer = new TcpListener(ip, port);
            salleClient = default(TcpClient);
        }
    }
}
