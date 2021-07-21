using System;
using System.Collections.Generic;
using System.Linq;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> FIO = new List<string>() { "Петров", "Сидоров", "Веселов", "Абрамов", "Иванов" };

            Obrabotka ob = new Obrabotka();
            ob.NumberEvent += ShowNumber;

            try
            {
                ob.Reader(FIO);
            }
            catch (Exception ex)
            {
                if (ex is FormatException)
                    Console.WriteLine("Введено не число");
                else if (ex is MyException)
                    Console.WriteLine("Введено число, но это ни 1 и не 2");
                else Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }

        static void ShowNumber(int number, List<string> spisok)
        {
            Console.WriteLine("Неотсортированный список фамилий:");
            Print(spisok);
            switch (number)
            {
                case 1: Console.WriteLine("Введено число 1, сортировка от А-Я"); spisok.Sort(); Print(spisok); break;
                case 2: Console.WriteLine("Введено число 2, сортировка от Я-А"); IEnumerable<string> spisok2 = spisok.OrderByDescending(u => u); Print(spisok2); break;
            }
        }

        static void Print(IEnumerable<string> spisok)
        {
            foreach (var item in spisok)
            {
                Console.Write(" " + item + " ");
            }
            Console.WriteLine();
        }

    }

    class Obrabotka
    {
        public delegate void Notify(int number, List<string> spisok);  // делегат
        public event Notify NumberEvent; // событие

        public void Reader(List<string> spisok)
        {
            Console.WriteLine("Введите число 1 или 2");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number != 1 && number != 2) throw new MyException();

            NumberEnter(number, spisok);
        }

        protected virtual void NumberEnter(int number, List<string> spisok)
        {
            NumberEvent?.Invoke(number, spisok);
        }
    }
}
