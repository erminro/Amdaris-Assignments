using CreationalPatterns.Factories;
using CreationalPatterns.Interfaces;


namespace CreationalPatterns
{
    public class Program
    {
        static void Main(string[] args)
        {
            ITrainTypeFactory trainTypeFactory;
            SingletoneRandomNumber b1 = SingletoneRandomNumber.GetLoadBalancer();
            if (b1.RandomNumber % 2 == 0)
            {
                trainTypeFactory = new CargoTrainFactory() { Name="AAA"} ;
            }
            else
            {
                trainTypeFactory = new PassengerTrainFactory() { Name="BBBB"};
            }
            ITrainType trainType=trainTypeFactory.Create();
            Console.WriteLine(trainType.Get());
        }
    }
}