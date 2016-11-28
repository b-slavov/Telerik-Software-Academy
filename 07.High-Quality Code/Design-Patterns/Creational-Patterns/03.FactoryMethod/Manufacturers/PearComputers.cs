namespace FactoryMethod.Manufacturers
{
    using FactoryMethod.Products;

    public class PearComputers : Manufacturer
    {
        public override Gsm ManufactureGsm()
        {
            return new EyePhone { BatteryLife = 1000, Height = 200, Weight = 100, Width = 50 };
        }
    }
}
