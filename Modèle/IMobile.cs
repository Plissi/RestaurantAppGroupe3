using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modèle
{
    interface IMobile:IPersonne
    {
        void seDeplacer();
        void attendre();
        void aider();
    }
}
