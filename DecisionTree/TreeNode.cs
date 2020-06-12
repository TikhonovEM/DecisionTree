using System;
using System.Collections.Generic;
using System.Text;

namespace DecisionTree
{
    public enum Comparator
    {
        MORE,
        EQUAL,
        LESS
    }
    public class TreeNode
    {
        public string Name { get; set; }

        public List<TreeNode> ChildNodes { get; set; } = new List<TreeNode>();

        public TreeParameter ParentParameter { get; set; }

        public string ParameterValue { get; set; }

        public Comparator? Comparator { get; set; }

        public TreeParameter CurrentParameter { get; set; }

    }
}
