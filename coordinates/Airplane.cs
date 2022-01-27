using System;
using System.Collections.Generic;
using System.Text;

namespace Coordinate
{
    class Airplane : IFlyable
    {
        Coordinate coordinate;//точка начала перемещения
        Coordinate newCoordinate;//точка куда перемещается обьект
        double Metrs;//растояние
        double Time;//время
        double Speed = 200;

        public Airplane(Coordinate coordinate, Coordinate new_coordinate)
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
            if (this.Metrs > 10000)
            {
                for (int i = (int)this.Metrs; i >= 10000; i -= 10000)
                {
                    if (Speed < 810)//ограничения от бесконечной скорости самолета
                    {
                        Speed += 10;
                    }
                }
            }
        }
        public void GetFlyTime()
        {
            Time = Metrs  / Speed;
        }

        public void examination()//оганичение на полет самолета(не более 7700км)
        {
            if (Metrs > 7700000)
            {
                Console.WriteLine("самолет не сможет попролететь столько. нужна дозаправка");
            }
        }
        public void text()
        {
            Console.WriteLine("самолет\n" + "скорость\t" + Speed + "\nрасстояние\t" + string.Format("{0:F1}", Metrs) + "\nвремя\t" + string.Format("{0:F1}", Time));
            examination();
        }
    }
}
