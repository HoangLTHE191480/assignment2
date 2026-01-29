internal class Program
{
    enum SIGN
    {
        PLUS,
        MINUS,
        MULTIPLY,
        DIVIDE
    }

    static double Calculate(SIGN sign, double arg1, double arg2)
    {
        switch (sign)
        {
            case SIGN.DIVIDE:
                return arg2 == 0 ? 0 : arg1 / arg2;

            default:
                return 0d;
        }
    }

}