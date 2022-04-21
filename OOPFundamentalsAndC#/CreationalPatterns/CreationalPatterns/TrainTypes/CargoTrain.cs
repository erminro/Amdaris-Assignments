using CreationalPatterns.Interfaces;


namespace CreationalPatterns.TrainTypes
{
    public class CargoTrain : ITrainType
    {
        public string TrainName { get; set; }
        public string Get()
        {
            return $"Cargo Train: {TrainName} ";
        }
    }
}
