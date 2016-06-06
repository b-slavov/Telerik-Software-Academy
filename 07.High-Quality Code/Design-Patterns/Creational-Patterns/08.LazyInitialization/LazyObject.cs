namespace LazyInitialization
{
    using System.Collections.Generic;
    
    // Standard type of object that will be constructed
    public struct LazyObject
    {
        public LazyObjectType Name;

        public IList<int> Result;
    }
}
