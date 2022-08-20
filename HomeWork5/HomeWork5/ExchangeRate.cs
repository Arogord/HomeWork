
namespace HomeWork5
{
    public class ExchangeRate
    {
        public ExchangeRate(Currencies FirstCurrency, Currencies SecondCurrency)
        {
            this.FirstCurrency = FirstCurrency;
            this.SecondCurrency = SecondCurrency;
        }
        public ExchangeRate(Currencies FirstCurrency, Currencies SecondCurrency, float Value) : this(FirstCurrency, SecondCurrency)
        {
            this.Value = Value;
        }

        public Currencies FirstCurrency;
        public Currencies SecondCurrency;
        public float Value { get; set; }
        public int CurrencyCount { get; set; } = 1;

        
        public override string ToString()
        {
            string str = $"{CurrencyCount:f2} { FirstCurrency} = { Value:f2} { SecondCurrency}";
            return str;
        }                                                                        
        
    }
}
