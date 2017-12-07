using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T> : IEnumerable<T>
    {
        private int count;
        private int capacity;
        private T[] array;
        public T this[int i]
        {
            get
            {
                return array[i];
            }
            set
            {
                array[i] = value;
            }
        }
        public int Count
        {
            get
            {
                return count;
            }
            set
            {
                count = value;
            }
        }
        public CustomList()
        {
            count = 0;
            capacity = 5;
            array = new T[capacity];
        }
        public void Add(T element)
        {
            if ((count * 2) >= capacity)
            {
                CreateIncreasedArray();
            }
            array[count] = element;
            IncrementCount();
        }
        public bool Remove(T element)
        {
            bool result = false;
            for (int i = 0; i < count; i++)
            {
                if (array[i].Equals(element))
                {
                    RemoveAt(i);
                    result = true;
                }
            }
            return result;
        }
        public void RemoveAt(int index)
        {
            if ((index < count) && (index >= 0))
            {
                for (int i = index; i < count; i++)
                {
                    {
                        array[i] = array[i + 1];
                    }
                }
                DecrementCount();
            }
            else
            {
                throw new ArgumentOutOfRangeException("{0} caused by nonexistent index parameter, RemoveAt(int index)", "ArgumentOutOfRangeException");
            }
        }
        public bool Contains(T element)
        {
            bool result = false;
            for (int i = 0; i < count; i++)
            {
                if (array[i].Equals(element))
                {
                    result = true;
                }
            }
            return result;
        }
        public int IndexOf(T element)
        {
            int index = 0;
            for (int i = 0; i < count; i++)
            {
                if (array[i].Equals(element))
                {
                    index = i;
                }
            }
            return index;
        }
        public void Insert(int index, T element)
        {
            for (int i = 0; i < count; i++)
            {
                if (array[i].Equals(index))
                {
                    array[i] = element;
                }
            }
        }
        public IEnumerator<T> GetEnumerator()
        {

        }
        public override string ToString()
        {
             
        }
        public void IncrementCount()
        {
            count++;
        }
        public void DoubleCapacity()
        {
           capacity *= 2;
        }
        public void DecrementCount()
        {
            count--;
        }
        public void CreateIncreasedArray()
        {
            DoubleCapacity();
            T[] newArray = new T[capacity];
            for (int i = 0; i < count; i++)
            {
                newArray[i] = array[i];
            }
            array = newArray;
        }
        public void CreateNewArray()
        {
            T[] newArray = new T[capacity];
            for (int i = 0; i < count; i++)
            {
                newArray[i] = array[i];
            }
            array = newArray;
        }
    }
}
