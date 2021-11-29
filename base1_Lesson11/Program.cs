using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace base1_Lesson11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Введите коэффициенты - действительные числа k,b для расчета линейного уравнения 0=k*x+b");
            Console.Write(" k= ");
            string input1 = Console.ReadLine();
            Console.Write(" b= ");
            string input2 = Console.ReadLine();
            double expect1, expect2;
            if ((!double.TryParse(input1, out expect1)) | (!double.TryParse(input2, out expect2)))
            {
                Console.Write(" Ошибка ввода! Формат числа не верен. Прерывание!");
            }
            else
            {
                Calc xRes = new Calc { k = expect1, b = expect2 };
                xRes.Root();
            }
            Console.ReadKey();
        }
        struct Calc
        {
            internal double k;
            internal double b;
            public double x;
            public const int c = 0;

            public void Root()
            {
                if (k != 0)
                {
                    x = c - (b / k);
                    Console.WriteLine(" х= {0}", x);
                }
                else
                {
                    Console.WriteLine(" Ошибка! Деление на 0!");
                }
            }
        }
    }
}
