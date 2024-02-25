namespace LibrarySquare
{
    public class Calculation
    {
        private string errorMessage = "Нет возможности расчета, проверьте данные!";
        public dynamic Square(double radius)
        {
            Circle circle = new Circle();
            double result = circle.Calculation(radius);
            return result > 0 ? result : errorMessage;
        }
        public dynamic Square(double FirstSide, double SecondSidde)
        {
            Tetragon tetragon = new Tetragon();
            double result = tetragon.Calculation(FirstSide, SecondSidde);
            return result > 0 ? result: errorMessage;
        }
        public dynamic Square(double FirstSide, double SecondSidde, double ThirdSide)
        {
            Triangle traversal = new Triangle();
            double result = traversal.Calculation(FirstSide, SecondSidde, ThirdSide);
            return result > 0 ? result : errorMessage;
        }
    }
    public interface ISquare
    {
        double Calculation(params double[] figurePart);
    }
    public abstract class Square : ISquare
    {
        protected bool Validation(params double[] elements)
        {
            return elements.Where(p => p < 0).Count() > 0 ? false : true; 
        }
        public abstract double Calculation(params double[] figurePart);
       
    }
    public class Circle : Square
    {
        public override double Calculation(params double[] figurePart)
        {
            if (figurePart.Length != 1)
                throw new ArgumentException("Метод Calculation круга требует ровно один аргумент (радиус).");

            double radius = figurePart[0];
            return Validation(radius) ? Math.PI * Math.Pow(radius, 2) : 0;
        }
    }

    public class Tetragon : Square
    {
        public override double Calculation(params double[] figurePart)
        {
            if (figurePart.Length != 2)
                throw new ArgumentException("Метод Calculation четырехугольника требует ровно два аргумента (длины сторон).");

            double firstSide = figurePart[0];
            double secondSide = figurePart[1];

            return Validation(firstSide, secondSide) ? firstSide * secondSide : 0;
        }
    }

    public class Triangle : Square
    {
        public override double Calculation(params double[] figurePart)
        {
            if (figurePart.Length != 3)
                throw new ArgumentException("Метод Calculation треугольника требует ровно три аргумента (длины сторон).");

            double firstSide = figurePart[0];
            double secondSide = figurePart[1];
            double thirdSide = figurePart[2];

            if (Validation(firstSide, secondSide, thirdSide))
            {
                if (ValidTriangle(firstSide, secondSide, thirdSide) > 0)
                {
                    double halfPerimeter = ValidTriangle(firstSide, secondSide, thirdSide);
                    return Math.Sqrt(halfPerimeter * (halfPerimeter - firstSide) * (halfPerimeter - secondSide) * (halfPerimeter - thirdSide));
                }
                else
                {
                    return 0;
                }
            }
            return 0;
        }

        private double ValidTriangle(double firstSide, double secondSide, double thirdSide)
        {
            double sumFirstSecond = firstSide + secondSide;
            double sumSecondThird = secondSide + thirdSide;
            double sumFirstThird = firstSide + thirdSide;
            return sumFirstSecond > thirdSide && sumFirstThird > secondSide && sumSecondThird > firstSide ?
                (firstSide + secondSide + thirdSide) / 2 : 0;
        }
    }
}
