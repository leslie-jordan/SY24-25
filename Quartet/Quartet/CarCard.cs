using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quartet
{
    internal class CarCard
    {
        public enum category { maxspeed, zerotosixty, hp, cc,
                                cylinders, rpm}
        public string name { get; set; }
        public int maxspeed { get; set; }
        public double zerotosixty { get; set; }
        public int hp { get; set; }
        public int cc { get; set; }
        public int cylinders { get; set; }
        public int rpm { get; set; }

        public string id { get; set; }
        public CarCard(string id, string name, int maxspeed, double zerotosixty, int hp, int cc, int cylinders, int rpm)
        {
            this.id = id.ToUpper();
            this.name = name;
            this.maxspeed = maxspeed;
            this.zerotosixty = zerotosixty;
            this.hp = hp;
            this.cc = cc;
            this.cylinders = cylinders;
            this.rpm = rpm;
        }
        public CarCard Compare(CarCard other, category c)
        {
            if (other == null) return this;
            //maxspeed
            if (c == category.maxspeed) 
                if (maxspeed > other.maxspeed)
                    return this;
                else
                    return other;
            //zerotosixty
            if (c == category.zerotosixty)
                if (zerotosixty < other.zerotosixty)
                    return this;
                else
                    return other;
            //hp
            if (c == category.hp)
                if (hp > other.hp)
                    return this;
                else
                    return other;
            //cc
            if (c == category.cc)
                if (cc > other.cc)
                    return this;
                else
                    return other;
            //cylinders
            if (c == category.cylinders)
                if (cylinders > other.cylinders)
                    return this;
                else
                    return other;
            //rpm
            if (c == category.rpm)
                if (rpm > other.rpm)
                    return this;
                else
                    return other;
            return null;
        }
        public override string ToString()
        {
            return name + ":\n\tmaxspeed:" + maxspeed +
                "\n\tzerotosixty:" + zerotosixty +
                "\n\thp:" + hp +
                "\n\tcc:" + cc +
                "\n\tcylinders:" + cylinders +
                "\n\trpm:" + rpm;
        }
    }
}
