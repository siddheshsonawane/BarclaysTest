using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdPartyTools;

namespace FileData
{
    public class TaskRunner
    {
        public void ExecuteTask(string taskKey, ITaskParameter taskParameters)
        {
            var fileDetails = new FileDetails();
            var parameter = taskParameters.Arguments.ToList()[0];

            var isVersionRequest = new[] { "-v", "--v", "/v", "--version" }
            .Any(t => t.Equals(taskKey));

            var isFileSizeRequest = new[] { "-s", "--s", "/s", "--size" }
            .Any(t => t.Equals(taskKey));

            // we are also use the GetValue method as extension
            if (isVersionRequest)
            {
                var fileResponse = fileDetails.Version(parameter);
                //write file response 
                Console.WriteLine(fileResponse);
            }

            if (isFileSizeRequest)
            {
                fileDetails.Size(parameter);
            }
        }
    }
}
