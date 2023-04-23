using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>
    {
        
        private T[] array;
        public CustomList()
        {
            array = new T[0];
        }

        public void Add(T nese)
        {
            Array.Resize(ref array, array.Length+1);
            array[array.Length-1] = nese;   
        }


        public T Find(Predicate<T> func)
        {
            foreach (T item in array)
            {
                if (func(item))
                {
                    return item;
                }
            }
            return null;
        }
        

    }
}
