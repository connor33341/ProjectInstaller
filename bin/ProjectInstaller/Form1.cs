using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace ProjectInstaller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] parts = Path.GetFileNameWithoutExtension(Application.ExecutablePath).Split('-');
        }
        private void btnDownload_Click(object sender, EventArgs e)
        {
            string directory = "dir";
            string mainExePath = Path.Combine(directory, "main.exe");
            string repoPath = Path.Combine(directory, "repo");
            string exeDirectory = Path.Combine(directory, "exe");

            // Check if main.exe exists
            if (!File.Exists(mainExePath))
            {
                // Create the directory if it doesn't exist
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                // Download and extract the repository
                DownloadAndExtractRepository("user", "repo", repoPath);

                // Move main.exe to the exe directory
                MoveMainExe(repoPath, exeDirectory);
            }
            else
            {
                MessageBox.Show("main.exe already exists.");
            }

            // Run main.exe with --msg hi flags
            RunMainExeWithFlags(exeDirectory);
        }

        private void DownloadAndExtractRepository(string user, string repo, string destinationPath)
        {
            string repoUrl = $"https://github.com/{user}/{repo}/archive/main.zip";

            using (var client = new WebClient())
            {
                MessageBox.Show($"Downloading {user}/{repo}...");
                client.DownloadFile(repoUrl, "repo.zip");
            }

            MessageBox.Show("Extracting repository...");
            ZipFile.ExtractToDirectory("repo.zip", destinationPath);
            File.Delete("repo.zip");
        }

        private void MoveMainExe(string sourceDirectory, string destinationDirectory)
        {
            string[] exeFiles = Directory.GetFiles(sourceDirectory, "main.exe", SearchOption.AllDirectories);

            if (exeFiles.Length > 0)
            {
                MessageBox.Show("Moving main.exe to exe directory...");
                Directory.CreateDirectory(destinationDirectory);
                File.Move(exeFiles[0], Path.Combine(destinationDirectory, "main.exe"));
                MessageBox.Show("main.exe moved successfully.");
            }
            else
            {
                MessageBox.Show("main.exe not found in the repository.");
            }
        }

        private void RunMainExeWithFlags(string exeDirectory)
        {
            string exePath = Path.Combine(exeDirectory, "main.exe");

            if (File.Exists(exePath))
            {
                MessageBox.Show("Running main.exe with --msg hi flags...");
                Process.Start(exePath, "--msg hi");
            }
            else
            {
                MessageBox.Show("main.exe not found in the exe directory.");
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
