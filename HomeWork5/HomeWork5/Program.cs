namespace HomeWork5
{
    public class Program
    {
        static void Main()
        {
            CurrencyConverter currencyConverter = new CurrencyConverter();

            //Заполнение массива случайных валют случайными числами
            Random random = new Random();
            int[,] numbers = new int[10, 3];
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                
                numbers[i, 2] = random.Next(50, 200);
                do
                {
                    numbers[i, 0] = random.Next(0, numbers.GetLength(0));
                    numbers[i, 1] = random.Next(0, numbers.GetLength(0));
                }
                //Не может быть курса USD/USD и в дополнение защита от ненужного обратного курса, например USD/EUR и EUR/USD
                while ((numbers[i, 0] == numbers[i, 1]) || (!(currencyConverter.FindExchangeRate((Currencies)numbers[i, 0], (Currencies)numbers[i, 1]) == null)));
                
                ExchangeRate ex = new((Currencies)numbers[i, 0], (Currencies)numbers[i, 1], (float)numbers[i, 2] / 100);
                currencyConverter.AddExchangeRate(ex);
            }

            //   - Отображать пользователю имеющиеся курсы 
            Console.WriteLine("Валютные пары с которыми мы работаем:");
            Console.WriteLine(currencyConverter);
            //   -Конвертировать валюты и отображать полученный результат

            while (true)
            {
                Console.WriteLine("Введите жеалему валюту для перевода");
                string bablo1 = Console.ReadLine();
                Console.WriteLine("Введите в какую валюту перевести");
                string bablo2 = Console.ReadLine();
                Console.WriteLine("Введите сумму для перевода");
                int howMoney = Convert.ToInt32(Console.ReadLine());

                Currencies value1;
                Currencies value2;
                if(Enum.TryParse(bablo1, out value1) && Enum.TryParse(bablo2, out value2)) 
                {
                    if (currencyConverter.Convert(value1, value2, howMoney) == null)
                    {
                        Console.WriteLine("Банк не работает с такими валютными парами, обратитесь к чувачку за углом");
                        break;
                    }
                    else
                    {
                        Console.WriteLine(currencyConverter.Convert(value1, value2, howMoney));
                        Console.WriteLine("Приходите еще, наши курсы вас удивят :)");
                        break;
                    }
                };
                
            }
        }
    }
}
