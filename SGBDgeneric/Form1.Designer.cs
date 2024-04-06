namespace SGBDgeneric
{
    partial class Form1
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
            this.ParentDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ChildDataGridView = new System.Windows.Forms.DataGridView();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ParentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChildDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ParentDataGridView
            // 
            this.ParentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ParentDataGridView.Location = new System.Drawing.Point(35, 34);
            this.ParentDataGridView.Name = "ParentDataGridView";
            this.ParentDataGridView.RowHeadersWidth = 51;
            this.ParentDataGridView.RowTemplate.Height = 24;
            this.ParentDataGridView.Size = new System.Drawing.Size(344, 235);
            this.ParentDataGridView.TabIndex = 0;
            this.ParentDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ParentDataGridView_RowHeaderMouseClick);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(35, 284);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 262);
            this.panel1.TabIndex = 1;
            // 
            // ChildDataGridView
            // 
            this.ChildDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ChildDataGridView.Location = new System.Drawing.Point(385, 34);
            this.ChildDataGridView.Name = "ChildDataGridView";
            this.ChildDataGridView.RowHeadersWidth = 51;
            this.ChildDataGridView.RowTemplate.Height = 24;
            this.ChildDataGridView.Size = new System.Drawing.Size(591, 235);
            this.ChildDataGridView.TabIndex = 2;
            this.ChildDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ChildDataGridView_RowHeaderMouseClick);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(866, 512);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(91, 34);
            this.RefreshButton.TabIndex = 3;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(600, 306);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(83, 32);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(600, 383);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(83, 33);
            this.UpdateButton.TabIndex = 5;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(600, 460);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(83, 32);
            this.DeleteButton.TabIndex = 6;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 568);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.ChildDataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ParentDataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ParentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChildDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ParentDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView ChildDataGridView;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button DeleteButton;
    }
}

