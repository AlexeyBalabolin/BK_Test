namespace CalculatorLibrary
{
    public interface IModel
    {
        //принимает выражение в виде строки и возвращает результат
        double Calculate(string input);
        //свойство для записи строки в постфиксной форме
        string PostfixForm { get; set; }
    }
}
