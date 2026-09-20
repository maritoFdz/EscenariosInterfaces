using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escenario1
{
    public interface ITrabajador
    {
        string Nombre { get; set; }
        decimal SalarioBase { get; set; }
        decimal CalcularSalarioFinal();
    }
}
