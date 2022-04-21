using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD
{
    public class Wearhouse
    {
        private int _capacity;
        private int _fill;
        public Wearhouse(int capacity)
        {
            _capacity = capacity;
        }
        public int Capacity { get { return _capacity; } }
        public int Fill { get { return _fill; } }
        public int increaseCapacity(int addcapacity)
        {
            _capacity += addcapacity;
            return _capacity;
        }
        public void fillWearhouse(int amount)
        {
            if (amount > 0 && _fill + amount <= _capacity)
                _fill += amount;
        }
        public void deliver()
        {
            _fill = 0;
        }
        public void operate()
        {
            if (_fill == _capacity)
            {
                fillWearhouse(_capacity);
                deliver();
            }
            else
            {
                fillWearhouse(_capacity);
                deliver();
            }
        }
        
    }
}
