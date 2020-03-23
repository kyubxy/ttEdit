using System;
using System.Collections.Generic;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace TimetableGenerator
{
    public partial class Form1 : Form
    {
        List<TtClass> Timetable;

        public Form1()
        {
            InitializeComponent();

            Reload();

            Line.SelectedIndex = 0;
            UpdateFields();
            Updatebox();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Subject.Leave += Subject_TextChanged;
            Room.Leave += Room_TextChanged;
            Line.TextChanged += Line_TextChanged;
            FormClosed += Form1_FormClosing;
        }

        void Reload()
        {
            if (File.Exists("timetable.json"))
            {
                // deserialize JSON directly from a file
                using (StreamReader file = File.OpenText(@"timetable.json"))
                {
                    try
                    {
                        JsonSerializer serializer = new JsonSerializer();
                        Timetable = (List<TtClass>)serializer.Deserialize(file, typeof(List<TtClass>));
                    }
                    catch (Exception e)
                    {
                        Timetable = new List<TtClass>();
                        for (int i = 1; i <= 8; i++)
                        {
                            int[] a = { 0, 0, 0 };
                            Timetable.Add(new TtClass(i, "", "", a));
                        }
                    }
                }
            }
            else
            {
                Timetable = new List<TtClass>();
                for (int i = 1; i <= 8; i++)
                {
                    int[] a = { 0, 0, 0 };
                    Timetable.Add(new TtClass(i, "", "", a));
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosedEventArgs e)
        {
            ExitProcess();
        }

        private void ExitProcess()
        {
            DialogResult d = MessageBox.Show("All unsaved changes will not be written", "Would you like to save changes ?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            switch (d)
            {
                case DialogResult.Yes:
                    Save();
                    break;
                case DialogResult.Cancel:
                    return;
            }

            Application.Exit();
        }

        private void Line_TextChanged(object sender, EventArgs e)
        {
            UpdateFields();
        }

        private void Room_TextChanged(object sender, EventArgs e)
        {
            Timetable[Line.SelectedIndex].room = Room.Text;
            Updatebox();
        }

        private void Subject_TextChanged(object sender, EventArgs e)
        {
            Timetable[Line.SelectedIndex].subject = Subject.Text;
            Updatebox();
        }

        void UpdateFields()
        {
            Subject.Text = Timetable[Line.SelectedIndex].subject;
            Room.Text = Timetable[Line.SelectedIndex].room;
            ColourButton.BackColor = Color.FromArgb(Timetable[Line.SelectedIndex].colour[0], Timetable[Line.SelectedIndex].colour[1], Timetable[Line.SelectedIndex].colour[2]);
        }

        void Updatebox()
        {
            listBox1.Items.Clear();

            foreach (TtClass c in Timetable)
            {
                listBox1.Items.Add($"{c.line} : {c.subject} - {c.room}");
            }

        }

        private void ColourButton_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.AllowFullOpen = false;
            MyDialog.AllowFullOpen = true;

            // Update the text box color if the user clicks OK 
            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                int[] a = { (int)MyDialog.Color.R, (int)MyDialog.Color.G, (int)MyDialog.Color.B };
                Timetable[Line.SelectedIndex].colour = a;
                UpdateFields();
            }
        }
        
        private void SaveButton_Click(object sender, EventArgs e)
        {
            Save();
        }

        void Save()
        {
            using (StreamWriter file = File.CreateText("timetable.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                //serialize object directly into file stream
                serializer.Serialize(file, Timetable);
            }
        }

        #region homo
        //Save
        private void button1_Click(object sender, EventArgs e)
        {

        }

        //Colour picker
        private void button2_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void Line_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExitProcess();
        }

        private void reloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("The file will be reverted to its last save", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            switch (d)
            {
                case DialogResult.No:
                    return;
            }

            Reload();
            Updatebox();
            UpdateFields();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();

            Updatebox();
            UpdateFields();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help h = new Help();
            h.Show();
        }

        private void resetSubjectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("All subjects will be reset", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (d == DialogResult.No)
                return;

            foreach (TtClass t in Timetable)
            {
                t.subject = "";
            }

            UpdateFields();
            Updatebox();
        }

        private void resetRoomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("All rooms will be reset", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (d == DialogResult.No)
                return;

            foreach (TtClass t in Timetable)
            {
                t.room = "";
            }
            UpdateFields();
            Updatebox();
        }

        private void resetColoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("All colours will be reset", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (d == DialogResult.No)
                return; 

            foreach (TtClass t in Timetable)
            {
                int [] a = { 0, 0, 0 };
                t.colour = a;
            }
            UpdateFields();
            Updatebox();
        }

        private void resetAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Everything will be reset", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (d == DialogResult.No)
                return;

            Timetable = new List<TtClass>();
            for (int i = 1; i <= 8; i++)
            {
                int[] a = { 0, 0, 0 };
                Timetable.Add(new TtClass(i, "", "", a));
            }
            UpdateFields();
            Updatebox();
        }

        private void alwaysOnTopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TopMost)
            {
                TopMost = false;
                alwaysOnTopToolStripMenuItem.Text = $"Always on top ⚪";
            }
            else
            {
                TopMost = true;
                alwaysOnTopToolStripMenuItem.Text = $"Always on top ⚫";
            }

        }

        private void trueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TopMost = true;
        }

        private void falseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TopMost = true;
        }

        private void closeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ExitProcess();
        }
    }
}
