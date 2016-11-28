namespace FactoryMethod.Products
{
    using System.Text;

    public abstract class Gsm
    {
        public int BatteryLife { get; set; }

        public int Weight { get; set; }

        public int Height { get; set; }

        public int Width { get; set; }

        public string Name { get; set; }

        public abstract void Start();

        public override string ToString()
        {
            var gsmAsString = new StringBuilder();

            gsmAsString.AppendLine($"Phone name: {this.Name}");
            gsmAsString.AppendLine($"Height: {this.Height}");
            gsmAsString.AppendLine($"Width: {this.Width}");
            gsmAsString.AppendLine($"Weight: {this.Weight}");
            gsmAsString.AppendLine($"Battery life: {this.BatteryLife}");

            return gsmAsString.ToString();
        }
    }
}
