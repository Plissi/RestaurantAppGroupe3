using Modèle.SalleRestauration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Modèle
{
    public class Client : Creator, IClientFactory
    {
        Commande commande;
        public int nombre;
        public Table table { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void faire()
        {

        }
        public void creerClient()
        {
            Thread.Sleep(5000);
        }

        public void commander()
        {
            commande = new Commande(new Random().Next(), new Random().Next(1, 13), 5000);
            Console.Write("Commande, id: " + commande.idRecette + ", prix: "+ commande.prix);
        }

        public override IClientFactory FactoryMethod()
        {
            return new Client();
        }

        public Client()
        {
            this.nombre = new Random().Next(1,5);
        }
    }
}
