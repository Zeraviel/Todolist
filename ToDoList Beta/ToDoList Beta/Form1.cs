using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ToDoList_Beta
{
    public partial class ToDoList : Form
    {

        public void PassValue(string strValue)
        {
            TodoPanel.Text = strValue;
        }
        public ToDoList()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddPanel frm2 = new AddPanel();
            if (frm2.ShowDialog(this) == DialogResult.OK)
            {
                TodoPanel.Items.Add(frm2.getItem());
            }
            frm2.Close();
            frm2.Dispose();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            
            foreach (var item in TodoPanel.CheckedItems.OfType<string>().ToList())
            {
                TodoPanel.Items.Remove(item);
            }
        }

        private void TodoPanel_SelectedIndexChanged(object sender, EventArgs e)
        {
               
        }

        private void SaveFile()
        {
            var saveFile = new SaveFileDialog();
            saveFile.Filter = "Text (*.txt)|*.txt";
            saveFile.InitialDirectory = @"C:\";
            saveFile.FilterIndex = 2;
            saveFile.Title = "保存先のファイルを選択してください";
            saveFile.RestoreDirectory = true;
            saveFile.OverwritePrompt = true;
            saveFile.CheckPathExists = true;

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                using (var sw = new StreamWriter(saveFile.FileName, false))
                    foreach (var item in TodoPanel.Items)
                        sw.Write(item.ToString() + Environment.NewLine);
                MessageBox.Show("Success");
            }
        }

        private void LoadFile()
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Title = "保存されたファイルを選択してください";
            f.CheckFileExists = true;
            if (f.ShowDialog() == DialogResult.OK)
            {
                List<string> lines = new List<string>();
                using (StreamReader r = new StreamReader(f.OpenFile()))
                {
                    string line;
                    while ((line = r.ReadLine()) != null)
                    {
                        TodoPanel.Items.Add(line);
                    }
                }
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void Load_Click(object sender, EventArgs e)
        {
            LoadFile();
        }
    }
}

