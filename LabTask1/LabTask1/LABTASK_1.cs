using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask1
{
    class Program
    {
        static void Main(string[] args)
        {  //task1
            Console.WriteLine("hello");
            Console.WriteLine("Kawsar Hamid");


            //task2
            int x, y;
            x = 12;
            y = 10;
            Console.WriteLine("sum: "+(x+y));
            

            //task3
            x = 10;
            y = 5;
            Console.WriteLine("divide: "+(x/y));


            //task4
            Console.WriteLine("a. - 5 + 8 * 6 = "+(-5 + 8 * 6));
            Console.WriteLine("b. (55 + 9) % 9 = "+ ((55 + 9) % 9));
            Console.WriteLine("c. 20 + -3 * 5 / 8 = "+(20 + -3 * 5 / 8));
            Console.WriteLine("d. 5 + 15 / 3 * 2 - 8 % 3 = "+(5 + 15 / 3 * 2 - 8 % 3));

            //task5
            Console.WriteLine(" addition : "+(x+y));
            Console.WriteLine(" multiply : " + (x * y));
            Console.WriteLine(" subtract : " + (x - y));
            Console.WriteLine(" divide: " + (x / y));
            Console.WriteLine(" remainder " + (x % y));


            //task6
            Console.WriteLine("((25.5 * 3.5 - 3.5 * 3.5) / (40.5 - 4.5)) ="+ ((25.5 * 3.5 - 3.5 * 3.5) / (40.5 - 4.5)));

            //task7
            /* Width = 5.5 Height = 8.5
 Sample Output:
 Area is 5.6 * 8.5 = 47.60
 Perimeter is 2 * (5.6 + 8.5) = 28.20*/
            double width = 5.5;
            double Height = 8.5;
            Console.WriteLine("Area is 5.6 * 8.5 = " + (5.6 * 8.5));
            Console.WriteLine("Perimeter is 2 * (5.6 + 8.5) = " + (2 * (5.6 + 8.5)));
            Console.ReadLine();


        }
    }
}
