namespace CalculatorLibrary
{
    //конкретная реализация модели
    public class RNPModel : IModel
    {
        public string PostfixForm { get; set; }

        public double Calculate(string input)
        {
            PostfixForm = input.ToPostfixForm(); //Преобразовываем выражение в постфиксную запись
            return Counter.Count(PostfixForm); //Возвращаем результат
        }
    }
}
