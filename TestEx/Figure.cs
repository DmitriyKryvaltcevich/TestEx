
namespace TestEx
{
    interface IFigure
    {
        double perimeter();
        double square();
    }
    class Func
    {
        public Dictionary<int, IFigure?> Figures = new Dictionary<int, IFigure?>();
        public double numcheck(string? tmp)
        {
            if (!double.TryParse(tmp, out double num))
            {
                Console.WriteLine("\r\nВведите число");
                num = numcheck(Console.ReadLine());
                return num;
            }
            else return num;
        }

        public int ussercheck(string? tmp)
        {
            if (!int.TryParse(tmp, out int num) || !(num > 0 && num < 5))
            {
                Console.WriteLine("\r\nВведите число от 1 до 4");
                num = ussercheck(Console.ReadLine());
                return num;
            }
            else return num;
        }
        public bool checkEx(int figure, bool noExMess = true, bool ExMess = true)
        {
            bool exists = false;
            if (Figures.ContainsKey(figure)) exists = true;
            if (ExMess && exists) Console.WriteLine("\r\nФигура существует");
            if (noExMess && !exists) Console.WriteLine("\r\nФигура не существует");
            return exists;
        }

        public int selectFigure()
        {
            Console.WriteLine("Выберите фигуру:\r\n1 - квадрат\r\n2 - прямоугольник\r\n3 - ромб\r\n4 - круг");
            return ussercheck(Console.ReadLine());
        }
   
        public void createFigure(int figure)
        {
            if (figure == 1)
            {
                if (!checkEx(figure, false))
                {
                    Console.WriteLine("Введите длину стороны:");
                    Figures.Add(figure, new fourSquare(numcheck(Console.ReadLine())));
                }
            }
            if (figure == 2)
            {

                if (!checkEx(figure, false))
                {
                    Console.WriteLine("Введите длину стороны A:");
                    double a = numcheck(Console.ReadLine());
                    Console.WriteLine("Введите длину стороны B:");
                    double b = numcheck(Console.ReadLine());
                    Figures.Add(figure, new Rectangle(a, b));
                }
            }
            if (figure == 3)
            {
                if (!checkEx(figure, false))
                {
                    Console.WriteLine("Введите длину диагонали A:");
                    double a = numcheck(Console.ReadLine());
                    Console.WriteLine("Введите длину диагонали B:");
                    double b = numcheck(Console.ReadLine());
                    Figures.Add(figure, new Rhombus(a, b));
                }
            }
            if (figure == 4)
            {
                if (!checkEx(figure, false))
                {
                    Console.WriteLine("Введите диаметр:");
                    Figures.Add(figure, new Circle(numcheck(Console.ReadLine())));
                }
            }
        }
    }
    class fourSquare : IFigure
    {
        double _sideA { get; }
        public fourSquare(double sideA)
        {
            _sideA = sideA;
        }
        public double square()
        {
            return _sideA * _sideA;
        }
        public double perimeter()
        {
            return _sideA * 4;
        }
    }
    class Rectangle : IFigure
    {
        double _sideA { get; }
        double _sideB { get; }


        public Rectangle(double sideA, double sideB)
        {
            _sideA = sideA;
            _sideB = sideB;
        }
        public double square()
        {
            return _sideA * _sideB;
        }
        public double perimeter()
        {
            return 2 * (_sideA + _sideB);

        }
    }
    class Circle : IFigure
    {
        double _diameter { get; }
        public Circle(double diameter)
        {
            _diameter = diameter;
        }
        public double square()
        {
            return Math.Pow(_diameter, 2) / 4 * Math.PI;
        }
        public double perimeter()
        {
            return _diameter * Math.PI;
        }
    }
    class Rhombus : IFigure
    {
        double _diagonalA { get; }
        double _diagonalB { get; }


        public Rhombus(double diagonalA, double diagonalB)
        {
            _diagonalA = diagonalA;
            _diagonalB = diagonalB;
        }
        public double square()
        {
            return (_diagonalA * _diagonalB) / 2;
        }
        public double perimeter()
        {
            return 4 * (Math.Sqrt(_diagonalA * _diagonalB / 4 + _diagonalB * _diagonalB / 4));
        }
    }
}