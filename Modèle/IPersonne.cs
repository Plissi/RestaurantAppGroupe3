﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modèle
{
    interface IPersonne:IPosition
    {
        Etat etate { get; set; }
    }
}
