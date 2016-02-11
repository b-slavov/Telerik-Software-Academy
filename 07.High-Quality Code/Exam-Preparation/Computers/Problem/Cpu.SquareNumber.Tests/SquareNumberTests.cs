namespace Cpu.SquareNumber.Tests
{
    using Computers.Logic;
    using Computers.Logic.Cpus;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Moq;

    [TestClass]
    public class SquareNumberTests
    {
        [TestMethod]
        public void SquareNumberShouldOutputCorrectValues()
        {
            var cpu = new Cpu32(4);
            var motherboardMock = new Mock<IMotherboard>();
            motherboardMock.Setup(x => x.LoadRamValue()).Returns(123);
            cpu.AttachTo(motherboardMock.Object);
            cpu.SquareNumber();
            motherboardMock.Verify(x => x.DrawOnVideoCard(It.Is<string>(z => z.Contains("15129"))));
        }

        [TestMethod]
        public void SquareNumberShouldOutputErrorMessageWhenValueIsLessThanZero()
        {
            var cpu = new Cpu32(4);
            var motherboardMock = new Mock<IMotherboard>();
            motherboardMock.Setup(x => x.LoadRamValue()).Returns(-1);
            cpu.AttachTo(motherboardMock.Object);
            cpu.SquareNumber();
            motherboardMock.Verify(x => x.DrawOnVideoCard(It.Is<string>(z => z == Cpu.NumberTooLowMessage)));
        }

        [TestMethod]
        public void SquareNumberInCpu32ShouldOutputErrorMessageWhenValueIsGreaterThanMaxValue()
        {
            var cpu = new Cpu32(4);
            var motherboardMock = new Mock<IMotherboard>();
            motherboardMock.Setup(x => x.LoadRamValue()).Returns(Cpu32.MaxValue + 1);
            cpu.AttachTo(motherboardMock.Object);
            cpu.SquareNumber();
            motherboardMock.Verify(x => x.DrawOnVideoCard(It.Is<string>(z => z == Cpu.NumberTooHighMessage)));
        }

        [TestMethod]
        public void SquareNumberInCpu64ShouldOutputErrorMessageWhenValueIsGreaterThanMaxValue()
        {
            var cpu = new Cpu64(4);
            var motherboardMock = new Mock<IMotherboard>();
            motherboardMock.Setup(x => x.LoadRamValue()).Returns(Cpu64.MaxValue + 1);
            cpu.AttachTo(motherboardMock.Object);
            cpu.SquareNumber();
            motherboardMock.Verify(x => x.DrawOnVideoCard(It.Is<string>(z => z == Cpu.NumberTooHighMessage)));
        }

        [TestMethod]
        public void SquareNumberInCpu128ShouldOutputErrorMessageWhenValueIsGreaterThanMaxValue()
        {
            var cpu = new Cpu128(4);
            var motherboardMock = new Mock<IMotherboard>();
            motherboardMock.Setup(x => x.LoadRamValue()).Returns(Cpu128.MaxValue + 1);
            cpu.AttachTo(motherboardMock.Object);
            cpu.SquareNumber();
            motherboardMock.Verify(x => x.DrawOnVideoCard(It.Is<string>(z => z == Cpu.NumberTooHighMessage)));
        }
    }
}