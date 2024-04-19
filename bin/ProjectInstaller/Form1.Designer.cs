namespace ProjectInstaller
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            progressBar1 = new ProgressBar();
            linkLabel1 = new LinkLabel();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            button3 = new Button();
            button2 = new Button();
            textBox2 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            tabPage2 = new TabPage();
            label4 = new Label();
            richTextBox1 = new RichTextBox();
            folderBrowserDialog1 = new FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = SystemColors.ActiveCaption;
            splitContainer1.Panel1.BackgroundImage = Properties.Resources.OIG4;
            splitContainer1.Panel1.BackgroundImageLayout = ImageLayout.Stretch;
            splitContainer1.Panel1.Controls.Add(progressBar1);
            splitContainer1.Panel1.Controls.Add(linkLabel1);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tabControl1);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 266;
            splitContainer1.TabIndex = 0;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(14, 379);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(238, 23);
            progressBar1.TabIndex = 2;
            progressBar1.Click += progressBar1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(0, 435);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(31, 15);
            linkLabel1.TabIndex = 1;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "v.1.5";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(240, 45);
            label1.TabIndex = 0;
            label1.Text = "Project Installer";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(3, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(527, 447);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(textBox2);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(519, 419);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "General";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(21, 233);
            label8.Name = "label8";
            label8.Size = new Size(59, 21);
            label8.TabIndex = 10;
            label8.Text = "Status: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(21, 212);
            label7.Name = "label7";
            label7.Size = new Size(95, 21);
            label7.TabIndex = 9;
            label7.Text = "RepoName: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(21, 191);
            label6.Name = "label6";
            label6.Size = new Size(100, 21);
            label6.TabIndex = 8;
            label6.Text = "RepoOwner: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(21, 170);
            label5.Name = "label5";
            label5.Size = new Size(55, 21);
            label5.TabIndex = 7;
            label5.Text = "Errors:";
            // 
            // button3
            // 
            button3.Location = new Point(436, 390);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 6;
            button3.Text = "Install";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(425, 128);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "Select";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(21, 128);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(383, 23);
            textBox2.TabIndex = 4;
            textBox2.Text = "C:\\Program Files\\{REPO NAME}\\";
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(106, 95);
            label3.Name = "label3";
            label3.Size = new Size(205, 30);
            label3.TabIndex = 3;
            label3.Text = "Installation Directory";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(106, 27);
            label2.Name = "label2";
            label2.Size = new Size(256, 30);
            label2.TabIndex = 2;
            label2.Text = "Git Repository (User/Repo)";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(425, 60);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Verify";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(21, 60);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(383, 23);
            textBox1.TabIndex = 0;
            textBox1.Text = "connor33341/projectinstaller";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(richTextBox1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(519, 419);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Advanced";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(203, 29);
            label4.Name = "label4";
            label4.Size = new Size(80, 15);
            label4.TabIndex = 1;
            label4.Text = "Program Args";
            label4.Click += label4_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(17, 56);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(480, 344);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Project Installer";
            Load += Form1_Load_1;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label label1;
        private ProgressBar progressBar1;
        private LinkLabel linkLabel1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button button1;
        private TextBox textBox1;
        private Label label2;
        private Button button2;
        private TextBox textBox2;
        private Label label3;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button button3;
        private RichTextBox richTextBox1;
        private Label label4;
        private Label label5;
        private Label label7;
        private Label label6;
        private Label label8;
    }
}
