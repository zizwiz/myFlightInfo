using System;
using System.Threading;
using System.Threading.Tasks;
using Timer = System.Timers.Timer;

namespace myFlightInfo.utils
{
    class TimeFunctions
    {
        /// <summary>
        /// Blocking delay, Thread continues after delay has expired.
        /// Parameter is delay in milliseconds e.g. 1 second = 1000 milliseconds 
        /// </summary>
        /// <param name="myDelayTime"></param>
        public static void BlockingTimeDelay(int myDelayTime)
        {
            Thread.Sleep(myDelayTime); // Pauses the thread for 1000 milliseconds (1 second)

        }

        /// <summary>
        /// Non-blocking delay, ideal for asynchronous programming.
        /// Parameter is delay in milliseconds e.g. 1 second = 1000 milliseconds
        /// </summary>
        /// <param name="myDelayTime"></param>
        public async static void AsyncTimeDelay(int myDelayTime)
        {
            await Task.Delay(myDelayTime); 
            
        }

        /// <summary>
        /// Using a Timer is useful if you want to execute code after a delay without blocking the thread.
        /// /// Parameter is delay in milliseconds e.g. 1 second = 1000 milliseconds
        /// </summary>
        /// <param name="myDelayTime"></param>
        /// <returns></returns>
        public static void NonBlockingTimeDelay(int myDelayTime)
        {
            Timer timer = new Timer(myDelayTime); // Set timer interval 

            timer.Elapsed += (sender, e) =>
            {
                timer.Stop(); // Stop the timer after it fires
            };

            timer.Start();
        }
    }
}
