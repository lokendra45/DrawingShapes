namespace DrawShapes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdExecuteBtn = new System.Windows.Forms.Button();
            this.commandtextBox = new System.Windows.Forms.TextBox();
            this.inputTextBox = new System.Windows.Forms.RichTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveShapeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.Output_Box = new System.Windows.Forms.Panel();
            this.mainPanel.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.Output_Box);
            this.mainPanel.Controls.Add(this.label2);
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Controls.Add(this.cmdExecuteBtn);
            this.mainPanel.Controls.Add(this.commandtextBox);
            this.mainPanel.Controls.Add(this.inputTextBox);
            this.mainPanel.Location = new System.Drawing.Point(12, 12);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(776, 426);
            this.mainPanel.TabIndex = 0;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(465, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Command";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(593, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter Coordinate ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmdExecuteBtn
            // 
            this.cmdExecuteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdExecuteBtn.ForeColor = System.Drawing.Color.SlateBlue;
            this.cmdExecuteBtn.Location = new System.Drawing.Point(645, 355);
            this.cmdExecuteBtn.Name = "cmdExecuteBtn";
            this.cmdExecuteBtn.Size = new System.Drawing.Size(76, 26);
            this.cmdExecuteBtn.TabIndex = 2;
            this.cmdExecuteBtn.Text = "Draw";
            this.cmdExecuteBtn.UseVisualStyleBackColor = true;
            this.cmdExecuteBtn.Click += new System.EventHandler(this.cmdExecuteBtn_Click);
            // 
            // commandtextBox
            // 
            this.commandtextBox.Location = new System.Drawing.Point(525, 355);
            this.commandtextBox.Name = "commandtextBox";
            this.commandtextBox.Size = new System.Drawing.Size(92, 20);
            this.commandtextBox.TabIndex = 1;
            this.commandtextBox.TextChanged += new System.EventHandler(this.commandtextBox_TextChanged);
            // 
            // inputTextBox
            // 
            this.inputTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.inputTextBox.Location = new System.Drawing.Point(509, 70);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(251, 258);
            this.inputTextBox.TabIndex = 0;
            this.inputTextBox.Text = "";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.saveShapeToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(51, 22);
            this.toolStripDropDownButton1.Text = "Menu";
            this.toolStripDropDownButton1.ToolTipText = "Menu";
            this.toolStripDropDownButton1.Click += new System.EventHandler(this.toolStripDropDownButton1_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.helpToolStripMenuItem.Text = "How to use";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // saveShapeToolStripMenuItem
            // 
            this.saveShapeToolStripMenuItem.Name = "saveShapeToolStripMenuItem";
            this.saveShapeToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.saveShapeToolStripMenuItem.Text = "Save Shape";
            this.saveShapeToolStripMenuItem.Click += new System.EventHandler(this.saveShapeToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialogLoad";
            // 
            // Output_Box
            // 
            this.Output_Box.BackColor = System.Drawing.SystemColors.WindowText;
            this.Output_Box.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Output_Box.Location = new System.Drawing.Point(3, 16);
            this.Output_Box.Name = "Output_Box";
            this.Output_Box.Size = new System.Drawing.Size(456, 407);
            this.Output_Box.TabIndex = 5;
            this.Output_Box.Paint += new System.Windows.Forms.PaintEventHandler(this.Output_Box_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.mainPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.TextBox commandtextBox;
        private System.Windows.Forms.RichTextBox inputTextBox;
        private System.Windows.Forms.Button cmdExecuteBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveShapeToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Panel Output_Box;
    }
}

