using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktikumoop
{
    class Taxi
    {
        //properti
        public string DriverName;
        public Boolean OnDuty;
        public int NumPassenger;

        //method
        public void TaxiInfo()
        {
            Console.WriteLine("Driver Name : {0}", DriverName);
            if (OnDuty == true)
            {Console.WriteLine("OnDuty : yes");}
            else { Console.WriteLine("OnDuty : no"); }
            Console.WriteLine("NumPassenger :{0}\n", NumPassenger);
        }

        public void PickUpPassenger()
        {
            Console.WriteLine(this.DriverName + " Sedang menjemput Penumpang");
        }

        public void DropOffPassenger()
        {
            Console.WriteLine(this.DriverName + " Selesai mmengantar Penumpang");
        }
    }
}
