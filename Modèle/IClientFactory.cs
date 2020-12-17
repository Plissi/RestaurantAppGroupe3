using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modèle.SalleRestauration;

namespace Modèle
{
    interface IClientFactory
    {
        int nombre { get; set; }
        Table table { get; set; }

        void creerClient();
    }
}
