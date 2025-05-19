using CalculadoraSolid.Interfaces;

namespace CalculadoraSolid.Operations
{
    public class Addition : IOperation
    {
        public double Execute(double a, double b) => a + b;
    }
}