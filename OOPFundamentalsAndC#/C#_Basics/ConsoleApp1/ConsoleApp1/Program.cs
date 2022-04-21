using System;
using System.Collections;

namespace ConsoleApp1
{
    public abstract class Ship
    {
        protected string shipId;
        public Ship(string shipId)
        {
            this.shipId = shipId;
        }
        public string ShipId { get { return shipId; } }
        public void set_sail()
        {
            Console.WriteLine(this.shipId + " set sail");
        }
        public override string ToString()
        {
            return "Ship: " + this.shipId;
        }

    }

    public abstract class CargoShip : Ship
    {

        public CargoShip(string shipId) : base(shipId) { }

        public void loadCargo()
        {
            Console.WriteLine("Ship: " + this.shipId + " loading cargo");
        }
        public virtual void reload() { }
    }

    public abstract class CruiseShip : Ship
    {
        protected int numberOfRooms;

        public CruiseShip(string shipId, int numberOfRooms) : base(shipId)
        {
            this.numberOfRooms = numberOfRooms;
        }
        public int MaxPassengers { get { return numberOfRooms; } set { numberOfRooms = value; } }

        public virtual void embark() { }

    }

    public class Costa_Cruises : CruiseShip
    {
        public Costa_Cruises(string shipId, int numberOfRooms) : base(shipId, numberOfRooms)
        {
        }

        public override void embark()
        {
            Console.WriteLine("Ship: " + this.shipId + " embarks ");
        }
    }

    public class Royal_Caribbean_International : CruiseShip
    {
        public Royal_Caribbean_International(string shipId, int numberOfRooms) : base(shipId, numberOfRooms) { }
        public override void embark()
        {
            Console.WriteLine("Ship: " + this.shipId + " embarks ");
        }

    }

    public class Evergreen : CargoShip
    {
        public Evergreen(string shipId) : base(shipId)
        {

        }
        public override void reload()
        {
            Console.WriteLine("Ship: " + this.shipId + " is reloading");
        }
    }

    public class ShipEnumerator : IEnumerator
    {
        private ShipCollection shipCollection;
        private int position=-1;

        public ShipEnumerator(ShipCollection shipCollection)
        {
            this.shipCollection = shipCollection;
        }

        public Ship Current => shipCollection[position];

        object IEnumerator.Current => Current;

        public bool MoveNext()
        {
            position++;
            return position < shipCollection.Count();
        }

        public void Reset()
        {
            position = -1;
        }
    }

    public class ShipCollection : IEnumerable<Ship>
    {

        public List<Ship> shipList = new List<Ship>();

        public void add(Ship p)
        {
            shipList.Add(p);
        }
        public IEnumerator<Ship> GetEnumerator()
        {
            return shipList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public Ship this[int position] => shipList[position];

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            CruiseShip Costa_Smeralda = new Costa_Cruises("01", 1500);
            Console.WriteLine(Costa_Smeralda.ShipId);

            CruiseShip Wonder_of_the_Seas = new Royal_Caribbean_International("02", 2000);
            Wonder_of_the_Seas.embark();

            CargoShip Ever_ACE = new Evergreen("03");
            Ever_ACE.loadCargo();
            Ever_ACE.reload();


            ShipCollection shipCollection = new ShipCollection();
            shipCollection.add(Costa_Smeralda);
            shipCollection.add(Wonder_of_the_Seas);
            shipCollection.add(Ever_ACE);

            var enumerator = shipCollection.GetEnumerator();

            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }


        }
    }
}
