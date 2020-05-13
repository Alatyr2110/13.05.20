using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Switch
    //ТАРАНУХА ЯНА
{
    /*
 Решить задачу с логинами из предыдущего урока, 
 только логины и пароли считать из файла в массив. 
 Создайте структуру Account, содержащую Login и Password.
*/

    partial class Homework4
    {
        public static void Task3()
        {
            string[] array;
            array = new string[2];
            array = new string[] {"root", "GeekBrains"};

            string s1 = null;
            string s2 = null;

            string[] arrayUser;
            arrayUser = new string[2];
           // arrayUser = new string[] {"s1", "s2"};


            for (int d = 0;  d < 3; d++)
            {
                Console.Write("Введите логин: ");
                s1 = Console.ReadLine();

                Console.Write("Введите пароль: ");
                s2 = Console.ReadLine();

                arrayUser = new string[] {s1, s2};

                if (array[0] == arrayUser[0])
                {
                   if (array[1] == arrayUser[1])
                   {
                        Console.Write("Все верно");
                        Console.WriteLine();
                        Console.ReadKey();
                   }
                
                break;
                }
                else
                {
                    int a = 2 - d;

                    Console.Write("Осталось попыток   " + a);
                    Console.WriteLine();
                    Console.ReadKey();
                }
               
            }

        }
    }
}
