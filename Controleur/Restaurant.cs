using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modèle.Cuisine;
using Modèle.SalleRestauration;

namespace Controleur
{
    public class Restaurant
    {
        public CuisineControleur cuisine;
        public SalleContoleur salle;
        
        public Restaurant()
        {
            cuisine = new CuisineControleur();
            salle = new SalleContoleur();
        }

        void pause()
        {
            Console.WriteLine();
        }

        void launch()
        {

        }
    }
}
