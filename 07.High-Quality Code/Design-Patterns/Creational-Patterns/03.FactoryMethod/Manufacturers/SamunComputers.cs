namespace FactoryMethod.Manufacturers
{
    using FactoryMethod.Products;

    public class SamunComputers : Manufacturer
    {
        public override Gsm ManufactureGsm()
        {
            return new SamunGalaxy { BatteryLife = 999, Height = 199, Weight = 99, Width = 49 };
        }
    }
}
