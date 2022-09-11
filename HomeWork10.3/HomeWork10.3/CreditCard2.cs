

namespace HomeWork10_3
{
    internal class CreditCard2
    {
        public delegate void AccountAction(string str);

        public event AccountAction? accountAction;
        
        private int cash = 0;
        
        public void Put(int val)
        {
            cash += val;
            accountAction?.Invoke($"You load {val}");
            //Console.WriteLine($"You load {val}");
        }
        public void Get(int val)
        {
            if (val > cash)
            {
                accountAction?.Invoke("No many");

            }
            else
            {
                accountAction?.Invoke($"Here is your many {val}");
            }
        }
    }
}
