using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number to check if its numbers up to n, are multiples of 3 and 5 \n ");
        int a = Convert.ToInt32(Console.ReadLine());
        FizzBuzz(a);
    }


    static int IsMul(int i)
    {
            if ((i % 5 == 0) && (i % 3 == 0))
            return 1;
       else  if (i % 3 == 0)
            return 2;
        else if (i % 5 == 0)
            return 3;
        else
            return 4;

    }
    public static void FizzBuzz(int n)
    {
        int multiple = n;

        for (int i = 1; i < multiple + 1; i++)
        {
            if (IsMul(i) == 1)
                Console.WriteLine("FizzBuzz");
            else if (IsMul(i) == 2)
                Console.WriteLine("Fizz");
            else if (IsMul(i) == 3)
                Console.WriteLine("Buzz");
            else
                Console.WriteLine(i);
        }
    }
}