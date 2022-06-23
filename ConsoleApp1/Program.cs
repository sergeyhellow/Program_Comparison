using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*Задание 4
Пользователь вводит в строку с клавиатуры логическое
выражение. Например, 3>2 или 7<3. Программа должна
посчитать результат введенного выражения и дать резуль-
тат true или false. В строке могут быть только целые числа
и операторы: <, >, <=, >=, ==, !=.Для обработки ошибок
ввода используйте механизм исключений*/











class Program_Comparison
{

    static void Main()
    {      
        bool correct = true; // переменная будет использована несколько раз.
        Console.WriteLine("Введите сравнение, можно в  дробях, попробуйте словами");
        string primer = string.Empty;
        double a, b;
        a = 1;
        b = 1;
        while (correct)
        {
            primer = Console.ReadLine();
            primer = primer.Replace('.', ',');
            string[] stringSeparators = new string[] { "=<", "<=", "=>", ">=", "<", ">", "==", "!=" };
            string[] numbers = primer.Split(stringSeparators, StringSplitOptions.None);
            
            try
            {
                a = Convert.ToDouble(numbers[0]);
            }
            catch (FormatException FE)
            {
                Console.WriteLine(FE.Message);
            }
            catch (IndexOutOfRangeException IorE)
            {
                Console.WriteLine(IorE.Message);
            }

            try
            {
                b = Convert.ToDouble(numbers[1]);
            }
            catch (FormatException FE)
            {
                Console.WriteLine(FE.Message);
            }
            catch (IndexOutOfRangeException IorE)
            {
                Console.WriteLine(IorE.Message);
            }
          

            finally
            {
                if (Double.TryParse(numbers[0], out a) && Double.TryParse(numbers[1], out b))
                {
                    correct = false;
                }
                else { Console.WriteLine("Вы ввели буквы, попробуйте еще"); }
            }
                  
        }

       
        if (primer.Contains("=<") || primer.Contains("<=") && a <= b) { correct = true; }
        if (primer.Contains("=<") || primer.Contains("<=") && a<=b ) { correct = true; }
        if (primer.Contains("=>") || primer.Contains(">=") && a >= b) { correct = true; }
        if (primer.Contains("==")  && a == b) { correct = true; }
        if (primer.Contains(">") && a > b) { correct = true; }
        if (primer.Contains("<") && a < b) { correct = true; }
        if (primer.Contains("!=") && a != b) { correct = true; }

        Console.WriteLine("Результат:\n");
        Console.WriteLine(correct);

        Console.ReadLine();

        

    }
}
