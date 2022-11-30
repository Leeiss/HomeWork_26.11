namespace Tumakov10
{
    internal class Rectangle : Point, ISquare
    {
        public double side1 { get; set; }
        public double side2 { get; set; }
        public Rectangle(double side1, double side2, int x, int y, string color, condition condition) : base(x, y, color, condition)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
        public void Square()
        {
            Console.WriteLine($"Площадь прямоугольника: {side1 * side2}");
        }
    }
}