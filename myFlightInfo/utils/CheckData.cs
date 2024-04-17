

using System;

namespace myFlightInfo.utils
{
    class CheckData
    {
        public static bool IsItADouble(string myData)
        {
            double result;
            return Double.TryParse(myData, out result);
        }


    }
}
