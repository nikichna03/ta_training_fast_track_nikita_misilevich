using System;
using System.Collections.Generic;
using System.Text;

namespace задание_3
{
    class Drone : IFlyable
    {
        Coordinate coordinate;//точка начала перемещения
        Coordinate new_coordinate;//точка куда перемещается обьект
        double metrs;//растояние
        double time;//время
        double speed = 10;

        public Drone(Coordinate coordinate, Coordinate new_coordinate)
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
        }
        public void GetFlyTime()
        {
            time = metrs / speed;
            for (int i = (int)time; i > 0; i -= 10)
                time += 1;
        }

        public void examination()//оганичение на полет дрона(не более 1км)
        {
            if (metrs > 1000)
                Console.WriteLine("дрон не сможет отдалиться на это расстояние");
        }
        public void examination1()//оганичение на полет дрона(не 3ч)
        {
            if (time > 3)
                Console.WriteLine("дрон разрядится");
        }
        public void text()
        {
            Console.WriteLine("дрон\n" + "скорость\t" + speed + "\nрасстояние\t" + string.Format("{0:F1}", metrs) + "\nвремя\t" + string.Format("{0:F1}", time));
            examination();
            examination1();
        }
    }
}
