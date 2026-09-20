namespace Escenario2
{
    public abstract class Triangulo : IFigura
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public double CalcularArea()
        {
            return (Base * Altura) / 2;
        }

        public abstract double CalcularPerimetro();
    }
}
