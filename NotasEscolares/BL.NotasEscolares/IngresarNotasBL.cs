using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.NotasEscolares
{
    public class IngresarNotasBL: DatosEstudiantesBL

    {
        public decimal IParcial { get; set; }
        public decimal IIParcial { get; set; }
        public decimal IIIParcial { get; set; }
        public decimal IVParcial { get; set; }
        public decimal NotaTotal { get; set; }

    }
}
