using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using FileData;
using AutoFixture;
using System.Linq;
using ThirdPartyTools;

namespace TestFileData
{
    
   public class FileDetailsTest:TestBase
    {

        [Fact]
        public void Test1HasArgument()
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
            var parameters = new List<string>() { "-v", "C:/test.text" };
            stub.Arguments = parameters.Skip(1).ToList();

            var taskKey = stub.Arguments.First();
            hasArgument = stub.Arguments != null && stub.Arguments.Any();
            var taskrunnerStub = Fixture.Create<TaskRunner>();
            Assert.True(hasArgument);
            taskrunnerStub.ExecuteTask(taskKey, stub);

            
        }
    }
}
