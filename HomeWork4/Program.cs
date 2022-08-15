using System;

namespace HomeWork4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //2
            Console.WriteLine("Please input size of array");
            int sizeArray = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[sizeArray];
            FillArray(array);
            ArrayInfo(array);
            PrintArray(array);
            BubleSortArray(array);
            PrintArray(array);
            Console.ReadKey();

            //3
            Console.WriteLine("Please input size x:");
            int sizeArrayX = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input size y:");
            int sizeArrayY = Convert.ToInt32(Console.ReadLine());
            int[,] multyArray = new int[sizeArrayX, sizeArrayY];
            FillArray(multyArray);
            ArrayInfo(multyArray);
            PrintArray(multyArray);
            BubleSortArray(multyArray);
            Console.WriteLine();
            PrintArray(multyArray);
            Console.ReadKey();


            //4
            Console.WriteLine("Translater");
            Console.WriteLine("Input word for translate");
            Dictionary<string, string> dic = new Dictionary<string, string>()
            {
                {"monday","понедельник" },
                {"one","один" },
                {"two","два" },
                {"three","три" },
                {"random","случайный" },
                {"read","чтение" },
                {"write","запись" },
                {"find","поиск" },
                {"close","закрыть" },
                {"open","открыть" },
            };

            string letter = Console.ReadLine();
            if (dic.ContainsKey(letter))
            {
                Console.WriteLine(dic.GetValueOrDefault(letter)); // может быть null
            }
            else
                Console.WriteLine("word not found");
            Console.ReadKey();



        }
        public static void FillArray(int[] arr)
        {
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(-100, 100);
            }
        }
        public static void FillArray(int[,] arr)
        {
            Random random = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = random.Next(-100,100) ;
                }
                
            }
        }
        public static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0,4}", arr[i]);
            }
            Console.WriteLine();
        }
        public static void PrintArray(int[,] arr)
        {
            for (int i= 0; i < arr.GetLength(0); i++)
            {
                for(int j=0; j < arr.GetLength(1); j++)
                {
                    Console.Write("{0,4}", arr[i,j]); ;
                }
                Console.WriteLine();
            }
        }
        public static void ArrayInfo(int[] arr)
        {
            int minIntegger;
            int maxIntegger;
            int summ = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                summ += arr[i];
                if (arr[i] > maxIntegger) maxIntegger = arr[i];
                else if (arr[i] < minIntegger) minIntegger = arr[i];
            }
            Console.WriteLine("Array information:");
            Console.WriteLine("Max = {0}", maxIntegger);
            Console.WriteLine("Min = {0}", minIntegger);
            Console.WriteLine("Average = {0}", summ / arr.Length);
            Console.WriteLine("Summ = {0}", summ);
        }
        public static void ArrayInfo(int[,] arr)
        {
            int minIntegger;
            int maxIntegger;
            int summ = 0;
            for (int j = 0; j < arr.GetLength(0); j++)
            {

                for (int i = 0; i < arr.GetLength(1); i++)
                {
                    summ += arr[j,i];
                    if (arr[j,i] > maxIntegger) maxIntegger = arr[j,i];
                    else if (arr[j,i] < minIntegger) minIntegger = arr[j,i];
                }
            }
            Console.WriteLine("Array information:");
            Console.WriteLine("Max = {0}", maxIntegger);
            Console.WriteLine("Min = {0}", minIntegger);
            Console.WriteLine("Average = {0}", summ / arr.Length);
            Console.WriteLine("Summ = {0}", summ);
        }
        public static void BubleSortArray(int[] arr)
        {

            int temp = 0;
            for (int j = 0; j < arr.Length; j++)
            {

                for (int i = 0; i < arr.Length - 1 - j; i++)
                {
                    if (arr[i + 1] > arr[i])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
        }
        public static void BubleSortArray(int[,] arr)
        {
            
            int[] sorted = new int[arr.GetLength(0)*arr.GetLength(1)];
            for (int i = 0;i < arr.GetLength(0); i++)
            {
                for(int j = 0; j<arr.GetLength(1); j++)
                {
                    sorted[j + i* arr.GetLength(1)] = arr[i, j];
                }
            }
            BubleSortArray(sorted);
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = sorted[j + i * arr.GetLength(1)];
                }
            }
            // можно было сделать и по другому :)
            
        }
        
    }
}