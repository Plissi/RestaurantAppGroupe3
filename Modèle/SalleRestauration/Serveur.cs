using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modèle.SalleRestauration
{
    public class Serveur : IMobile
    {
        int id;
        Carre carre;

        public Etat etate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int posX { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int posY { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Serveur(int identification, Carre carre)
        {
            this.id = identification;
            this.carre = carre;
        }
        void servirCommande()
        {

        }

        void debarasserTable()
        {

        }

        public void aider()
        {
            throw new NotImplementedException();
        }

        public void attendre()
        {
            throw new NotImplementedException();
        }

        public void seDeplacer()
        {
            throw new NotImplementedException();
        }

        public int changerPosX()
        {
            throw new NotImplementedException();
        }

        public int changerPosY()
        {
            throw new NotImplementedException();
        }
    }
}
