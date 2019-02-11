  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Advanced_Lesson_7_Delegates.Extension_Methods;


namespace Advanced_Lesson_7_Delegates
{
    public class Practice
    {
        /// <summary>
        /// L7.P1. Переписать консольный калькулятор с использованием делегатов. 
        /// Используйте switch/case, чтоб определить какую математическую функцию.
        /// </summary>
        public static void L7P1_Calculator()
        {
            int value1 = 100;
            int value2 = 200;
            Func<int, int, double> operation = null;

            switch (Console.ReadKey().KeyChar)
            {
                case '+':
                {
                    operation = delegate(int var1, int var2)
                    {
                        return (var1 + var2);
                    };
                    break;
                }
                case '-':
                {
                    operation = (a, b) =>
                    {
                        Console.WriteLine(a);
                        return a - b;
                    };
                    break;
                }
            }

            double result = operation(value1, value2);
            Console.WriteLine($"Result - {result}");
            Console.ReadKey();
        }
        
      
        /// <summary>
        /// L7.P2. Создать расширяющий метод для коллекции строк.
        /// Метод должен принимать делегат форматирующей функции для строки.
        /// Метод должен проходить по всем элементам коллекции и применять данную форматирующую функцию к каждому элементу.
        /// Реализовать следующие форматирующие функции:
        /// Перевод строки в заглавные буквы.
        /// Замена пробелов на подчеркивание.
        /// Продемонстрировать работу расширяющего метода.
        /// </summary>
        public static void L7P2_StringFormater()
        {
           List<String> ls = new List<String>();
           ls.Add("some testText");
           List<String> ls2 = new List<String>();
           ls2.Add("some  new test Text");
           var stringToUpper = ls.Format(ConverToUpperCase);
           var stringWithoutSpaces = ls.Format(SpacesConverter);
           var stringToUpper2 = ls2.Format(ConverToUpperCase);
           var stringWithoutSpaces2 = ls2.Format(SpacesConverter);

            ConsoleLIstWriteLIne(stringToUpper);
            ConsoleLIstWriteLIne(stringWithoutSpaces);
            ConsoleLIstWriteLIne(stringToUpper2);
            ConsoleLIstWriteLIne(stringWithoutSpaces2);
        }

        public static string ConverToUpperCase(string text)
        {
            return text.ToUpper();
        }

        public static string SpacesConverter(string text)
        {
            return text.Replace(" ", "_");
        }

        public static void ConsoleLIstWriteLIne(List<String> items)
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
