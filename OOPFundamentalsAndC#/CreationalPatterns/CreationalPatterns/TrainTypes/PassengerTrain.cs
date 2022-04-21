using CreationalPatterns.Interfaces;

namespace CreationalPatterns.TrainTypes
{
    public class PassengerTrain : ITrainType
    {
        public string TrainName { get; set; }
        public string Get()
        {
            return $"Passenger Train:{TrainName} ";
        }
    }
}
