

namespace HomeWork6
{
    internal class XmlParser : FileParser
    {
        public XmlParser(string str) : base(str)
        {
        }

        internal override string ParserFormat 
        { 
            get => ".xml"; 
        }

        internal override void Analize()
        {
            Console.WriteLine($"{nameof(XmlParser)}: Файл {FileName}, Analiz");
        }

        internal override void Close()
        {
            Console.WriteLine($"{nameof(XmlParser)}: Файл {FileName}, Closed");
        }

        internal override void Open()
        {
            Console.WriteLine($"{nameof(XmlParser)}: Файл {FileName}, Opened");
        }

        internal override void Read()
        {
            Console.WriteLine($"{nameof(XmlParser)}: Файл {FileName}, Reading");
        }
    }
}
