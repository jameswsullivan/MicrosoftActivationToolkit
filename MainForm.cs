using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;

namespace MicrosoftActivationToolkit
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            CustomInitialization();
        }
        private string getTimestamp()
        {
            return DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void writeToConsole(string output)
        {
            consoleTextBox.AppendText(output);
            consoleTextBox.ScrollToCaret();
        }

        private bool isRunningWithElevatedPrivilege()
        {
            return new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
        }

        private bool isValidKMS(string kmsServer)
        {
            return Regex.IsMatch(kmsServer, kmsServerPatternRegex);
        }

        private bool isValidWindowsProductKey(string winProductKey)
        {
            return Regex.IsMatch(winProductKey, winProductKeyPatternRegex);
        }

        private void setKMSServerButton_Click(object sender, EventArgs e)
        {
            setKMSServer();
        }
        private void removeKMSServerButton_Click(object sender, EventArgs e)
        {
            removeKMSServer();
        }

        private void installProductKeyButton_Click(object sender, EventArgs e)
        {
            installWindowsProductKey();
        }

        private void uninstallProductKeyButton_Click(object sender, EventArgs e)
        {
            uninstallWindowsProductKey();
        }

        private void officeRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void startOverButton_Click(object sender, EventArgs e)
        {
            kmsServerTextBox.Clear();
            productKeyTextBox.Clear();
            consoleTextBox.Clear();
            productSelectionComboBox.SelectedIndex = 0;
        }

        private void activateButton_Click(object sender, EventArgs e)
        {
            activateWindows();
        }

        private void checkActivationStatusButton_Click(object sender, EventArgs e)
        {
            checkWindowsActivation();
        }

        private void checkWindowsActivation()
        {
            writeToConsole(lineDivider);
            string consoleMessage = getTimestamp() + " - INFO - Checking activation status ... " + Environment.NewLine + Environment.NewLine;
            writeToConsole(consoleMessage);

            using (Process process = new Process())
            {
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.Arguments = $"/c cscript {slmgrFilePath} /dlv";
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.StandardOutputEncoding = Encoding.UTF8;
                process.StartInfo.StandardErrorEncoding = Encoding.UTF8;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = true;

                process.Start();
                string output = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd() + Environment.NewLine;
                process.WaitForExit();

                if (process.ExitCode == 0)
                {
                    writeToConsole(output);
                    consoleMessage = getTimestamp() + " - INFO - Activation status retrieved." + Environment.NewLine + Environment.NewLine;
                    writeToConsole(consoleMessage);
                }
                else
                {
                    writeToConsole(error);
                    consoleMessage = getTimestamp() + " - ERROR - Error retrieving activation status." + Environment.NewLine + Environment.NewLine;
                    writeToConsole(consoleMessage);
                }
            }
        }

        private void uninstallWindowsProductKey()
        {
            writeToConsole(lineDivider);
            string consoleMessage = getTimestamp() + " - INFO - Removing Windows Product Key ... " + Environment.NewLine + Environment.NewLine;
            writeToConsole(consoleMessage);

            using (Process process = new Process())
            {
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.Arguments = $"/c cscript {slmgrFilePath} /upk";
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.StandardOutputEncoding = Encoding.UTF8;
                process.StartInfo.StandardErrorEncoding = Encoding.UTF8;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = true;

                process.Start();
                string output = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd() + Environment.NewLine;
                process.WaitForExit();

                if (process.ExitCode == 0)
                {
                    writeToConsole(output);
                    consoleMessage = getTimestamp() + " - INFO - Windows Product Key Removed." + Environment.NewLine + Environment.NewLine;
                    writeToConsole(consoleMessage);
                }
                else
                {
                    writeToConsole(error);
                    consoleMessage = getTimestamp() + " - ERROR - Error removing Windows Product Key." + Environment.NewLine + Environment.NewLine;
                    writeToConsole(consoleMessage);
                }
            }
        }

        private void installWindowsProductKey()
        {
            string winProductKey = productKeyTextBox.Text;
            string consoleMessage;

            if (winProductKey == "")
            {
                writeToConsole(lineDivider);
                consoleMessage = getTimestamp() + " - ERROR - No Product Key supplied! ... " + Environment.NewLine + Environment.NewLine;
                writeToConsole(consoleMessage);

            }
            else if (!isValidWindowsProductKey(winProductKey))
            {
                writeToConsole(lineDivider);
                consoleMessage = getTimestamp() + " - ERROR - Invalid Product Key supplied! ... " + Environment.NewLine + Environment.NewLine;
                writeToConsole(consoleMessage);

            }
            else if (isValidWindowsProductKey(winProductKey))
            {
                writeToConsole(lineDivider);
                consoleMessage = getTimestamp() + $" - INFO - Installing Windows Product Key - {winProductKey} ... " + Environment.NewLine + Environment.NewLine;
                writeToConsole(consoleMessage);

                using (Process process = new Process())
                {
                    process.StartInfo.FileName = "cmd.exe";
                    process.StartInfo.Arguments = $"/c cscript {slmgrFilePath} /ipk {winProductKey}";
                    process.StartInfo.RedirectStandardOutput = true;
                    process.StartInfo.RedirectStandardError = true;
                    process.StartInfo.StandardOutputEncoding = Encoding.UTF8;
                    process.StartInfo.StandardErrorEncoding = Encoding.UTF8;
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.CreateNoWindow = true;

                    process.Start();
                    string output = process.StandardOutput.ReadToEnd();
                    string error = process.StandardError.ReadToEnd() + Environment.NewLine;
                    process.WaitForExit();

                    if (process.ExitCode == 0)
                    {
                        writeToConsole(output);
                        writeToConsole(getTimestamp() + $" - INFO - Windows Product Key - {winProductKey} - successfully installed." + Environment.NewLine + Environment.NewLine);
                    }
                    else
                    {
                        writeToConsole(error);
                        writeToConsole(getTimestamp() + $" - ERROR - Error Windows Product Key - {winProductKey}." + Environment.NewLine + Environment.NewLine);
                    }
                }
            }
        }

        private void removeKMSServer()
        {
            writeToConsole(lineDivider);
            string consoleMessage = getTimestamp() + $" - INFO - Removing KMS server ... " + Environment.NewLine + Environment.NewLine;
            writeToConsole(consoleMessage);

            using (Process process = new Process())
            {
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.Arguments = $"/c cscript {slmgrFilePath} /ckms";
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.StandardOutputEncoding = Encoding.UTF8;
                process.StartInfo.StandardErrorEncoding = Encoding.UTF8;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = true;

                process.Start();
                string output = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd() + Environment.NewLine;
                process.WaitForExit();

                if (process.ExitCode == 0)
                {
                    writeToConsole(output);
                    consoleMessage = getTimestamp() + " - INFO - KMS server successfully removed." + Environment.NewLine + Environment.NewLine;
                    writeToConsole(consoleMessage);
                }
                else
                {
                    writeToConsole(error);
                    consoleMessage = getTimestamp() + " - ERROR - Error removing KMS server." + Environment.NewLine + Environment.NewLine;
                    writeToConsole(consoleMessage);
                }
            }
        }

        private void setKMSServer()
        {
            string kmsServer = kmsServerTextBox.Text;
            string consoleMessage;

            if (kmsServer == "")
            {
                writeToConsole(lineDivider);
                consoleMessage = getTimestamp() + " - ERROR - No KMS server supplied! ... " + Environment.NewLine + Environment.NewLine;
                writeToConsole(consoleMessage);
            }
            else if (!isValidKMS(kmsServer))
            {
                writeToConsole(lineDivider);
                consoleMessage = getTimestamp() + " - ERROR - KMS server {kmsServer} needs to be a valid IP or hostname! ... " + Environment.NewLine + Environment.NewLine;
                writeToConsole(consoleMessage);
            }
            else if (isValidKMS(kmsServer))
            {
                writeToConsole(lineDivider);
                consoleMessage = getTimestamp() + $" - INFO - Setting KMS server to {kmsServer} ... " + Environment.NewLine + Environment.NewLine;
                writeToConsole(consoleMessage);

                using (Process process = new Process())
                {
                    process.StartInfo.FileName = "cmd.exe";
                    process.StartInfo.Arguments = $"/c cscript {slmgrFilePath} /skms {kmsServer}";
                    process.StartInfo.RedirectStandardOutput = true;
                    process.StartInfo.RedirectStandardError = true;
                    process.StartInfo.StandardOutputEncoding = Encoding.UTF8;
                    process.StartInfo.StandardErrorEncoding = Encoding.UTF8;
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.CreateNoWindow = true;

                    process.Start();
                    string output = process.StandardOutput.ReadToEnd();
                    string error = process.StandardError.ReadToEnd() + Environment.NewLine;
                    process.WaitForExit();

                    if (process.ExitCode == 0)
                    {
                        writeToConsole(output);
                        writeToConsole(getTimestamp() + $" - INFO - KMS server {kmsServer} successfully added." + Environment.NewLine + Environment.NewLine);
                    }
                    else
                    {
                        writeToConsole(error);
                        writeToConsole(getTimestamp() + $" - ERROR - Error adding KMS server {kmsServer}." + Environment.NewLine + Environment.NewLine);
                    }
                }
            }
        }

        private void activateWindows()
        {
            writeToConsole(lineDivider);
            string consoleMessage = getTimestamp() + $" - INFO - Activating windows ... " + Environment.NewLine + Environment.NewLine;
            writeToConsole(consoleMessage);

            using (Process process = new Process())
            {
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.Arguments = $"/c cscript {slmgrFilePath} /ato";
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.StandardOutputEncoding = Encoding.UTF8;
                process.StartInfo.StandardErrorEncoding = Encoding.UTF8;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = true;

                process.Start();
                string output = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd() + Environment.NewLine;
                process.WaitForExit();

                if (process.ExitCode == 0)
                {
                    writeToConsole(output);
                    consoleMessage = getTimestamp() + " - INFO - Windows activated successfully." + Environment.NewLine + Environment.NewLine;
                    writeToConsole(consoleMessage);
                }
                else
                {
                    writeToConsole(error);
                    consoleMessage = getTimestamp() + " - ERROR - Error activating Windows." + Environment.NewLine + Environment.NewLine;
                    writeToConsole(consoleMessage);
                }
            }
        }

    }
}