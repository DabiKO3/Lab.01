using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab._01
{
    internal class Program
    {

 
        static void Main(string[] args)
        {
            
                Console.WriteLine("Введiть назву процесора: ");
                string name = Console.ReadLine();
                Console.WriteLine("Введiть виробника: ");
                string manufacturer = Console.ReadLine();
                Console.WriteLine("Введiть кiлькiсть ядер: ");
                int cores = int.Parse(Console.ReadLine());
                Console.WriteLine("Введiть частоту процесора (GHz): ");
                double frequency = double.Parse(Console.ReadLine());
                Console.WriteLine("Введiть тепловидiлення (TDP в Вт): ");
                double tdp = double.Parse(Console.ReadLine());
                Console.WriteLine("Введiть кiлькiсть транзисторiв (млн): ");
                long transistors = long.Parse(Console.ReadLine());
                Console.WriteLine("Чи підтримує багатопоточність? (y - так /n - ні ): ");
                ConsoleKeyInfo multithreading = Console.ReadKey();
                Console.WriteLine();
                Console.WriteLine("Введiть продуктивнiсть на 1 ядро (бали): ");
                double performancePerCore = double.Parse(Console.ReadLine());

                Processor myProcessor = new Processor();
                myProcessor.Name = name;
                myProcessor.Manufacturer = manufacturer;
                myProcessor.Cores = cores;
                myProcessor.Frequency = frequency;
                myProcessor.TDP = tdp;
                myProcessor.Transistors = transistors;
                myProcessor.Multithreading = multithreading.Key == ConsoleKey.Y ? true : false;
                myProcessor.PerformancePerCore = performancePerCore;

                double totalPerformance = myProcessor.CalculateTotalPerformance();

                Console.WriteLine();
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("Данi про процесор:");
                Console.WriteLine("------------------------------------------");
                Console.WriteLine();
                Console.WriteLine("Назва: " + myProcessor.Name);
                Console.WriteLine("Виробник: " + myProcessor.Manufacturer);
                Console.WriteLine("Кiлькiсть ядер: " + myProcessor.Cores);
                Console.WriteLine("Частота: " + myProcessor.Frequency.ToString("0.00") + " GHz");
                Console.WriteLine("Тепловидiлення (TDP): " + myProcessor.TDP.ToString("0.00") + " W");
                Console.WriteLine("Кiлькiсть транзисторiв: " + myProcessor.Transistors + " млн.");
                Console.WriteLine("Багатопоточнiсть: " + (myProcessor.Multithreading ? "Так" : "Ні"));
                Console.WriteLine("Продуктивнiсть на 1 ядро: " + myProcessor.PerformancePerCore.ToString("0.00") + " бали");
                Console.WriteLine();
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("Загальна продуктивнiсть: " + totalPerformance.ToString("0.00") + " бали");
                Console.ReadLine();
            

        }
    }
}
