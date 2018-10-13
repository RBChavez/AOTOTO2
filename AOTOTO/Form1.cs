using System;
using System.Windows.Forms;

namespace AOTOTO
{
    public partial class Form1 : Form
    {
        //private IButtonControl myCancelBtn;
        //private object folderBrowserDialog1;

        public Form1()
        {
            InitializeComponent();
        }

        private void BT_Browse_Import_File_Click(object sender, EventArgs e)
        {
            // Show the dialog and get result.
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                TB_Import_Test_Case_Location.Text = openFileDialog1.FileName;
            }
        }

        private void BT_Start_Click(object sender, EventArgs e)
        {
            Aototo St = new Aototo();
            St.StepCommands(TB_Import_Test_Case_Location.Text.Trim(), TB_Report_Location.Text.Trim());
        }

        private void BT_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult cancel = new DialogResult();
            cancel = MessageBox.Show("Click 'Ok' to close program or Click 'Cancel' to cancel", "Do you want to close program?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (cancel == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void BT_Browse_Report_Location_Click(object sender, EventArgs e)
        {
            // Show the dialog and get result.
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                TB_Report_Location.Text = openFileDialog1.FileName;
            }
        }
    }
}
