public class Calculator : ICalculator 
{
    public Calculator() {}

    public int Addition(int a, int b)
    {
        // comment added by dev4
        return a+b;
    }

    public int Subtraction(int a, int b)
    {
        return a - b;
    }

    public int Multiplication(int a, int b)
    {
        return a * b;
    }

    public int Division(int a, int b)
    {
        return a / b;
    }
}