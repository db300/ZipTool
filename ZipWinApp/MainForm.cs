using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
using iHawkZipStdLibrary;

namespace ZipWinApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnZip_Click(object sender, EventArgs e)
        {
            if (this.lstFile.Items.Count == 0)
            {
                MessageBox.Show("请添加要压缩的文件！");
                return;
            }


            if (this.saveFileDialog1.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                return;
            }

            string zipFilePath = this.saveFileDialog1.FileName;

            var fileList = new List<string>();
            foreach (var item in this.lstFile.Items)
            {
                var filePath = item.ToString();
                if (!fileList.Contains(filePath))
                {
                    fileList.Add(filePath);
                }
            }

            string comment = this.txtComment.Text;
            string password = this.txtPassword.Text;
            int level = (int)this.numZipLevel.Value;

            try
            {
                if (SharpZip.CompressFile(fileList, zipFilePath, comment, password, level))
                {
                    MessageBox.Show("完成文件压缩。", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Process.Start("explorer.exe", "/select, " + zipFilePath);//打开资源管理器并选中文件
                }
                else
                {
                    MessageBox.Show("文件压缩失败。", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //显示/隐藏压缩密码
        private void ChkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            this.txtPassword.PasswordChar = this.chkShowPassword.Checked ? '\0' : '*';
        }

        //文件列表拖放效果
        private void LstFile_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        //文件列表拖放
        private void LstFile_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            this.lstFile.Items.AddRange(files);
        }

        //文件列表删除选中项
        private void LstFile_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                var indices = this.lstFile.SelectedIndices;
                for (int i = indices.Count - 1; i >= 0; i--)
                {
                    this.lstFile.Items.RemoveAt(indices[i]);
                }
            }
        }

        //选择要解压的文件
        private void BtnChooseZipFile_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                return;
            }

            this.txtZipFile.Text = this.openFileDialog1.FileName;
        }

        //文件拖放效果
        private void TxtZipFile_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        //文件拖放
        private void TxtZipFile_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            this.txtZipFile.Text = files[0];
        }

        //显示/隐藏解压密码
        private void ChkShowUnzipPassword_CheckedChanged(object sender, EventArgs e)
        {
            this.txtUnzipPassword.PasswordChar = this.chkShowUnzipPassword.Checked ? '\0' : '*';
        }

        //执行文件解压
        private void BtnUnzip_Click(object sender, EventArgs e)
        {
            string zipFile = this.txtZipFile.Text;
            if (!File.Exists(zipFile))
            {
                MessageBox.Show("要解压的文件路径不正确，请重新选择！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (this.folderBrowserDialog1.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                return;
            }

            string password = this.txtUnzipPassword.Text;
            string destFolder = this.folderBrowserDialog1.SelectedPath;

            try
            {
                var s = SharpZip.DecomparessFile(zipFile, destFolder, password);
                if (string.IsNullOrWhiteSpace(s))
                {
                    MessageBox.Show("完成解压文件。", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Process.Start("explorer.exe", "/select, " + destFolder);//打开资源管理器并选中文件夹
                }
                else
                {
                    MessageBox.Show("解压文件失败！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
