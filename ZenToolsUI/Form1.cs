using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZenToolsUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "Find the Input Folder";
            if (dialog.ShowDialog() == DialogResult.OK )
            {
                txtInput.Text = dialog.SelectedPath;
            }
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "Find the output Folder";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtOutput.Text = dialog.SelectedPath;
            }
        }

        private void btnKey_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                txtKey.Text = dialog.FileName;
            }

        }

        private void btnZen_Click(object sender, EventArgs e)
        {

            //ZenTools.exe ExtractPackages "D:\\SteamLibrary\\steamapps\\common\\somegame\\projectname\\Content\\Paks" "D:\\somegame\\Output" -EncryptionKeys="D:\\somegame\\keys.json"
            

            txtCmdCode.Text = "ZenTools.exe " + "ExtractPackages \"" + txtInput.Text + "\" \"" + txtOutput.Text + "\" -EncryptionKeys=\"" + txtKey.Text + "\"";
            txtCmdCode.Text = txtCmdCode.Text.Replace("\\", "/");
            string app = "ZenTools.exe";
            string args = "ExtractPackages \"" + txtInput.Text + "\" \"" + txtOutput.Text + "\" -EncryptionKeys=\"" + txtKey.Text + "\"";

            Process p = new Process();
            p.StartInfo.FileName = app;
            p.StartInfo.Arguments = args.Replace("\\", "/");
            p.Start();
            
        }
    }
}
