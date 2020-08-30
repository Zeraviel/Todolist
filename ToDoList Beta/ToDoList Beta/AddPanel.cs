using System;
using System.Windows.Forms;

namespace ToDoList_Beta
{
    public partial class AddPanel : Form
    {
        public AddPanel()
        {
            InitializeComponent();
            Ok.DialogResult = DialogResult.OK;
            Cancel.DialogResult = DialogResult.Cancel;

        }

        private void Ok_Click(object sender, EventArgs e)
        {
            
        }
        public string getItem()
        {
            DateTime dt1 = new DateTime();
            dt1 = Deadline.Value;
            return AddTaskPanel.Text + "    " + dt1.ToString("dd-MM-yyyy") + " まで";
        }

        private void Cancel_Click(object sender, EventArgs e)
        {

        }

        private void AddTaskPanel_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
