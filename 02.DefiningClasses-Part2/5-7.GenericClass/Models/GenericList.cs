namespace _5_7.GenericClass.Models
{
    using System;
    using System.Text;
    public class GenericList<T> where T : IComparable
    {
        private T[] list;
        private uint index;

        public GenericList(uint capacity)
        {
            if (capacity < 1)
            {
                throw new ArgumentException("The capacity must be greater than 0!");
            }
            this.list = new T[capacity];
            this.index = 0;
        }

        public T[] List
        {
            get
            {
                return this.list;
            }
            private set
            {
                this.list = value;
            }
        }

        public T this[int i]
        {
            get
            {
                if (i >= index)
                {
                    throw new IndexOutOfRangeException();
                }

                return this.List[i];
            }
            set
            {
                if (i > index)
                {
                    throw new IndexOutOfRangeException();
                }

                this.List[i] = value;
            }
        }

        public void Add(T element)
        {
            if (index == list.Length)
            {
                list = IncreaseArrayLength(list);
            }

            this.List[index] = element;
            index++;
        }

        public void Insert(int possition, T element)
        {
            if (possition >= index)
            {
                throw new IndexOutOfRangeException();
            }

            var tempArr = new T[list.Length];
            var tempArrIndex = 0;
            for (int i = 0; i < list.Length; i++)
            {
                if (tempArrIndex == tempArr.Length)
                {
                    tempArr = IncreaseArrayLength(tempArr);
                }

                if (tempArrIndex == possition)
                {
                    tempArr[tempArrIndex] = element;
                    i--;
                }
                else
                {
                    tempArr[tempArrIndex] = list[i];
                }

                tempArrIndex++;
            }

            list = tempArr;
            index++;
        }

        /// <summary>
        /// Return the index of the first occurrence
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public int IsContain(T element)
        {
            return Array.IndexOf(list, element);
        }

        /// <summary>
        /// Remove element on given possition
        /// </summary>
        /// <param name="possition"></param>
        public void Remove(int possition)
        {
            if (possition >= index)
            {
                throw new IndexOutOfRangeException();
            }

            var tempArr = new T[list.Length];
            var tempArrIndex = 0;
            for (int i = 0; i < list.Length; i++)
            {
                if (possition == i)
                {
                    continue;
                }
                else
                {
                    tempArr[tempArrIndex] = list[i];
                }

                tempArrIndex++;
            }

            list = tempArr;
            index--;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            for (int i = 0; i < index; i++)
            {
                if (i == index)
                {
                    sb.Append(list[i]);
                }
                else
                {
                    sb.Append(list[i] + ", ");
                }

            }

            return sb.ToString();
        }

        /// <summary>
        /// Remove all elemnts from the list, but keep the capacity
        /// </summary>
        public void Clear()
        {
            var newArr = new T[list.Length];
            index = 0;
            list = newArr;
        }
        
        public T Min()
        {
            T min = list[0];
            for (int i = 1; i < index; i++)
            {
                if (min.CompareTo(list[i]) > 0)
                {
                    min = list[i];
                }
            }

            return min;
        }

        public T Max()
        {
            T max = list[0];
            for (int i = 1; i < index; i++)
            {
                if (max.CompareTo(list[i]) < 0)
                {
                    max = list[i];
                }
            }

            return max;
        }

        private T[] IncreaseArrayLength(T[] array)
        {
            T[] newArr = new T[array.Length * 2];
            for (int i = 0; i < array.Length; i++)
            {
                newArr[i] = array[i];
            }

            return newArr;
        }
    }
}
