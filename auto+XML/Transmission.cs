using System;
using System.Collections.Generic;
using System.Text;

namespace auto
{
    class Трансмиссия : Двигатель
    {
        public int Broadcast { get; set; }
        public string Typ { get; set; }
        public string Manufacturer { get; set; }

        public Трансмиссия(int broadcast, string typ, string manufacturer, double power, double size, bool type, string id) : base(power, size, type, id)
        {
            this.Broadcast = broadcast;
            this.Typ = typ;
            this.Manufacturer = manufacturer;
        }

        public Трансмиссия() { }
    }
}