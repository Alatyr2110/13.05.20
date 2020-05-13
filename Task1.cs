using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
        partial class Homework4
        {
        //ТАРАНУХА ЯНА
            private const string V = "[{0, 2}]";

            public static void Task1()
            {
                /*
                Дан целочисленный массив из 20 элементов. 
                Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно. 
                Написать программу, позволяющую найти и вывести количество пар элементов массива, 
                в которых хотя бы одно число делится на 3. В данной задаче под парой подразумевается 
                два подряд идущих элемента массива. 
                Например, для массива из пяти элементов: 6; 2; 9; –3; 6 – ответ: 4.
                */

                {
                    //Объявление массива длинной 20 элементов с минимальным и максимальным значениями 
                    MyArray myArray = new MyArray(20, -10000, 10000);
                    Console.WriteLine(myArray.ToString());
                    myArray.Divisibility3();
                    Console.ReadLine();
                }
            }
            public class MyArray
            {
                //Приватное поле-массив класса Array 
                private int[] am;

                //Конструктор массива с заполением случаяными числами 
                public MyArray(int n, int min, int max)
                {
                    am = new int[n];
                    Random rnd = new Random();
                    for (int i = 0; i < am.Length; i++)
                        am[i] = rnd.Next(min, max);
                }

                //Метод подсчета пар чисел, которые делятся на 3
                public int Divisibility3()
                {
                    int i = 0;
                    int c = 0;
                    while (i < 20)
                    {
                        if (am[i] % 3 == 0 & am[i + 1] % 3 == 0)
                        {
                            Console.WriteLine("{0} и {1}", am[i], am[i + 1]);
                            c++;
                        }
                        else
                            Console.WriteLine("В этой паре нет");
                        i = i + 2;
                    }
                    Console.WriteLine("Количество пар, делящихся на три:  " + c);
                    Console.WriteLine("Общее количество пар:  " + i / 2);
                    return i;
                }

                //Метод вывода массива на консоль
                override public string ToString()
                {
                    string stringarray = "";
                    foreach (int x in am)
                        stringarray = stringarray + x + " ";
                    return stringarray;
                }
            }
        }
    }



    /*//Если в массиве оказались одинаковые цифры
    Tuple<int, int> t = null;
    int?[] idx = new int?[101];

     for (i = 0; i < am.Length; i++)
     {
         if (idx[am[i]].HasValue)
         {
             t = Tuple.Create(idx[arr[i]].Value, i);
         }
         idx[am[i]] = i;
     }
     Console.WriteLine(t == null ? "Нет такого числа" : $"{t} = {am[t.Item1]}");


Console.ReadKey();*/


