namespace LinqAssignment
{
    public static class Earthquake
    {
        public static void Main(string[] args)
        {
            var minmalDmage = EarthquakeMagnitude.Richter3;
            if (minmalDmage.IsMinimalDamage())
            {
                Console.WriteLine("Good chane of minimal damage");
            }
            else
            {
                Console.WriteLine("Damage won't be minimal");
            }

        }
    }

    public enum EarthquakeMagnitude
    {
        Richter1,
        Richter2,
        Richter3,
        Richter4,
        Richter5,
        Richter6,
        Richter7,
        Richter8,
        Richter9,
        Richter10
    }
    public static class EarthquakeMagnitudeExtensions
    {
        public static bool IsMinimalDamage(this EarthquakeMagnitude minmalDmage)
        {
            switch (minmalDmage)
            {
                case EarthquakeMagnitude.Richter4:
                case EarthquakeMagnitude.Richter3:
                case EarthquakeMagnitude.Richter2:
                case EarthquakeMagnitude.Richter1:
                    return true;
                case EarthquakeMagnitude.Richter5:
                case EarthquakeMagnitude.Richter6:
                case EarthquakeMagnitude.Richter7:
                case EarthquakeMagnitude.Richter8:
                case EarthquakeMagnitude.Richter9:
                case EarthquakeMagnitude.Richter10:
                    return false;
                default:
                    throw new Exception("No such case");
            }
        }
    }
    }

