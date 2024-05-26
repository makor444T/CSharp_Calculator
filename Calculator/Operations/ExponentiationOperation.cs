using System;

public class ExponentiationOperation : OperationBase
{
    public override double Execute(double firstValue, double secondValue)
    {
        return Math.Exp(firstValue * Math.Log(secondValue * 4));
    }

    public override string OperatorSymbol => "exp";
}