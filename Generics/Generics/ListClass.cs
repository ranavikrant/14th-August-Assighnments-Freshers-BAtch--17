using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class ListClass<T>
    {
        public T[] array=new T[10];
        public int i = 0;
        public void add(T t)
        {
            array[i] =t;
            i++;
            
        }

    }
}
