using Modèle.SalleRestauration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Modèle
{
    class Client : IClientFactory
    {
        Commande commande;
        public int nombre {
            get
            {
                return nombre;
            }
            set {
                Random num = new Random();
                nombre = num.Next(1, 10);
            } 
        }
        public Table table { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void faire()
        {

        }
        public void creerClient()
        {
            
        }

        public void commander()
        {
            commande = new Commande(new Random().Next(), new Random().Next(1, 13), 5000);
            Console.Write("Commande passée pour " + nombre);
        }

        public Client() { 
        }
    }
}
