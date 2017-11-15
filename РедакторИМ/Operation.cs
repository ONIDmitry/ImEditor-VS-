using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImEditor;

namespace ImEditor
{
    class Operation
    {
        public string OperationName;
        public string PatternName;
        public List<string> ResourceNames;

        public Operation (string operationName, string patternName, List<string> resourceName)
        {
            OperationName = operationName;
            PatternName = patternName;
            ResourceNames = resourceName;
        }
    }
}
