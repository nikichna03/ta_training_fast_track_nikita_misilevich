using System;

namespace задание_3
{
    // единица перемещения 1м. если обьект переместился с 0.0.0 на 0.0.5 обьект переместился на 5м
    struct Coordinate
    {
        public int X;
        public int Y;
        public int Z;

        public Coordinate(int X, int Y, int Z)
        {
            this.X = X;
            this.Y = Y;
            this.Z = Z;
        }
    }
    class Program
    {
        static void Main()
        {
            Coordinate coordinate = new Coordinate(1, 15, 5), coordinate1 = new Coordinate(0, 0, 0);
            Птица птица = new Птица(coordinate, coordinate1, 5);
            птица.FlyTo();
            птица.GetFlyTime();
            птица.text();

            Console.WriteLine();

            coordinate = new Coordinate(10000, 1546, 55);
            coordinate1 = new Coordinate(0, 0, 0);
            Самолет самолет = new Самолет(coordinate, coordinate1);
            самолет.FlyTo();
            самолет.GetFlyTime();
            самолет.text();

            Console.WriteLine();

            coordinate = new Coordinate(1, 146, 55);
            coordinate1 = new Coordinate(0, 0, 0);
            Дрон дрон = new Дрон(coordinate, coordinate1);
            дрон.FlyTo();
            дрон.GetFlyTime();
            дрон.text();
        }
    }
}