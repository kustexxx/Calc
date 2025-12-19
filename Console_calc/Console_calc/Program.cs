using Console_calc;
using System;

namespace Console_calc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Class1();
            string input1;
            string input2;
            double num1;
            double num2;
            string message;

            Console.WriteLine(" Калькулятор ");


            input1 = GetData("Введите первое число:");
            num1 = CheckData.CheckDataToDouble(input1, out message);
            if (!string.IsNullOrEmpty(message))
            {
                Console.WriteLine($"Ошибка: {message}");
                Console.WriteLine("Нажмите любую клавишу для выхода...");
                Console.ReadKey();
                return;
            }


            input2 = GetData("Введите второе число:");
            num2 = CheckData.CheckDataToDouble(input2, out message);
            if (!string.IsNullOrEmpty(message))
            {
                Console.WriteLine($"Ошибка: {message}");
                Console.WriteLine("Нажмите любую клавишу для выхода...");
                Console.ReadKey();
                return;
            }

            Console.WriteLine();
            Console.WriteLine("Выберите операцию:");
            Console.WriteLine("1 - Сложение (+)");
            Console.WriteLine("2 - Вычитание (-)");
            Console.WriteLine("3 - Умножение (*)");
            Console.WriteLine("4 - Деление (/)");
            Console.Write("Ваш выбор: ");

            string choice = Console.ReadLine();
            if (string.IsNullOrEmpty(choice))
            {
                Console.WriteLine("Операция не выбрана!");
                Console.WriteLine("Нажмите любую клавишу для выхода...");
                Console.ReadKey();
                return;
            }
            Console.WriteLine();

            double result = 0;
            string operation = "";

            switch (choice.Trim())
            {
                case "1":
                    result = calculator.Add(num1, num2);
                    operation = "+";
                    break;
                case "2":
                    result = calculator.Subtract(num1, num2);
                    operation = "-";
                    break;
                case "3":
                    result = calculator.Multiply(num1, num2);
                    operation = "*";
                    break;
                case "4":
                    result = calculator.Divide(num1, num2, out message);
                    if (!string.IsNullOrEmpty(message))
                    {
                        Console.WriteLine(message);
                        Console.WriteLine("Нажмите любую клавишу для выхода...");
                        Console.ReadKey();
                        return;
                    }
                    operation = "/";
                    break;
                default:
                    Console.WriteLine("Неверный выбор операции!");
                    Console.WriteLine("Нажмите любую клавишу для выхода...");
                    Console.ReadKey();
                    return;
            }

            Console.WriteLine($"Результат: {num1} {operation} {num2} = {result}");
            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }

        public static string GetData(string prompt)
        {
            Console.Write(prompt + " ");
            string input = Console.ReadLine();
            return input ?? "";
        }
    }
}

