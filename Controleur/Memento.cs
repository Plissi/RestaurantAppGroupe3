using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controleur
{
    class Memento : IMememto
    {
        public string State { get { return this.State; } set { this.State = value; } }

        public Memento(string state)
        {

        }
        public DateTime GetDate()
        {
            throw new NotImplementedException();
        }
    }
}
