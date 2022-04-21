using LinqAssignment;
using System.Linq;
namespace LinqAssignment
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Filtering();
            Ordering();
            Quantifiers();
            Generation();
            Projection();
            Grouping();
            ElementOperators();
            DataConversion();
            Aggregation();
            SetOperations();
            Joins();
        }

        private static void PrintCollection<T>(IEnumerable<T> source)
        {
            foreach (var item in source)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("/////////////////////////");
        }

        public static void Filtering()
        {
            PrintCollection(_cars);

            // Where (deffered execution)
            var newCars = _cars.Where(car => car.IsNew);
            PrintCollection(newCars);
 
            // Skip
            var allButFirstTwo= _cars.Skip(2);
            PrintCollection(allButFirstTwo);
            // SkipWhile

            var result = _cars.SkipWhile(car => car.Year == 2014);
            PrintCollection(result);
            
            // Take
            var result1 = _cars.Take(2);
            PrintCollection(result1);

            // TakeWhile
            var result2 = _cars.TakeWhile(x => x.Year<2014);
            PrintCollection(result2);

            // Chunk
            var chunkedResult = _cars.Chunk(2);
            PrintCollection(chunkedResult);

            // OfType
            var damagedCars = _cars.OfType<DamagedCar>();
            PrintCollection(damagedCars);

        }

        public static void Ordering()
        {
            // OrderBy, ThenBy
            var ordered = _cars.OrderBy(x => x.ManufacturerName).ThenBy(x => x.ModelName).ThenBy(x => x.Year).ToList();
            PrintCollection(ordered);

            // OrderByDescending, ThenByDescending
            var orderdes = _cars.OrderByDescending(x => x.Year).ThenByDescending(x=>x.ManufacturerName).ThenByDescending(x => x.ModelName).ToList();
            PrintCollection(orderdes);
            // Reverse
            var revorder = _cars.OrderBy(x => x.Year).Reverse();
            PrintCollection(revorder);
        }

        public static void Quantifiers()
        {
            // Any
            Console.WriteLine(_cars.Any(x => x.Year == 2014));
            Console.WriteLine("/////////////////////////");
            // All
            Console.WriteLine(_cars.All(x => x.Year ==2014));
            Console.WriteLine("/////////////////////////");
            // Contains
            var cc1 = new Car { ManufacturerName = "BMW", ModelName = "X1", Year = 2021, IsNew = true, ShowroomId = 1 };
            Console.WriteLine(_cars.Contains(cc1));
            Console.WriteLine("/////////////////////////");
            // SequenceEqual
            var equals=new List<int> {1,2,3 }.SequenceEqual(new[] { 1,2,4});
            Console.WriteLine(equals);
            Console.WriteLine("/////////////////////////");
        }

        public static void Projection()
        {
            // Select (anonymus types)
            var manufacturerNames = _cars.Select(x => x.ManufacturerName);
            PrintCollection(manufacturerNames);

            // SelectMany
            var allCars = _showrooms.SelectMany(x => x.Cars);
            PrintCollection(allCars);
        }

        public static void Grouping()
        {
            // GroupBy
            var grupedCars = _cars.GroupBy(x => x.ManufacturerName);

            foreach (var manufacturerName in grupedCars)
            {
                Console.WriteLine(manufacturerName.Key);
                foreach (var car in manufacturerName)
                {
                    Console.WriteLine(car);
                }
            }
        }

        public static void Generation()
        {
            // DefaultIfEmpty
            var e = _cars.Where(x => x.Year < 200).DefaultIfEmpty(_cars.Where(x=>x.Year==2011).First());
            PrintCollection(e);
            // Empty
            var sh = Enumerable.Empty<Showroom>();
            PrintCollection(sh);
            // Range
            IEnumerable<int> ss = Enumerable.Range(5, 3);
            PrintCollection(ss);
            // Repeat
            IEnumerable<int> ss2 = Enumerable.Repeat(5, 3);
            PrintCollection(ss2);

        }

        public static void ElementOperators()
        {
            // First, FirstOrDefault
            var first = _cars.Where(x => x.Year == 2014).First();
            Console.WriteLine(first);
            Console.WriteLine("/////////////////////////");
            var firstdef = _cars.Where(x => x.Year == 200).FirstOrDefault(first);
            Console.WriteLine(firstdef);
            Console.WriteLine("/////////////////////////");
            // Last, LastOrDefault
            var last = _cars.Where(x => x.Year == 2014).Last();
            Console.WriteLine(last);
            Console.WriteLine("/////////////////////////");
            var lastdef = _cars.Where(x => x.Year == 200).LastOrDefault(last);
            Console.WriteLine(lastdef);
            Console.WriteLine("/////////////////////////");
            // Single, SingleOrDefault
            var single= _cars.Where(x => x.Year ==2011).Single();
            Console.WriteLine(single);
            Console.WriteLine("/////////////////////////");
            var singledef = _cars.Where(x => x.Year == 200).SingleOrDefault(single);
            Console.WriteLine(singledef);
            Console.WriteLine("/////////////////////////");
            // ElementAt, ElementAtOrDefault
            var eleat= _cars.Where(x => x.Year ==2014).ElementAt(1);
            Console.WriteLine(eleat);
            Console.WriteLine("/////////////////////////");
            var eleatdef= _cars.Where(x => x.Year == 200).ElementAtOrDefault(1);
            Console.WriteLine(eleatdef);
            Console.WriteLine("/////////////////////////");
        }

        public static void DataConversion()
        {
            // Cast (throws InvalidCastException if unable to cast an item in the collection)
            var cst=_cars.Select(x=>x.ManufacturerName).Cast<string>();
            PrintCollection(cst);
            // ToDictionary (simply by a key or with element selector)
            var dict = _showrooms.ToDictionary(x=>x.Id);
            PrintCollection(dict);
            // ToLookup
            var lkp = _showrooms.ToLookup(x => x.Id);
            PrintCollection(lkp);
        }

        public static void Aggregation()
        {
            // Aggregate
            var allModelNames = _cars.Aggregate("", (previewsResult, car) => previewsResult + car.ModelName, allModelNames => allModelNames);
            Console.WriteLine(allModelNames);
            Console.WriteLine("////////////////////");
            // Average
            var yearAvg= _cars.Average(x => x.Year);
            Console.WriteLine(yearAvg);
            Console.WriteLine("//////////////////");
            // Count, LongCount
            var carCount=_cars.Count();//difera doar marimea count este pe 32 iar longcount pe 64
            Console.WriteLine(carCount);
            Console.WriteLine("/////////////////");
            // Max, MaxBy
            var maxcaryear= _cars.Max(x => x.Year);
            Console.WriteLine(maxcaryear);
            Console.WriteLine("///////////////////");
            var maxbycaryear = _cars.MaxBy(x => x.Year);
            Console.WriteLine(maxbycaryear);
            Console.WriteLine("///////////////////");
            // Min, MinBy
            var mincaryear = _cars.Min(x => x.Year);
            Console.WriteLine(mincaryear);
            Console.WriteLine("/////////////");
            var minbycaryear = _cars.MinBy(x => x.Year);
            Console.WriteLine(minbycaryear);
            Console.WriteLine("/////////////");
            // Sum
            var yearsum= _cars.Sum(x => x.Year);
            Console.WriteLine(yearsum);
            Console.WriteLine("///////////////");
        }

        public static void SetOperations()
        {
            // Distinct, DistinctBy
            var dst = _cars.Select(x=>x.Year).Distinct();
            PrintCollection(dst);
            var dstby= _showrooms.Select(x=>x.Name).DistinctBy(x=>x.First());
            PrintCollection(dstby);
            // Except, ExeceptBy
            var exc = _cars.Select(x=>x.ManufacturerName).Except(_cars1.Select(x=>x.ManufacturerName));
            PrintCollection(exc);
            var exc1 = _cars.ExceptBy(_cars1.Select(x => x.ManufacturerName), x => x.ManufacturerName);
            PrintCollection(exc1);
            // Intersect, IntersectBy
            var inter = _cars1.Intersect(_cars);
            PrintCollection(inter);
            var inter1 = _cars1.IntersectBy(_cars.Select(x=>x.ManufacturerName),x=>x.ManufacturerName);
            PrintCollection(inter1);
            // Union, UnionBy (distinct union)
            var uni = _cars.Union(_cars1);
            PrintCollection(uni);
            var uni1 = _cars.Select(x => x.ManufacturerName).UnionBy(_cars1.Select(x => x.ManufacturerName),x=>x.Equals(_cars1.Select(x => x.ManufacturerName)));
            PrintCollection(uni1);
            // Concat (non distinct)
            var conc = _cars.Concat(_cars1);
            PrintCollection(conc);

        }

        public static void Joins()
        {
            // Join 
            var showroomsByCar = from car in _cars
                                     join showroom in _showrooms on car.ShowroomId equals showroom.Id
                                     select new { car.ManufacturerName, showroom.Name };

            PrintCollection(showroomsByCar);
            //Outer Join
            var showroomsByCar1 = from showroom in _showrooms
                                  join car in _cars on showroom.Id equals car.ShowroomId into joined from j in joined.DefaultIfEmpty(new Car { ManufacturerName="scapam de exceptie"})
                                 select new { j.ManufacturerName, showroom.Name };
            PrintCollection(showroomsByCar1);
            // GroupJoin
            var carsByShowroom = from showroom in _showrooms
                                    join car in _cars on showroom.Id equals car.ShowroomId into showroomGroup
                                    select new { showroom.Name, showroomGroup };

            foreach (var studentGroup in carsByShowroom)
            {
                Console.WriteLine(studentGroup.Name);
                foreach (var car in studentGroup.showroomGroup)
                {
                    Console.WriteLine(car);
                }

            }
            Console.WriteLine("/////////////////////////////");
            // Zip
            int[] price = { 1, 2, 3, 4, 5, 6, 7 };
            var zip=_cars.Zip(price);
            PrintCollection(zip);
        }

        private static readonly IEnumerable<Car> _cars = CreateCarList();
        private static IEnumerable<Car> CreateCarList()
        {
            return new List<Car>
            {
                new Car {ManufacturerName = "BMW",ModelName="X1",Year=2011,IsNew=false,ShowroomId=1},
                new Car {ManufacturerName = "Mercedes",ModelName="CLA",Year=2014,IsNew=false,ShowroomId=2},
                new Car {ManufacturerName = "BMW",ModelName="X5",Year=2021,IsNew=true,ShowroomId=1},
                new Car {ManufacturerName = "BMW",ModelName="X3",Year=2014,IsNew=false,ShowroomId=3},
                new DamagedCar {ManufacturerName = "Audi",ModelName="A4",Year=2013,IsNew=false,ShowroomId=1,DamageDescription="Damaged rear bumper"},
                new DamagedCar {ManufacturerName = "BMW",ModelName="X2",Year=2021,IsNew=true,ShowroomId=3,DamageDescription="Damaged front bumper"},
                new Car {ManufacturerName = "Mercedes",ModelName="GLA",Year=2022,IsNew=true,ShowroomId=2},
 
            };
        }

        private static readonly IEnumerable<Showroom> _showrooms = CreateShowroomList();
        private static IEnumerable<Showroom> CreateShowroomList()
        {
            return new List<Showroom>
            {
                new Showroom {Id = 1, Name = "AutoShow",
                    Cars= new List<Car>{new Car() { ModelName="c1"} , new Car { ModelName = "c2" } } },
                new Showroom {Id = 2, Name ="TAuto",
                    Cars=new List<Car>{new Car() { ModelName="c3"},new Car{ ModelName="c4"}}},
                //new Showroom {Id = 3, Name ="AAuto"},
               // new Showroom {Id = 4, Name ="BAuto"},
                
            };
        }
        private static readonly IEnumerable<Car> _cars1 = CreateCrList();
        private static IEnumerable<Car> CreateCrList()
        {
            return new List<Car>
            {

                new Car {ManufacturerName = "BMW",ModelName="X1",Year=2011,IsNew=false,ShowroomId=1},
                new Car {ManufacturerName = "Renault",ModelName="Megane",Year=2011,IsNew=false,ShowroomId=1}

            };
        }
    }
}
