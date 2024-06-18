using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> фирмы = new Dictionary<string, string>();
            фирмы.Add("фирмы1", "страна1");
            фирмы.Add("фирмы2", "страна2");
            фирмы.Add("фирмы3", "страна3");
            Console.WriteLine("Введите количество элементов для добавления: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++) 
            {
                Console.WriteLine("Введите название фирмы");
                string фирма = Console.ReadLine();
                Console.Write($"Введите страну фирмы");
                string страна = Console.ReadLine();
                фирмы.Add(фирма, страна);
            }
            Console.WriteLine("Содержимое словаря: ");
            foreach (KeyValuePair<string, string> пара in фирмы);
            {
                Console.WriteLine($"{пара.Key}. {пара.Value}");
            }
            Console.WriteLine($"Количество элементов словаря: {фирмы.Count}");
        }
    }
}
