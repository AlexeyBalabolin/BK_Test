using System.Collections.Generic;

namespace CalculatorLibrary
{
    // Класс для вычисления значения выражения в постфиксной форме
    public static class Counter
    {
        //Метод, вычисляющий значение выражения, уже преобразованного в постфиксную запись
        public static double Count(string input)
        {
            double result = 0;
            Stack<double> temp = new Stack<double>(); //Стек для решения

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    string a = string.Empty;

                    while (!ServiceMethods.IsDelimeter(input[i]) && !ServiceMethods.IsOperator(input[i]))
                    {
                        a += input[i];
                        i++;
                        if (i == input.Length) break;
                    }
                    temp.Push(double.Parse(a));
                    i--;
                }
                else if (ServiceMethods.IsOperator(input[i]))
                {
                    //Берем два последних значения из стека
                    double a = temp.Pop();
                    double b = temp.Pop();

                    switch (input[i]) //И производим над ними действие, согласно оператору
                    {
                        case '+': result = b + a; break;
                        case '-': result = b - a; break;
                        case '*': result = b * a; break;
                        case '/': result = b / a; break;
                    }
                    temp.Push(result); //Результат вычисления записываем обратно в стек
                }
            }
            return temp.Peek(); //Забираем результат всех вычислений из стека и возвращаем его
        }
    }
}
