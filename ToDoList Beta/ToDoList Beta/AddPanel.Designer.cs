namespace ToDoList_Beta
{
    partial class AddPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPanel));
            this.TopPanel = new System.Windows.Forms.Label();
            this.Ok = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.AddTaskPanel = new System.Windows.Forms.TextBox();
            this.DeadlineLabel = new System.Windows.Forms.Label();
            this.Deadline = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.Blue;
            this.TopPanel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopPanel.Location = new System.Drawing.Point(12, 9);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(341, 39);
            this.TopPanel.TabIndex = 0;
            this.TopPanel.Text = "Add a New Task";
            this.TopPanel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Ok
            // 
            this.Ok.Location = new System.Drawing.Point(45, 350);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(123, 59);
            this.Ok.TabIndex = 1;
            this.Ok.Text = "Confirm";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(198, 350);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(123, 59);
            this.Cancel.TabIndex = 2;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // AddTaskPanel
            // 
            this.AddTaskPanel.Location = new System.Drawing.Point(18, 79);
            this.AddTaskPanel.Multiline = true;
            this.AddTaskPanel.Name = "AddTaskPanel";
            this.AddTaskPanel.Size = new System.Drawing.Size(335, 119);
            this.AddTaskPanel.TabIndex = 3;
            this.AddTaskPanel.TextChanged += new System.EventHandler(this.AddTaskPanel_TextChanged);
            // 
            // DeadlineLabel
            // 
            this.DeadlineLabel.AutoSize = true;
            this.DeadlineLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeadlineLabel.Location = new System.Drawing.Point(13, 210);
            this.DeadlineLabel.Name = "DeadlineLabel";
            this.DeadlineLabel.Size = new System.Drawing.Size(52, 28);
            this.DeadlineLabel.TabIndex = 4;
            this.DeadlineLabel.Text = "期限";
            // 
            // Deadline
            // 
            this.Deadline.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Deadline.Location = new System.Drawing.Point(18, 255);
            this.Deadline.Name = "Deadline";
            this.Deadline.Size = new System.Drawing.Size(150, 22);
            this.Deadline.TabIndex = 5;
            // 
            // AddPanel
            // 
            this.AcceptButton = this.Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 450);
            this.Controls.Add(this.Deadline);
            this.Controls.Add(this.DeadlineLabel);
            this.Controls.Add(this.AddTaskPanel);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.TopPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddPanel";
            this.Text = "AddPanel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TopPanel;
        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.TextBox AddTaskPanel;
        private System.Windows.Forms.Label DeadlineLabel;
        private System.Windows.Forms.DateTimePicker Deadline;
    }
}