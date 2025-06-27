using System;

namespace myFlightInfo.take_off_landing
{
    class TemperatureFactor
    {

        public static double WorkOutTemperatureFactor(double Temperature)
        {
            //factor is same for take-off or landing
            //factor is 1.1 for every 10°C increase over 15°C

            return 1 + ((Temperature - 15) / 10) * 0.1;
        }
    }
}
