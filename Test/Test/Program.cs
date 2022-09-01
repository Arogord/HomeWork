using System.Runtime.InteropServices;

namespace Test
{
    public class Program
    {
        public static void Main()
        {
            
            // variant 1
            using(MyFileStream fs = new MyFileStream()) 
            {
            }
            // variant 2
            MyFileStream fs2 = new MyFileStream();
            try
            {

            }
            finally
            {
                fs2.Dispose();
            }
        }
    }
    public class MyFileStream : IDisposable
    {
        private readonly IntPtr _handle;
        public void Dispose()
        {
            Marshal.FreeHGlobal(_handle);
        }
    }
}
