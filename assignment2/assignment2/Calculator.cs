public class Calculator
{
    public enum SIGN
    {
        PLUS,
        MINUS,
        MULTIPLY,
        DIVIDE
    }

    public double Calculate(SIGN sign, double arg1, double arg2)
    {
        switch (sign)
        {
            case SIGN.MINUS:
                return arg1 - arg2;

            default:
                break;
        }
        return 0d;
    }
}
