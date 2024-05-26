
public interface IOperation
{
        double Execute(double firstValue, double secondValue);
        string OperatorSymbol { get; }
}