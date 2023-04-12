using System;

namespace LasagnaProject
{
    class Lasagna
    {

        //method that does not take any parameters and returns how many minutes the lasagna should be in the oven
        public int ExpectedMinutesInOven()
        {
            return 40;
        }



        //method that takes the actual minutes the lasagna has been in the oven as a parameter and returns how 
        //many minutes the lasagna still has to remain in the oven, based on the expected oven time in minutes from the previous task.
        public int RemainingMinutesInOven(int actualMinutesInOven)
        {
            // Calculate the remaining minutes based on the expected time and actual time.
            return ExpectedMinutesInOven() - actualMinutesInOven;
        }



        //method that takes the number of layers you added to the lasagna as a parameter and returns how many minutes you spent 
        //preparing the lasagna, assuming each layer takes you 2 minutes to prepare.
        public int PreparationTimeInMinutes(int numberOfLayers)
        {
            return numberOfLayers * 2;
        }


        //method that takes two parameters: the first parameter is the number of layers you added to the lasagna, 
        //and the second parameter is the number of minutes the lasagna has been in the oven.
        public int ElapsedTimeInMinutes(int numberOfLayers, int ActualMinutes)
        {
            return PreparationTimeInMinutes(numberOfLayers) + ActualMinutes;
        }



        //To use these methods, we need yo create an instance of the Lasagna class and call the methods on that instance:
        static void Main(string[] args)
        {
            Lasagna lasagna1 = new Lasagna();
            int expectedMinutes = lasagna1.ExpectedMinutesInOven();
            int RemainingMinutesInOven = lasagna1.RemainingMinutesInOven(30);
            int PreparationTimeInMinutes = lasagna1.PreparationTimeInMinutes(2);
            int ElapsedTimeInMinutes = lasagna1.ElapsedTimeInMinutes(3, 20);

            Console.WriteLine(expectedMinutes);
            Console.WriteLine(RemainingMinutesInOven);
            Console.WriteLine(PreparationTimeInMinutes);
            Console.WriteLine(ElapsedTimeInMinutes);

        }

    }

}