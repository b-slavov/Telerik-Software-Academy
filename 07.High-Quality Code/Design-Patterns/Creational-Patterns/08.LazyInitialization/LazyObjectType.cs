namespace LazyInitialization
{
    // Enumeration for passing name of type required. Avoids passing strings and is part of type ahead
    public enum LazyObjectType
    {
        None,
        Small,
        Big,
        Bigger,
        Huge
    }
}