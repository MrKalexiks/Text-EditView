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

namespace Text_EditView_Setup
{
    public partial class Form1 : Form
    {
        string appPath = $@"C:\Users\{Environment.UserName}\Text EditView\";
        public Form1()
        {
            InitializeComponent();
        }

        private void InstallButton_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(appPath);
            Directory.CreateDirectory(appPath + @"Metrica\");
            Directory.CreateDirectory(appPath + @"Temp\");
            if (RunAppBeforeInstall.Checked == false)
            {
                MessageBox.Show("Success install!");
                Close();

            }
            else if (RunAppBeforeInstall.Checked == true)
            {
                MessageBox.Show("Success install!");
                System.Diagnostics.Process.Start(appPath + "Text EditView.exe");
            }
        }
    }
}
