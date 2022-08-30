using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
class Program_sort
{
static void Main(string[] args)
{
while (true)
{
Console.Write("Введите количество участников: ");
int count = int.Parse(Console.ReadLine());
int[] party = new int[count];
int[] partyDo = new int[count];
int[] playerNum = new int[count];
Console.WriteLine();

for (int i = 0; i < party.Length; i++)
{
Console.Write($"Введите значение для {i + 1}-го участника: ");
//try { party[i] = int.Parse(Console.ReadLine()); } 
//catch(FormatException ) {      Console.Write($"Введите значение для {i + 1}-го участника: используется числовой формат: "); 
//party[i] = int.Parse(Console.ReadLine());    }
party[i] = int.Parse(Console.ReadLine());
partyDo[i] = party[i];
}

Console.WriteLine();
for (int i = 0; i < party.Length; i++)
{
for (int j = i + 1; j < party.Length; j++)
{
if (party[i] < party[j])
{
int t = party[i];
party[i] = party[j];
party[j] = t;
}
}
}


for (int i = 0; i < party.Length; i++)
{
for (int j = 0; j < partyDo.Length; j++)
{
if (party[i] == partyDo[j])
playerNum[i] = j + 1;
}
}


for (int i = 0; i < 3; i++)
Console.WriteLine($"{i + 1} место: участник {playerNum[i]}; {party[i]}б.");

Console.WriteLine("-------------------------");
double maxValue = party.Max();
maxValue = maxValue / 2;

for (int i = 3; i < party.Length; i++)
{
if (party[i] >= maxValue)
Console.WriteLine($"МЕДАЛЬОН: участник {playerNum[i]}; {party[i]}б.");
}
Console.WriteLine("Желаете повторить программу? (y/n)");
if (Console.ReadKey(true).Key != ConsoleKey.Y) break;
}

Console.ReadKey();
}
}
}