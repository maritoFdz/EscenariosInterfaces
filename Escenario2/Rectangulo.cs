namespace Escenario2
{
    public class Rectangulo : IFigura
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public double CalcularArea()
        {
            return Base * Altura;
        }

        public double CalcularPerimetro()
        {
            return 2 * (Base + Altura);
        }
    }
}
