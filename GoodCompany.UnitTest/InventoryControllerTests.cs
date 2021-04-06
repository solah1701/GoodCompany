using GoodCompany.Controllers;
using GoodCompany.Models;
using GoodCompany.Services;
using NSubstitute;
using NUnit.Framework;

namespace GoodCompany.UnitTest
{
    public class InventoryControllerTests
    {
        public InventoryController sut;

        public IPersistence<Computer> computerPersistence;
        public IPersistence<Laptop> laptopPersistence;

        [SetUp]
        public void SetUp()
        {
            computerPersistence = Substitute.For<IPersistence<Computer>>();
            laptopPersistence = Substitute.For<IPersistence<Laptop>>();

            computerPersistence.Load().Returns(new System.Collections.Generic.List<Computer>
            {
                new Computer
                {
                    Id=1,
                    ComputerType="Desktop PC"
                }
            });

            laptopPersistence.Load().Returns(new System.Collections.Generic.List<Laptop>
            {
                new Laptop
                {
                    Id=3,
                    ComputerType="Laptop"
                }
            });
            sut = new InventoryController(computerPersistence, laptopPersistence);
        }

        [Test]
        public void Index_calls_computer_load_once()
        {
            sut.Index();
            computerPersistence.Received().Load();
        }

        [Test]
        public void Index_calls_laptop_load_once()
        {
            sut.Index();
            laptopPersistence.Received().Load();
        }
    }
}
