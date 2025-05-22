namespace GUI {
    partial class SelectWorldForm {
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
            if (disposing && (components != null)) {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectWorldForm));
            this.BrowseWorldButton = new System.Windows.Forms.Button();
            this.WorldPathTextBox = new System.Windows.Forms.TextBox();
            this.SelectWorldLabel = new System.Windows.Forms.Label();
            this.RegionRangeTextBox = new System.Windows.Forms.TextBox();
            this.AllRegionsCheckBox = new System.Windows.Forms.CheckBox();
            this.RegionRangeExampleLabel = new System.Windows.Forms.Label();
            this.RegionRangeLabel = new System.Windows.Forms.Label();
            this.CreateMapButton = new System.Windows.Forms.Button();
            this.BrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SaveAutomaticallyLabel = new System.Windows.Forms.Label();
            this.SaveTextBox = new System.Windows.Forms.TextBox();
            this.BrowseSaveButton = new System.Windows.Forms.Button();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // BrowseWorldButton
            // 
            this.BrowseWorldButton.Location = new System.Drawing.Point(16, 32);
            this.BrowseWorldButton.Name = "BrowseWorldButton";
            this.BrowseWorldButton.Size = new System.Drawing.Size(75, 23);
            this.BrowseWorldButton.TabIndex = 0;
            this.BrowseWorldButton.Text = "Browse";
            this.BrowseWorldButton.UseVisualStyleBackColor = true;
            this.BrowseWorldButton.Click += new System.EventHandler(this.BrowseWorldButton_Click);
            // 
            // WorldPathTextBox
            // 
            this.WorldPathTextBox.Location = new System.Drawing.Point(97, 34);
            this.WorldPathTextBox.Name = "WorldPathTextBox";
            this.WorldPathTextBox.Size = new System.Drawing.Size(368, 20);
            this.WorldPathTextBox.TabIndex = 1;
            // 
            // SelectWorldLabel
            // 
            this.SelectWorldLabel.AutoSize = true;
            this.SelectWorldLabel.ForeColor = System.Drawing.Color.Black;
            this.SelectWorldLabel.Location = new System.Drawing.Point(13, 16);
            this.SelectWorldLabel.Name = "SelectWorldLabel";
            this.SelectWorldLabel.Size = new System.Drawing.Size(65, 13);
            this.SelectWorldLabel.TabIndex = 2;
            this.SelectWorldLabel.Text = "Select world";
            // 
            // RegionRangeTextBox
            // 
            this.RegionRangeTextBox.Location = new System.Drawing.Point(98, 88);
            this.RegionRangeTextBox.Name = "RegionRangeTextBox";
            this.RegionRangeTextBox.Size = new System.Drawing.Size(115, 20);
            this.RegionRangeTextBox.TabIndex = 3;
            // 
            // AllRegionsCheckBox
            // 
            this.AllRegionsCheckBox.AutoSize = true;
            this.AllRegionsCheckBox.ForeColor = System.Drawing.Color.Black;
            this.AllRegionsCheckBox.Location = new System.Drawing.Point(17, 90);
            this.AllRegionsCheckBox.Name = "AllRegionsCheckBox";
            this.AllRegionsCheckBox.Size = new System.Drawing.Size(74, 17);
            this.AllRegionsCheckBox.TabIndex = 5;
            this.AllRegionsCheckBox.Text = "All regions";
            this.AllRegionsCheckBox.UseVisualStyleBackColor = true;
            this.AllRegionsCheckBox.CheckedChanged += new System.EventHandler(this.AllRegionsCheckBox_CheckedChanged);
            // 
            // RegionRangeExampleLabel
            // 
            this.RegionRangeExampleLabel.AutoSize = true;
            this.RegionRangeExampleLabel.ForeColor = System.Drawing.Color.Black;
            this.RegionRangeExampleLabel.Location = new System.Drawing.Point(217, 92);
            this.RegionRangeExampleLabel.Name = "RegionRangeExampleLabel";
            this.RegionRangeExampleLabel.Size = new System.Drawing.Size(69, 13);
            this.RegionRangeExampleLabel.TabIndex = 6;
            this.RegionRangeExampleLabel.Text = "x1, z1; x2, z2";
            // 
            // RegionRangeLabel
            // 
            this.RegionRangeLabel.AutoSize = true;
            this.RegionRangeLabel.ForeColor = System.Drawing.Color.Black;
            this.RegionRangeLabel.Location = new System.Drawing.Point(14, 72);
            this.RegionRangeLabel.Name = "RegionRangeLabel";
            this.RegionRangeLabel.Size = new System.Drawing.Size(71, 13);
            this.RegionRangeLabel.TabIndex = 7;
            this.RegionRangeLabel.Text = "Region range";
            // 
            // CreateMapButton
            // 
            this.CreateMapButton.Location = new System.Drawing.Point(16, 162);
            this.CreateMapButton.Name = "CreateMapButton";
            this.CreateMapButton.Size = new System.Drawing.Size(118, 23);
            this.CreateMapButton.TabIndex = 8;
            this.CreateMapButton.Text = "Create Map";
            this.CreateMapButton.UseVisualStyleBackColor = true;
            this.CreateMapButton.Click += new System.EventHandler(this.CreateMapButton_Click);
            // 
            // SaveAutomaticallyLabel
            // 
            this.SaveAutomaticallyLabel.AutoSize = true;
            this.SaveAutomaticallyLabel.Location = new System.Drawing.Point(159, 146);
            this.SaveAutomaticallyLabel.Name = "SaveAutomaticallyLabel";
            this.SaveAutomaticallyLabel.Size = new System.Drawing.Size(164, 13);
            this.SaveAutomaticallyLabel.TabIndex = 11;
            this.SaveAutomaticallyLabel.Text = "Save automatically when finished";
            // 
            // SaveTextBox
            // 
            this.SaveTextBox.Location = new System.Drawing.Point(242, 163);
            this.SaveTextBox.Name = "SaveTextBox";
            this.SaveTextBox.Size = new System.Drawing.Size(223, 20);
            this.SaveTextBox.TabIndex = 12;
            // 
            // BrowseSaveButton
            // 
            this.BrowseSaveButton.Location = new System.Drawing.Point(161, 162);
            this.BrowseSaveButton.Name = "BrowseSaveButton";
            this.BrowseSaveButton.Size = new System.Drawing.Size(75, 23);
            this.BrowseSaveButton.TabIndex = 13;
            this.BrowseSaveButton.Text = "Browse";
            this.BrowseSaveButton.UseVisualStyleBackColor = true;
            this.BrowseSaveButton.Click += new System.EventHandler(this.BrowseSaveButton_Click);
            // 
            // SaveFileDialog
            // 
            this.SaveFileDialog.Filter = "\"Images|*.png;*.bmp;*.jpeg\";";
            // 
            // SelectWorldForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(479, 200);
            this.Controls.Add(this.BrowseSaveButton);
            this.Controls.Add(this.SaveTextBox);
            this.Controls.Add(this.SaveAutomaticallyLabel);
            this.Controls.Add(this.CreateMapButton);
            this.Controls.Add(this.RegionRangeLabel);
            this.Controls.Add(this.RegionRangeExampleLabel);
            this.Controls.Add(this.AllRegionsCheckBox);
            this.Controls.Add(this.SelectWorldLabel);
            this.Controls.Add(this.RegionRangeTextBox);
            this.Controls.Add(this.WorldPathTextBox);
            this.Controls.Add(this.BrowseWorldButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SelectWorldForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select World";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BrowseWorldButton;
        private System.Windows.Forms.TextBox WorldPathTextBox;
        private System.Windows.Forms.Label SelectWorldLabel;
        private System.Windows.Forms.TextBox RegionRangeTextBox;
        private System.Windows.Forms.CheckBox AllRegionsCheckBox;
        private System.Windows.Forms.Label RegionRangeExampleLabel;
        private System.Windows.Forms.Label RegionRangeLabel;
        private System.Windows.Forms.Button CreateMapButton;
        private System.Windows.Forms.FolderBrowserDialog BrowserDialog;
        private System.Windows.Forms.Label SaveAutomaticallyLabel;
        private System.Windows.Forms.TextBox SaveTextBox;
        private System.Windows.Forms.Button BrowseSaveButton;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
    }
}