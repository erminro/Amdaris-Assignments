using CreationalPatterns.Interfaces;
using CreationalPatterns.TrainTypes;


namespace CreationalPatterns.Factories
{
    public class CargoTrainFactory : ITrainTypeFactory
    {
        public string Name { get; set; }
        public ITrainType Create()
        {
            return new CargoTrain() {TrainName=Name};
        }
    }
}
