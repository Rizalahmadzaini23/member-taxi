using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace latihan_member
{
    public class taxi
    {
        //properti
        public string DriverName  { get; set; }
        public bool OnDuty { get; set; }
        public int NumPassenger { get; set; }

        public void Taxiinfo()
        {
            Console.WriteLine("Driver name :{0}", DriverName);

            if (OnDuty)
                Console.WriteLine("On Duty : Yes");
            else
                Console.WriteLine("On Duty : No");

            Console.WriteLine("Number Of Passenger : {0}", NumPassenger);

            Console.WriteLine();

        }
        public void PickUpPassenger()
        {
            Console.WriteLine("{0} sedang menjemput penumpang", DriverName);
        }
        public void TaxiInfo()
        {
            Console.WriteLine("{0} sedang menjemput penumpang", DriverName);
        }
        public void DropOfPassenger()
        {
            Console.WriteLine("{0} selesai mengantar penumpang", DriverName);
        }
        }
}
