namespace Notepad
{
    partial class MainForm
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
        	this.fileNameBox = new System.Windows.Forms.RichTextBox();
        	this.fileContentBox = new System.Windows.Forms.RichTextBox();
        	this.myPanel = new System.Windows.Forms.Panel();
        	this.fileLocationLabel = new System.Windows.Forms.Label();
        	this.fileLocationBox = new System.Windows.Forms.RichTextBox();
        	this.fileNameLabel = new System.Windows.Forms.Label();
        	this.saveButton = new System.Windows.Forms.Button();
        	this.myPanel.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// fileNameBox
        	// 
        	this.fileNameBox.Location = new System.Drawing.Point(72, 6);
        	this.fileNameBox.Name = "fileNameBox";
        	this.fileNameBox.Size = new System.Drawing.Size(214, 18);
        	this.fileNameBox.TabIndex = 0;
        	this.fileNameBox.Text = "";
        	// 
        	// fileContentBox
        	// 
        	this.fileContentBox.Location = new System.Drawing.Point(8, 47);
        	this.fileContentBox.Name = "fileContentBox";
        	this.fileContentBox.Size = new System.Drawing.Size(278, 268);
        	this.fileContentBox.TabIndex = 1;
        	this.fileContentBox.Text = "";
        	// 
        	// myPanel
        	// 
        	this.myPanel.Controls.Add(this.fileLocationLabel);
        	this.myPanel.Controls.Add(this.fileLocationBox);
        	this.myPanel.Controls.Add(this.fileNameLabel);
        	this.myPanel.Controls.Add(this.fileNameBox);
        	this.myPanel.Controls.Add(this.saveButton);
        	this.myPanel.Controls.Add(this.fileContentBox);
        	this.myPanel.Location = new System.Drawing.Point(-2, -1);
        	this.myPanel.Name = "myPanel";
        	this.myPanel.Size = new System.Drawing.Size(297, 345);
        	this.myPanel.TabIndex = 2;
        	// 
        	// fileLocationLabel
        	// 
        	this.fileLocationLabel.AutoSize = true;
        	this.fileLocationLabel.Location = new System.Drawing.Point(6, 26);
        	this.fileLocationLabel.Name = "fileLocationLabel";
        	this.fileLocationLabel.Size = new System.Drawing.Size(35, 13);
        	this.fileLocationLabel.TabIndex = 5;
        	this.fileLocationLabel.Text = "label2";
        	// 
        	// fileLocationBox
        	// 
        	this.fileLocationBox.Location = new System.Drawing.Point(81, 26);
        	this.fileLocationBox.Name = "fileLocationBox";
        	this.fileLocationBox.Size = new System.Drawing.Size(205, 18);
        	this.fileLocationBox.TabIndex = 4;
        	this.fileLocationBox.Text = "";
        	// 
        	// fileNameLabel
        	// 
        	this.fileNameLabel.AutoSize = true;
        	this.fileNameLabel.Location = new System.Drawing.Point(6, 6);
        	this.fileNameLabel.Name = "fileNameLabel";
        	this.fileNameLabel.Size = new System.Drawing.Size(35, 13);
        	this.fileNameLabel.TabIndex = 3;
        	this.fileNameLabel.Text = "label1";
        	// 
        	// saveButton
        	// 
        	this.saveButton.Location = new System.Drawing.Point(3, 320);
        	this.saveButton.Name = "saveButton";
        	this.saveButton.Size = new System.Drawing.Size(291, 22);
        	this.saveButton.TabIndex = 2;
        	this.saveButton.Text = "button1";
        	this.saveButton.UseVisualStyleBackColor = true;
        	this.saveButton.Click += new System.EventHandler(this.button1_Click);
        	// 
        	// MainForm
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(292, 344);
        	this.Controls.Add(this.myPanel);
        	this.Name = "MainForm";
        	this.Text = "MainForm";
        	this.myPanel.ResumeLayout(false);
        	this.myPanel.PerformLayout();
        	this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.RichTextBox fileNameBox;
        private System.Windows.Forms.RichTextBox fileContentBox;
        private System.Windows.Forms.Panel myPanel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.Label fileLocationLabel;
        private System.Windows.Forms.RichTextBox fileLocationBox;
    }
}

