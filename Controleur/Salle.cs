using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using Modèle.SalleRestauration;

namespace Controleur
{
    public class Salle
    {
        public SalleContoleur salle;
        public  TcpClient salleClient;
        int port = 5050;
        IPAddress ip = Dns.GetHostEntry("localhost").AddressList[0];

        public Salle(SalleContoleur salle)
        {
            this.salle = salle;
            salleClient = new TcpClient("localhost", port);
        }
    }
}
