using System;

namespace HomeWork3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            int a = 5;
            int b = 6;
            Console.WriteLine("Before exchange a = {0}, b = {1}", a, b);
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("After exchamge a = {0}, b = {1}", a, b);

            //2
            while (true)
            {
                Console.WriteLine("If you want to exit, please input -1");
                Console.WriteLine("Please input interger x= ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please input interger y= ");
                int y = Convert.ToInt32(Console.ReadLine());
                if (x == -1 || y == -1)
                    break;
                if (x == y)
                    Console.WriteLine("x is equal than y");
                else if (x > y)
                    Console.WriteLine("x is greater than y");
                else
                    Console.WriteLine("y is greater than x");

            }

            //3
            Console.WriteLine("Please input integger //3");
            string z = Console.ReadLine();
            for(int i = 0; i < (z.Length) / 2 + 1; i++)
            {
                if(z[i] != z[z.Length - 1 - i])
                {
                    Console.WriteLine("Integger is not polidrom");
                    break;
                }
                if(i == z.Length/2)
                {
                    Console.WriteLine("Integger is  polidrom");
                }
                    

            }

        }
    }
}