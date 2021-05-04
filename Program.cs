using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkipinSumma
{
    class Program

        //Скипин Михаил подсчитать сумму всех нечетных чисел

    {
        
        static void Main(string[] args)
        {
            int summ = 0;
            int num = 0;
            Console.WriteLine("Добро пожаловать в програамму подсчета нечетных чисел. После каждого введенного числа нажмите клавишу Enter." +
                "Ввод закончите цифрой ноль.");
            do
            {
                
                num = int.Parse(Console.ReadLine());
                if (num > 0 && num % 2 == 1)
                {
                    summ += num;
                }
            } while (num != 0);

            Console.WriteLine("Сумма нечетных чисел: " + summ);
            Console.ReadKey();

        }


    }
    
}
