namespace HomeWork11_2
{
    class Program
    {
        public static void Main()
        {
            MyDictionary<int, string> dictionary = new MyDictionary<int, string>();
            dictionary.Add(1, "Raptor");
            dictionary.Add(2, "Tirex");
            dictionary.Add(5, "Plesiosaur");
            dictionary.PrintAllKeys();
            try
            {
                Console.WriteLine($"Value is: {dictionary.GetValue(1)}");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Key not found");
            }
            dictionary.Remove(2);
            dictionary.Remove(3);
            dictionary.PrintAllKeys();
        } 
    }
}