using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modèle.Cuisine
{
    public class ChefCuisine: IPersonne
    {
        public Etat etate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int posX { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int posY { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }


        private static ChefCuisine _instance;

        private static readonly object _lock = new object();

        public static ChefCuisine GetInstance(string value)
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

        void recevoirCommande()
        {

        }

        void attribuerTache()
        {

        }

        void annulerPlat()
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
