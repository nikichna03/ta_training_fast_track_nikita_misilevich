using System;

namespace Coordinate
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
            Bird bird = new Bird(coordinate, coordinate1, 5);
            bird.FlyTo();
            bird.GetFlyTime();
            bird.text();

            Console.WriteLine();

            coordinate = new Coordinate(10000, 1546, 55);
            coordinate1 = new Coordinate(0, 0, 0);
            Airplane airplane = new Airplane(coordinate, coordinate1);
            airplane.FlyTo();
            airplane.GetFlyTime();
            airplane.text();

            Console.WriteLine();

            coordinate = new Coordinate(1, 146, 55);
            coordinate1 = new Coordinate(0, 0, 0);
            Drone drone = new Drone(coordinate, coordinate1);
            drone.FlyTo();
            drone.GetFlyTime();
            drone.text();
        }
    }
}