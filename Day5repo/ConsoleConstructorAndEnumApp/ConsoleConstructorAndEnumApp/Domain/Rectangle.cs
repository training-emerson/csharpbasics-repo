namespace ConsoleConstructorAndEnumApp.Domain
{
    class Rectangle
    {
        //attributes 
        private readonly int _width; //immutable
        private readonly int _height;
        private readonly string _color;
        private const int UPPER_BOUND = 100;
        private const int LOWER_BOUND = 1;


        public Rectangle(int width, int height, string color)
        {
            _width = SanitizeDimension(width);
            _height = SanitizeDimension(height);
            _color = SanitizeColor(color);

        }
        public int Width
        {
            get { return _width; }
        }

        public int Height
        {
            get
            {
                return _height;
            }
        }
        public string Color
        {
            get
            {
                return _color;
            }
        }
        public int CalculateArea()
        {

            return _width * _height;
        }

        private int SanitizeDimension(int dimension)
        {
            if (dimension < LOWER_BOUND)
            {
                return LOWER_BOUND;
            }
            else if (dimension > UPPER_BOUND)
            {
                return UPPER_BOUND;
            }

            return dimension;

        }

        private string SanitizeColor(string color)
        {
            if (color == "red" || color == "blue" || color == "green")
            {
                return color;
            }
            return "green";
        }
        public int Area
        {
            get
            {
                return _width * _height;
            }
        }
    }
}
