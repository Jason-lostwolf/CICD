using System;
using System.Linq;
using Xunit;

namespace TestxUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestMethod1()
        {
            Console.WriteLine("Test xUnit Test in .Net Framwork " + DateTime.Now.ToString());
            Assert.True(true);
        }
    }
}
