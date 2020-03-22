using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LabActivity3
{
    class Taxi
    {
        private string driverName;
        private bool onDuty;
        private int numPassenger;
        public string DriverName
        {
            get { return driverName; }
            set { driverName = value; }
        }

        public bool OnDuty
        {
            get { return onDuty; }
            set { onDuty = value; }
        }

        public int NumPassenger
        {
            get { return numPassenger; }
            set { numPassenger = value; }
        }

        public void TaxiInfo()
        {
            Console.WriteLine("Driver name: {0}", this.driverName);
            if (onDuty == true)
            {
                Console.WriteLine("On Duty: Yes");
            }
            else
            {
                Console.WriteLine("On Duty: No");
            }
            Console.WriteLine("Number of passenger: {0}", numPassenger);
            Console.WriteLine();
        }

        public void PickUpPassenger()
        {
            Console.WriteLine("{0} sedang menjemput penumpang",driverName);
        }

        public void DropOffPassenger()
        {
            Console.WriteLine("{0} selesai menjemput penumpang",driverName);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
           Taxi taxi = new Taxi();

           taxi.DriverName = "Erwin Syahrul";
           taxi.OnDuty = true;
           taxi.NumPassenger = 2687;

           taxi.TaxiInfo();
           taxi.PickUpPassenger();
           taxi.DropOffPassenger();

           Console.ReadKey();
        }
    }
}
