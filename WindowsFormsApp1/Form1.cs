using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            var correctSurname = CorrectSurname(programName_textbox.Text);
            if (isConsultant.Checked == true)
            {
                
            }
            else
            {
                var RA_Label = new RemoteAppLabel()
                {
                    programName = programName_textbox.Text,
                    programFolder = fileLocation_textbox.Text,
                    ipAddress = $"{ip1_text.Text}.{ip2_text.Text}.{ip3_text.Text}.{ip4_text.Text}",
                    labelFolder = RALabel_textbox.Text
                };
                var correctProgramName = RA_Label.CreateCorrectProgramName(RA_Label.programName);
                try
                {
                    RA_Label.CreateRegistryKey(correctProgramName, RA_Label.ipAddress, RA_Label.programFolder);
                    RA_Label.CreateRDPLabel(correctProgramName, RA_Label.labelFolder);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message);
                }
            }



            //try
            //{
            //    CreateFolderForBatfile(correctSurname);
            //    CreateBatFile(correctSurname);
            //    CreateRegistryKey(correctSurname);
            //    CreateRDPLabel(correctSurname);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(this, ex.Message);
            //}
        }

        // Переменная varForEditString необходима для того, чтобы имя сотрудника выводилось с большой буквы, независимо от ввода
        // эта запись - проба пера в git'е
        private string CorrectSurname(string surname)
        {
            var varForEditString = new CultureInfo("en-US", false).TextInfo.ToTitleCase(surname.ToLower());
            return varForEditString;
        }

        private void CreateRegistryKey(string correctSurname)
        {
            RegistryKey accessKey = RegistryKey.OpenRemoteBaseKey(RegistryHive.LocalMachine, "10.0.29.18", RegistryView.Registry64);
            RegistryKey openDirectory = accessKey.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Terminal Server\TSAppAllowList\Applications", true);
            if (openDirectory is null)
            {
                openDirectory = accessKey.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Terminal Server\TSAppAllowList", true);
                openDirectory = openDirectory.CreateSubKey("Applications");
            }
            var path = @"C:\sps\Consultant\Links\" + correctSurname + "\\Consultant" + correctSurname + ".bat";
            RegistryKey surnameFolder = openDirectory.CreateSubKey("Consultant" + correctSurname);
            surnameFolder.SetValue("Name", "Consultant" + correctSurname);
            surnameFolder.SetValue("Path", path);
        }

        private void CreateFolderForBatfile(string correctSurname)
        {
            Directory.CreateDirectory(@"\\10.0.29.18\sps\Consultant\Links\" + correctSurname);
        }

        private void CreateBatFile(string correctSurname)
        {
            var batFileText = "start \\\\10.0.29.18\\sps\\Consultant\\cons.exe\r\nexit";
            File.WriteAllText(@"\\10.0.29.18\sps\Consultant\Links\" + correctSurname + @"\Consultant" + correctSurname + ".bat", batFileText.ToString());
        }

        private void CreateRDPLabel(string correctSurname)
        {
            var currentDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
            var arrayOfLinesLabelContents = File.ReadAllLines(currentDirectory + @"\files\textForRDPLabel.txt");
            for (var i = 21; i < 23; i++)
            {
                arrayOfLinesLabelContents[i] = arrayOfLinesLabelContents[i].Replace("***", "Consultant" + correctSurname);
            }
            File.WriteAllLines($@"\\10.0.29.18\sps\Consultant\Links\Ярлыки\Консультант Плюс ({correctSurname}).rdp", arrayOfLinesLabelContents);
        }

        private void isConsultant_CheckedChanged(object sender, EventArgs e)
        {
            if (isConsultant.Checked == true)
            {
                programName_textbox.Text = @"Consultant";
                fileLocation_textbox.Text = @"C:\sps\Consultant\cons.exe";

            }
        }

        private void bat_button_Click(object sender, EventArgs e)
        {

        }

        private void RALabel_button_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                RALabel_textbox.Paste(folderBrowserDialog1.SelectedPath);
                RALabel_textbox.Enabled = true;
            }
        }

        private void fileLocation_button_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileLocation_textbox.Paste(openFileDialog1.FileName);
                fileLocation_textbox.Enabled = true;
            }
        }
    }
}
