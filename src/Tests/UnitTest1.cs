using System;
using Xunit;
using Core;

namespace Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestItemHasAGoodProps()
        {
            var now = DateTime.Now;
            var content = "Test 1";

            var item = new TodoItem(content, now);

            Assert.True(item.Content.Equals(name));
            Assert.True(item.CreatedAt.Equals(now));
        }
    }
}
