using GoodCompany.Services;
using NUnit.Framework;

namespace GoodCompany.UnitTest
{
    public class LaptopPersistenceTests
    {
        public LaptopPersistenceService sut;

        [SetUp]
        public void SetUp()
        {
            sut = new LaptopPersistenceService();
        }
    }
}
