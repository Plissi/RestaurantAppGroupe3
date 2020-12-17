using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modèle.Cuisine.Matériel;

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
        List<FeuCuisson> feux;
        List<Casserole> casseroles;
        List<Poele> poeles;
        Four four;
        List<CuilliereBois> cuilliereBois;
        Mixeur mixeur;
        List<BolSalade> bolSalades;
        List<Autocuiseur> autocuiseurs;
        PresseAgrume presseAgrume;
        Tamis tamis;
        Entonnoir entonnoir;
        List<CouteauCuisine> couteauxCuisine;
        Frigo frigo;
        LaveVaisselle laveVaisselle;
        MachineALaver machineALaver;
        Evier evier;

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

            //Console.WriteLine("L'équipe de la cuisine est prête");


            evier = new Evier();
            four = new Four();
            tamis = new Tamis();
            mixeur = new Mixeur();
            frigo = new Frigo();
            entonnoir = new Entonnoir();
            presseAgrume = new PresseAgrume();
            laveVaisselle = new LaveVaisselle();
            machineALaver = new MachineALaver();

            feux = new List<FeuCuisson>();
            bolSalades = new List<BolSalade>();
            couteauxCuisine = new List<CouteauCuisine>();

            for (int i = 0; i < 5; i++)
            {
                feux.Add(new FeuCuisson());
                bolSalades.Add(new BolSalade());
                couteauxCuisine.Add(new CouteauCuisine());
            }

            casseroles = new List<Casserole>();
            poeles = new List<Poele>();
            cuilliereBois = new List<CuilliereBois>();

            for (int i = 0; i < 10; i++)
            {
                casseroles.Add(new Casserole());
                poeles.Add(new Poele());
                cuilliereBois.Add(new CuilliereBois());
            }

            autocuiseurs = new List<Autocuiseur>();

            for (int i = 0; i < 2; i++)
            {
                autocuiseurs.Add(new Autocuiseur());
            }

        }
    }
}
