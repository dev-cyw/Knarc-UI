using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Diagnostics;
using System.IO;
using System.Security.AccessControl;
using System.Windows.Forms;

namespace Knarc_UI {
    public partial class Main : Form {
        public Main() {
            InitializeComponent();
        }

        string NarcPath;
        string ContentsPath;
        string UnpackedFolderPath;
        string NewNarcPath;

        private void NarcPathBTN_Click(object sender, EventArgs e) {
            CommonOpenFileDialog NarcPathDialog = new CommonOpenFileDialog {
                Title = "Narc Path",
                EnsureFileExists = true,
                InitialDirectory = Environment.CurrentDirectory
            };
            NarcPathDialog.Filters.Add(new CommonFileDialogFilter("All Files", "*.*"));
            NarcPathDialog.Filters.Add(new CommonFileDialogFilter("Narc Files", "*.narc"));

            if (NarcPathDialog.ShowDialog() == CommonFileDialogResult.Ok) {
                NarcPath = NarcPathDialog.FileName;
                NarcPathTxt.Text = NarcPathDialog.FileName;
            }
        }

        private void ContentsPathBTN_Click(object sender, EventArgs e) {
            CommonOpenFileDialog NarcContentsDialog = new CommonOpenFileDialog {
                Title = "Narc Contents",
                IsFolderPicker = true,
                EnsurePathExists = true,
                Multiselect = false,
                InitialDirectory = Environment.CurrentDirectory
            };

            if (NarcContentsDialog.ShowDialog() == CommonFileDialogResult.Ok) {
                ContentsPath = NarcContentsDialog.FileName;
                ContentsPathTxt.Text = NarcContentsDialog.FileName;
            }
        }

        private void UnpackNarcBTN_Click(object sender, EventArgs e) {
            if (!File.Exists("Knarc.exe")) {
                MessageBox.Show("Knarc.exe not found", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(ContentsPathTxt.Text) || string.IsNullOrEmpty(NarcPathTxt.Text)) {
                MessageBox.Show("Please fill out all required fields", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (NewFolderCB.Checked) {
                string newFolder = Path.Combine(ContentsPath, Path.GetFileNameWithoutExtension(NarcPath) + "_contents");
                if (Directory.Exists(newFolder)) {
                    if (MessageBox.Show("Do you want to overwrite the folder?", "Overwrite...", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No) {
                        return;
                    }
                }
                else {
                    Directory.CreateDirectory(newFolder);
                }
                ContentsPath = newFolder;
            }

            using (Process KNARC = new Process()) {
                KNARC.StartInfo.UseShellExecute = false;
                KNARC.StartInfo.CreateNoWindow = true;
                KNARC.StartInfo.RedirectStandardOutput = true;
                KNARC.StartInfo.FileName = "Knarc.exe";
                KNARC.StartInfo.Arguments = $"-d \"{ContentsPath}\" -u \"{NarcPath}\"";
                KNARC.Start();

                string output = KNARC.StandardOutput.ReadToEnd();
                KNARC.WaitForExit();

                if (!string.IsNullOrEmpty(output)) {
                    MessageBox.Show("Error: " + output, "Knarc Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else {
                    MessageBox.Show("Unpacking Successful", "Unpack...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            ContentsPath = ContentsPathTxt.Text;
        }

        private void UnpackedFolderBTN_Click(object sender, EventArgs e) {
            CommonOpenFileDialog UnpackedNarcDialog = new CommonOpenFileDialog {
                Title = "Unpacked Narc Folder",
                IsFolderPicker = true,
                EnsurePathExists = true,
                Multiselect = false,
                InitialDirectory = Environment.CurrentDirectory
            };

            if (UnpackedNarcDialog.ShowDialog() == CommonFileDialogResult.Ok) {
                UnpackedFolderPath = UnpackedNarcDialog.FileName;
                UnpackedFolderPathTxt.Text = UnpackedNarcDialog.FileName;
            }
        }

        private void NewNarcPathBTN_Click(object sender, EventArgs e) {
            CommonSaveFileDialog saveFileDialog = new CommonSaveFileDialog() {
                Title = "Unpacked Narc Folder",
                EnsurePathExists = true,
                InitialDirectory = Environment.CurrentDirectory
            };

            saveFileDialog.Filters.Add(new CommonFileDialogFilter("Narc Files", "*.narc"));


            if (saveFileDialog.ShowDialog() == CommonFileDialogResult.Ok) {
                NewNarcPath = saveFileDialog.FileName;
                NewNarcPathTxt.Text = saveFileDialog.FileName;
            }
        }

        private void PackNarcBTN_Click(object sender, EventArgs e) {
            if (!File.Exists("Knarc.exe")) {
                MessageBox.Show("Knarc.exe not found", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(UnpackedFolderPathTxt.Text) || string.IsNullOrEmpty(NewNarcPathTxt.Text)) {
                MessageBox.Show("Please fill out all required fields", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (Process KNARC = new Process()) {
                KNARC.StartInfo.UseShellExecute = false;
                KNARC.StartInfo.CreateNoWindow = true;
                KNARC.StartInfo.RedirectStandardOutput = true;
                KNARC.StartInfo.FileName = "Knarc.exe";
                KNARC.StartInfo.Arguments = $"-d \"{UnpackedFolderPath}\" -p \"{NewNarcPath}\"";
                KNARC.Start();

                string output = KNARC.StandardOutput.ReadToEnd();
                KNARC.WaitForExit();

                if (!string.IsNullOrEmpty(output)) {
                    MessageBox.Show("Error: " + output, "Knarc Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else {
                    MessageBox.Show("Packing Successful", "Pack...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
