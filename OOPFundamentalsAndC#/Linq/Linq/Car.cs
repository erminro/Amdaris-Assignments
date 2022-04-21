using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAssignment
{
    public class Car
    {
        public string ManufacturerName { get; set; }
        public string ModelName { get; set; }
        public int Year { get; set; }
        public bool IsNew { get; set; }
        public int ShowroomId { get; set; }

        public override string ToString()
        {
            return $"{ManufacturerName} {ModelName} from {Year} {(IsNew ? "is new ":"" )} ";
        }

    }
    public class DamagedCar : Car
    {
        public string DamageDescription { get; set; }
    }
    public class Showroom
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Car> Cars { get; set; }
    }

}
