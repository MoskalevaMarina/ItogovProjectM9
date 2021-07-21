using System;

namespace ItogovProjectM9
{
    class Program
    {
        static void Main(string[] args)
        {
            Exception[] mas = new Exception[5];
            mas[0] = new RankException();
            mas[1] = new ArgumentException();
            mas[2] = new ArgumentOutOfRangeException();
            mas[3] = new DivideByZeroException();
            mas[4] = new MyException("Свой тип исключения");

            for (int i = 0; i < 5; i++)
            {
                try
                {
                    throw mas[i];
                }
                catch (Exception ex)
                {
                    if (ex is ArgumentException)
                        Console.WriteLine($"Ошибка:  {ex.Message}");
                    else if (ex is RankException)
                        Console.WriteLine($"Ошибка:  {ex.Message}");
                    else if (ex is ArgumentOutOfRangeException)
                        Console.WriteLine($"Ошибка:  {ex.Message}");
                    else if (ex is DivideByZeroException)
                        Console.WriteLine($"Ошибка:  {ex.Message}");
                    else if (ex is MyException)
                        Console.WriteLine($"Ошибка: {ex.Message}");
                }
            }
        }
    }
}
