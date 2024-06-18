using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Список овощей");
            List<string> овощи = new List<string>();

            овощи.Add("Морковь");
            овощи.Add("Картофель");
            овощи.Add("Помидор");

            Console.Write("Введите количество элементов для добавления: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) 
            {
                Console.Write($"Введите элемент {i + 1}: ");
                string элемент = Console.ReadLine();
                овощи.Add(элемент);
            }
            Console.WriteLine("Элементы списка");
            for (int i = 0; i < овощи.Count; i++)
            {
                Console.WriteLine($"{i + 1} {овощи[i]}");
            }
            Console.WriteLine($"Количество элементов списка: {овощи:Count}");

            Console.ReadLine();
            
        }
    }
}
