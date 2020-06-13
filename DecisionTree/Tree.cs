using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecisionTree
{
    public class Tree
    {
        public string Name { get; set; }

        public List<TreeNode> Nodes { get; set; } = new List<TreeNode>();

        public List<TreeParameter> TreeParameters { get; set; } = new List<TreeParameter>();

        public List<TreeNode> RightRoot { get; set; } = new List<TreeNode>();

        public string GetResult(Dictionary<string, string> paramValues)
        {
            RightRoot.Clear();
            var root = Nodes[0];
            var flag = true;
            while (flag)
            {
                flag = false;
                var value = paramValues[root.CurrentParameter.Name];
                var child = root.ChildNodes.Where(x => IsValid(value, x)).FirstOrDefault();
                RightRoot.Add(child);
                if (child.ChildNodes.Count > 0)
                {
                    flag = true;
                    root = child;
                }
                else return child.Name;
            }
            return string.Empty;

        }

        private bool IsValid(string enteredValue, TreeNode node)
        {
            if (node.ParentParameter.IsNumeric)
            {
                if (node.Comparator == Comparator.MORE)
                {
                    var biggestOne = node.ParentParameter.Values.Where(x => int.Parse(node.ParameterValue) < int.Parse(x)).OrderBy(x => int.Parse(x)).FirstOrDefault();
                    if (biggestOne != null)
                    {
                        if (int.Parse(enteredValue) > int.Parse(node.ParameterValue) && int.Parse(enteredValue) < int.Parse(biggestOne)) return true;
                    }
                    else
                    {
                        if (int.Parse(enteredValue) > int.Parse(node.ParameterValue)) return true;
                    }
                }
                if (node.Comparator == Comparator.EQUAL)
                {
                    if (int.Parse(enteredValue) == int.Parse(node.ParameterValue)) return true;
                }
                if (node.Comparator == Comparator.LESS)
                {
                    var moreMinThanMin = node.ParentParameter.Values.Where(x => int.Parse(node.ParameterValue) > int.Parse(x)).OrderBy(x => int.Parse(x)).LastOrDefault();
                    if (moreMinThanMin != null)
                    {
                        if (int.Parse(enteredValue) < int.Parse(node.ParameterValue) && int.Parse(enteredValue) > int.Parse(moreMinThanMin)) return true;
                    }
                    else
                    {
                        if (int.Parse(enteredValue) < int.Parse(node.ParameterValue)) return true;
                    }
                }
            }
            else
            {
                if (enteredValue.Equals(node.ParameterValue)) return true;
            }
            return false;
        }
    }
}
