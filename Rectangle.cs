namespace Training
{
    internal class Rectangle
    {
        public double width;
        public double height;
        public Rectangle()
        {
            width = 1; height = 1;
        }
        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        public double getArea() { return width * height; }
        public double getPerimeter() { return (width + height) * 2; }
        public String toString()
        {
            return $"Area = {width * height} ,Perimeter{(width + height) * 2} ";
        }


    }
}
