namespace calc
{
    using System;
    using System.Globalization;

    using System;

    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Консольный калькулятор");
            Console.WriteLine("Доступные операции: +  -  *  /  ^");
            Console.WriteLine();

            Console.Write("Введите первое число: ");
            string inputA = Console.ReadLine();
            double a;

            if (!double.TryParse(inputA, out a))
            {
                Console.WriteLine("Ошибка: некорректный ввод первого числа.");
                return;
            }

            Console.Write("Введите второе число: ");
            string inputB = Console.ReadLine();
            double b;

            if (!double.TryParse(inputB, out b))
            {
                Console.WriteLine("Ошибка: некорректный ввод второго числа.");
                return;
            }

            Console.Write("Введите знак операции (+, -, *, /, ^): ");
            string operation = Console.ReadLine();

            double result = 0;
            bool isError = false;

            switch (operation)
            {
                case "+":
                    result = a + b;
                    break;

                case "-":
                    result = a - b;
                    break;

                case "*":
                    result = a * b;
                    break;

                case "/":
                    if (b == 0)
                    {
                        Console.WriteLine("Ошибка: деление на ноль недопустимо.");
                        isError = true;
                    }
                    else
                    {
                        result = a / b;
                    }
                    break;

                case "^":
                    result = Math.Pow(a, b);
                    break;

                default:
                    Console.WriteLine("Ошибка: введён недопустимый знак операции.");
                    isError = true;
                    break;
            }

            if (!isError)
            {
                Console.WriteLine();
                Console.WriteLine("Результат: " + result);
            }

            Console.WriteLine();
            Console.WriteLine("Программа завершена.");
        }
    }

}
