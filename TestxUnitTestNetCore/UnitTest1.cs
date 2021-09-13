using System;
using Xunit;

namespace TestxUnitTestNetCore
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Console.WriteLine("Test xUnit Test in .Net Core " + DateTime.Now.ToString());
            Assert.True(true);
        }
    }
}
