using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modèle
{
    public abstract class Creator
    {

        public abstract IClientFactory FactoryMethod();
    }
}
