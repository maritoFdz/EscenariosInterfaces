using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escenario1
{
    public class TrabajadorXComision : ITrabajador
    {
        public string Nombre { get; set; }
        public decimal SalarioBase { get; set; }
        public decimal Comision { get; set; }

        public decimal CalcularSalarioFinal()
        {
            return SalarioBase + Comision;
        }
    }
}
