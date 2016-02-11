namespace Cpu.Rand.Tests
{
    using System;
    using System.Collections.Generic;
    using Computers.Logic;
    using Computers.Logic.Cpus;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Moq;
    
    [TestClass]
    public class RandTests
    {
        [TestMethod]
        public void RandShouldNotProduceNumbersLessThanMinValue()
        {
            var cpu = new Cpu32(2);
            var motherboardMock = new Mock<IMotherboard>();
            cpu.AttachTo(motherboardMock.Object);
            var globalMin = int.MaxValue;
            motherboardMock.Setup(x => x.SaveRamValue(It.IsAny<int>()))
                .Callback<int>(z => globalMin = Math.Min(globalMin, z));
            for (int i = 0; i < 10000; i++)
            {
                cpu.Rand(1, 10);
            }

            Assert.AreEqual(1, globalMin);
        }

        [TestMethod]
        public void RandShouldNotProduceNumbersGreaterThanMaxValue()
        {
            var cpu = new Cpu32(2);
            var motherboardMock = new Mock<IMotherboard>();
            cpu.AttachTo(motherboardMock.Object);
            var globalMax = int.MinValue;
            motherboardMock.Setup(x => x.SaveRamValue(It.IsAny<int>()))
                .Callback<int>(z => globalMax = Math.Max(globalMax, z));
            for (int i = 0; i < 10000; i++)
            {
                cpu.Rand(1, 10);
            }

            Assert.AreEqual(10, globalMax);
        }

        [TestMethod]
        public void RandShouldAlwaysReturnRandomNumbers()
        {
            var hashSet = new HashSet<int>();
            var cpu = new Cpu32(2);
            var motherboardMock = new Mock<IMotherboard>();
            cpu.AttachTo(motherboardMock.Object);
            motherboardMock.Setup(x => x.SaveRamValue(It.IsAny<int>()))
                .Callback<int>(z => hashSet.Add(z));
            for (int i = 0; i < 10000; i++)
            {
                cpu.Rand(1, 10);
            }

            Assert.AreEqual(10, hashSet.Count);
        }
    }
}