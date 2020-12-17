using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Modèle.SalleRestauration
{
    public class SalleContoleur
    {
        public CommisSalle commisSalle;
        public List<Serveur> serveurs;
        public List<ChefRang> chefRangs;
        public MaitreHotel maitre;
        public List<Carre> carres;

        public SalleContoleur()
        {
            
            serveurs = new List<Serveur>();
            chefRangs = new List<ChefRang>();
            

            carres = new List<Carre>();
            carres.Add(new Carre(1));
            carres.Add(new Carre(2));


            /*Thread process1 = new Thread(() =>
            {
                CreationMH("FOO");
            });*/

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

       /* public void CreationMH(string value)
        {
            Singleton singleton = Singleton.GetInstance(value);
            Console.WriteLine(singleton.Value);
        }*/
    }
}
