using System;
using System.Collections.Generic;
using System.Text;

namespace задание_3
{
    class Bird : IFlyable
    {
        Coordinate coordinate;//точка начала перемещения
        Coordinate new_coordinate;//точка куда перемещается обьект
        double metrs;//растояние
        double time;//время
        double speed;

        public Bird(Coordinate coordinate, Coordinate new_coordinate, double speed)
        {
            this.coordinate = coordinate;
            this.new_coordinate = new_coordinate;
            this.speed = speed;
        }
        public Coordinate null_dot
        {
            set { coordinate = value; }
            get { return coordinate; }
        }

        public void FlyTo()
        {
            Coordinate metrs = new Coordinate(new_coordinate.X - null_dot.X, new_coordinate.Y - null_dot.Y, new_coordinate.Z - null_dot.Z);
            this.metrs = Math.Sqrt((Math.Pow(metrs.Z, 2) + Math.Pow(Math.Sqrt(Math.Pow(metrs.Y, 2) + Math.Pow(metrs.X, 2)), 2)));
        }
        public void GetFlyTime()
        {
            time = metrs / speed;
        }

        public void examination()//оганичение на полет птицы(не более часа)
        {
            if (time > 1)
                Console.WriteLine("птица не пролетит больше часа");
        }
        public void text()
        {
            Console.WriteLine("птица\n" + "скорость\t" + speed + "\nрасстояние\t" + string.Format("{0:F1}", metrs) + "\nвремя\t" + string.Format("{0:F1}", time));
            examination();
        }
    }
}