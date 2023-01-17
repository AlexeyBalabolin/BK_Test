using System.Collections.Generic;

namespace CalculatorLibrary
{
    public static class ServiceMethods
    {
        private static Dictionary<char, byte> _priorityDictionary = new Dictionary<char, byte>()
        {
            {'(', 0 },
            {')', 1 },
            {'+', 2 },
            {'-', 3 },
            {'*', 4 },
            {'/', 5 }
        };

        //Метод возвращает true, если проверяемый символ - разделитель ("пробел" или "равно")
        public static bool IsDelimeter(char c) => " =".IndexOf(c) != -1;

        //Метод возвращает true, если проверяемый символ - оператор
        public static bool IsOperator(char с) => "+-/*^()".IndexOf(с) != -1;

        //Метод возвращает приоритет оператора
        public static byte GetPriority(char s) => _priorityDictionary[s];
    }
}
