//Программа определяющая какое число больше
using System;
class Sample
{
    public static void Main(){
          int a, b, max;
        Console.Write ("Введите число a ");
        a=int.Parse(Console.ReadLine());
        Console.Write ("Введите число b ");
        b=int.Parse(Console.ReadLine());
            max=0;

 
            if (a>b)
            {
                max=a;

            }
            else
            {
                 max=b;

            }
                Console.WriteLine($"max= {max}");
    }
    }
