namespace DecisionTree
{
    partial class UserForm
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
            this.TreeName = new System.Windows.Forms.ComboBox();
            this.GetResult = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TreeName
            // 
            this.TreeName.FormattingEnabled = true;
            this.TreeName.Location = new System.Drawing.Point(240, 77);
            this.TreeName.Name = "TreeName";
            this.TreeName.Size = new System.Drawing.Size(238, 21);
            this.TreeName.TabIndex = 0;
            this.TreeName.SelectedIndexChanged += new System.EventHandler(this.TreeName_SelectedIndexChanged);
            // 
            // GetResult
            // 
            this.GetResult.Location = new System.Drawing.Point(483, 77);
            this.GetResult.Name = "GetResult";
            this.GetResult.Size = new System.Drawing.Size(135, 20);
            this.GetResult.TabIndex = 1;
            this.GetResult.Text = "Получить резуьтат";
            this.GetResult.UseVisualStyleBackColor = true;
            this.GetResult.Click += new System.EventHandler(this.GetResult_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Дерево решений";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GetResult);
            this.Controls.Add(this.TreeName);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox TreeName;
        private System.Windows.Forms.Button GetResult;
        private System.Windows.Forms.Label label1;
    }
}