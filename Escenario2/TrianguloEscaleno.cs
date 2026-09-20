namespace Escenario2
{
    public class TrianguloEscaleno : Triangulo
    {
        public double LadoB { get; set; }
        public double LadoC { get; set; }

        public override double CalcularPerimetro()
        {
            return Base + LadoB + LadoC;
        }
    }
}
