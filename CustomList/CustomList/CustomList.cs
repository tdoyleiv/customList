using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T> where T : IComparer<T>, IEqualityComparer<T>
    {
        private int count;
        private T[] array = new T[] { };
        public T this[int i] => array[i];
        public void AddElement(object element)
        {

        }
        public void ClearElements()
        {

        }
        public void ContainsELement(object element)
        {

        }
        public void IndexOfElement(object element)
        {

        }
        public void InsertElement(Int32 index, object element)
        {

        }
        public void RemoveElementAtIndex(Int32 index)
        {

        }
        public void CompareElementTo(object otherElement, IComparer<T> comparableElement)
        {

        }
        public void ElementEquals(object otherElement, IEqualityComparer<T> comparableElement)
        {

        }
        public void GetElementHashCode(IEqualityComparer<T> comparableElement)
        {

        }
    }
}
