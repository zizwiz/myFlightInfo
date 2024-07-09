using System;
using System.Windows.Forms;
using myFlightInfo.utils;

namespace myFlightInfo.crosswind
{
    class Speed_Time_Fuel
    {

        public static (Double, Double, Double, Double, Double) Calculate_Speed_Time_fuel(TextBox myTrueAirSpeed, TextBox myWindSpeed,
            TextBox myCourse, TextBox myWindDirection, TextBox myDistance, TextBox myFuelConsumption,
            TextBox myMinLandingFuel, TextBox myFuelSpecificGravity)
        {
            /*
             * In aviation, the ground speed formula is as follows: vg = √(va2 + vw2 - (2vavw cos(δ - ω + ⍺))
               
               Where, vg – Ground speed 
               va – True airspeed 
               vw – Wind speed
               δ – Course – the desired flight path, measured clockwise from the North
               ω – Wind direction
               ⍺ – Wind correction angle
               The above equation is a simple vector addition of the true airspeed and wind speed of the aircraft. 
                It can be calculated using the law of cosines formula.
             
             * wind correction angle, ⍺ as: Note this is inverse of Sin which is Asin
             * All Degrees need to be converted into Radians
               
               𝛼=sin−1[(vw/va)*sin(ω−δ)]

               double mycalcInRadians = Math.Asin([(vw/va)*sin(DegreeToRadian(ω−δ))]);
               double mycalcInDegrees = Math.Asin([(vw/va)*sin(DegreeToRadian(ω−δ))]) * 180 / Math.PI;
             
             * The heading is the direction in which a pilot directs the nose of the aircraft to avoid any
             * wind-induced deviation from its course. The sum of the course and the wind correction angle is as
             * follows: ѱ = δ + ⍺
             */

            double TrueAirspeed = Double.Parse(myTrueAirSpeed.Text);
            double WindSpeed = Double.Parse(myWindSpeed.Text);
            double Course = Double.Parse(myCourse.Text);
            double WindDirection = Double.Parse(myWindDirection.Text);

            //Get the wind correction but here we need to convert degrees to radian do the inverse
            //SIN then convert radians to Degrees
            double WindCorrection = Math.Round(Math.Asin((WindSpeed / TrueAirspeed) *
                                              Math.Sin(Converts.DegreeToRadian(WindDirection - Course))) *
                                                    180 / Math.PI, 0);

            //Convert all Degrees into Radians
            double GroundSpeed = Math.Round(Math.Sqrt((Math.Pow(TrueAirspeed, 2.0) + Math.Pow(WindSpeed, 2.0)) -
                                                      (2 * TrueAirspeed * WindSpeed * Math.Cos(Converts.DegreeToRadian(Course - WindDirection + WindCorrection)))), 0);

            //myRichTextBox.AppendText("Wind Correction = " + WindCorrection + "°\r");
            //myRichTextBox.AppendText("Heading = " + (Course + WindCorrection) + "°\r");
            //myRichTextBox.AppendText("Ground Speed = " + GroundSpeed + "kts\r");

            //FlightTime = Distance in nautical miles / speed in knots
            Double FlightTime = Double.Parse(myDistance.Text) / GroundSpeed;
            //myRichTextBox.AppendText("\rFlight Time = " + TimeSpan.FromHours(FlightTime).ToString("h\\:mm\\:ss") + "\r");

            //Fuel Consumption = Flight Time * Hourly consumption rate
            Double JourneyFuelLoad = Math.Ceiling(FlightTime * Double.Parse(myFuelConsumption.Text));
            //myRichTextBox.AppendText("\rMin journey fuel consumption = " + JourneyFuelLoad + "ℓ");

            Double FuelLoad = JourneyFuelLoad + Double.Parse(myMinLandingFuel.Text);
            //myRichTextBox.AppendText("\rMin takeoff fuel load = " + FuelLoad + "ℓ");

            //myRichTextBox.AppendText("\rFuel weight at takeoff= " + FuelLoad * Double.Parse(myFuelSpecificGravity.Text) + "kg");

            return (WindCorrection, GroundSpeed, FlightTime, JourneyFuelLoad, FuelLoad);
        }





    }
}
