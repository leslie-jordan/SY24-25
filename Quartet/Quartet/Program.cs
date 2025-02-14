using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quartet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarCard C4 = new CarCard("Corvette Coupe", 281, 5.2, 344, 5665, 8, 5400);
            CarCard C3 = new CarCard("Porsche 911 Targa", 285, 5.2, 320, 3596, 6, 6800);
            CarCard A3 = new CarCard("Ferrari F430 F1", 315, 4.0, 490, 4308, 8, 8500);
            CarCard G4 = new CarCard("Porsche Cayman S", 275, 5.4, 295, 3387, 6, 6250);
            CarCard G1 = new CarCard("Marcos Mantara", 225, 5.4, 190, 3998, 8, 4750);
        }
    }
}
