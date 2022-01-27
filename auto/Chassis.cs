using System;
using System.Collections.Generic;
using System.Text;

namespace auto
{
    class Chassis : Transmission
    {
        public int Wheel
        {
            get
            {
                if (value <= 0)
                    Console.WriteLine("Wheel должен быть больше 0");
                else
                    Wheel = value;
            }
            set { return Wheel; }
        }
        public int Numer { get; set; }
        public double load { get; set; }

        public Chassis(int wheel, int numer, double load, int broadcast, string typ, string manufacturer, double power, double size, bool type, string id) : base(broadcast, typ, manufacturer, power, size, type, id)
        {
            this.Wheel = wheel;
            this.Numer = numer;
            this.load = load;
        }
        public Chassis() { }
    }
}
