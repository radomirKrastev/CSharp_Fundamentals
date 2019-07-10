namespace ProblemOne
{
    using System;
    public class Program
    {
        public static void Main()
        {
            var stepsMade = int.Parse(Console.ReadLine());
            var stepsLengthCentimeters = double.Parse(Console.ReadLine());
            var distanceMeters = int.Parse(Console.ReadLine());

            var distanceCentimeters = distanceMeters * 100;

            int fifthStepsCount = stepsMade / 5;
            double normalStepsValue = (stepsMade - fifthStepsCount) * stepsLengthCentimeters;
            double fifthStepsValue = fifthStepsCount * (stepsLengthCentimeters * 0.7);
            double totalStepsLength = normalStepsValue + fifthStepsValue;
            double percentageCompleted = (totalStepsLength/distanceCentimeters)*100;

            Console.WriteLine($"You travelled {percentageCompleted:F2}% of the distance!");

        }
    }
}
