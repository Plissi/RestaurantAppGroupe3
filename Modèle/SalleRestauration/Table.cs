using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modèle.SalleRestauration
{
    public class Table
    {
        public List<Chaise> chaises;
        public int nombreChaises;
        public bool dispo = true;
        public int numero;

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
