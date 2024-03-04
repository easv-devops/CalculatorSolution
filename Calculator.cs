using ConsoleCalculator;

public class Calculator : ICalculator
{
    private readonly CalculatorRepository _calculatorRepository;

    public Calculator(CalculatorRepository calculatorRepository)
    {
        _calculatorRepository = calculatorRepository;
    }
    public double Add(double n1, double n2)
    {
        double result = n1 + n2;
        _calculatorRepository.InsertIntoDatabase(n1,n2, result, "Add");
        return result;
    }

    public double Divide(double n1, double n2)
    {
        if(n2 == 0)
        throw new DivideByZeroException("Cannot devide by zero!");

        double result = n1 / n2;
        _calculatorRepository.InsertIntoDatabase(n1, n2, result, "Divide");
        return result;
    }

    public double Multiply(double n1, double n2)
    {
        double result = n1 * n2;
        _calculatorRepository.InsertIntoDatabase(n1,n2, result, "Multiply");
        return result;
    }

    public double Subtract(double n1, double n2)
    {
        double result = n1 - n2;
        _calculatorRepository.InsertIntoDatabase(n1,n2,result, "Subtract");
        return result;
    }



}
