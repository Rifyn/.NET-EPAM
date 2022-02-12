using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DYNAMIC_ARRAY
{
    public class DynamicArray<T> : IEnumerable<T>, ICloneable
    {
        protected T[] array;
        public int Capacity { get; private set; }
        public int Length { get; private set; }
        public DynamicArray() : this(8) { }
        public DynamicArray(int capacity)
        {
            Capacity = capacity;
            array = new T[capacity];
        }
        public DynamicArray(IEnumerable<T> sourse)
        {
            array = sourse.ToArray();
            Length = array.Length;
            Capacity = Length;
        }

        public void Add(T element)
        {
            ExtentionMass();
            T[] newArray = new T[Capacity];
            array.CopyTo(newArray, 0);
            array = newArray;
            array[Length - 1] = element;
        }
        public bool Remove(T element)
        {
            int index = Array.IndexOf(array, element);
            if (index >= 0)
            {
                T[] newArray = new T[Capacity];
                Array.Copy(array, newArray, index);
                Array.Copy(array, index+1 , newArray, index, Length);
                array = newArray;
                return true;
            }
            else return false;
        }
        public bool Insert(T element, int index)
        {
            if (index <= Length || index < 0)
            {
                ExtentionMass();
                T[] newArray = new T[Capacity];
                //Array.Copy(array, newArray, index);
                //newArray[index] = element;
                //Array.Copy(array, index, newArray, index+1, Lenght);
                int j = 0;
                for (int i = 0; i < Length; i++)
                {
                    if (i != index)
                    {
                        newArray[i] = array[j++];
                    }
                    else newArray[i] = element;
                }
                array = newArray;
                return true;
            }
            else throw new ArgumentOutOfRangeException();
        }
        public void AddRange(IEnumerable<T> collection)
        {
            int position = Length;
            Length += (collection as ICollection).Count;
            while (Length > Capacity)
            {
                Capacity *= 2;
            }
            T[] newArray = new T[Capacity];
            array.CopyTo(newArray, 0);
            array = newArray;
            (collection as ICollection).CopyTo(array, position);
        }
        public override string ToString()
        {
            string res = string.Empty;
            for (int i = 0; i < Length; i++)
            {
                res += array[i] + " ";
            }
            return res;
        }

        public void ExtentionMass()
        {
            Length++;
            if (Length > Capacity)
            {
                Capacity *= 2;
            }
        }
        public T this[int index]
        {
            get
            { 
                return array[NegativeIndex(index)];
            }
            set
            { 
                array[NegativeIndex(index)] = value; 
            }
        }
        public int NegativeIndex(int index)
        {
            if (index < 0)
            {
                index = Length + index;
            }
            return index;
        }

        public void ChangeCapacity(int value)
        {
            if (value < Length)
            {
                Length = value;
            }
            Capacity = value;
        }
        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)array).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return array.GetEnumerator();
        }

        public T[] ToArray()
        {
            T[] result = new T[Length];
            Array.Copy(array, result, Length);
            return result;
        }
        public object Clone() => new DynamicArray<T>(ToArray());
    }
}
