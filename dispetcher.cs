using System;
using System.Collections.Generic;		

public class Program
{
	 public static List<int> Items = new List<int>(); // список артикулов
     public static List<int> Amounts = new List<int>(); // список количеств
	public static void Main()
	{
		Console.WriteLine("Hello World");
	 Console.WriteLine("Введите номер товара и через пробел количество (для окончания - 0):");
            while (true)
            {
                string[] str = Console.ReadLine().Split(' ');
                if (str[0] == "0") break;
                AddItem(int.Parse(str[0]), int.Parse(str[1]));
            }
            Console.WriteLine("-------");
            Console.WriteLine("Различных товаров за день "+Items.Count);
            int sum = 0;
            for (int i = 0; i < Amounts.Count; i++)
            {
                sum += Amounts[i];
            }
            Console.WriteLine("Всего товаров завезено = "+sum);
            Console.ReadLine();
        }
 
        /// <summary>
        /// Добавить товар на склад
        /// </summary>
        /// <param name="item">Артикул товара</param>
        /// <param name="amount">Количество товара</param>
        public static void AddItem(int item, int amount)
        {
            if (Items.Count == 0)
            {
                Items.Add(item);
                Amounts.Add(amount);
            }
            else
            {
                if (Items.Contains(item))
                {
                    Amounts[Items.LastIndexOf(item)] += amount;
                }
                else
                {
                    Items.Add(item);
                    Amounts.Add(amount);
                }
            }
        }
    	
	
}
