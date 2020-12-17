using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modèle.SalleRestauration
{
    public class MaitreHotel:IPersonne
    {
        public List<Carre> carres;
        public Etat etate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int posX { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int posY { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public MaitreHotel(List<Carre> carres)
        {
            this.carres = carres;
        }

        private static Random aleatoire = new Random();
        private int nombreClient = aleatoire.Next(1, 11);
        public static int accueillirClient(int nombreClient)
        {
            if (nombreClient > 0)
            {
                return nombreClient;
            }
            else
            {
                return 0;
            }
        }

        void verifierPlace()
        {

        }

        void attribuerTable()
        {
            foreach (Carre c in carres)
            {
                foreach (Table t in c.tables)
                {
                    if (Table.nombreChaises >= nombreClient && Table.dispo == true)
                    {
                        bool dispo = false;
                    }
                }
            }
        }

        void appelerChefRang()
        {

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
