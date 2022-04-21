namespace Generics
{
    public class Program
    {
        static void Main(string[] args)
        {
            var TrainPassengers1 = new TrainPassenger
            {
                PassengerName = "Alex Stanciu",
                Trainid = 1,
                SeatNumber = 22
            };

            var TrainPassengers2 = new TrainPassenger
            {
                PassengerName = "Alex Bija",
                Trainid = 1,
                SeatNumber = 10,
            };

            var TrainPassengers3 = new TrainPassenger
            {
                PassengerName = "Andrei Grigore",
                Trainid = 2,
                SeatNumber = 3,
            };

            var TrainPassengers4 = new TrainPassenger
            {
                PassengerName = "Chris Carpineanu",
                Trainid = 1,
                SeatNumber = 8,
            };


            Collection<TrainPassenger> _TrainPassengers1 = new Collection<TrainPassenger>();

            _TrainPassengers1.Add(TrainPassengers1);
            _TrainPassengers1.Add(TrainPassengers2);
            _TrainPassengers1.Add(TrainPassengers3);
            _TrainPassengers1.Add(TrainPassengers4);

            foreach (TrainPassenger TrainPassengers in _TrainPassengers1.Get())
            {
                if (TrainPassengers != null)
                {
                    Console.WriteLine(TrainPassengers);

                }

            }

            Console.WriteLine();
            Console.WriteLine(_TrainPassengers1.GetTrainPassengers(3));
            Console.WriteLine();
            _TrainPassengers1.SwapTrainPassengers(0, 2);
            _TrainPassengers1.SetTrainPassenger(0, TrainPassengers2);
            foreach (TrainPassenger TrainPassengers in _TrainPassengers1.Get())
            {
                if (TrainPassengers != null)
                {
                    Console.WriteLine(TrainPassengers);

                }
            }

            Console.WriteLine();
            _TrainPassengers1.Remove();
            foreach (TrainPassenger TrainPassengers in _TrainPassengers1.Get())
            {
                if (TrainPassengers != null)
                {
                    Console.WriteLine(TrainPassengers);
                }

            }
        }
    }
}