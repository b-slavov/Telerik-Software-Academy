namespace Iterator.ClearImplementation
{
    using System.Collections;

    public class ConcreteAggregate : Aggregate
    {
        private readonly ArrayList items = new ArrayList();

        public int Count
        {
            get
            {
                return this.items.Count;
            }
        }

        public object this[int index]
        {
            get
            {
                return this.items[index];
            }

            set
            {
                this.items.Insert(index, value);
            }
        }

        public override IIterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }
    }
}
