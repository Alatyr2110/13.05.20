using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
    //ТАРАНУХА ЯНА
{
    /*
2. а) Дописать класс для работы с одномерным массивом. 
Реализовать конструктор, создающий массив заданной размерности 
и заполняющий массив числами от начального значения с заданным шагом. 
Создать свойство Sum, которые возвращают сумму элементов массива, 
метод Inverse, меняющий знаки у всех элементов массива, 
метод Multi, умножающий каждый элемент массива на определенное число, 
свойство MaxCount, возвращающее количество максимальных элементов. 
В Main продемонстрировать работу класса
*/
    partial class Homework4
    {
        public static void Task2()
        {
            Console.Write("Введите длину массива: ");
            string s = Console.ReadLine();
            int n = Convert.ToInt32(s);

            Console.Write("Введите первое число массива: ");
            string s1 =Console.ReadLine();
            int p = Convert.ToInt32(s1);

            Console.Write("Введите шаг: ");
            string s2 = Console.ReadLine();
            int h = Convert.ToInt32(s2);



            int[] myInts = new int[n];
            int[] myInts1 = new int[n];
            int[] myInts2 = new int[n];
           

            int i = 0;
            myInts[0] = p;
            i = i + 1;

            while (i < myInts.Length)
            {
                myInts[i] = myInts[i-1] + h;
                i++;
            }
            foreach (int x in myInts)
                Console.Write("{0, 5}", x);
                Console.WriteLine();

            int Sum = 0;
            i = 0;
            while (i < myInts.Length)
            {
                Sum = Sum + myInts[i];
                i++;
            }
            Console.Write("Сумма всех чисел:   " + Sum);
            Console.WriteLine();

            //метод Inverse
            //void Inverse(int n, int[] myInts)
            {
                for (i = 0; i < myInts1.Length; i++)
                    if (myInts[i] > 0) myInts1[i] = -1 * myInts[i];
            }
            foreach (int z in myInts1)
                Console.Write("{0, 5}", z);
                Console.WriteLine();

            //метод Multi
            Console.Write("Введите множитель: ");
            string s3 = Console.ReadLine();
            int d = Convert.ToInt32(s3);
            {
                for (i = 0; i < myInts2.Length; i++)
                    if (myInts[i] != 0) 
                        myInts2[i] = d * myInts[i];
            }
            foreach (int q in myInts2)
                Console.Write("{0, 5}", q);
                Console.WriteLine();

            //свойство MaxCount
            i = 0;

            int MaxNum = myInts[0];
            int w = 0;
            {
                while (i < myInts.Length)
                    if (myInts[i] > MaxNum)
                    {
                        MaxNum = myInts[i];
                        i++;
                        w++;
                    }
                    else
                    {
                        MaxNum = myInts[i];
                        i++;
                    }
            }
                Console.WriteLine("Количество максимальных элементов относительно первого:   " + w);
                Console.WriteLine();
                Console.ReadKey();
        }
    }
}
