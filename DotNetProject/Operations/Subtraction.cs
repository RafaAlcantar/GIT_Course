using CalculadoraSolid.Interfaces;

namespace CalculadoraSolid.Operations
{
    public class Subtraction : IOperation
    {
        public double Execute(double a, double b) => a - b;
    }
}
