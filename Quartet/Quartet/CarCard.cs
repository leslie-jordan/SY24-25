using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quartet
{
    internal class CarCard
    {
        public string name { get; set; }
        public int maxspeed { get; set; }
        public double zerotosixty { get; set; }
        public int hp { get; set; }
        public int cc { get; set; }
        public int cylinders { get; set; }
        public int rpm { get; set; }
        public CarCard(string name, int maxspeed, double zerotosixty, int hp, int cc, int cylinders, int rpm)
        {
            this.name = name;
            this.maxspeed = maxspeed;
            this.zerotosixty = zerotosixty;
            this.hp = hp;
            this.cc = cc;
            this.cylinders = cylinders;
            this.rpm = rpm;
        }
    }
}
