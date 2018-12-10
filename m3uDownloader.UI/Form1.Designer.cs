namespace m3uDownload.UI
{
    partial class Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.TitleTop = new System.Windows.Forms.Label();
            this.TitleDown = new System.Windows.Forms.Label();
            this.ChooseM3ULabel = new System.Windows.Forms.Label();
            this.ChooseDir = new System.Windows.Forms.Label();
            this.LabelNumberOnTitle = new System.Windows.Forms.Label();
            this.CopyrightLabel = new System.Windows.Forms.LinkLabel();
            this.playlistPath = new System.Windows.Forms.TextBox();
            this.DirPath = new System.Windows.Forms.TextBox();
            this.LabelNumberOnTag = new System.Windows.Forms.Label();
            this.ParallelLabel = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.CheckNumerInTitle = new System.Windows.Forms.CheckBox();
            this.CheckNumberInTag = new System.Windows.Forms.CheckBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.CntOfParallelDonload = new System.Windows.Forms.TrackBar();
            this.DownLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CntOfParallelDonload)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleTop
            // 
            this.TitleTop.AutoSize = true;
            this.TitleTop.BackColor = System.Drawing.Color.Transparent;
            this.TitleTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleTop.Location = new System.Drawing.Point(96, 9);
            this.TitleTop.Name = "TitleTop";
            this.TitleTop.Size = new System.Drawing.Size(119, 16);
            this.TitleTop.TabIndex = 0;
            this.TitleTop.Text = "Загрузка треков";
            // 
            // TitleDown
            // 
            this.TitleDown.AutoSize = true;
            this.TitleDown.BackColor = System.Drawing.Color.Transparent;
            this.TitleDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleDown.Location = new System.Drawing.Point(91, 28);
            this.TitleDown.Name = "TitleDown";
            this.TitleDown.Size = new System.Drawing.Size(128, 16);
            this.TitleDown.TabIndex = 1;
            this.TitleDown.Text = "из M3U плейлиста";
            // 
            // ChooseM3ULabel
            // 
            this.ChooseM3ULabel.AutoSize = true;
            this.ChooseM3ULabel.BackColor = System.Drawing.Color.Transparent;
            this.ChooseM3ULabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChooseM3ULabel.Location = new System.Drawing.Point(12, 57);
            this.ChooseM3ULabel.Name = "ChooseM3ULabel";
            this.ChooseM3ULabel.Size = new System.Drawing.Size(168, 15);
            this.ChooseM3ULabel.TabIndex = 2;
            this.ChooseM3ULabel.Text = "1. Выберите .m3u плейлист";
            // 
            // ChooseDir
            // 
            this.ChooseDir.AutoSize = true;
            this.ChooseDir.BackColor = System.Drawing.Color.Transparent;
            this.ChooseDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChooseDir.Location = new System.Drawing.Point(12, 114);
            this.ChooseDir.Name = "ChooseDir";
            this.ChooseDir.Size = new System.Drawing.Size(255, 15);
            this.ChooseDir.TabIndex = 3;
            this.ChooseDir.Text = "2. Выберите дирректорию для сохранения";
            // 
            // LabelNumberOnTitle
            // 
            this.LabelNumberOnTitle.AutoSize = true;
            this.LabelNumberOnTitle.BackColor = System.Drawing.Color.Transparent;
            this.LabelNumberOnTitle.Location = new System.Drawing.Point(34, 256);
            this.LabelNumberOnTitle.Name = "LabelNumberOnTitle";
            this.LabelNumberOnTitle.Size = new System.Drawing.Size(216, 13);
            this.LabelNumberOnTitle.TabIndex = 4;
            this.LabelNumberOnTitle.Text = "Пронумеровать каждый трек в названии";
            // 
            // CopyrightLabel
            // 
            this.CopyrightLabel.AutoSize = true;
            this.CopyrightLabel.BackColor = System.Drawing.Color.Transparent;
            this.CopyrightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CopyrightLabel.LinkColor = System.Drawing.Color.Navy;
            this.CopyrightLabel.Location = new System.Drawing.Point(173, 383);
            this.CopyrightLabel.Name = "CopyrightLabel";
            this.CopyrightLabel.Size = new System.Drawing.Size(109, 15);
            this.CopyrightLabel.TabIndex = 5;
            this.CopyrightLabel.TabStop = true;
            this.CopyrightLabel.Text = "@nedoche_love_k";
            this.CopyrightLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CopyrightLabel_LinkClicked);
            // 
            // playlistPath
            // 
            this.playlistPath.Location = new System.Drawing.Point(16, 77);
            this.playlistPath.Name = "playlistPath";
            this.playlistPath.ReadOnly = true;
            this.playlistPath.Size = new System.Drawing.Size(231, 20);
            this.playlistPath.TabIndex = 6;
            // 
            // DirPath
            // 
            this.DirPath.Location = new System.Drawing.Point(16, 135);
            this.DirPath.Name = "DirPath";
            this.DirPath.ReadOnly = true;
            this.DirPath.Size = new System.Drawing.Size(231, 20);
            this.DirPath.TabIndex = 7;
            // 
            // LabelNumberOnTag
            // 
            this.LabelNumberOnTag.AutoSize = true;
            this.LabelNumberOnTag.BackColor = System.Drawing.Color.Transparent;
            this.LabelNumberOnTag.Location = new System.Drawing.Point(34, 280);
            this.LabelNumberOnTag.Name = "LabelNumberOnTag";
            this.LabelNumberOnTag.Size = new System.Drawing.Size(190, 13);
            this.LabelNumberOnTag.TabIndex = 8;
            this.LabelNumberOnTag.Text = "Пронумеровать каждый трек в теге";
            // 
            // ParallelLabel
            // 
            this.ParallelLabel.AutoSize = true;
            this.ParallelLabel.BackColor = System.Drawing.Color.Transparent;
            this.ParallelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ParallelLabel.Location = new System.Drawing.Point(12, 172);
            this.ParallelLabel.Name = "ParallelLabel";
            this.ParallelLabel.Size = new System.Drawing.Size(260, 15);
            this.ParallelLabel.TabIndex = 9;
            this.ParallelLabel.Text = "3. Выберите кол-во параллельных загрузок";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "Корж и скрипи ♥";
            this.openFileDialog1.Filter = "m3u playlists(*.m3u)|*.m3u|All files(*.*)|*.*";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(253, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 22);
            this.button1.TabIndex = 10;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(72, 309);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 31);
            this.button3.TabIndex = 12;
            this.button3.Text = "СКАЧАТЬ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // CheckNumerInTitle
            // 
            this.CheckNumerInTitle.AutoSize = true;
            this.CheckNumerInTitle.BackColor = System.Drawing.Color.Transparent;
            this.CheckNumerInTitle.Checked = true;
            this.CheckNumerInTitle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckNumerInTitle.Location = new System.Drawing.Point(16, 256);
            this.CheckNumerInTitle.Name = "CheckNumerInTitle";
            this.CheckNumerInTitle.Size = new System.Drawing.Size(15, 14);
            this.CheckNumerInTitle.TabIndex = 13;
            this.CheckNumerInTitle.UseVisualStyleBackColor = false;
            // 
            // CheckNumberInTag
            // 
            this.CheckNumberInTag.AutoSize = true;
            this.CheckNumberInTag.BackColor = System.Drawing.Color.Transparent;
            this.CheckNumberInTag.Checked = true;
            this.CheckNumberInTag.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckNumberInTag.Location = new System.Drawing.Point(16, 279);
            this.CheckNumberInTag.Name = "CheckNumberInTag";
            this.CheckNumberInTag.Size = new System.Drawing.Size(15, 14);
            this.CheckNumberInTag.TabIndex = 14;
            this.CheckNumberInTag.UseVisualStyleBackColor = false;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "m3u Downloader";
            this.notifyIcon1.Visible = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(16, 351);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(266, 23);
            this.progressBar1.TabIndex = 15;
            // 
            // CntOfParallelDonload
            // 
            this.CntOfParallelDonload.BackColor = System.Drawing.SystemColors.Control;
            this.CntOfParallelDonload.LargeChange = 1;
            this.CntOfParallelDonload.Location = new System.Drawing.Point(16, 194);
            this.CntOfParallelDonload.Maximum = 12;
            this.CntOfParallelDonload.Minimum = 1;
            this.CntOfParallelDonload.Name = "CntOfParallelDonload";
            this.CntOfParallelDonload.Size = new System.Drawing.Size(266, 45);
            this.CntOfParallelDonload.TabIndex = 2;
            this.CntOfParallelDonload.Value = 12;
            // 
            // DownLabel
            // 
            this.DownLabel.AutoSize = true;
            this.DownLabel.BackColor = System.Drawing.Color.Transparent;
            this.DownLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DownLabel.Location = new System.Drawing.Point(13, 383);
            this.DownLabel.Name = "DownLabel";
            this.DownLabel.Size = new System.Drawing.Size(40, 15);
            this.DownLabel.TabIndex = 17;
            this.DownLabel.Text = "0 из 0";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(253, 136);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(29, 22);
            this.button2.TabIndex = 18;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(289, 409);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.DownLabel);
            this.Controls.Add(this.CntOfParallelDonload);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.CheckNumberInTag);
            this.Controls.Add(this.CheckNumerInTitle);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ParallelLabel);
            this.Controls.Add(this.LabelNumberOnTag);
            this.Controls.Add(this.DirPath);
            this.Controls.Add(this.playlistPath);
            this.Controls.Add(this.CopyrightLabel);
            this.Controls.Add(this.LabelNumberOnTitle);
            this.Controls.Add(this.ChooseDir);
            this.Controls.Add(this.ChooseM3ULabel);
            this.Controls.Add(this.TitleDown);
            this.Controls.Add(this.TitleTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(305, 448);
            this.MinimumSize = new System.Drawing.Size(305, 448);
            this.Name = "Form";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "m3u Downloader";
            ((System.ComponentModel.ISupportInitialize)(this.CntOfParallelDonload)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleTop;
        private System.Windows.Forms.Label TitleDown;
        private System.Windows.Forms.Label ChooseM3ULabel;
        private System.Windows.Forms.Label ChooseDir;
        private System.Windows.Forms.Label LabelNumberOnTitle;
        private System.Windows.Forms.LinkLabel CopyrightLabel;
        private System.Windows.Forms.TextBox playlistPath;
        private System.Windows.Forms.TextBox DirPath;
        private System.Windows.Forms.Label LabelNumberOnTag;
        private System.Windows.Forms.Label ParallelLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox CheckNumerInTitle;
        private System.Windows.Forms.CheckBox CheckNumberInTag;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TrackBar CntOfParallelDonload;
        private System.Windows.Forms.Label DownLabel;
        private System.Windows.Forms.Button button2;
    }
}

