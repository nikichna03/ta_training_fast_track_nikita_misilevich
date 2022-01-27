using System;
using System.Collections.Generic;
using System.Text;

namespace auto
{
    class Auto : Chassis
    {
        public Auto(int wheel, int numer, double load, int broadcast, string typ, string manufacturer, double power, double size, bool type, string id) : base(wheel, numer, load, broadcast, typ, manufacturer, power, size, type, id)
        {
        }
        public void Text()
        {
            Console.WriteLine($"Двигатель:\n {power} {size} {type} {id}\n");
            Console.WriteLine($"Трансмиссия:\n {broadcast} {typ} {manufacturer}\n");
            Console.WriteLine($"Шасси:\n {wheel} {numer} {load}\n");
        }
    }
}
