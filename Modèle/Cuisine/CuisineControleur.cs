using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modèle.Cuisine
{
    public class CuisineControleur
    {
        //Personnel
        ChefCuisine chefCuisine;
        List<ChefPartie> chefsPartie;
        List<CommisCuisine> commisCuisine;
        Plongeur plongeur;

        //Matériel


        public CuisineControleur()
        {
            chefCuisine = new ChefCuisine();
            chefsPartie = new List<ChefPartie>();
            commisCuisine = new List<CommisCuisine>();
            plongeur = new Plongeur();

            for (int i = 0; i < 2; i++)
            {
                chefsPartie.Add(new ChefPartie());
                commisCuisine.Add(new CommisCuisine());
            }

            Console.WriteLine("L'équipe de la cuisine est prête");
        }
    }
}
