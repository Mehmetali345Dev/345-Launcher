using System;
using System.IO;
using System.Windows.Forms;

namespace _345_Launcher
{
    public partial class Modlar : Form
    {
        public Modlar()
        {
            InitializeComponent();

            DirectoryInfo directoryInfo = new DirectoryInfo(yol);
            if (directoryInfo.Exists)
            {
                BuildTree(directoryInfo, treeView1.Nodes);
            }
        }

        string yol = (Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Appdata\\Roaming\\.minecraft\\mods");

        private void BuildTree(DirectoryInfo directoryInfo, TreeNodeCollection addInMe)
        {
            TreeNode curNode = addInMe.Add(directoryInfo.Name);

            foreach (FileInfo file in directoryInfo.GetFiles())
            {
                curNode.Nodes.Add(file.FullName, file.Name);
            }
            foreach (DirectoryInfo subdir in directoryInfo.GetDirectories())
            {
                BuildTree(subdir, curNode.Nodes);
            }
        }
        private void guna2TileButton1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(yol);
        }

        private void guna2TileButton2_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            DirectoryInfo directoryInfo = new DirectoryInfo(yol);
            if (directoryInfo.Exists)
            {
                BuildTree(directoryInfo, treeView1.Nodes);
            }
        }
    }

}
