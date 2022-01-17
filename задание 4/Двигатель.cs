using System;
using System.Collections.Generic;
using System.Text;

namespace задание_4
{
    class Двигатель
    {
        public double power { get; set; }
        public double size { get; set; }
        public bool type { get; set; }
        public string id { get; set; }

        public Двигатель(double power, double size, bool type, string id)
        {
            this.power = power;
            this.size = size;
            this.type = type;
            this.id = id;
        }

        public Двигатель() { }
    }
}
