using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImEditor;

namespace ImEditor
{
    class ImModel
    {

        static public string ChosenTypeResource = "";
        static public int NumberChosenTypeResource = -1;
        static public string ChosenResource = "";
        static public int NumberChosenResource = -1;
        static public string ChosenPatternOperation = "";
        static public int NumberChosenPatternOperation = -1;
        static public string ChosenOperation = "";
        static public int NumberChosenOperation = -1;

        public static List<TypeResource> ListTypeResources = new List<TypeResource>();
        public static List<Resource> ListResources = new List<Resource>();
        public static List<PatternOperation> ListPatternOperations = new List<PatternOperation>();
        public static List<Operation> ListOperations = new List<Operation>();
    }
}
