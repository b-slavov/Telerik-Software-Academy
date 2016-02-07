namespace TradeAndTravel
{
    using System.Linq;
    public static class ExtendedPerson
    {
        public static bool HasItemInInventory(this Person actor, ItemType itemType)
        {
            return actor.ListInventory().Any(i => i.ItemType == itemType);
        }
    }
}
