namespace DecisionTree
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ParameterName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ParameterType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ParameterValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AddParameterValue = new System.Windows.Forms.Button();
            this.AddParameter = new System.Windows.Forms.Button();
            this.NodeName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ParentNodeName = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MainParameter = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.MainParameterValue = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ComparatorName = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.AddNode = new System.Windows.Forms.Button();
            this.TreeName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.AddTree = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.CurrentParameterName = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ParameterName
            // 
            this.ParameterName.Location = new System.Drawing.Point(956, 47);
            this.ParameterName.Name = "ParameterName";
            this.ParameterName.Size = new System.Drawing.Size(118, 20);
            this.ParameterName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(824, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название параметра";
            // 
            // ParameterType
            // 
            this.ParameterType.FormattingEnabled = true;
            this.ParameterType.Items.AddRange(new object[] {
            "Число",
            "Строка"});
            this.ParameterType.Location = new System.Drawing.Point(956, 75);
            this.ParameterType.Name = "ParameterType";
            this.ParameterType.Size = new System.Drawing.Size(118, 21);
            this.ParameterType.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(824, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Тип параметра";
            // 
            // ParameterValue
            // 
            this.ParameterValue.Location = new System.Drawing.Point(956, 100);
            this.ParameterValue.Name = "ParameterValue";
            this.ParameterValue.Size = new System.Drawing.Size(118, 20);
            this.ParameterValue.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(824, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Значение параметра";
            // 
            // AddParameterValue
            // 
            this.AddParameterValue.Location = new System.Drawing.Point(1079, 101);
            this.AddParameterValue.Name = "AddParameterValue";
            this.AddParameterValue.Size = new System.Drawing.Size(117, 20);
            this.AddParameterValue.TabIndex = 6;
            this.AddParameterValue.Text = "Добавить значение";
            this.AddParameterValue.UseVisualStyleBackColor = true;
            this.AddParameterValue.Click += new System.EventHandler(this.AddParameterValue_Click);
            // 
            // AddParameter
            // 
            this.AddParameter.Location = new System.Drawing.Point(956, 127);
            this.AddParameter.Name = "AddParameter";
            this.AddParameter.Size = new System.Drawing.Size(118, 20);
            this.AddParameter.TabIndex = 7;
            this.AddParameter.Text = "Добавить параметр";
            this.AddParameter.UseVisualStyleBackColor = true;
            this.AddParameter.Click += new System.EventHandler(this.AddParameter_Click);
            // 
            // NodeName
            // 
            this.NodeName.Location = new System.Drawing.Point(148, 49);
            this.NodeName.Name = "NodeName";
            this.NodeName.Size = new System.Drawing.Size(112, 20);
            this.NodeName.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Узел";
            // 
            // ParentNodeName
            // 
            this.ParentNodeName.FormattingEnabled = true;
            this.ParentNodeName.Location = new System.Drawing.Point(148, 74);
            this.ParentNodeName.Name = "ParentNodeName";
            this.ParentNodeName.Size = new System.Drawing.Size(112, 21);
            this.ParentNodeName.TabIndex = 10;
            this.ParentNodeName.SelectedIndexChanged += new System.EventHandler(this.ParentNodeName_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Корневой узел";
            // 
            // MainParameter
            // 
            this.MainParameter.FormattingEnabled = true;
            this.MainParameter.Location = new System.Drawing.Point(148, 99);
            this.MainParameter.Name = "MainParameter";
            this.MainParameter.Size = new System.Drawing.Size(112, 21);
            this.MainParameter.TabIndex = 12;
            this.MainParameter.SelectedIndexChanged += new System.EventHandler(this.MainParameter_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Зависит от параметра";
            // 
            // MainParameterValue
            // 
            this.MainParameterValue.FormattingEnabled = true;
            this.MainParameterValue.Location = new System.Drawing.Point(148, 126);
            this.MainParameterValue.Name = "MainParameterValue";
            this.MainParameterValue.Size = new System.Drawing.Size(112, 21);
            this.MainParameterValue.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Значение параметра";
            // 
            // ComparatorName
            // 
            this.ComparatorName.FormattingEnabled = true;
            this.ComparatorName.Location = new System.Drawing.Point(148, 152);
            this.ComparatorName.Name = "ComparatorName";
            this.ComparatorName.Size = new System.Drawing.Size(112, 21);
            this.ComparatorName.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Оператор сравнения";
            // 
            // AddNode
            // 
            this.AddNode.Location = new System.Drawing.Point(148, 204);
            this.AddNode.Name = "AddNode";
            this.AddNode.Size = new System.Drawing.Size(111, 20);
            this.AddNode.TabIndex = 18;
            this.AddNode.Text = "Добавить узел";
            this.AddNode.UseVisualStyleBackColor = true;
            this.AddNode.Click += new System.EventHandler(this.AddNode_Click);
            // 
            // TreeName
            // 
            this.TreeName.Location = new System.Drawing.Point(535, 11);
            this.TreeName.Name = "TreeName";
            this.TreeName.Size = new System.Drawing.Size(287, 20);
            this.TreeName.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(433, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Названия дерева";
            // 
            // AddTree
            // 
            this.AddTree.Location = new System.Drawing.Point(827, 11);
            this.AddTree.Name = "AddTree";
            this.AddTree.Size = new System.Drawing.Size(110, 20);
            this.AddTree.TabIndex = 22;
            this.AddTree.Text = "Добавить дерево";
            this.AddTree.UseVisualStyleBackColor = true;
            this.AddTree.Click += new System.EventHandler(this.AddTree_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 182);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Собственный параметр";
            // 
            // CurrentParameterName
            // 
            this.CurrentParameterName.FormattingEnabled = true;
            this.CurrentParameterName.Location = new System.Drawing.Point(148, 179);
            this.CurrentParameterName.Name = "CurrentParameterName";
            this.CurrentParameterName.Size = new System.Drawing.Size(112, 21);
            this.CurrentParameterName.TabIndex = 25;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 567);
            this.Controls.Add(this.CurrentParameterName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.AddTree);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TreeName);
            this.Controls.Add(this.AddNode);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ComparatorName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MainParameterValue);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MainParameter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ParentNodeName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NodeName);
            this.Controls.Add(this.AddParameter);
            this.Controls.Add(this.AddParameterValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ParameterValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ParameterType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ParameterName);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ParameterName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ParameterType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ParameterValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddParameterValue;
        private System.Windows.Forms.Button AddParameter;
        private System.Windows.Forms.TextBox NodeName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ParentNodeName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox MainParameter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox MainParameterValue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ComparatorName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button AddNode;
        private System.Windows.Forms.TextBox TreeName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button AddTree;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox CurrentParameterName;
    }
}