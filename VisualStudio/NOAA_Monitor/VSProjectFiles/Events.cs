using System;
using MaterialSkin;
using MaterialSkin.Controls;
using IronPython.Hosting;
using System.Diagnostics;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NOAA_Monitor
{
    public struct Events
    {
        public void run_cmd(string cmd)
        {

            ProcessStartInfo pythonInfo = new ProcessStartInfo();
            // Process python;
            pythonInfo.FileName = @"py";
            pythonInfo.Arguments = cmd;
            pythonInfo.CreateNoWindow = true;
            pythonInfo.UseShellExecute = false;
            pythonInfo.RedirectStandardOutput = false;
            pythonInfo.RedirectStandardError = false;
            Process.Start(pythonInfo);
        }

        public string timestampFile(string _fileName, MainWindow Form)
        {
            string nowDateTime;

            nowDateTime = DateTime.UtcNow.ToString("MM/dd/yyyy HH:mm");
            Form.updateLabel.Text = "Last Updated: " + nowDateTime + " GMT";
            nowDateTime = nowDateTime.Replace('/', '_');
            nowDateTime = nowDateTime.Replace(' ', '_');
            nowDateTime = nowDateTime.Replace(':', '_');
            string newFileName = "latest_obs-" + nowDateTime + ".txt";
            try
            {
                System.IO.File.Move(_fileName, newFileName);
            }
            catch
            {
                return newFileName;
            }

            return newFileName;
        }
    }
}
