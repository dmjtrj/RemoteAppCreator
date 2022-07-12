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

namespace RemoteAppLabel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            name_Label.Visible = consName_textBox.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var RA_Label = new RemoteAppLabel();
            string correctProgramName;
            if (isConsultant.Checked)
            {
                correctProgramName = RA_Label.CreateCorrectProgramName(consName_textBox.Text);
                RemoteAppLabel.CreateFolderForBatfile(correctProgramName);
                RemoteAppLabel.CreateBatFile(correctProgramName);
                RA_Label.programName = "Consultant" + correctProgramName;
                RA_Label.programFolder = @"\\10.0.29.18\sps\Consultant\Links\" + correctProgramName + @"\Consultant" + correctProgramName + ".bat";
                RA_Label.ipAddress = "10.0.29.18";
                RA_Label.labelFolder = $@"\\10.0.29.18\sps\Consultant\Links\Ярлыки\";
            }
            else
            {
                RA_Label.programName = programName_textbox.Text;
                RA_Label.programFolder = fileLocation_textbox.Text;
                RA_Label.ipAddress = $"{ip1_text.Text}.{ip2_text.Text}.{ip3_text.Text}.{ip4_text.Text}";
                RA_Label.labelFolder = RALabel_textbox.Text;
                correctProgramName = RA_Label.CreateCorrectProgramName(RA_Label.programName);
            }
            try
            {
                RA_Label.CreateRegistryKey(RA_Label.programName, RA_Label.ipAddress, RA_Label.programFolder);
                RA_Label.CreateRDPLabel(RA_Label.programName, RA_Label.labelFolder);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message);
            }
        }

        private void isConsultant_CheckedChanged(object sender, EventArgs e)
        {
            if (isConsultant.Checked)
                switchEnabledTextBoxes(true, false);
            else
            {
                switchEnabledTextBoxes(false, true);
                consName_textBox.Text = "";
            }
        }

        private void switchEnabledTextBoxes(bool consTrigger, bool programTrigger)
        {
            name_Label.Visible = consName_textBox.Visible = consTrigger;
            programName_textbox.Enabled = programTrigger;
            ip1_text.Enabled = ip2_text.Enabled = ip3_text.Enabled = ip4_text.Enabled = programTrigger;
            fileLocation_button.Enabled = RALabel_button.Enabled = programTrigger;
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

        private void ip1_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void ip2_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) && e.KeyChar == 8)
                e.Handled = true;
        }

        private void ip3_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void ip4_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }
    }
}
