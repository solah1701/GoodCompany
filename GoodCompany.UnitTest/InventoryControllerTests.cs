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

            sut = new InventoryController(computerPersistence, laptopPersistence);
        }
    }
}
