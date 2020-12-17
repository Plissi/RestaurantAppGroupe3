using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAD
{
    public class CLcad
    {
        String cnx; // chaine de connexion à la bd
        String rq_sql; // variable contenant les instructions SQL
        SqlDataAdapter dataAdapter; // lien entre le niveau applicatif et la bd
        SqlConnection connexion; // informations de connection à la bd
        SqlCommand commande; // info nécessaires à l'exécution de commande sql
        DataSet dataSet; // cache contenan les données manipulable par l'ihm

        public CLcad()
        {
            this.cnx = @"Data Source=PLINE-S\WSSERVER;Initial Catalog=RESTAURANTNEW;Integrated Security=True";
            this.connexion = new SqlConnection(this.cnx);
            this.rq_sql = null;
            this.dataAdapter = null;
            this.commande = null;
            this.dataSet = new DataSet();

        }

        //exécute les actions
        public void ActionRows(string rq_sql)
        {
            commande = new SqlCommand(rq_sql, this.connexion);
            dataAdapter = new SqlDataAdapter(this.commande);
            
        }

        //récupère les données
        public DataSet GetRows(string rq_sql, string dataTableName)
        {
            this.connexion.Open();
            ActionRows(rq_sql);
            dataAdapter.Fill(this.dataSet, dataTableName);
            this.connexion.Close();
            return this.dataSet;
        }
    }
}
