

namespace HomeWork10_3
{
    internal class CreditCard
    {
        public delegate void AccountAction(string str);
        private AccountAction? accountAction; 
        private int cash = 0;
        
        public void RegisterAccountAction(AccountAction accountAction)
        {
            this.accountAction += accountAction; //через эту переменную вызывается подписаный внешний метод  и получает аргумент.
        }
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
