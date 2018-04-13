using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    public class GarageClass<T> : IEnumerable<T> where T : Vehicle
    {
        T[] vehicles;

        int cap, count;
        public GarageClass(int capacity)
        {
            cap = capacity;
            count = 0;
            vehicles = new T[capacity];
        }

        public void Leave(T input)
        {
            if (cap > count)
            {
                vehicles[count++] = input;
            }
        }


        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return vehicles[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
