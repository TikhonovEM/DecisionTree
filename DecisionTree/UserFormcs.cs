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
    public partial class UserForm : Form
    {

        public UserForm()
        {
            InitializeComponent();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            foreach (var tree in Storage.Trees)
            {
                this.TreeName.Items.Add(tree.Name);
            }
        }

        private void GetResult_Click(object sender, EventArgs e)
        {
            if (this.TreeName.SelectedIndex > -1)
            {
                var tree = Storage.Trees[this.TreeName.SelectedIndex];
                var paramValues = new Dictionary<string, string>();
                foreach (var param in tree.TreeParameters)
                {
                    var key = param.Name;
                    var value = this.Controls.Find(key, false).First().Text;
                    paramValues.Add(key, value);
                }
                MessageBox.Show(tree.GetResult(paramValues));
                Graph DecTree = new Graph(tree.Nodes[0].Name);
                for (var i = 1; i < tree.Nodes.Count; i++)
                {
                    var parent = tree.Nodes.Where(x => x.ChildNodes.Contains(tree.Nodes[i])).First();
                    DecTree.AddEdge(parent.Name, GetComparatorText(tree.Nodes[i].Comparator) + tree.Nodes[i].ParameterValue,tree.Nodes[i].Name);
                }
                GViewer viewer = new GViewer();
                viewer.Width = 400;
                viewer.Height = 300;
                var gr = new GraphForm();
                gr.Controls.Add(viewer);
                viewer.Graph = DecTree;
                gr.Show();
            }

        }

        private string GetComparatorText(Comparator? comparator)
        {
            if (!comparator.HasValue)
                return "";
            if (comparator.Value == Comparator.EQUAL)
                return "=";
            if (comparator.Value == Comparator.LESS)
                return "<";
            if (comparator.Value == Comparator.MORE)
                return ">";
            return "";
        }

        private void TreeName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.TreeName.SelectedIndex > -1)
            {
                var tree = Storage.Trees[this.TreeName.SelectedIndex];
                var startXLabel = 150;
                var startXTextbox = 240;
                var startY = 77 + 28;
                this.SuspendLayout();
                foreach (var param in tree.TreeParameters)
                {
                    var label = new System.Windows.Forms.Label();
                    label.Location = new Point(startXLabel, startY + 5);
                    label.Size = new Size(70, 15);
                    label.Name = param.Name + "label";
                    label.Text = param.Name;
                    var textBox = new TextBox();
                    textBox.Name = param.Name;
                    textBox.Location = new Point(startXTextbox, startY);
                    this.Controls.Add(label);
                    this.Controls.Add(textBox);
                    startY += 28;
                }
                this.ResumeLayout(false);
                this.PerformLayout();
            }
        }
    }
}
