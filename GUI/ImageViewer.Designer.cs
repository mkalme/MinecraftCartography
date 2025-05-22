namespace GUI {
    partial class ImageViewer {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageViewer));
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.Panel = new System.Windows.Forms.Panel();
            this.ToolBarPanel = new System.Windows.Forms.Panel();
            this.ClipboardLink = new System.Windows.Forms.LinkLabel();
            this.SaveAsButton = new System.Windows.Forms.Button();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.Panel.SuspendLayout();
            this.ToolBarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PictureBox
            // 
            this.PictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PictureBox.Location = new System.Drawing.Point(0, 0);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(1266, 688);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PictureBox.TabIndex = 0;
            this.PictureBox.TabStop = false;
            this.PictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseDown);
            this.PictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseMove);
            this.PictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseUp);
            // 
            // Panel
            // 
            this.Panel.Controls.Add(this.ToolBarPanel);
            this.Panel.Controls.Add(this.PictureBox);
            this.Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel.Location = new System.Drawing.Point(0, 0);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(1266, 688);
            this.Panel.TabIndex = 1;
            this.Panel.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseWheel);
            // 
            // ToolBarPanel
            // 
            this.ToolBarPanel.Controls.Add(this.ClipboardLink);
            this.ToolBarPanel.Controls.Add(this.SaveAsButton);
            this.ToolBarPanel.Location = new System.Drawing.Point(12, 12);
            this.ToolBarPanel.Name = "ToolBarPanel";
            this.ToolBarPanel.Size = new System.Drawing.Size(93, 56);
            this.ToolBarPanel.TabIndex = 1;
            // 
            // ClipboardLink
            // 
            this.ClipboardLink.ActiveLinkColor = System.Drawing.Color.DimGray;
            this.ClipboardLink.AutoSize = true;
            this.ClipboardLink.LinkColor = System.Drawing.Color.LightGray;
            this.ClipboardLink.Location = new System.Drawing.Point(3, 3);
            this.ClipboardLink.Name = "ClipboardLink";
            this.ClipboardLink.Size = new System.Drawing.Size(89, 13);
            this.ClipboardLink.TabIndex = 1;
            this.ClipboardLink.TabStop = true;
            this.ClipboardLink.Text = "Copy to clipboard";
            this.ClipboardLink.VisitedLinkColor = System.Drawing.Color.LightGray;
            this.ClipboardLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ClipboardLink_LinkClicked);
            // 
            // SaveAsButton
            // 
            this.SaveAsButton.Location = new System.Drawing.Point(3, 28);
            this.SaveAsButton.Name = "SaveAsButton";
            this.SaveAsButton.Size = new System.Drawing.Size(86, 23);
            this.SaveAsButton.TabIndex = 0;
            this.SaveAsButton.Text = "Save As";
            this.SaveAsButton.UseVisualStyleBackColor = true;
            this.SaveAsButton.Click += new System.EventHandler(this.SaveAsButton_Click);
            // 
            // SaveFileDialog
            // 
            this.SaveFileDialog.Filter = "\"Images|*.png;*.bmp;*.jpeg\";";
            // 
            // ImageViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(1266, 688);
            this.Controls.Add(this.Panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ImageViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Map";
            this.Load += new System.EventHandler(this.MapForm_Load);
            this.Resize += new System.EventHandler(this.ImageViewer_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.Panel.ResumeLayout(false);
            this.ToolBarPanel.ResumeLayout(false);
            this.ToolBarPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.Panel ToolBarPanel;
        private System.Windows.Forms.LinkLabel ClipboardLink;
        private System.Windows.Forms.Button SaveAsButton;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
    }
}

