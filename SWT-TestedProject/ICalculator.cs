namespace SWT_TestedProject;

public interface ICalculator
{
    int Add(int a, int b);
    int Subtract(int a, int b);
    int Multiply(int a, int b);
    double MultiplyDouble(double a, double b);
    double Divide(double a, double b);
    int RemainingDiv(int a, int b);
    string AddEurToCalculation(Func<int, int, int> func, int a, int b);
}