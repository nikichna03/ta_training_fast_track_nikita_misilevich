using System;

namespace auto
{
    class Program
    {
        static void Main()
        {
            Auto auto = new Auto(4, 0, 9.9, 0, "***", "***", 9.9, 9.9, true, "***");
            Console.WriteLine("--------------------------------------\nавто");
            auto.Text();

            Auto truck = new Auto(1, 1, 1.1, 1, "+++", "+++", 1.1, 1.1, false, "+++");
            Console.WriteLine("--------------------------------------\nгрузовик");
            truck.Text();

            Auto bus = new Auto(2, 2, 2.2, 2, "---", "---", 2.2, 2.2, true, "---");
            Console.WriteLine("--------------------------------------\nавтобус");
            bus.Text();

            Auto Scooter = new Auto(3, 3, 3.3, 3, "000", "000", 3.3, 3.3, false, "000");
            Console.WriteLine("--------------------------------------\nСкутер");
            Scooter.Text();
        }
    }
}