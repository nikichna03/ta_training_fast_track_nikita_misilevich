using System;
using System.Collections.Generic;
using System.Text;

namespace Coordinate
{
    class Drone : IFlyable
    {
        Coordinate coordinate;//точка начала перемещения
        Coordinate newCoordinate;//точка куда перемещается обьект
        double Metrs;//растояние
        double Time;//время
        double Speed = 10;

        public Drone(Coordinate coordinate, Coordinate new_coordinate)
        {
            this.coordinate = coordinate;
            this.newCoordinate = new_coordinate;
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
            for (int i = (int)Time; i > 0; i -= 10)
            {
                Time += 1;
            }
        }

        public void examination()//оганичение на полет дрона(не более 1км)
        {
            if (Metrs > 1000)
            {
                Console.WriteLine("дрон не сможет отдалиться на это расстояние");
            }
        }
        public void examination1()//оганичение на полет дрона(не 3ч)
        {
            if (Time > 3)
            {
                Console.WriteLine("дрон разрядится");
            }
        }
        public void text()
        {
            Console.WriteLine("дрон\n" + "скорость\t" + Speed + "\nрасстояние\t" + string.Format("{0:F1}", Metrs) + "\nвремя\t" + string.Format("{0:F1}", Time));
            examination();
            examination1();
        }
    }
}
