using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modèle.SalleRestauration
{
    public class Table
    {
        List<Chaise> chaises;
        public static int nombreChaises;
        public static bool dispo = true;

        public Table(int nbChaises)
        {
            nombreChaises = nbChaises;
            chaises = new List<Chaise>();
            for(int i=0; i<nbChaises; i++)
            {
                chaises.Add(new Chaise());
            }
        }
    }
}
