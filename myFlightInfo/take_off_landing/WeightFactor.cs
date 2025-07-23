using System;

namespace myFlightInfo.take_off_landing
{
    class WeightFactor
    {
        public static double WorkOutWeightFactor(int type, string Engine_hp, string MTOW, int POB)
        {
            //10% increase in aircraft weight	x 1.2	x 1.1
            //double baseWeightPercentage = baseWeight / 10;
            //double myWeight = Math.Ceiling((ladenWeight - baseWeight) / baseWeightPercentage);
            double myWeight = 600;

            double factor = 0.2; //for every 10% increase in weight : Takeoff
            if (type == 1) //0 = take-off, 1 = landing
            {
                factor = 0.1; //for every 10% increase in weight : Landing
            }


            switch (Engine_hp)
            {
                case "80":
                    if ((type == 0) && (POB == 1)) // takeoff single person
                    {
                        
                    }
                    else if ((type == 0) && (POB == 2)) // takeoff two persons
                    {

                    }
                    else if ((type == 1) && (POB == 1)) // landing single person
                    {
                        
                    }
                    else if ((type == 1) && (POB == 2)) // landing two persons
                    {

                    }
                    break;
                case "100":
                    if ((type == 0) && (POB == 1)) // takeoff single person
                    {

                    }
                    else if ((type == 0) && (POB == 2)) // takeoff two persons
                    {

                    }
                    else if ((type == 1) && (POB == 1)) // landing single person
                    {

                    }
                    else if ((type == 1) && (POB == 2)) // landing two persons
                    {

                    }
                    break;


                default:

                    break;
            }



            return myWeight * (1 + factor);

        }

    }
}
