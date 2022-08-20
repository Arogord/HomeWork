using System.Text;
namespace HomeWork5
{
    public class CurrencyConverter
    {
        List<ExchangeRate> ExchangeRates;
        
        public CurrencyConverter()
        {
            ExchangeRates = new List<ExchangeRate>();
        }

        public void AddExchangeRate(ExchangeRate ex)
        {
            ExchangeRates.Add(ex);
        }
        public void AddExchangeRates(ExchangeRate[] ex) 
        { 
            foreach(ExchangeRate ex2 in ex)
            {
                ExchangeRates.Add(ex2);
            }
        }



        public bool TryDeleteExchangeRate(Currencies firstCurrency, Currencies secondCurrency)
        {
            if(FindExchangeRate(firstCurrency, secondCurrency) != null)
            {
                ExchangeRates.Remove(FindExchangeRate(firstCurrency, secondCurrency));
                return true;
            }else return false;
              //
        } //– попытка найти и удалить ExchangeRate из ExchangeRates;

        public ExchangeRate FindExchangeRate(Currencies firstCurrency, Currencies secondCurrency)
        {
            foreach (ExchangeRate ex in ExchangeRates)
            {
                if((ex.FirstCurrency==firstCurrency && ex.SecondCurrency == secondCurrency) || (ex.FirstCurrency == secondCurrency) &&(ex.SecondCurrency == firstCurrency))
                {
                    return ex;
                }
            }
            return null;

        } //поиск в ExchangeRates;

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach(ExchangeRate exchangeRate in ExchangeRates)
            {
                sb.Append(exchangeRate);
                sb.Append('\n');
            }
            return sb.ToString();
        }//– метод должен выводить список всех курсов,
        // которые хранятся в ExchangeRates (необходимо использовать StringBuilder и цикл foreach);

        public ExchangeRate Convert(Currencies CurrencyFirst, Currencies CurrencySecond, int count)
        {
            ExchangeRate exchangeFind = FindExchangeRate(CurrencyFirst, CurrencySecond);
            ExchangeRate exchange;
            if (exchangeFind != null)
            {
                exchange = new ExchangeRate(CurrencyFirst, CurrencySecond, count);
                if (exchangeFind.FirstCurrency == CurrencyFirst && exchangeFind.SecondCurrency == CurrencySecond)
                {
                    exchange.CurrencyCount = count;
                    exchange.Value = exchangeFind.Value * count;
                }
                else
                {
                    exchange.CurrencyCount = count;
                    exchange.Value = 1/exchangeFind.Value * count;
                }
                return exchange;
            }
            else
            {
                return null;
            }
            
        }
        // – метод выполняет поиск поиск нужного ExchangeRate в List<ExchangeRate>,
        // делает конвертацию валют и возвращает новый ExchangeRate с установленными
        // FirstCyrrency, SecondCurrency, Value, Count.
    }
}
