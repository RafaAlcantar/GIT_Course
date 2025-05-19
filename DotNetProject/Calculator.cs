using CalculadoraSolid.Interfaces;

namespace CalculadoraSolid
{
    public class Calculator
    {
        public double Calculate(double a, double b, IOperation operation)
        {
            return operation.Execute(a, b);
        }
    }
}
