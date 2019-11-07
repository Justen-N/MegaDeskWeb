using MegaDeskWeb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MegaDeskWeb.Models
{
    public class Desk
    {
        public int ID { get; set;}
        public decimal Width { get; set; }
        public decimal Depth { get; set; }
        public int NumDrawers { get; set; }
        public SurfaceMaterial SurfaceMaterial { get; set; }
    }

    
}
