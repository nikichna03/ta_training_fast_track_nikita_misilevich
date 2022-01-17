using System;
using System.Collections.Generic;
using System.Text;

namespace задание_4
{
    class Трансмиссия : Двигатель
    {
        public int broadcast { get; set; }
        public string typ { get; set; }
        public string manufacturer { get; set; }

        public Трансмиссия(int broadcast, string typ, string manufacturer, double power, double size, bool type, string id) : base(power, size, type, id)
        {
            this.broadcast = broadcast;
            this.typ = typ;
            this.manufacturer = manufacturer;
        }

        public Трансмиссия() { }
    }
}