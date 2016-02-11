namespace Builder.Directors
{
    using Builders;

    /// The 'Director' class constructs an object using the Builder interface
    public class VehicleConstructor : IVehicleConstructor
    {
        // There may be different constructors (with different steps order)
        public void Construct(VehicleBuilder vehicleBuilder)
        {
            vehicleBuilder.BuildFrame();
            vehicleBuilder.BuildEngine();
            vehicleBuilder.BuildWheels();
            vehicleBuilder.BuildDoors();
        }
    }
}