namespace Escenario2
{
    public class TrianguloIsosceles : Triangulo
    {
        public double LadoIgual { get; set; }
        public override double CalcularPerimetro()
        {
            return Base + (LadoIgual* 2);
        }
    }
}
