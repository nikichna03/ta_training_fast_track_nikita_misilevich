using System;
using System.Collections.Generic;
using System.Text;

namespace auto
{
    class Engine
    {
        public double Power
        {
            get
            {
                if (value <= 0)
                    Console.WriteLine("Power должен быть больше 0");
                else
                    Power = value;
            }
            set { return Power; }
        }
        public double Power 
        {
            get
            {
                if (value <=0)
                    Console.WriteLine("Size должен быть больше 0");
                else
                    Size = value;
            }
            set { return Size; }
        }
        public bool Type { get; set; }
        public string Id { get; set; }

        public Engine(double power, double size, bool type, string id)
        {
            this.Power = power;
            this.Size = size;
            this.Type = type;
            this.Id = id;
        }

        public Engine() { }
    }
}
