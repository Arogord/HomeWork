using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6
{
    internal abstract class FileParser
    {
        internal FileParser(string str)
        {
            FileName = str;
        }
        internal abstract string ParserFormat { get; }
        internal readonly string FileName; 
        internal abstract void Read();
        internal abstract void Open();
        internal abstract void Analize();
        internal abstract void Close();
        internal virtual void Parse() 
        {
            Open(); 
            Read(); 
            Analize(); 
            Close();
        }
        public static FileParser GetParser(string fileName)
        {
            string[] str = fileName.Split('.');
            switch (str[str.Length-1])
                {
                case "xml":
                    return new XmlParser(str[0]);
                case "rtf":
                    return new RtfParser(str[0]);
                case "html":
                    return new HtmlParser(str[0]);
                default:
                    return null;
            }
        }

    }
}
