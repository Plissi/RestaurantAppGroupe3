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
        SalleContoleur salle;
        TcpClient salleClient;
        
        public Salle(SalleContoleur salle, string ip, int port)
        {
            this.salle = salle;
            salleClient = new TcpClient(ip, port);
        }
    }
}
