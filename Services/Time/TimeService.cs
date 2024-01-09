namespace MC2to4.Services.Time;

    public class TimeService : ITimeService
    {

        public string GetBoth(string myName, string myTime)
        {
            return ("My name is " + myName + " and I woke up at " + myTime + " today.");
        }

    }
