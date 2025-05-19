using CalculadoraSolid.Interfaces;

namespace CalculadoraSolid.Operations
{
    public class Multiplication : IOperation
    {
        public double Execute(double a, double b) => a * b;
    }
}
