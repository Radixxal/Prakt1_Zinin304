using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prakt1_Zinin304
{
    class Program
    {
        
        private static void FourNubersEqual(int a, int b, int c, int d)
        {
            
            if(a == b && b == c && c == d) { Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("The numbers are Equal"); }
            else { Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("The numbers are NOT equals"); }
            
        }

        private static void ArrayMaxMin(int[] array, int b)
        {
            for(int i = array.Length - b; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }    
        }

        private static void ArrayAvg(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == Math.Round(array.Average())) { Console.WriteLine(array[i].ToString()); return; }
            }
        }

        private static void ArrayAvgMax(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] > Math.Round(array.Average())) { Console.WriteLine(array[i].ToString()); }
            }
        }

        private static void Mult(int n1, int n2)
        {
            int res = 0;
            for (int i = 0; i < n2; i++)
            {
                res += n1;
            }

            Console.WriteLine(res);
        }

      


        static void Main(string[] args)
        {
            // Проверка 4 чисел на равенство (Задание 2)
            Console.Write("Число 1: "); int a = int.Parse(Console.ReadLine());
            Console.Write("Число 2: "); int b = int.Parse(Console.ReadLine());
            Console.Write("Число 3: "); int c = int.Parse(Console.ReadLine());
            Console.Write("Число 4: "); int d = int.Parse(Console.ReadLine());
            FourNubersEqual(a, b, c, d);
            Console.ForegroundColor = ConsoleColor.White;
            /////////////////////////////////////////////
            
            // k Самых больших значений в массиве (Задание 3)
            Console.Write("Задайте размер массива: "); int arraysize = int.Parse(Console.ReadLine());
            Console.Write("Задайте k самых больших элементов в массиве"); int k = int.Parse(Console.ReadLine());

            int[] array_test = new int[arraysize];

            for (int i = 0; i < array_test.Length; i++ )
            {
                Console.Write($"Задайте значение {i} элемента массива: ");
                array_test[i] = int.Parse(Console.ReadLine());
            }

            // Массив сортируется по возрастанию
            Array.Sort(array_test);

            // Узнаем максимальное 
            Console.WriteLine($"{k} наибольших значений массива:");
            ArrayMaxMin(array_test, k);

            Console.Write("Задайте k самых МЕНЬШИХ элементов в массиве"); k = int.Parse(Console.ReadLine());


            // Элементы массива меняют свой порядок на противоположный (убывание)
            Array.Reverse(array_test);

            // Узнаем наименьшие
            Console.WriteLine($"{k} наименьших значений массива:");
            ArrayMaxMin(array_test, k);

            // Узнаем среднее
            Console.WriteLine("Среднее значение массива:");
            ArrayAvg(array_test);

            // Узнаем значения массива, которые превышают среднее значение
            Console.WriteLine("Значения, превышающие среднее");
            ArrayAvgMax(array_test);

            // Умножение
            Console.Write("Первое число:"); int n1 = int.Parse(Console.ReadLine());
            Console.Write("Второе число (множитель):"); int n2 = int.Parse(Console.ReadLine());
            Mult(n1, n2);

            // Разбиение массива на четные числа первыми и нечетные вторым



            // Фаренгейта в Цельсия
            Console.Write("Напишите градусы в Фаренгейтах: ");
            double s = Double.Parse(Console.ReadLine());
            s = (s - 32) / 1.8000;
            Console.WriteLine($"В градусах цельсия это: {s}");

            // ИМТ
            Console.Write("Ваш вес:");
            double w = Double.Parse(Console.ReadLine());
            Console.Write("Ваш рост:");
            double h = Double.Parse(Console.ReadLine());

            Console.WriteLine($"Индекс массы тела равен: {w / h}");

            // Степень 2-4
            Console.Write("Дайте число, быстро!: ");
            s = Double.Parse(Console.ReadLine());

            for (int i = 0; i < 3; i++) { s *= s; Console.WriteLine(s); }

            // Треугольник
            int s1, s2, s3;
            Console.Write("1 Сторона: ");
            s1 = int.Parse(Console.ReadLine());
            Console.Write("2 Сторона:: ");
            s2 = int.Parse(Console.ReadLine());
            Console.Write("3 Сторона:: ");
            s3 = int.Parse(Console.ReadLine());

            if(s1 + s2 > s3 && s1 + s3 > s2 && s2 + s3 > s1)
            {
                Console.WriteLine("Стороны могут образовать треугольник)");
            }
            else { Console.WriteLine("Стороны НЕ могут образовать треугольник("); }

        }


    }
}
