using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class TrainPassenger
    {
        public int Trainid { get; set; }
        public string PassengerName { get; set; }
        
        public int SeatNumber { get; set; }
        public override string ToString()
        {
            return PassengerName + " is in sit " + SeatNumber + " in train: " + Trainid;
        }
    }
}
