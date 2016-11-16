using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Notepad
{
    public partial class MainForm : Form
    {
    	string myDocs;
        public MainForm()
        {
            InitializeComponent();
            this.BackColor = Color.Black;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            //PROPERTIES
            Font myConsolas = new Font("Consolas", 8f, FontStyle.Regular);
            myPanel.BorderStyle = BorderStyle.None;
            myDocs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            //LABELS
            List<Label> labels = new List<Label>();
            labels.Add(fileNameLabel);
            labels.Add(fileLocationLabel);
            string[] text = {"FILE NAME:", "%LOCATION%:"};
            for (var i = 0; i < 2; i++) {
            	labels[i].BackColor = Color.Black;
            	labels[i].ForeColor = Color.White;
            	labels[i].Font = myConsolas;
            	labels[i].Text = text[i];
            }
            
            //RICHTEXTBOXES
            List<RichTextBox> textBoxes = new List<RichTextBox>();
            textBoxes.Add(fileNameBox);
            textBoxes.Add(fileContentBox);
            textBoxes.Add(fileLocationBox);
            foreach (RichTextBox textBox in textBoxes) {
            	textBox.BackColor = Color.Black;
            	textBox.ForeColor = Color.White;
            	textBox.Font = myConsolas;
            	textBox.BorderStyle = BorderStyle.None;
            }

            fileLocationBox.Text = myDocs;
            fileLocationBox.Click += showDocDir;
            fileContentBox.AutoSize = false;
            fileContentBox.Anchor = AnchorStyles.Left;

            //BUTTON
            saveButton.FlatStyle = FlatStyle.Flat;
            saveButton.Font = new Font("Consolas", 8f, FontStyle.Bold);
            saveButton.ForeColor = Color.White;
            saveButton.FlatAppearance.BorderSize = 0;
            saveButton.Text = "SAVE";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (fileLocationBox.Text[fileLocationBox.Text.Length-1] != '\\') {
                    fileLocationBox.Text += "\\";
                }
                System.IO.Directory.CreateDirectory(fileLocationBox.Text);
                System.IO.StreamWriter file = new System.IO.StreamWriter(fileLocationBox.Text + fileNameBox.Text);
                file.WriteLine(fileContentBox.Text);
                file.Close();
            }
            catch (System.Exception ex) {
                fileContentBox.ForeColor = Color.Red;
                fileContentBox.Text = "ERROR: Invalid parameters.";
                fileContentBox.Click += errormms;
            }
        }

        public void errormms(object sender, EventArgs e)
        {
            fileContentBox.ForeColor = Color.White;
            fileContentBox.Text = "";
            fileContentBox.Click -= errormms;
        }
        
        public void showDocDir(object sender, EventArgs e) {
        	if (fileLocationBox.Text == "") fileLocationBox.Text = myDocs;
        }
    }
}