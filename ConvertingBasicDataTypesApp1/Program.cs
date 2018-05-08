using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertingBasicDataTypesApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // преобразование базовых типов
            byte a = 4; // 1 байт
            byte b = (byte)(a + 70); // переменные типа byte/short/int; a+70 результат 4 байта
                                     // сужаюющее преобразование   
            Console.WriteLine(b);

            byte a1 = 4;
            short b1 = (short)(a1 + 70); // 2 байта
            Console.WriteLine(b1);

            byte a2 = 4; // 1 байт
            int b2 = a2 + 70; // 1 байт в 4 байта - расширяющее преоразование
                              
            Console.WriteLine(b2);

            // не нужно преобразовывать от
            // byte - short - int - long - decimal
            // byte - short - int - double
            // byte - short - float - double
            // char - int 

            double d1 = 33.0;
            decimal d2 = (decimal)d1;
            Console.WriteLine(d2);

            // недопустить переполнение

            try
            {
                int a3 = 33;
                int c = 600;
                byte b3 = checked((byte)(a3 + c));
                Console.WriteLine(b3);
            }
            catch(OverflowException)
            {
                Console.WriteLine("Недопустимый диапазон");
            }                     
                       
            Console.ReadKey();
        }
    }
}
