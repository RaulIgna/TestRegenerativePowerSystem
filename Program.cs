using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ivi.Driver.Interop;
using Agilent.AgAPS.Interop;

namespace TestRegenerativePowerSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AgAPS driver = new AgAPS();

            driver.Initialize("USB0::0x2A8D::0x2802::MY63000137::0::INSTR", false, false, "");
            Console.WriteLine(driver.Initialized ? "Deschis" : "Nu");
            driver.Close();


        }
    }
}
