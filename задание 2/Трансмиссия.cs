using System;
using System.Collections.Generic;
using System.Text;

namespace задание_2
{
    class Transmission : Engine
    {
        public int broadcast { get; set; }
        public string typ { get; set; }
        public string manufacturer { get; set; }

        public Transmission(int broadcast, string typ, string manufacturer, double power, double size, bool type, string id) : base(power, size, type, id)
        {
            this.broadcast = broadcast;
            this.typ = typ;
            this.manufacturer = manufacturer;
        }

        public Transmission() { }
    }
}