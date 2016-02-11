namespace Computers.Tests
{
    using Logic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    
    [TestClass]
    public class LaptopBatteryChargeTest
    {
        [TestMethod]
        public void ChargeShouldAddToPercentageWhenPositiveNumberIsGiven()
        {
            var battery = new LaptopBattery();
            battery.Percentage = LaptopBattery.DefaultBatteryPercentage;
            battery.Charge(10);
            Assert.AreEqual(60, battery.Percentage);
        }

        [TestMethod]
        public void ChargeShouldSubstractFromPercentageWhenNegativeNumberIsGiven()
        {
            var battery = new LaptopBattery();
            battery.Percentage = LaptopBattery.DefaultBatteryPercentage;
            battery.Charge(-10);
            Assert.AreEqual(40, battery.Percentage);
        }

        [TestMethod]
        public void ChargeShouldNotAddToPercentageWhenPositiveNumberIsGivenAndCurrentPercentageIsHundered()
        {
            var battery = new LaptopBattery();
            battery.Percentage = LaptopBattery.MaxBatteryPercentage;
            battery.Charge(10);
            Assert.AreEqual(LaptopBattery.MaxBatteryPercentage, battery.Percentage);
        }

        [TestMethod]
        public void ChargeShouldNotSubstractFromPercentageWhenNegativeNumberIsGivenAndCurrentPercentageIsZero()
        {
            var battery = new LaptopBattery();
            battery.Percentage = LaptopBattery.MinBatteryPercentage;
            battery.Charge(-10);
            Assert.AreEqual(LaptopBattery.MinBatteryPercentage, battery.Percentage);
        }

        [TestMethod]
        public void ChargeShouldNotAddToPercentageOrSubstractFromItWhenZeroIsGiven()
        {
            var battery = new LaptopBattery();
            battery.Percentage = LaptopBattery.DefaultBatteryPercentage;
            battery.Charge(0);
            Assert.AreEqual(LaptopBattery.DefaultBatteryPercentage, battery.Percentage);
        }
    }
}