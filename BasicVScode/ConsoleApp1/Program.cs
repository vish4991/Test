using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        delegate int delegatecheck(int num, int num2);

        static int add  (int a, int b){
            return a+b;
        }

        static int sub (int a, int b){
            return a-b;
        }
        // static void Main(string[] args)
        // {
        //     delegatecheck addch= new delegatecheck(add);
        //     delegatecheck subch= new delegatecheck(sub);
        //     string fname= Console.ReadLine();
        //     Console.WriteLine("enter the num");
        //     int num1=Convert.ToInt32(Console.ReadLine());
        //     switch (num1){
        //         case 1:
        //         Console.WriteLine(addch(1,2));
        //         break;
        //         case 2: 
        //         System.Console.WriteLine("invalid input");
        //         break;
        //     }

            
        }
    }
}
