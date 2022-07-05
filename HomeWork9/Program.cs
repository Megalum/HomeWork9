using System;

namespace HomeWork9
{
    class Program
    {
        static void Main(string[] args)
        {
            int task, numberFirst, numberSecond;
            do
            {
                Task();
                task = Input("Введите номер задания: ");
                Console.Clear();
                switch (task)
                {
                    case 1:
                        numberFirst = Input("Введите число: ");
                        numberSecond = 1;
                        Console.WriteLine(NaturalNumbers(numberFirst, numberSecond));
                        break;

                    case 2:
                        numberFirst = Input("Введите первое значение: ");
                        numberSecond = Input("Введите второе значение: ");
                        Console.WriteLine(SumNaturalNumbers(numberFirst, numberSecond));
                        break;

                    case 3:
                        numberFirst = Input("Введите первое значение: ");
                        numberSecond = Input("Введите второе значение: ");
                        if(Flag(numberFirst, numberSecond))
                            Console.WriteLine(FunctionsAckerman(numberFirst, numberSecond));
                        else
                            Console.WriteLine("Error!");
                        break;
                }
                Console.Write("Press key to continue... ");
                Console.ReadKey();

            } while (task < 4);

            int Input(string str)
            {
                Console.Write(str);
                return Convert.ToInt32(Console.ReadLine());
            }

            int NaturalNumbers(int number, int i)
            {
                if (i == number)
                    return number;
                else
                    Console.Write(NaturalNumbers(number, i + 1) + ", ");
                return i;
            }

            int SumNaturalNumbers(int minNumber, int maxNamber)
            {
                if (minNumber == maxNamber)
                    return minNumber;
                else if (minNumber > maxNamber)
                    return SumNaturalNumbers(maxNamber + 1, minNumber) + maxNamber;
                else
                    return SumNaturalNumbers(minNumber + 1, maxNamber) + minNumber;
            }

            int FunctionsAckerman(int numberFirst, int numberSecond)
            {
                if (numberFirst == 0)
                    return numberSecond + 1;
                else if (numberFirst > 0 && numberSecond == 0)
                    return FunctionsAckerman(numberFirst - 1, 1);
                else 
                    return FunctionsAckerman(numberFirst - 1, FunctionsAckerman(numberFirst, numberSecond - 1));
            }

            bool Flag(int numberFirst, int numberSecond)
            {
                int maxResult = 16058; //если рекурсия превышает это значение выдает ошибку
                if (numberFirst > 4)
                    return false;
                else if (numberFirst == 4 && numberSecond >= 1)
                    return false;
                else if (numberFirst == 3 && numberSecond > 10)
                    return false;
                else if (numberFirst == 2 && 2 * numberSecond + 3 >= maxResult) 
                    return false;
                else if (numberFirst == 1 && numberSecond + 2 >= maxResult)
                    return false;
                else if (numberFirst == 0 && numberSecond + 1 >= maxResult)
                    return false;

                return true;
            }

            void Task()
            {
                Console.Clear();
                Console.WriteLine("Номера заданий:");
                Console.WriteLine("1 - Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.");
                Console.WriteLine("2 - Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.");
                Console.WriteLine("3 - Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.");
                Console.WriteLine();
            }

        }
    }
}
