using CreationalPatterns.Interfaces;
using CreationalPatterns.TrainTypes;


namespace CreationalPatterns.Factories
{
    public class PassengerTrainFactory : ITrainTypeFactory
    {
        public string Name { get; set; }
        public ITrainType Create()
        {
            return new PassengerTrain() { TrainName=Name};
        }
    }
}
