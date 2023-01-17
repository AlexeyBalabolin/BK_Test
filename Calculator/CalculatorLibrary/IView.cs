namespace CalculatorLibrary
{
    //интерфейс для вьюшек
    public interface IView
    {
        //принимаемое значение
        string Value { get; }
        //результат выполнения 
        string Result { set; }
    }
}
