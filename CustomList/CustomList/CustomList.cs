using System;
using System.Collections;
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
            if ((index < count) && (index >= 0))
            {
                array[index] = element;
            }
            else
            {
                throw new ArgumentOutOfRangeException("{0} caused by nonexistent index parameter, Insert(int index)", "ArgumentOutOfRangeException");
            }
        }
        public override string ToString() 
        {
            string returnValue = string.Empty;
            for (int i = 0; i < count; i++)
            {
                if (string.IsNullOrEmpty(returnValue))
                    returnValue += array[i].ToString();
                else
                    returnValue += string.Format("{0}", array[i]);
            }
            return returnValue;
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
        private IEnumerable<T> Event()
        {
            for (int index = 0; index < count; index++)
            {
                yield return array[index];
            }
        }
        public IEnumerator<T> GetEnumerator()
        {
            return Event().GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public static CustomList<T> operator +(CustomList<T> c1, CustomList<T> c2)
        {
            CustomList<T> c3 = c1;

            
            return new CustomList<T>(c1 + c2);     
        }
    }
}
