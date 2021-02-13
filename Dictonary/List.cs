using System;
using System.Collections.Generic;
using System.Text;

namespace Dictonary
{
    class List<F>
    {
        F[] items;

        public List()
        {
            items = new F[0];
        }
        public void Add(F item)
        {
            F[] tempArray = items;
            items = new F[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item;

        }

    }
}
