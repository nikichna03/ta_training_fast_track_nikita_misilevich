using System;
using System.Collections.Generic;
using System.Text;

namespace задание_2
{
    class chassis : Transmission
    {
        public int wheel { get; set; }
        public int numer { get; set; }
        public double load { get; set; }

        public chassis(int wheel, int numer, double load, int broadcast, string typ, string manufacturer, double power, double size, bool type, string id) : base(broadcast, typ, manufacturer, power, size, type, id)
        {
            this.wheel = wheel;
            this.numer = numer;
            this.load = load;
        }

        public chassis() { }

        public void Text()
        {
            Console.WriteLine("Двигатель:\n" + power + " " + size + " " + type + " " + id);
            Console.WriteLine();
            Console.WriteLine("Трансмиссия:\n" + broadcast + " " + typ + " " + manufacturer);
            Console.WriteLine();
            Console.WriteLine("Шасси:\n" + wheel + " " + numer + " " + load);
            Console.WriteLine();
        }
    }
}
