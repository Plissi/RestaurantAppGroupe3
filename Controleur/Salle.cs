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
        int port = 5050;
        public IPAddress ip;
        public IPEndPoint endPoint;
        public Socket sender;

        public Salle(SalleContoleur salle)
        {
            this.salle = salle;
        }

        public void StartClient()
        {
            try
            {
                byte[] bytes = new byte[1024];
                ip = Dns.GetHostEntry(Dns.GetHostName()).AddressList[0];
                endPoint = new IPEndPoint(ip, port);
                sender = new Socket(ip.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

                try
                {
                    sender.Connect(endPoint);
                    Console.WriteLine("L'équipe de la salle est prête");
                    Console.ReadLine();
                    /*byte[] msg = Encoding.ASCII.GetBytes("Test");
                    int byteSent = sender.Send(msg);
                    int byteRec = sender.Receive(bytes);
                    sender.Shutdown(SocketShutdown.Both);
                    sender.Close();*/
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.ToString());
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
