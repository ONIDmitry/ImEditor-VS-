using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImEditor;

namespace ImEditor
{
    class Resource
    {
        public string ResourceName;
        public string TypeName;
        public List<string> ParamValue;
        public string TraseValue;

        public Resource(string typeName, string resourceName, List<string> paramValue, string traseValue)
        {
            TypeName = typeName;
            ResourceName = resourceName;
            ParamValue = paramValue;
            TraseValue = traseValue;
        }
    }
}
