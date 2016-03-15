using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rules;

namespace RulesTest
{
    [TestClass]
    public class SystemRequirementsTests
    {
        private SystemRequirementsChecker sut;
        private Computer computer;
        public SystemRequirementsTests()
        {
            sut = new SystemRequirementsChecker();
        }

        [TestInitialize]
        public void Init()
        {
            computer = new Computer();
        }

        [TestMethod]
        public void MustBeWindowsOperatingSystem()
        {
            computer.OperatingSystem = "Linux";
            Assert.IsFalse(sut.CheckSystem(computer));
        }

        [TestMethod]
        public void MustHave3GHzOrMore()
        {
            computer.Ghz = 2.9;
            Assert.IsFalse(sut.CheckSystem(computer));
        }

        [TestMethod]
        public void MustHave4GbOrMoreOfRam()
        {
            computer.Ram = 3;
            Assert.IsFalse(sut.CheckSystem(computer));
        }

        [TestMethod]
        public void MustHave10GbOrMoreOfDiskSpace()
        {
            computer.DiskSpace = 9;
            Assert.IsFalse(sut.CheckSystem(computer));
        }

        [TestMethod]
        public void DefaultModelValuesAreValid()
        {
            Assert.IsTrue(sut.CheckSystem(computer));
        }
    }
}
