namespace RectangleEncapulation.Domain
{
    class Rectangle
    {
        //attributes 
        private int _width;
        private int _height;
        private string _color;
        private const int DimUpperBound = 100;
        private const int DimLowerBound = 1;

        public void SetHeight(int height)
        {
            _height = SanitizeDimension(height);
        }

        public int GetHeight()
        {
            return _height;

        }

        public void SetWidth(int width)
        {
            _width = SanitizeDimension(width);
        }

        public int GetWidth()
        {
            return _width;

        }
        public void SetColor(string color)
        {
            if (color == "red" || color == "blue" || color == "blue")

                _color = color;
            else
                _color = "green";
        }
        public string GetColor()
        {
            return _color;
        }
        public int CalculateArea()
        {

            return _width * _height;
        }

        private int SanitizeDimension(int dimension)
        {
            if (dimension < DimLowerBound)
            {
                return DimLowerBound;
            }
            else if (dimension > DimUpperBound)
            {
                return DimUpperBound;
            }
           
           return dimension;
           
        }

    }
}
