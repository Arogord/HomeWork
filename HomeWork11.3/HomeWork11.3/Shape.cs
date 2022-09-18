
namespace HomeWork11_3
{
    [Serializable]
    public class Shape
    {
        
        public Point ShapePoint { get; set; }
        public float Length { get; set; }
        public float Height { get; set; }
        public string Name { get; set; }
        public Shape()
        {
            ShapePoint = new Point();
        }
    }
}
