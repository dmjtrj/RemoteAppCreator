using Microsoft.Win32;
using System;
using System.Globalization;
using System.IO;

namespace RemoteAppLabel
{
    internal class RemoteAppLabel
    {
        public string programName { get; set; }
        public string programFolder { get; set; } // необходим путь программы относительно системы на которой она установлена
        public string labelFolder { get; set; }
        public string ipAddress { get; set; }

        // Переменная varForEditString необходима для того, чтобы имя сотрудника выводилось с большой буквы, независимо от ввода

        public string CreateCorrectProgramName(string programName)
        {
            var varForEditString = new CultureInfo("en-US", false).TextInfo.ToTitleCase(programName.ToLower());
            return varForEditString;
        }

        public void CreateRegistryKey(string correctProgramName, string ipAddress, string programFolder)
        {
            RegistryKey accessKey = RegistryKey.OpenRemoteBaseKey(RegistryHive.LocalMachine, ipAddress, RegistryView.Registry64);
            RegistryKey applicationsFolder = accessKey.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Terminal Server\TSAppAllowList\Applications", true);
            if (applicationsFolder is null)
            {
                applicationsFolder = accessKey.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Terminal Server\TSAppAllowList", true);
                applicationsFolder = applicationsFolder.CreateSubKey("Applications");
            };
            RegistryKey surnameFolder = applicationsFolder.CreateSubKey(correctProgramName);
            surnameFolder.SetValue("Name", correctProgramName);
            surnameFolder.SetValue("Path", programFolder);
        }

        public static void CreateFolderForBatfile(string correctProgramName)
        {
            Directory.CreateDirectory(@"\\10.0.29.18\sps\Consultant\Links\" + correctProgramName);
        }

        public static void CreateBatFile(string correctProgramName)
        {
            var batFileText = "start \\\\10.0.29.18\\sps\\Consultant\\cons.exe\r\nexit";
            File.WriteAllText(@"\\10.0.29.18\sps\Consultant\Links\" + correctProgramName + @"\Consultant" + correctProgramName + ".bat", batFileText.ToString());
        }

        public void CreateRDPLabel(string correctProgramName, string labelFolder)
        {
            //var currentDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
            var arrayOfLinesLabelContents = File.ReadAllLines(@"../../files/textForRDPLabel.txt");
            for (var i = 21; i < 23; i++)
            {
                arrayOfLinesLabelContents[i] = arrayOfLinesLabelContents[i].Replace("***", correctProgramName);
            }
            File.WriteAllLines(labelFolder + "\\" + correctProgramName + ".rdp", arrayOfLinesLabelContents);
        }
    }
}
