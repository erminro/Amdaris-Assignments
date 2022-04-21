using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Collection<T>
    {
        private T[] list = new T[10000];
        private int index = 0;

        public void SetTrainPassenger(int i, T s)
        {
            list[i] = s;
        }
        public T GetTrainPassengers(int i)
        {
            if (list[i] == null)
            {
                return default(T);
            }
            return list[i];
        }

        public void SwapTrainPassengers(int index1, int index2)
        {
            T aux;
            aux = list[index1];
            list[index1] = list[index2];
            list[index2] = aux;
        }

        public void Add(T item)
        {
            if (index < 10000)
            {
                list[index] = item;
                index++;
            }
            else
            {
                throw new InvalidOperationException("Collection is full!");
            }
        }

        public T Remove()
        {
            index--;
            if (index >= 0)
            {
                T aux = list[index];
                list[index] = default(T);
                return aux;
            }
            else
            {
                index = 0;
                throw new InvalidOperationException("Collection is empty!");
            }
        }
        public T[] Get()
        {
            return list;
        }
    }
}

