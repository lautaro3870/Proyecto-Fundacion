﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFundacion.Models
{
    public partial class Area
    {
        public Area()
        {
            AreasxProyectos = new HashSet<AreasxProyecto>();
        }

        public int Id { get; set; }
        public string Area1 { get; set; }

        public virtual ICollection<AreasxProyecto> AreasxProyectos { get; set; }
    }
}
