using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoodCompany.Adapters;
using NUnit.Framework;

namespace GoodCompany.UnitTest
{
    public class DeviceAdapterTest
    {
        public DeviceAdapter sut;

        [SetUp]
        public void Setup()
        {
            sut = new DeviceAdapter();
        }
    }
}
