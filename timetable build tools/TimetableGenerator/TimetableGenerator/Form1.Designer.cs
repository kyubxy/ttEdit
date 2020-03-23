namespace TimetableGenerator
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Line = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Subject = new System.Windows.Forms.TextBox();
            this.Room = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ColourButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.alwaysOnTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetSubjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetRoomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetColoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.closeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(370, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reloadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.closeToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetSubjectsToolStripMenuItem,
            this.resetRoomsToolStripMenuItem,
            this.resetColoursToolStripMenuItem,
            this.resetAllToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alwaysOnTopToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 179);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(342, 186);
            this.listBox1.TabIndex = 4;
            // 
            // Line
            // 
            this.Line.FormattingEnabled = true;
            this.Line.Items.AddRange(new object[] {
            "Line 1",
            "Line 2",
            "Line 3",
            "Line 4",
            "Line 5",
            "Line 6",
            "Line 7",
            "Line 8"});
            this.Line.Location = new System.Drawing.Point(15, 51);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(201, 21);
            this.Line.TabIndex = 5;
            this.Line.SelectedIndexChanged += new System.EventHandler(this.Line_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Subject";
            // 
            // Subject
            // 
            this.Subject.Location = new System.Drawing.Point(15, 91);
            this.Subject.Name = "Subject";
            this.Subject.Size = new System.Drawing.Size(201, 20);
            this.Subject.TabIndex = 7;
            // 
            // Room
            // 
            this.Room.Location = new System.Drawing.Point(15, 130);
            this.Room.Name = "Room";
            this.Room.Size = new System.Drawing.Size(201, 20);
            this.Room.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Room";
            // 
            // ColourButton
            // 
            this.ColourButton.Location = new System.Drawing.Point(222, 75);
            this.ColourButton.Name = "ColourButton";
            this.ColourButton.Size = new System.Drawing.Size(132, 75);
            this.ColourButton.TabIndex = 10;
            this.ColourButton.UseVisualStyleBackColor = true;
            this.ColourButton.Click += new System.EventHandler(this.ColourButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Line";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(15, 404);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(339, 30);
            this.SaveButton.TabIndex = 12;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // alwaysOnTopToolStripMenuItem
            // 
            this.alwaysOnTopToolStripMenuItem.Name = "alwaysOnTopToolStripMenuItem";
            this.alwaysOnTopToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.alwaysOnTopToolStripMenuItem.Text = "Always on top ⚪";
            this.alwaysOnTopToolStripMenuItem.Click += new System.EventHandler(this.alwaysOnTopToolStripMenuItem_Click);
            // 
            // reloadToolStripMenuItem
            // 
            this.reloadToolStripMenuItem.Name = "reloadToolStripMenuItem";
            this.reloadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reloadToolStripMenuItem.Text = "Reload";
            this.reloadToolStripMenuItem.Click += new System.EventHandler(this.reloadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // resetSubjectsToolStripMenuItem
            // 
            this.resetSubjectsToolStripMenuItem.Name = "resetSubjectsToolStripMenuItem";
            this.resetSubjectsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.resetSubjectsToolStripMenuItem.Text = "Reset subjects";
            this.resetSubjectsToolStripMenuItem.Click += new System.EventHandler(this.resetSubjectsToolStripMenuItem_Click);
            // 
            // resetRoomsToolStripMenuItem
            // 
            this.resetRoomsToolStripMenuItem.Name = "resetRoomsToolStripMenuItem";
            this.resetRoomsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.resetRoomsToolStripMenuItem.Text = "Reset rooms";
            this.resetRoomsToolStripMenuItem.Click += new System.EventHandler(this.resetRoomsToolStripMenuItem_Click);
            // 
            // resetColoursToolStripMenuItem
            // 
            this.resetColoursToolStripMenuItem.Name = "resetColoursToolStripMenuItem";
            this.resetColoursToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.resetColoursToolStripMenuItem.Text = "Reset colours";
            this.resetColoursToolStripMenuItem.Click += new System.EventHandler(this.resetColoursToolStripMenuItem_Click);
            // 
            // resetAllToolStripMenuItem
            // 
            this.resetAllToolStripMenuItem.Name = "resetAllToolStripMenuItem";
            this.resetAllToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.resetAllToolStripMenuItem.Text = "Reset all...";
            this.resetAllToolStripMenuItem.Click += new System.EventHandler(this.resetAllToolStripMenuItem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(222, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Choose colour...";
            // 
            // closeToolStripMenuItem1
            // 
            this.closeToolStripMenuItem1.Name = "closeToolStripMenuItem1";
            this.closeToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.closeToolStripMenuItem1.Text = "Close";
            this.closeToolStripMenuItem1.Click += new System.EventHandler(this.closeToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(370, 446);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ColourButton);
            this.Controls.Add(this.Room);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Subject);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Line);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "ttEdit Writer 0.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox Line;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Subject;
        private System.Windows.Forms.TextBox Room;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ColourButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.ToolStripMenuItem alwaysOnTopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetSubjectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetRoomsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetColoursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetAllToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem1;
    }
}

