 class Program
{

    private static void Main(string[] args)
    {
        try
        {
            ILogger logger = new Logger();
            int a = 4;
            int b = 5;
            ICalculate calculate = new Calculate();
            logger.Log("Калькулятро исправен");
            calculate.Sum(a, b);
            
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка {ex.Message}");
            
        }
        
    }
}
interface ICalculate
{
    int Sum(int a, int b);
}
class Calculate : ICalculate
{
    public int Sum(int a, int b)
    {
        int result = a + b;
        Console.WriteLine(result);
        return result;
            
    }
}
interface ILogger
{
    void Log(string message);
}
class Logger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine(message);
    }
}