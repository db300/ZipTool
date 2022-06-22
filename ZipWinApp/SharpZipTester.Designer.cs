namespace ZipWinApp
{
    partial class SharpZipTester
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkShowPassword = new System.Windows.Forms.CheckBox();
            this.numZipLevel = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnZip = new System.Windows.Forms.Button();
            this.lstFile = new System.Windows.Forms.ListBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnUnzip = new System.Windows.Forms.Button();
            this.chkShowUnzipPassword = new System.Windows.Forms.CheckBox();
            this.txtUnzipPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtZipFile = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnChooseZipFile = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numZipLevel)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "要压缩的文件列表(拖放文件到列表)：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkShowPassword);
            this.groupBox1.Controls.Add(this.numZipLevel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtComment);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnZip);
            this.groupBox1.Controls.Add(this.lstFile);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(680, 277);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "文件压缩";
            // 
            // chkShowPassword
            // 
            this.chkShowPassword.AutoSize = true;
            this.chkShowPassword.Location = new System.Drawing.Point(314, 248);
            this.chkShowPassword.Name = "chkShowPassword";
            this.chkShowPassword.Size = new System.Drawing.Size(72, 16);
            this.chkShowPassword.TabIndex = 9;
            this.chkShowPassword.Text = "显示密码";
            this.chkShowPassword.UseVisualStyleBackColor = true;
            this.chkShowPassword.CheckedChanged += new System.EventHandler(this.chkShowPassword_CheckedChanged);
            // 
            // numZipLevel
            // 
            this.numZipLevel.Location = new System.Drawing.Point(473, 245);
            this.numZipLevel.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numZipLevel.Name = "numZipLevel";
            this.numZipLevel.Size = new System.Drawing.Size(120, 21);
            this.numZipLevel.TabIndex = 8;
            this.numZipLevel.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(402, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "压缩等级：";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(208, 245);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(100, 21);
            this.txtPassword.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "密码：";
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(54, 245);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(100, 21);
            this.txtComment.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "备注：";
            // 
            // btnZip
            // 
            this.btnZip.Location = new System.Drawing.Point(599, 43);
            this.btnZip.Name = "btnZip";
            this.btnZip.Size = new System.Drawing.Size(75, 23);
            this.btnZip.TabIndex = 2;
            this.btnZip.Text = "压缩";
            this.btnZip.UseVisualStyleBackColor = true;
            this.btnZip.Click += new System.EventHandler(this.btnZip_Click);
            // 
            // lstFile
            // 
            this.lstFile.AllowDrop = true;
            this.lstFile.FormattingEnabled = true;
            this.lstFile.ItemHeight = 12;
            this.lstFile.Location = new System.Drawing.Point(8, 43);
            this.lstFile.Name = "lstFile";
            this.lstFile.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstFile.Size = new System.Drawing.Size(585, 196);
            this.lstFile.TabIndex = 1;
            this.lstFile.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstFile_DragDrop);
            this.lstFile.DragEnter += new System.Windows.Forms.DragEventHandler(this.lstFile_DragEnter);
            this.lstFile.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lstFile_KeyUp);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "ZIP文件|*.zip";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "ZIP文件|*.zip";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnChooseZipFile);
            this.groupBox2.Controls.Add(this.btnUnzip);
            this.groupBox2.Controls.Add(this.chkShowUnzipPassword);
            this.groupBox2.Controls.Add(this.txtUnzipPassword);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtZipFile);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 313);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(680, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "文件解压";
            // 
            // btnUnzip
            // 
            this.btnUnzip.Location = new System.Drawing.Point(599, 31);
            this.btnUnzip.Name = "btnUnzip";
            this.btnUnzip.Size = new System.Drawing.Size(75, 23);
            this.btnUnzip.TabIndex = 10;
            this.btnUnzip.Text = "解压";
            this.btnUnzip.UseVisualStyleBackColor = true;
            this.btnUnzip.Click += new System.EventHandler(this.btnUnzip_Click);
            // 
            // chkShowUnzipPassword
            // 
            this.chkShowUnzipPassword.AutoSize = true;
            this.chkShowUnzipPassword.Location = new System.Drawing.Point(521, 63);
            this.chkShowUnzipPassword.Name = "chkShowUnzipPassword";
            this.chkShowUnzipPassword.Size = new System.Drawing.Size(72, 16);
            this.chkShowUnzipPassword.TabIndex = 9;
            this.chkShowUnzipPassword.Text = "显示密码";
            this.chkShowUnzipPassword.UseVisualStyleBackColor = true;
            this.chkShowUnzipPassword.CheckedChanged += new System.EventHandler(this.chkShowUnzipPassword_CheckedChanged);
            // 
            // txtUnzipPassword
            // 
            this.txtUnzipPassword.Location = new System.Drawing.Point(103, 61);
            this.txtUnzipPassword.Name = "txtUnzipPassword";
            this.txtUnzipPassword.PasswordChar = '*';
            this.txtUnzipPassword.Size = new System.Drawing.Size(412, 21);
            this.txtUnzipPassword.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "解压密码：";
            // 
            // txtZipFile
            // 
            this.txtZipFile.AllowDrop = true;
            this.txtZipFile.Location = new System.Drawing.Point(103, 31);
            this.txtZipFile.Name = "txtZipFile";
            this.txtZipFile.Size = new System.Drawing.Size(412, 21);
            this.txtZipFile.TabIndex = 1;
            this.txtZipFile.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtZipFile_DragDrop);
            this.txtZipFile.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtZipFile_DragEnter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "要解压的文件：";
            // 
            // btnChooseZipFile
            // 
            this.btnChooseZipFile.Location = new System.Drawing.Point(522, 31);
            this.btnChooseZipFile.Name = "btnChooseZipFile";
            this.btnChooseZipFile.Size = new System.Drawing.Size(75, 23);
            this.btnChooseZipFile.TabIndex = 11;
            this.btnChooseZipFile.Text = "选择文件";
            this.btnChooseZipFile.UseVisualStyleBackColor = true;
            this.btnChooseZipFile.Click += new System.EventHandler(this.btnChooseZipFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 425);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "压缩解压测试";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numZipLevel)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnZip;
        private System.Windows.Forms.ListBox lstFile;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkShowPassword;
        private System.Windows.Forms.NumericUpDown numZipLevel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkShowUnzipPassword;
        private System.Windows.Forms.TextBox txtUnzipPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtZipFile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUnzip;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnChooseZipFile;
    }
}

