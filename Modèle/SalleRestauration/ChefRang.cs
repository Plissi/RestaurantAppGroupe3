using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modèle.SalleRestauration
{
    public class ChefRang : IMobile
    {
        int id;
        Carre carre;

        public Etat etate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int posX { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int posY { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public ChefRang(int id, Carre carre)
        {
            this.id = id;
            this.carre = carre;
        }

        void distribuerCarte()
        {

        }

        void prendreCommande()
        {

        }

        void transmettreCommande()
        {

        }

        void installerClient()
        {

        }

        void dresserTable()
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
