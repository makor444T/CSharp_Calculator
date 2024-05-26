
public class AdditionOperation : OperationBase
{
    public override double Execute(double firstValue, double secondValue)
    {
        return firstValue + secondValue;
    }

    public override string OperatorSymbol => "+";
}