using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImEditor
{
    class TypeResource
    {
        public string TypeName;
        public string TraseValue;
        public string TempValue;
        public List<string> ParamName;
        public List<string> ParamType;
        public List<string> ParamVariant;
        public List<string> ParamDefault;

        public TypeResource(string typeName, string traseValue, string tempValue, List<string> paramName, List<string> paramType, List<string> paramVariant, List<string> paramDefault)
        {
            TypeName = typeName;
            TraseValue = traseValue;
            TempValue = tempValue;
            ParamName = paramName;
            ParamType = paramType;
            ParamVariant = paramVariant;
            ParamDefault = paramDefault;
        }
    }
}
