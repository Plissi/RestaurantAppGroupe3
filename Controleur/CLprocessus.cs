using Modèle;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controleur
{
    public class CLprocessus
    {
        DataSet oDs;
        CLmapTB_A2_WS2 oMap;
        CLcad oCad;
        String rq_sql;

        public CLprocessus()
        {
            this.oDs = new DataSet();
            this.oMap = new CLmapTB_A2_WS2();
            this.oCad = new CLcad();
            this.rq_sql = "";
        }

        public DataSet afficher(string dataTableName)
        {
            oDs.Tables.Clear();
            //oDs.Clear();
            //oDs = new DataSet();
            rq_sql = oMap.selectAll();
            oDs = oCad.GetRows(this.rq_sql, dataTableName);

            return oDs;
        }

        public DataSet rechercherNom(string dataTableName, string nom)
        {
            oDs.Tables.Clear();
            //oDs.Clear();
            //oDs = new DataSet();
            rq_sql = oMap.selectByName(nom);
            oDs = oCad.GetRows(this.rq_sql, dataTableName);

            return oDs;
        }

        public void deleteById()
        {
            
        }
    }
}
