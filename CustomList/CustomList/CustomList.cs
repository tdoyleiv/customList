﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>
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
            if (Count < capacity)
            {
                array[Count] = element;
                IncrementCount(Count);
            }
            else if (Count >= capacity)
            {
                DoubleCapacity(capacity);
                array[Count] = element;
                IncrementCount(Count);
            }
        }
        public void Remove(T element)
        {

        }
        public void Contains(T element)
        {

        }
        public void IndexOf(T element)
        {

        }
        public void Insert(int index, T element)
        {

        }
        public void RemoveAt(int index)
        {

        }
        public int IncrementCount(int count)
        {
            return Count++;
        }
        public int DoubleCapacity(int capacity)
        {
           return capacity * 2;
        }
    }
}
