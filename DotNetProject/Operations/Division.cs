using CalculadoraSolid.Interfaces;

namespace CalculadoraSolid.Operations
{
    public class Division : IOperation
    {
        public double Execute(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("No se puede dividir entre cero.");
            return a / b;
        }
    }
}
