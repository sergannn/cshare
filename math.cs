using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace света
{
    public class math
    {

            public static void Main() {
                Console.WriteLine(ConvertTo2("199"));
                   Console.WriteLine(convertTo10());

            }

        public static string ConvertTo2(string num, int round = 5)
        {
            string result = ""; //Результат
            int left = 0; //Целая часть
            string right = "0"; //Дробная часть
            string[] temp1 = num.Split(new char[] { '.', ',' }); //Нужна для разделения целой и дробной частей
            left = Convert.ToInt32(temp1[0]);
            //Проверяем имеется ли у нас дробная часть
            if (temp1.Count() > 1)
            {
                right = num.Split(new char[] { '.', ',' })[1]; //Дробная часть
            }
            //Алгоритм перевода целой части в двоичную систему
            while (true)
            {
                result += left % 2; //В ответ помещаем остаток от деления. В конце программы мы перевернём строку, так как в обратном порядке записываются остатки
                left = left / 2; //Так как Left целое число, то при делении например числа 2359 на 2, мы получим не 1179,5 а 1179
                if (left == 0)
                    break;
            }
            result = new string(result.ToCharArray().Reverse().ToArray()); //Реверсирование строки
            
            //Прокеряем есть ли у нас дробная часть, можно было бы проверить и так if(temp1.count()>1)
            if (Convert.ToInt32(right) == 0)
                return result;
 
            //Добавляем разделить целой части от дробной
            result += '.';
 
            int count = right.ToString().Count(); // Нам нужно знать кол-во цифр, при превышении которого дописывается единичка
            int INTright = Convert.ToInt32(right);
 
            for (int i = 0; i < round; i++)
            {
                /*Умножаем число на 2 и проверяем, стало ли оно больше по количеству цифр, если да,
                то в результат идёт "1" и первая цифра у right удаляется */
                INTright = INTright * 2;
                if (INTright.ToString().Count() > count)
                {
                    string buf = INTright.ToString();
                    buf = buf.Remove(0, 1);
                    INTright = Convert.ToInt32(buf);
 
                    result += '1';
                }
                else
                {
                    result += '0';
                }
            }
            return result;
        }
        public static int convertTo10() {
            Console.Write("\nBinary Number: ");
      String Number = Console.ReadLine();
      Int32 DecimalNumber = 0;
 
      for (int i = 0; i < Number.Length; i++)
      {
         if (Number[Number.Length - i - 1] == '0') continue;
         DecimalNumber += (int)Math.Pow(2, i);
      }
      Console.WriteLine("Decimal Number: " + DecimalNumber);
      Console.WriteLine();
      return DecimalNumber;
        }
    }
}