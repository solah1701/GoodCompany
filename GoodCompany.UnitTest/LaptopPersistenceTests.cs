using GoodCompany.Models;
using GoodCompany.Services;
using NUnit.Framework;
using System;

namespace GoodCompany.UnitTest
{
    public class LaptopPersistenceTests
    {
        public LaptopPersistenceService sut;

        public Laptop testRecord;
        public Laptop errorRecord;
        public Laptop existingRecord;

        [SetUp]
        public void SetUp()
        {
            sut = new LaptopPersistenceService();
            testRecord = new Laptop
            {
                Id = 4,
                Brand = "TestBrand",
                ComputerType = "Laptop",
                FormFactor = "Normal",
                Processor = "Mobile",
                Quantity = 1,
                RamSlots = 2,
                ScreenSize = "Standard",
                UsbPorts = 2
            };
            errorRecord = new Laptop
            {
                Id = 3,
                Brand = "TestBrand",
                ComputerType = "Laptop",
                FormFactor = "Normal",
                Processor = "Mobile",
                Quantity = 1,
                RamSlots = 2,
                ScreenSize = "Standard",
                UsbPorts = 2
            };
            existingRecord = sut.Load()[0];
        }

        [Test]
        public void Load_Returns_One_Record()
        {
            const int expectedCount = 1;
            var actualCount = sut.Load().Count;

            Assert.AreEqual(expectedCount, actualCount);
        }

        [Test]
        public void Add_Increases_Record_Count_to_Two_Records()
        {
            const int expectedCount = 2;
            sut.Add(testRecord);
            var actualCount = sut.Load().Count;

            Assert.AreEqual(expectedCount, actualCount);
        }

        [Test]
        public void Add_Throws_Exception_If_Duplicate_Id_Is_Used()
        {
            Assert.Throws<ArgumentException>(() => sut.Add(errorRecord));
        }

        [Test]
        public void Delete_Decreases_Record_Count_to_Zero_Records()
        {
            const int expectedCount = 0;
            sut.Delete(existingRecord);
            var actualCount = sut.Load().Count;

            Assert.AreEqual(expectedCount, actualCount);
        }


    }
}
