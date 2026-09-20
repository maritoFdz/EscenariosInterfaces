using System;

namespace Escenario2
{
    public class Circulo : IFigura
    {
        public double Radio { get; set; }

        public double CalcularArea()
        {
            return Math.PI * Radio * Radio;
        }

        public double CalcularPerimetro()
        {
            return 2 * Math.PI * Radio;
        }
    }
}
