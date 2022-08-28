using HomeWork6;
using System;
namespace HomeWork
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Please enter the file name in the format: [file_name].[format]. format can be: xml,rtf,html.");
            string fileName = Console.ReadLine();
            if (FileParser.GetParser(fileName) != null)
            {
                FileParser.GetParser(fileName).Parse();
            }
            else
            {
                Console.WriteLine("This format is not supported");
            }

        }
    }
     
}
