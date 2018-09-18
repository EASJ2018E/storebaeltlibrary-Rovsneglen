using System;
using billetlibrary_Rovsneglen;
namespace storebaeltlibrary_Rovsneglen
{
    public class Car: Bil
    {

        public Car()
        {
            
        }

        public double Pris(bool Brobizz, bool Weekend)
        {
            if (Brobizz)
            {
                if (Weekend)
                {
                    return 240 * 0.95 * 0.8;
                }
                return 240 * 0.95;
            }
            return 240;
        }
    }
}
