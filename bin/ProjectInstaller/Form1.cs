using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Runtime.Serialization;
using System.Security.Principal;
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

        }
        private bool IsAdministrator()
        {
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }
        private void RunAsAdmin(string fileName)
        {
            ProcessStartInfo processInfo = new ProcessStartInfo
            {
                FileName = fileName,
                UseShellExecute = true,
                Verb = "runas"
            };

            try
            {
                Process.Start(processInfo);
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        string[] parts = ["", ""];
        private void btnDownload_Click(object sender, EventArgs e)
        {
            string directory = "C:\\Program Files\\ProjectInstaller\\v1-5";
            string mainExePath = Path.Combine(directory, "installer.exe");
            string repoPath = Path.Combine(directory, "MainRepo");
            // Create the directory if it doesn't exist
            string[] parts2 = Path.GetFileNameWithoutExtension(Application.ExecutablePath).Split('-');
            if (parts2.Length == 2 && parts.Length != 2)
            {
                parts = parts2;
            }
            bool Admin = IsAdministrator();
            bool Testing = true;
            if (Testing)
            {
                parts[0] = "connor33341";
                parts[1] = "projectinstaller";
            }
            if (!Admin)
            {
                RunAsAdmin(Application.ExecutablePath);
            }
            if (parts.Length == 2)
            {
                label6.Text = "RepoOwner: " + parts[0];
                label7.Text = "RepoName: " + parts[1];
                textBox2.Text = $"C:\\Program Files\\{parts[0]}-{parts[1]}\\";
            }
            else
            {
                MessageBox.Show("Invalid installer name; name must be user-repo.exe and the repo must be a public github.com repo");
                label5.Text = "Error: Invalid Installer";
                return;
            }
            if (!Directory.Exists(directory))
            {
                label8.Text = "Creating Directory";
                if (Admin)
                {
                    Directory.CreateDirectory(directory);
                }
                else
                {
                    RunAsAdmin(Application.ExecutablePath);
                }
            }
            // Check if main.exe exists
            if ((!File.Exists(mainExePath)))
            {
                if (richTextBox1.Text == "")
                {
                    richTextBox1.Text = $"--owner {parts[0]} --repo {parts[1]} --path {textBox2.Text} --buildfile config.json";
                }
                else
                {
                    richTextBox1.Text = $" --owner {parts[0]} --repo {parts[1]} --path {textBox2.Text} --buildfile config.json";
                }
                // Download and extract the repository
                DownloadAndExtractRepository("connor33341", "projectinstaller", repoPath);

                // Move main.exe to the exe directory
                MoveMainExe(repoPath, mainExePath);
            }
            else
            {

            }

            RunMainExeWithFlags(directory);
        }

        private void DownloadAndExtractRepository(string user, string repo, string destinationPath)
        {
            if (Directory.Exists(destinationPath))
            {
                Directory.Delete(destinationPath, true);
            }
            string repoUrl = $"https://github.com/{user}/{repo}/archive/main.zip";

            using (var client = new WebClient())
            {
                //MessageBox.Show($"Downloading {user}/{repo}...");
                try
                {
                    client.DownloadFile(repoUrl, "repo.zip");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to find {user}/{repo}");
                    return;
                }
            }

            MessageBox.Show("Extracting repository...");
            ZipFile.ExtractToDirectory("repo.zip", destinationPath);
            File.Delete("repo.zip");
        }

        private void MoveMainExe(string sourceDirectory, string destinationDirectory)
        {
            string[] exeFiles = Directory.GetFiles(sourceDirectory, "installer.exe", SearchOption.AllDirectories);

            if (exeFiles.Length > 0)
            {
                //Directory.CreateDirectory(destinationDirectory);
                File.Move(exeFiles[0], Path.Combine(destinationDirectory, "installer.exe"));
            }
            else
            {
                MessageBox.Show("Error finding installer.exe");
            }
        }

        private void RunMainExeWithFlags(string exeDirectory)
        {
            string exePath = Path.Combine(exeDirectory, "installer.exe");

            if (File.Exists(exePath))
            {
                //MessageBox.Show("Running main.exe with --msg hi flags...");
                Process.Start(exePath, richTextBox1.Text);
            }
            else
            {
                MessageBox.Show($"Failed to find installer.exe in {exePath}");
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
            btnDownload_Click(sender, e);
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] reposplit = textBox1.Text.Split('/');
            string user = reposplit[0];
            string repo = reposplit[1];
            string repoUrl = $"https://github.com/{user}/{repo}/archive/main.zip";
            parts[0] = user;
            parts[1] = repo;
            using (var client = new WebClient())
            {
                //MessageBox.Show($"Downloading {user}/{repo}...");
                try
                {
                    client.OpenRead(repoUrl);
                    MessageBox.Show("Repo Validated");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to find {user}/{repo}");
                    return;
                }
            }
        }
    }
}
