using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using Microsoft.Msagl;
using Microsoft.Msagl.Drawing;
using Microsoft.Msagl.GraphViewerGdi;

namespace DecisionTree
{
    public partial class AdminForm : Form
    {
        Tree Tree = new Tree();
        List<TreeNode> Nodes = new List<TreeNode>();
        List<TreeParameter> TreeParameters = new List<TreeParameter>();
        List<string> ParameterValues = new List<string>();
        GViewer GViewer;
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void AddTree_Click(object sender, EventArgs e)
        {
            Tree.Name = this.TreeName.Text;
            Tree.Nodes.AddRange(Nodes);
            Tree.TreeParameters.AddRange(TreeParameters);
            Storage.Trees.Add(Tree);
            this.Close();
        }

        private void AddNode_Click(object sender, EventArgs e)
        {
            var newNode = new TreeNode();
            newNode.Name = this.NodeName.Text;
            if (this.ParentNodeName.SelectedIndex > -1 && !string.IsNullOrWhiteSpace(this.ParentNodeName.Text))
                Nodes[this.ParentNodeName.SelectedIndex].ChildNodes.Add(newNode);
            if (this.MainParameter.SelectedIndex > -1 && !string.IsNullOrWhiteSpace(this.MainParameter.Text))
                newNode.ParentParameter = TreeParameters[this.MainParameter.SelectedIndex];
            if (this.MainParameterValue.SelectedIndex > -1 && !string.IsNullOrWhiteSpace(this.MainParameterValue.Text))
                newNode.ParameterValue = newNode.ParentParameter.Values[this.MainParameterValue.SelectedIndex];
            if (this.ComparatorName.SelectedIndex > -1 && !string.IsNullOrWhiteSpace(this.ComparatorName.Text))
                if (newNode.ParentParameter.IsNumeric)
                    newNode.Comparator = (Comparator)this.ComparatorName.SelectedIndex;
            if (this.CurrentParameterName.SelectedIndex > -1 && !string.IsNullOrWhiteSpace(this.CurrentParameterName.Text))
                newNode.CurrentParameter = TreeParameters[this.CurrentParameterName.SelectedIndex];
            Nodes.Add(newNode);
            this.NodeName.Text = "";
            this.ParentNodeName.SelectedIndex = -1;
            this.MainParameter.SelectedIndex = -1;
            this.MainParameterValue.SelectedIndex = -1;
            this.ComparatorName.SelectedIndex = -1;
            this.CurrentParameterName.SelectedIndex = -1;
            this.ParentNodeName.Items.Clear();
            foreach (var node in Nodes)
                this.ParentNodeName.Items.Add(node.Name);
            if (Nodes.Count > 1)
            {
                Graph DecTree = new Graph(Nodes[0].Name);
                for (var i = 1; i < Nodes.Count; i++)
                {
                    var parent = Nodes.Where(x => x.ChildNodes.Contains(Nodes[i])).First();
                    DecTree.AddEdge(parent.Name, UserForm.GetComparator(Nodes[i].Comparator) + Nodes[i].ParameterValue, Nodes[i].Name);
                }
                if (this.GViewer != null)
                    this.Controls.Remove(this.GViewer);
                GViewer viewer = new GViewer();
                this.GViewer = viewer;
                viewer.Width = 450;
                viewer.Height = 400;
                viewer.Location = new Point(350, 50);
                viewer.Graph = DecTree;
                this.Controls.Add(viewer);
            }
        }

        private void AddParameter_Click(object sender, EventArgs e)
        {
            var param = new TreeParameter();
            param.Name = this.ParameterName.Text;
            param.IsNumeric = this.ParameterType.SelectedIndex < 1;
            param.Values.AddRange(ParameterValues);
            TreeParameters.Add(param);
            ParameterValues.Clear();
            this.ParameterName.Text = "";
            this.ParameterType.SelectedIndex = -1;
            this.MainParameter.Items.Clear();
            foreach (var par in TreeParameters)
                this.MainParameter.Items.Add(par.Name);
            this.CurrentParameterName.Items.Clear();
            foreach (var par in TreeParameters)
                this.CurrentParameterName.Items.Add(par.Name);
        }

        private void AddParameterValue_Click(object sender, EventArgs e)
        {
            ParameterValues.Add(this.ParameterValue.Text);
            this.ParameterValue.Text = "";
        }

        private void MainParameter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.MainParameter.SelectedIndex > -1)
            {
                var param = TreeParameters[this.MainParameter.SelectedIndex];
                this.MainParameterValue.Items.Clear();
                foreach (var value in param.Values)
                    this.MainParameterValue.Items.Add(value);
                this.ComparatorName.Items.Clear();
                if (param.IsNumeric)
                {
                    this.ComparatorName.Items.Add("Больше");
                    this.ComparatorName.Items.Add("Равно");
                    this.ComparatorName.Items.Add("Меньше");
                }
            }
        }

        private void ParentNodeName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.ParentNodeName.SelectedIndex > -1)
            {
                var node = Nodes[this.ParentNodeName.SelectedIndex];
                this.MainParameter.SelectedIndex = TreeParameters.IndexOf(node.CurrentParameter);

            }
        }

    }
}
