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

            DirectoryInfo directoryInfo = new DirectoryInfo(modspath);
            if (directoryInfo.Exists)
            {
                BuildTree(directoryInfo, treeView1.Nodes);
            }
            else
            {
                // If directory not contains this code is creates directory for you

                Directory.CreateDirectory(modspath);
                BuildTree(directoryInfo, treeView1.Nodes);
            }
        }

        string modspath = (Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Appdata\\Roaming\\.minecraft\\mods");

        //This mods are have a error but i'M solved problem
        private void BuildTree(DirectoryInfo directoryInfo, TreeNodeCollection addInMe)
        {
            // Add directory name
            TreeNode curNode = addInMe.Add(directoryInfo.Name);

            foreach (FileInfo file in directoryInfo.GetFiles())
            {
                // Adds files to nodes
                curNode.Nodes.Add(file.FullName, file.Name);
            }
            foreach (DirectoryInfo subdir in directoryInfo.GetDirectories())
            {
                // Gets subdirectories
                BuildTree(subdir, curNode.Nodes);
            }
        }
        private void guna2TileButton1_Click(object sender, EventArgs e)
        {
            //This button starts explorer.exe for looking mods folder
            System.Diagnostics.Process.Start(modspath);
        }

        private void guna2TileButton2_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            //Clears Mods tree

            DirectoryInfo directoryInfo = new DirectoryInfo(modspath);
            if (directoryInfo.Exists)
            {
                // Re-builds tree
                BuildTree(directoryInfo, treeView1.Nodes);
            }
        }
    }

}
