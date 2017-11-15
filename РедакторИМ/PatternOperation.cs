using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImEditor;

namespace ImEditor
{
    class PatternOperation
    {
        public string PatternName;
        public string PatternType;
        public string PatternTrace;
        public string TypeTime;
        public string TimeValue;
        public string TimeLaw;
        public string StartInt;
        public string EndInt;
        public List<string> RelResName;
        public List<string> TypeNameW;
        public List<string> ConvStatus;
        public List<string> ConvBegin;
        public List<string> ConvEnd;
        public List<string> Condition;
        public List<string> ConvertEvent;
        public List<string> ConvertRule;
        public List<string> ConvertBegin;
        public List<string> ConvertEnd;

        public PatternOperation(string patternName, string patternType, string patternTrace, string typeTime, string timeValue, string timeLaw, string startInt, string endInt, List<string> relResName,  List<string> typeNameW, List<string> convStatus, List<string> convBegin, List<string> convEnd, List<string> condition, List<string> convertEvent, List<string> convertRule, List<string> convertBegin, List<string> convertEnd)
        {
            PatternName = patternName;
            PatternType = patternType;
            PatternTrace = patternTrace;
            TypeTime = typeTime;
            TimeValue = timeValue;
            TimeLaw = timeLaw;
            StartInt = startInt;
            EndInt = endInt;
            RelResName = relResName;
            TypeNameW = typeNameW;
            ConvStatus = convStatus;
            ConvBegin = convBegin;
            ConvEnd = convEnd;
            Condition = condition;
            ConvertEvent = convertEvent;
            ConvertRule = convertRule;
            ConvertBegin = convertBegin;
            ConvertEnd = convertEnd;
        }


    }
}
