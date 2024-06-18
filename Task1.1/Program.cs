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

            Dictionary<string, string> фирмы = new Dictionary<string, string>();
            фирмы.Add("фирмы1", "страна1");
            фирмы.Add("фирмы2", "страна2");
            фирмы.Add("фирмы3", "страна3");
            Console.WriteLine("Введите количество элементов для добавления: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Введите название фирмы");
                string фирма = Console.ReadLine();
                Console.Write($"Введите страну фирмы");
                string страна = Console.ReadLine();
            }
            Console.WriteLine($"Содержимое словаря: ");
            Console.WriteLine($"Количество элементов словаря: {фирмы.Count}");
        }
    }
}