
namespace HomeWork6
{
    internal class RtfParser : FileParser
    {
        public RtfParser(string str) : base(str)
        {
        }
        internal override string ParserFormat
        {
            get => ".Rtf";
        }

        internal override void Analize()
        {
            Console.WriteLine($"{nameof(RtfParser)}: file {FileName}, Analiz");
        }

        internal override void Close()
        {
            Console.WriteLine($"{nameof(RtfParser)}: file {FileName}, Closed");
        }

        internal override void Open()
        {
            Console.WriteLine($"{nameof(RtfParser)}: file {FileName}, Opened");
        }

        internal override void Read()
        {
            Console.WriteLine($"{nameof(RtfParser)}: file {FileName}, Reading");
        }
    }
}
