using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileData
{
    public class TaskParameter : ITaskParameter
    {
        public ICollection<string> Arguments { get; set; }
    }
}
