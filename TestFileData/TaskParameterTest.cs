using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using FileData;
using AutoFixture;
using System.Linq;

namespace TestFileData
{
    public class TaskParameterTest : TestBase
    {
        [Fact]
        public void TestHasArgument()
        {
            //no argument 
            var stub = Fixture.Create<TaskParameter>();
            stub.Arguments = null;
            var hasArgument = stub.Arguments != null && stub.Arguments.Any();
            Assert.False(hasArgument);

            //should not be null
            stub.Arguments = new List<string>();
            hasArgument = stub.Arguments != null && stub.Arguments.Any();
            Assert.False(hasArgument);

            //should not be null
            stub.Arguments = new List<string>() { "-v C:/test.text"};
            hasArgument = stub.Arguments != null && stub.Arguments.Any();
            Assert.True(hasArgument);
        }

    }
}
