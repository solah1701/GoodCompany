using GoodCompany.Services;
using NUnit.Framework;

namespace GoodCompany.UnitTest
{
    public class ComputerPersistenceTests
    {
        public ComputerPersistenceService sut;

        [SetUp]
        public void SetUp()
        {
            sut = new ComputerPersistenceService();
        }
    }
}
