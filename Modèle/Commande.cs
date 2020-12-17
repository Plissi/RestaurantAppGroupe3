using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using Modèle.Cuisine;

namespace Modèle
{
    public class Commande
    {
        public int id;
        public int idRecette;
        public int prix;

        public Commande(int id, int idRecette, int prix)
        {
            this.id = id;
            this.idRecette = idRecette;
            this.prix = prix;
        }
    }
}