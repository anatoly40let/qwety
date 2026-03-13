using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myapp
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
Console.Title = "Моё первое приложение";
    string name = Console.ReadLine();
Console.WriteLine()$"\nРад знакомству, {name}!");
    Console.WriteLine()$"Сегодня на календаре: {DateTime.Now:dd.MM.yyyy}");
    Console.WriteLine()"Нажми любую клавишу, чтобы выйти...");
    Console.ReadKey();