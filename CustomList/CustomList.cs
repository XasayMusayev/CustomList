using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>
    {
        
      private T[] arr={};

        public CustomList()
        {
            arr=new T[0];
        }

        public void Add(T item)
        {
            Array.Resize(ref arr, arr.Length+1);
            arr[arr.Length-1]=item; 
        }


        public T Find(Predicate<T> method)
        {
            foreach (T item in arr)
            {
                if (method(item))
                {
                    return item;
                }
                break;
            }

            
            return default;
             
            
        }
        

    }
}
