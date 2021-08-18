﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFundacion.Models
{
    public partial class AreasxProyecto
    {
        public int IdProyecto { get; set; }
        public int IdArea { get; set; }

        public virtual Area IdAreaNavigation { get; set; }
        public virtual Proyecto IdProyectoNavigation { get; set; }
    }
}
