using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using Modèle.SalleRestauration;
using Modèle;

namespace Controleur
{
    public class Salle
    {
        public SalleContoleur salle;
        int port = 5050;
        public IPAddress ip;
        public IPEndPoint endPoint;
        public Socket sender;
        public List<Client> clients;

        public Salle(SalleContoleur salle)
        {
            this.salle = salle;
            clients = new List<Client>();
        }

        public void StartClient()
        {
            try
            {
                byte[] bytes = new byte[1024];
                ip = Dns.GetHostEntry(Dns.GetHostName()).AddressList[0];
                //ip = Dns.GetHostEntry("192.168.43.141").AddressList[0];
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

        public Client nouveauClient()
        {
            Client client = new Client();
            clients.Add(client);
            Console.WriteLine("Il y a " + client.nombre + " nouveau(x) client(s)");
            return client;
        }
        
        public void addClient()
        {
            Client client = new Client();
            clients.Add(client);
            Console.WriteLine("Il y a " + client.nombre +" nouveau(x) client(s)");
            Console.WriteLine("Le Chef de rang arrive...");

        }

    }
}
