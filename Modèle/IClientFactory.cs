using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modèle.SalleRestauration;

namespace Modèle
{
    public interface IClientFactory
    {
        Table table { get; set; }

        void creerClient();
    }
}
