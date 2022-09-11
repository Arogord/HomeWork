

namespace HomeWork10_3
{
    internal class Client
    {
        // версия 1
        public void Sender(string mess) // этот метод вызывается из класса CreditCard  и от туда же прилетает аргумент. т.к он подписан на делегат creditCard.RegisterAccountAction(client.Sender);
        {
            
            Console.WriteLine(mess);
            Console.WriteLine("Method Client");
            Console.WriteLine();

        }
    }
}
