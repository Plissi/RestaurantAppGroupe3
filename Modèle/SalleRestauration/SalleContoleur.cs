using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modèle.SalleRestauration
{
    public class SalleContoleur
    {
        CommisSalle commisSalle;
        List<Serveur> serveurs;
        List<ChefRang> chefRangs; 
        MaitreHotel maitre;
        List<Carre> carres;

        public SalleContoleur()
        {
            
            serveurs = new List<Serveur>();
            chefRangs = new List<ChefRang>();
            

            carres = new List<Carre>();
            carres.Add(new Carre(1));
            carres.Add(new Carre(2));
            
            
            maitre = new MaitreHotel(carres);

            commisSalle = new CommisSalle(1, carres[0]);

            foreach (var carre in carres)
            {
                for (int i = 0; i < 2; i++)
                {
                    serveurs.Add(new Serveur(i, carre));
                }

                chefRangs.Add(new ChefRang(carre.id, carre));
            }
        }
    }
}
