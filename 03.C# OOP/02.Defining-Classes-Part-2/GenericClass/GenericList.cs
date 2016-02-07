namespace DefiningClassesPartTwo.GenericClass
{
    using System;
    using System.Text;

    public class GenericList<T>
    {
        // fields
        private T[] elements;
        private int count;

        // constructor
        public GenericList(int size)
        {
            if (size > 0)
            {
                this.elements = new T[size];
                this.count = 0;
            }
            else
            {
                throw new ArgumentException("Size can't be negative or zero.");
            }
        }

        // properties
        public int Count
        {
            get { return this.count; }
        }

        // indexer declaration
        public T this[int index]
        {
            get
            {
                if (index >= 0 && index < this.elements.Length)
                {
                    return this.elements[index];
                }
                else
                {
                    throw new IndexOutOfRangeException(string.Format("Index {0} is invalid!", index));
                }
            }

            set
            {
                if (index >= 0 && index < this.elements.Length)
                {
                    this.elements[index] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException(string.Format("Index {0} is invalid!", index));
                }
            }
        }

        // methods
        public void Add(T element)
        {
            if (this.count == this.elements.Length)
            {
                this.AutoGrow();
            }

            this.elements[this.count] = element;
            this.count++;
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= this.count)
            {
                throw new ArgumentException("Invalid index.");
            }

            // starting from targeted index move back with one position all elements
            for (int i = index; i < this.elements.Length - 2; i++)
            {
                this.elements[i] = this.elements[i + 1];
            }

            // the last element should be released
            this.elements[this.elements.Length - 1] = default(T);
            this.count--;
        }

        public void InsertAt(T element, int index)
        {
            if (index < 0 || index >= this.count)
            {
                throw new ArgumentException("Invalid index.");
            }

            if (this.count == this.elements.Length)
            {
                this.AutoGrow();
            }

            for (int i = this.elements.Length - 1; i > index; i--)
            {
                this.elements[i] = this.elements[i - 1];
            }

            this.elements[index] = element;
            this.count++;
        }

        public void Clear()
        {
            this.elements = new T[this.elements.Length];
            this.count = 0;
        }

        public int Find(T targetElement)
        {
            for (int i = 0; i < this.count; i++)
            {
                if (this.elements[i].Equals(targetElement))
                {
                    return i;
                }
            }

            return -1;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder(this.count);

            for (int i = 0; i < this.count; i++)
            {
                result.AppendLine(string.Format("[{0}] = {1}", i, this.elements[i]));
            }

            return result.ToString().TrimEnd('\n');
        }

        private void AutoGrow()
        {
            T[] doubledArr = new T[this.elements.Length << 1];

            for (int i = 0; i < this.count; i++)
            {
                doubledArr[i] = this.elements[i];
            }

            this.elements = (T[])doubledArr.Clone();
        }
    }
}
