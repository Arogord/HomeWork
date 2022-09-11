namespace HomeWork10_3
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Delegates:");
            Console.WriteLine();
            CreditCard creditCard = new CreditCard();
            Client client = new Client();
            creditCard.RegisterAccountAction(client.Sender); //подписка на делегат через метод
            creditCard.Put(10); // выполняется метод в классе Client, аргумент прилетает из метода Put после подписки на RegisterAccountAction из класса creditCard
            creditCard.Get(20);
            creditCard.Get(10);
            creditCard.RegisterAccountAction(delegate (string abc) { Console.WriteLine($"anonym {abc}"); });
            creditCard.RegisterAccountAction((string say) => Console.WriteLine($"lambda {say}"));
            creditCard.Put(10); //аргумент летит из метода put в класс Client, и в анонимный и в лямбду


            Console.WriteLine();
            Console.WriteLine("Events:");
            Console.WriteLine();
            CreditCard2 creditCard2 = new CreditCard2();
            Client client2 = new Client();
            creditCard2.accountAction += client2.Sender; //подписка на событие
            creditCard2.Put(111); // выполняется метод в классе Client, аргумент прилетает из метода Put после подписки на RegisterAccountAction из класса creditCard
            creditCard2.Get(221);
            creditCard2.Get(180);
            creditCard2.accountAction += delegate (string abc) { Console.WriteLine($"anonym {abc}"); };
            creditCard2.accountAction += (string say) => Console.WriteLine($"lambda {say}");
            creditCard2.Put(11);
            
            //

        }   

    }
}
