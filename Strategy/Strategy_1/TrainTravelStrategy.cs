using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_1
{
    public class TrainTravelStrategy : ITravelStrategy
    {
        public void GotoAirport()
        {
            Console.WriteLine("Traveler is going to Airport by Train and will be charged Rs 200");
        }
    }
}
