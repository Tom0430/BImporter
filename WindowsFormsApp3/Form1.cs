using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BridgeImporter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSelectExcelFilePath_Click_1(object sender, EventArgs e)
        {
            DialogResult dr = folderBrowserDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                label4.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void buttonSelectExportFilePath_Click(object sender, EventArgs e)
        {
            DialogResult dr = folderBrowserDialog2.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                label5.Text = folderBrowserDialog2.SelectedPath;
            }
        }

        private void buttonSelectImportFolderPath_Click(object sender, EventArgs e)
        {
            DialogResult dr = folderBrowserDialog3.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                label6.Text = folderBrowserDialog3.SelectedPath;
            }
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {

        }
    }
}
