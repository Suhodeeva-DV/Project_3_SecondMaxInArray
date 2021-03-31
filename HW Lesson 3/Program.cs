using System;

namespace HW_Lesson_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество чисел в массиве: ");
            int arraySize = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Введите числа массива через пробел: ");

            int[] array = new int[arraySize];
            array = FillingArray(arraySize);

            int secondMax = SecondMax(arraySize, array);
            Console.WriteLine ($"Второй макимум в массиве: {secondMax}");

        }

        public static int[] FillingArray(int sizeTheory)
        {
            string str = "";
            string[] arrayStr;

            str = Console.ReadLine();
            arrayStr = str.Split(' ');

            while (!(sizeTheory == arrayStr.Length))
            {
                Console.WriteLine("Число введеных элементов не равно заявленному размеру массива! Пожалуйста, введите массив ещё раз");
                str = Console.ReadLine();
                arrayStr = str.Split(' ');
            } 
            
            int[] arrayNum = new int[arrayStr.Length];

            for (int i = 0; i < arrayStr.Length; i++)
            {
                if (!int.TryParse(arrayStr[i], out arrayNum[i]))
                {
                    Console.WriteLine("Массив содержит некорректный элемент!");
                    Environment.Exit(0);
                }
            }

            return arrayNum;
        }

        public static int SecondMax (int size, int[] array)
        {
            int max1 = array[0];
            int max2 = -2000000000;

            for (int i = 0; i < size; i++)
            {
                if (array[i] > max1)
                {
                    max2 = max1;
                    max1 = array[i];
                }
                else if ((array[i] > max2) && (array[i] < max1))
                {
                    max2 = array[i];
                }
            }
            return max2;
        }
    }
}
