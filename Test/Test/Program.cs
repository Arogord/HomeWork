using System.Runtime.InteropServices;

namespace Test
{
    public class Program
    {
        public static void Main()
        {
            Some<int> som = new Some<int>();
            Some<int>.staticvalue = 10;
            
        }
        
        
    }
    public class Some<T>
    {
        public T value;
        public static T staticvalue;
        static Some()
        {
            Console.WriteLine("static ctor");
        }
    }
    
}
