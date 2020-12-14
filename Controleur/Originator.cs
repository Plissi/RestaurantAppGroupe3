using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controleur
{
    class Originator
    {
        string _state;

        public Originator(string state)
        {
            this._state = state;
        }

        public IMememto CreateMemento()
        {
            return new Memento(this._state);
        }

        public void SetMemento(Memento memento)
        {
            this._state = memento.State;
        }
    }
}
