using System;
using System.Collections.Generic;
using System.Linq;
using ThirdPartyTools;

namespace FileData
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            if (args == null) throw new ArgumentNullException(nameof(args));

            var taskParameters = new TaskParameter()
            {
                Arguments = args.Skip(1).ToList()
            };

            var taskKey = args.First();
            var taskRunner = new TaskRunner();
            taskRunner.ExecuteTask(taskKey, taskParameters);
        }

       
    }
}
