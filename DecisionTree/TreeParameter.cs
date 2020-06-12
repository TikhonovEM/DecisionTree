using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DecisionTree
{
    public class TreeParameter
    {
        public string Name { get; set; }

        public bool IsNumeric { get; set; }

        public List<string> Values { get; set; } = new List<string>();


    }
}
