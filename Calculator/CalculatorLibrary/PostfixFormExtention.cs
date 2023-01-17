using System.Collections.Generic;

namespace CalculatorLibrary
{
    public static class PostfixFormExtention
    {
        //Метод, преобразующий входную строку с выражением в постфиксную запись
        public static string ToPostfixForm(this string input)
        {
            string output = string.Empty; //Строка для хранения выражения
            Stack<char> operStack = new Stack<char>(); //Стек для хранения операторов

            for (int i = 0; i < input.Length; i++)
            {
                if (ServiceMethods.IsDelimeter(input[i]))
                    continue;

                if (char.IsDigit(input[i]))
                {
                    while (!ServiceMethods.IsDelimeter(input[i]) && !ServiceMethods.IsOperator(input[i]))
                    {
                        output += input[i];
                        i++;

                        if (i == input.Length) break;
                    }
                    output += " ";
                    i--;
                }

                if (ServiceMethods.IsOperator(input[i]))
                {
                    if (input[i] == '(') //Если символ - открывающая скобка
                        operStack.Push(input[i]); //Записываем её в стек
                    else if (input[i] == ')') //Если символ - закрывающая скобка
                    {
                        //Выписываем все операторы до открывающей скобки в строку
                        char s = operStack.Pop();

                        while (s != '(')
                        {
                            output += s.ToString() + ' ';
                            s = operStack.Pop();
                        }
                    }
                    else //Если любой другой оператор
                    {
                        if (operStack.Count > 0)
                            if (ServiceMethods.GetPriority(input[i]) <= ServiceMethods.GetPriority(operStack.Peek())) //Если приоритет нашего оператора меньше или равен приоритету оператора на вершине стека
                                output += operStack.Pop().ToString() + " "; //То добавляем последний оператор из стека в строку с выражением

                        operStack.Push(char.Parse(input[i].ToString())); //Если стек пуст, или же приоритет оператора выше - добавляем операторов на вершину стека

                    }
                }
            }

            //Когда прошли по всем символам, выкидываем из стека все оставшиеся там операторы в строку
            while (operStack.Count > 0)
                output += operStack.Pop() + " ";

            return output;
        }
    }
}
