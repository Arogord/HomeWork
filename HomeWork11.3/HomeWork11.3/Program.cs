using HomeWork11_3;
using System.Linq.Expressions;
using System.Text.Json;
using System.Xml.Serialization;
using Newtonsoft;
using Newtonsoft;

namespace HomeWork11_3
{
    class Program
    {
        public static void Main()
        {
            Shape[] shapes = new Shape[3];

            shapes[0] = new Shape();
            shapes[0].Name = "Cirle";
            shapes[0].ShapePoint.X = 10.5F;
            shapes[0].ShapePoint.Y = 8.5F;
            shapes[0].Height = 5.5F;
            shapes[0].Length = shapes[0].Height;

            shapes[1] = new Shape();
            shapes[1].Name = "Cube";
            shapes[1].ShapePoint.X = 1.5F;
            shapes[1].ShapePoint.Y = 1.5F;
            shapes[1].Height = 8.5F;
            shapes[1].Length = shapes[1].Height;

            shapes[2] = new Shape();
            shapes[2].Name = "Dot";
            shapes[2].ShapePoint.X = 19.5F;
            shapes[2].ShapePoint.Y = 19.5F;
            shapes[2].Height = 0F;
            shapes[2].Length = shapes[2].Height;



            Console.WriteLine("Please input file name for serialise Json");
            string filename = Console.ReadLine();
            filename += ".json";
            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                JsonSerializer.Serialize(fs, shapes);
                Console.WriteLine("Serialize is comleat");
            }

            Console.WriteLine("Please input file name for deserialise Json");
            filename = Console.ReadLine();
            filename += ".json";
            try
            {
                using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
                {
                    Shape[]? deserialeseShapeJson = JsonSerializer.Deserialize<Shape[]>(fs);
                    Console.WriteLine("Deserialize Json is compleat");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong, maybe there is no such file.");
            }


            Console.WriteLine("Please input file name for serialise Xml");
            string filename2 = Console.ReadLine();
            filename2 += ".xml";
            XmlSerializer serializer = new XmlSerializer(typeof(Shape[]));
            using (FileStream fs = new FileStream(filename2, FileMode.OpenOrCreate))
            {
                serializer.Serialize(fs, shapes);
            }

            Console.WriteLine("Please input file name for deserialise Xml");
            filename2 = Console.ReadLine();
            filename2 += ".xml";
            try
            {
                using (FileStream fs = new FileStream(filename2, FileMode.OpenOrCreate))
                {
                    Shape[]? deserialeseShapeXml = serializer.Deserialize(fs) as Shape[];
                    Console.WriteLine("Deserialize Xml is compleat");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong, maybe there is no such file.");
            }


            //Newtonsoft


            using (StreamWriter sw = File.CreateText("NewtonJson.json"))
            {
                Newtonsoft.Json.JsonSerializer serializer3 = new Newtonsoft.Json.JsonSerializer();
                serializer3.Serialize(sw, shapes);
            }

            Shape[] shapeDeserialeze;

            using(StreamReader sw = File.OpenText("NewtonJson.json"))
            {
                Newtonsoft.Json.JsonSerializer serializer5 = new Newtonsoft.Json.JsonSerializer();
                shapeDeserialeze = (Shape[])serializer5.Deserialize(sw, typeof(Shape[]));
                Console.WriteLine("File Deserialize from Newton");
            }
            Console.WriteLine(shapeDeserialeze[1].Name);


        }
    }
}