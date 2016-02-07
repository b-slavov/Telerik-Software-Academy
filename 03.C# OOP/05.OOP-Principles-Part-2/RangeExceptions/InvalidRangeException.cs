namespace RangeExceptions
{
    using System;

    public class InvalidRangeException<T> : ApplicationException
        where T : IComparable<T>
    {
        private T end;

        public InvalidRangeException(T start, T end)
            : base(string.Format("You are out of range[{0}..{1}]!", start, end))
        {
            this.Start = start;
            this.End = end;
        }

        public T Start { get; private set; }

        public T End
        {
            get
            {
                return this.end;
            }

            private set
            {
                if (this.Start.CompareTo(value) > 0)
                {
                    throw new ArgumentException("The end should be after the start");
                }

                this.end = value;
            }
        }
    }
}