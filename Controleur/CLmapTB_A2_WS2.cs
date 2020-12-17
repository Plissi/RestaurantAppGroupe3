using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controleur
{
    public class CLmapTB_A2_WS2
    {
        string rq_sql;
        int id;
        string nom;
        string prenom;

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }

        //sélectionne tous les enregistrements
        public string selectAll()
        {
            rq_sql = "SELECT * FROM dbo.TB_A2_WS2;";
            return rq_sql;
        }

        //sélectionne les enregistrement qui correspondent au critère nom
        public string selectByName(string nom)
        {
            rq_sql = "SELECT * FROM dbo.TB_A2_WS2 WHERE nom ='" + nom + "';";
            return rq_sql;
        }

        //sélectionne les enregistrement qui correspondent au critère id
        public string delete()
        {
            return rq_sql;
        }

        //ajoute la un enregistrement
        public string insert()
        {
            rq_sql = "INSERT INTO dbo.Commande values(" +"  ";
            return rq_sql;
        }

        //
        public string update()
        {
            return rq_sql;
        }
    }
}
