﻿using MegaDeskWeb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDeskWeb
{
    public class Desk
    {
        public decimal Width { get; set; }
        public decimal Depth { get; set; }
        public int NumDrawers { get; set; }
        public SurfaceMaterial SurfaceMaterial { get; set; }
    }

    
}
