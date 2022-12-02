using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace AliasTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void uTF8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {

                InitialDirectory = @"D:\",
                Title = "Open .ALL FILES",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "ALL",
                Filter = "all files (*.all|*.all|All files (*.*)|*.*",

                FilterIndex = 1,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)

            {
                string directory;
                directory = System.IO.Path.GetDirectoryName(openFileDialog1.FileName);
                textBox1.Text = openFileDialog1.FileName;

                using (Stream fileStream = new FileStream(textBox1.Text, FileMode.Open, FileAccess.Read))
                {
                    using (BinaryReader reader = new BinaryReader(fileStream))
                        reader.Close();
                    string strExeFilePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
                    string strWorkPath = Path.GetDirectoryName(strExeFilePath);
                    Process process = new Process();
                    string porra = Path.GetDirectoryName(textBox1.Text);
                    string command = "-G -w -r -r";
                    string scriptbms = "DANGETGIRL.BMS";
                    string bms = strWorkPath + "\\" + scriptbms;
                    string pasta = "Extracted";
                    string quickbms = strWorkPath + " " + "quickbms.exe";
                    string Arguments = command + scriptbms + textBox1.Text + pasta;
                    ProcessStartInfo processInfo = new ProcessStartInfo("cmd.exe", $"/c Alias_Script_Dumper.exe -e \"{textBox1.Text}\"");

                    process.StartInfo = processInfo;
                    process.Start();
                    process.WaitForExit();
                }
            }
        }

        private void eXTRACTToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void uTF8SCRIPSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {

                InitialDirectory = @"D:\",
                Title = "Open .ALL FILES",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "ALL",
                Filter = "all files (*.all|*.all|All files (*.*)|*.*",

                FilterIndex = 1,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)

            {
                string directory;
                directory = System.IO.Path.GetDirectoryName(openFileDialog1.FileName);
                textBox1.Text = openFileDialog1.FileName;

                using (Stream fileStream = new FileStream(textBox1.Text, FileMode.Open, FileAccess.Read))
                {
                    using (BinaryReader reader = new BinaryReader(fileStream))
                        reader.Close();
                    string strExeFilePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
                    string strWorkPath = Path.GetDirectoryName(strExeFilePath);
                    Process process = new Process();
                    string porra = Path.GetDirectoryName(textBox1.Text);
                    string command = "-G -w -r -r";
                    string scriptbms = "DANGETGIRL.BMS";
                    string bms = strWorkPath + "\\" + scriptbms;
                    string pasta = "Extracted";
                    string quickbms = strWorkPath + " " + "quickbms.exe";
                    string Arguments = command + scriptbms + textBox1.Text + pasta;
                    ProcessStartInfo processInfo = new ProcessStartInfo("cmd.exe", $"/c Alias_Script_Dumper.exe -e \"{textBox1.Text}\"");

                    process.StartInfo = processInfo;
                    process.Start();
                    process.WaitForExit();
                    string message = "SCRIPTS EXTRAÍDOS! RIP ROMCHACK!!";
                    string title = "ALIAS SCRIPT  1.0b";
                    MessageBox.Show(message, title);
                }
            }
        }

        private void uNICODESCRIPTSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {

                InitialDirectory = @"D:\",
                Title = "Open .ALL FILES",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "ALL",
                Filter = "all files (*.all|*.all|All files (*.*)|*.*",

                FilterIndex = 1,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)

            {
                string directory;
                directory = System.IO.Path.GetDirectoryName(openFileDialog1.FileName);
                textBox1.Text = openFileDialog1.FileName;

                using (Stream fileStream = new FileStream(textBox1.Text, FileMode.Open, FileAccess.Read))
                {
                    using (BinaryReader reader = new BinaryReader(fileStream))
                        reader.Close();
                    string strExeFilePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
                    string strWorkPath = Path.GetDirectoryName(strExeFilePath);
                    Process process = new Process();
                    string porra = Path.GetDirectoryName(textBox1.Text);
                    string command = "-d";
                    string scriptbms = "ALIAS_SCRIPT_EXTRACTOR.bms";
                    string pasta = "Extracted";
                    string quickbms = strWorkPath + " " + "quickbms.exe";
                    string Arguments = command + scriptbms + textBox1.Text + pasta;
                    ProcessStartInfo processInfo = new ProcessStartInfo("cmd.exe", $"/c quickbms.exe -d {scriptbms} \"{textBox1.Text}\" \"{porra}\"");

                    process.StartInfo = processInfo;
                    process.Start();
                    process.WaitForExit();
                    string message = "SCRIPTS EXTRAÍDOS! RIP ROMCHACK!!";
                    string title = "ALIAS SCRIPT  1.0b";
                    MessageBox.Show(message, title);
                }
            }
        }

        private void pPSFILESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {

                InitialDirectory = @"D:\",
                Title = "Open .cat FILES",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "CAT",
                Filter = "cat files (*.cat|*.cat|All files (*.*)|*.*",

                FilterIndex = 1,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)

            {
                string directory;
                directory = System.IO.Path.GetDirectoryName(openFileDialog1.FileName);
                textBox1.Text = openFileDialog1.FileName;

                using (Stream fileStream = new FileStream(textBox1.Text, FileMode.Open, FileAccess.Read))
                {
                    using (BinaryReader reader = new BinaryReader(fileStream))
                        reader.Close();
                    string strExeFilePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
                    string strWorkPath = Path.GetDirectoryName(strExeFilePath);
                    Process process = new Process();
                    string porra = Path.GetDirectoryName(textBox1.Text);
                    string command = "-d";
                    string scriptbms = "ALIASCAT2.BMS";
                    string pasta = "Extracted";
                    string quickbms = strWorkPath + " " + "quickbms.exe";
                    string Arguments = command + scriptbms + textBox1.Text + pasta;
                    ProcessStartInfo processInfo = new ProcessStartInfo("cmd.exe", $"/c quickbms.exe -d {scriptbms} \"{textBox1.Text}\" \"{porra}\"");

                    process.StartInfo = processInfo;
                    process.Start();
                    process.WaitForExit();
                    string message = "CATS EXTRAÍDOS! RIP ROMCHACK!!";
                    string title = "ALIAS SCRIPT  1.0b";
                    MessageBox.Show(message, title);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void uTF8SCRIPTSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {

                InitialDirectory = @"D:\",
                Title = "Open .ALL FILES",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "ALL",
                Filter = "all files (*.all|*.all|All files (*.*)|*.*",

                FilterIndex = 1,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)

            {
                string directory;
                directory = System.IO.Path.GetDirectoryName(openFileDialog1.FileName);
                textBox1.Text = openFileDialog1.FileName;

                using (Stream fileStream = new FileStream(textBox1.Text, FileMode.Open, FileAccess.Read))
                {
                    using (BinaryReader reader = new BinaryReader(fileStream))
                        reader.Close();
                    string strExeFilePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
                    string strWorkPath = Path.GetDirectoryName(strExeFilePath);
                    Process process = new Process();
                    string porra = Path.GetDirectoryName(textBox1.Text);
                    string command = "-G -w -r -r";
                    string scriptbms = "DANGETGIRL.BMS";
                    string bms = strWorkPath + "\\" + scriptbms;
                    string pasta = "Extracted";
                    string quickbms = strWorkPath + " " + "quickbms.exe";
                    string Arguments = command + scriptbms + textBox1.Text + pasta;
                    ProcessStartInfo processInfo = new ProcessStartInfo("cmd.exe", $"/c Alias_Script_Dumper.exe -i \"{textBox1.Text}\"");

                    process.StartInfo = processInfo;
                    process.Start();
                    process.WaitForExit();
                    string message = "SCRIPTS EXTRAÍDOS! RIP ROMCHACK!!";
                    string title = "ALIAS SCRIPT  1.0b";
                    MessageBox.Show(message, title);
                }
            }
        }

        private void uTF16SCRIPTSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {

                InitialDirectory = @"D:\",
                Title = "Open .ALL FILES",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "all",
                Filter = "all files (*.all|*.all|All files (*.*)|*.*",

                FilterIndex = 1,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)

            {
                string directory;
                directory = System.IO.Path.GetDirectoryName(openFileDialog1.FileName);
                textBox1.Text = openFileDialog1.FileName;

                using (Stream fileStream = new FileStream(textBox1.Text, FileMode.Open, FileAccess.Read))
                {
                    using (BinaryReader reader = new BinaryReader(fileStream))
                        reader.Close();
                    string strExeFilePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
                    string strWorkPath = Path.GetDirectoryName(strExeFilePath);
                    Process process = new Process();
                    string porra = Path.GetDirectoryName(textBox1.Text);
                    string command = "-G -w -r -r";
                    string scriptbms = "ALIAS_SCRIPT_EXTRACTOR.bms";
                    string bms = strWorkPath + "\\" + scriptbms;
                    string pasta = "Extracted";
                    string quickbms = strWorkPath + " " + "quickbms.exe";
                    string Arguments = command + scriptbms + textBox1.Text + pasta;
                    ProcessStartInfo processInfo = new ProcessStartInfo("cmd.exe", $"/c quickbms.exe -G -w -r -r -r {bms} \"{textBox1.Text}\"");

                    process.StartInfo = processInfo;
                    process.Start();
                    process.WaitForExit();
                }
            }
        }

        private void pPSSCRIPTSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {

                InitialDirectory = @"D:\",
                Title = "Open .CAT FILES",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "cat",
                Filter = "cat files (*.cat|*.cat|All files (*.*)|*.*",

                FilterIndex = 1,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)

            {
                string directory;
                directory = System.IO.Path.GetDirectoryName(openFileDialog1.FileName);
                textBox1.Text = openFileDialog1.FileName;

                using (Stream fileStream = new FileStream(textBox1.Text, FileMode.Open, FileAccess.Read))
                {
                    using (BinaryReader reader = new BinaryReader(fileStream))
                        reader.Close();
                    string strExeFilePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
                    string strWorkPath = Path.GetDirectoryName(strExeFilePath);
                    Process process = new Process();
                    string porra = Path.GetDirectoryName(textBox1.Text);
                    string command = "-G -w -r -r";
                    string scriptbms = "ALIASCAT2.BMS";
                    string bms = strWorkPath + "\\" + scriptbms;
                    string pasta = "Extracted";
                    string quickbms = strWorkPath + " " + "quickbms.exe";
                    string Arguments = command + scriptbms + textBox1.Text + pasta;
                    ProcessStartInfo processInfo = new ProcessStartInfo("cmd.exe", $"/c quickbms.exe -G -w -r -r -r {bms} \"{textBox1.Text}\"");

                    process.StartInfo = processInfo;
                    process.Start();
                    process.WaitForExit();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
    }
    
    
    
    
    

      
       
        


    