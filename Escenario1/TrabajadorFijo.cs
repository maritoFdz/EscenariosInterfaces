using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escenario1
{
    public class TrabajadorFijo : ITrabajador
    {
        public string Nombre { get; set; }
        public decimal SalarioBase { get; set; }

        public decimal CalcularSalarioFinal()
        {
            return SalarioBase;
        }
    }
}
