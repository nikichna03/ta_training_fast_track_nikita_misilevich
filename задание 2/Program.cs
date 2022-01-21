using System;

namespace задание_2
{
    class Program
    {
        static void Main()
        {
            chassis auto = new chassis(0, 0, 9.9, 0, "***", "***", 9.9, 9.9, true, "***");
            Console.WriteLine("--------------------------------------\nавто");
            auto.Text();

            chassis truck = new chassis(1, 1, 1.1, 1, "+++", "+++", 1.1, 1.1, false, "+++");
            Console.WriteLine("--------------------------------------\nгрузовик");
            truck.Text();

            chassis bus = new chassis(2, 2, 2.2, 2, "---", "---", 2.2, 2.2, true, "---");
            Console.WriteLine("--------------------------------------\nавтобус");
            bus.Text();

            chassis Scooter = new chassis(3, 3, 3.3, 3, "000", "000", 3.3, 3.3, false, "000");
            Console.WriteLine("--------------------------------------\nСкутер");
            Scooter.Text();
        }
    }
}