using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask2
{
    class LABTASK2
    {
        static void Main(string[] args)
        {
            //task 1
            /* for (int i=0;i<=10;i++)
             {
                 int x = i % 2;
                 if (x == 0)
                 {
                     Console.Write(i + " ");
                 }
             }*/



            //task 2
            /* int x = 0;
            for (int i = 0; i < 4; i++)
            {

                for(int j = 0; j <= 5; j++)
                {
                    x = i + j;
                    if (x%2==0)
                    {
                        Console.Write("x");
                    }
                    else
                    {

                        Console.Write("0");
                    }
                }
                Console.WriteLine();
            }*/


            //task 3
            /*int x = 0;
            for (int i = 1; i <=6; i++)
            {
                x = i;

                for (int j = 0; j <= 3; j++)
                {
                   Console.Write(x+j);
                }
                Console.WriteLine();
            }*/



            //task 4
            /*
            int even, odd;
            even = 0;odd = 0;
           for(int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    even +=i; 
                }
                else
                {
                    odd += i;
                }
               
            }
            Console.WriteLine("sum of even number: " + even);
            Console.WriteLine("sum of even number: " + odd);
          */


            //Task 5
            /*
            for(int i = 1; i <= 5; i++)
            {
                for(int j=1;j<=i;j++){
                    if (i == j)
                    {
                        Console.Write(i);

                    }
                    else
                    {
                        Console.Write("  ");
                    }
                
                }
                Console.WriteLine();
            }
            */
            //task 6
            /*
            int fac = 1;
            string s="";
            for(int i = 1; i <= 5; i++)
            {
                fac *= i;
                if (i == 1)
                {
                    s = s + i;
                }
                else
                {
                    s = s + "*" + i;
                }
            }
            Console.WriteLine(s);
            Console.WriteLine("factorial : "+fac);
            */


            //task 7
            /*int n = 5;
            for (int i=0;i<=n;i++)
            {
                for(int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

                
            }
            for(int i=(n-1);i>=1;i--)
            {
                for (int p =1; p<=i; p++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            */


            Console.ReadLine();
        }
    }
}
