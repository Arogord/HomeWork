
namespace HomeWork10_2
{
    public class Program
    {
        public static void Main()
        {
            int num = 1;
            TimerCallback tm = new TimerCallback(Count);
            Timer timer = new Timer(tm,num,2000,1000);
            TimerCallback tm2 = new TimerCallback(DeathTimer);
            Timer timerof = new Timer(tm2, null, 6000, 0);

            
            

            
            Console.ReadLine();

            void Count(object obj)
            {
                int x = (int)obj;
                Console.WriteLine($"{x}");
                
            }
            void DeathTimer(object obj)
            {
                Console.WriteLine("Timer is death");
                timer.Dispose();
            }
        }
    }
}