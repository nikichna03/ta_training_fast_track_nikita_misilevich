using System;
using System.Collections.Generic;
using System.Text;

namespace Coordinate
{
    class Bird : IFlyable
    {
        Coordinate coordinate;//точка начала перемещения
        Coordinate newCoordinate;//точка куда перемещается обьект
        double Metrs;//растояние
        double Time;//время
        double Speed;

        public Bird(Coordinate coordinate, Coordinate new_coordinate, double speed)
        {
            this.coordinate = coordinate;
            this.newCoordinate = new_coordinate;
            this.Speed = speed;
        }
        public Coordinate nullDot
        {
            set { coordinate = value; }
            get { return coordinate; }
        }

        public void FlyTo()
        {
            Coordinate metrs = new Coordinate(newCoordinate.X - nullDot.X, newCoordinate.Y - nullDot.Y, newCoordinate.Z - nullDot.Z);
            this.Metrs = Math.Sqrt((Math.Pow(metrs.Z, 2) + Math.Pow(Math.Sqrt(Math.Pow(metrs.Y, 2) + Math.Pow(metrs.X, 2)), 2)));
        }
        public void GetFlyTime()
        {
            Time = Metrs / Speed;
        }

        public void examination()//оганичение на полет птицы(не более часа)
        {
            if (Time > 1)
            {
                Console.WriteLine("птица не пролетит больше часа");
            }
        }
        public void text()
        {
            Console.WriteLine("птица\n" + "скорость\t" + Speed + "\nрасстояние\t" + string.Format("{0:F1}", Metrs) + "\nвремя\t" + string.Format("{0:F1}", Time));
            examination();
        }
    }
}