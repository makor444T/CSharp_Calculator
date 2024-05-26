
public abstract class OperationBase : IOperation
{
    public abstract double Execute(double firstValue, double secondValue);
    public abstract string OperatorSymbol { get; }
}
