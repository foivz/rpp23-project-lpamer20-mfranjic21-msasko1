﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer.Entities
{
    public partial class Vehicle
    {
        public override string ToString()
        {
            return model + " " + mark;
        }
    }
}
