
namespace HomeWork6
{
    internal class HtmlParser : FileParser
    {
        public HtmlParser(string str) : base(str)
        {
        }
        internal override string ParserFormat
        {
            get => ".Html";
        }

        internal override void Analize()
        {
            Console.WriteLine($"{nameof(HtmlParser)}: file {FileName}, Analiz");
        }

        internal override void Close()
        {
            Console.WriteLine($"{nameof(HtmlParser)}: file {FileName}, Closed");
        }

        internal override void Open()
        {
            Console.WriteLine($"{nameof(HtmlParser)}: file {FileName}, Opened");
        }

        internal override void Read()
        {
            Console.WriteLine($"{nameof(HtmlParser)}: file {FileName}, Reading");
        }
    }
}
