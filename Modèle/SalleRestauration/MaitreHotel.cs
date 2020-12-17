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

        private static MaitreHotel _instance;

        private static readonly object _lock = new object();

        public static MaitreHotel GetInstance(string value)
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance.Value = value;
                    }
                }
            }
            return _instance;
        }

        public string Value { get; set; }

        public MaitreHotel(List<Carre> carres)
        {
            this.carres = carres;
        }

        private static Random aleatoire = new Random();
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

        public void verifierPlace()
        {

        }

        public int attribuerTable(int nombreClient)
        {
            System.Threading.Thread.Sleep(3000);
            int num = 1;
            foreach (Carre c in carres)
            {
                foreach (Table t in c.tables)
                {
                    if (t.nombreChaises >= nombreClient && t.dispo == true)
                    {
                        bool dispo = false;
                        //num = t.numero;
                    }
                }
            }
            return num;
        }

        public void appelerChefRang()
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
