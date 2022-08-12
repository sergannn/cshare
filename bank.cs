using System;
using System.Linq;

public class Program
{
		
		
	public static void Main()
	{   
		Random rnd = new Random();
		Bank[] banks = new Bank[7]; //создаем объект из массива банков (7 штук)
	 //добавляем 7 банков через цикл
	 //имя и курс можно сделать случайными или зависящими от i
	 // i  = число, нужно перевести его в строку 
	 //rate- случайный (от 50 до 100)
		for (int i = 0; i < 7; i++) {    banks[i]= new Bank{name = "bank"+(i.ToString()) ,rate = rnd.Next(50, 100) }; }
		
		for (int i = 0; i < 7; i++) { 
		Console.WriteLine(banks[i].name+":"+banks[i].rate);
		}
		var max_rate = banks.Max(p => p.rate);
		var best_bank = banks.First(x => x.rate == max_rate);
		Console.WriteLine("Наивысший курс:"+max_rate+" в банке "+best_bank.name);
		Console.WriteLine("Обменяйте деньги - введите кол-во");
		var your_money = Console.ReadLine();
		Console.WriteLine(int.Parse(your_money)*max_rate);
	}
	public class Bank //класс для банка - у него есть имя и курс
{
    public string name { get; set; }
    public int rate { get; set; }
}
}
