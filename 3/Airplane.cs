using System;
using System.Collections.Generic;
using System.Text;

namespace задание_3
{
    class Airplane : IFlyable
    {
        Coordinate coordinate;//точка начала перемещения
        Coordinate new_coordinate;//точка куда перемещается обьект
        double metrs;//растояние
        double time;//время
        double speed = 200;

        public Airplane(Coordinate coordinate, Coordinate new_coordinate)
        {
            this.coordinate = coordinate;
            this.new_coordinate = new_coordinate;
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
            if (this.metrs > 10000)
                for (int i = (int)this.metrs; i >= 10000; i -= 10000)
                    if (speed < 810)//ограничения от бесконечной скорости самолета
                        speed += 10;
        }
        public void GetFlyTime()
        {
            time = metrs  / speed;
        }

        public void examination()//оганичение на полет самолета(не более 7700км)
        {
            if (metrs > 7700000)
                Console.WriteLine("самолет не сможет попролететь столько. нужна дозаправка");
        }
        public void text()
        {
            Console.WriteLine("самолет\n" + "скорость\t" + speed + "\nрасстояние\t" + string.Format("{0:F1}", metrs) + "\nвремя\t" + string.Format("{0:F1}", time));
            examination();
        }
    }
}
