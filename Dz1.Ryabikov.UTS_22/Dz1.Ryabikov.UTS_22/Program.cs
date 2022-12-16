using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz1.Ryabikov.UTS_22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введиие A: ");
            double A = float.Parse(Console.ReadLine());
            double B = Math.Pow(A,2);
            Console.WriteLine(B);
            double B1 = Math.Pow(A, 4);
            Console.WriteLine(B1);
            double B2 = Math.Pow(A, 8);
            Console.Write("A^8 = ", B2);
            Console.ReadKey();
        }
    }
}



//class Program
//{
//    const float pi = 3.14f;
//    public static void Main(string[] args)
//    {
//        Console.WriteLine("Станов Степан УТС-22\nДомашнее задание\nВариант 16\n");
//        Console.Write("Введиие значения угла в радианах ar: ");
//        float ar = float.Parse(Console.ReadLine());

//        if ((ar <= 2 * pi) && (ar >= 0))
//        {
//            float ad = ar * (180 / pi);//перевод в фаренгейты
//            Console.Write("Значения угла в градусах ad:         ");
//            Console.WriteLine(string.Format("{0:F3}", ad));
//        }
//        else
//        {
//            Console.WriteLine("Значение угла вне диапазона: [0;2pi].Программа завершит работу");
//        }
//        Console.WriteLine("Для завершения нажмите на любую кнопку");
//        Console.ReadKey();
//    }
//}
