using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace latihan_member
{
    class Program
    {
        static void Main(string[] args)
        {
            //membuat objek taxi
            taxi taxi = new taxi();

            //pengesetan nilai properties
            taxi.DriverName = "jono";
            taxi.OnDuty = true;
            taxi.NumPassenger = 10;

            //pemanggil method
            taxi.TaxiInfo ();
            taxi.PickUpPassenger ();
            taxi.DropOfPassenger ();

            Console.ReadKey();
        }
    }
}
