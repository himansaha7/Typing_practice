namespace Typing_Practice
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.headingPart1 = new System.Windows.Forms.Label();
            this.headingPart2 = new System.Windows.Forms.Label();
            this.headingPart3 = new System.Windows.Forms.Label();
            this.settingButtonLabel = new System.Windows.Forms.Label();
            this.aboutButtonLabel = new System.Windows.Forms.Label();
            this.selectDurationChoice = new System.Windows.Forms.ComboBox();
            this.selectDurationLabel = new System.Windows.Forms.Label();
            this.remainingTimeLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.textView = new System.Windows.Forms.RichTextBox();
            this.textWrite = new System.Windows.Forms.RichTextBox();
            this.statisticsButtonLabel = new System.Windows.Forms.Label();
            this.statisticsButton = new System.Windows.Forms.Button();
            this.aboutButton = new System.Windows.Forms.Button();
            this.settingButton = new System.Windows.Forms.Button();
            this.nevigationBar_line2 = new System.Windows.Forms.PictureBox();
            this.nevigationBar_line1 = new System.Windows.Forms.PictureBox();
            this.touchTypingPicture = new System.Windows.Forms.PictureBox();
            this.endLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nevigationBar_line2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nevigationBar_line1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.touchTypingPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // headingPart1
            // 
            resources.ApplyResources(this.headingPart1, "headingPart1");
            this.headingPart1.BackColor = System.Drawing.Color.Transparent;
            this.headingPart1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.headingPart1.Name = "headingPart1";
            // 
            // headingPart2
            // 
            resources.ApplyResources(this.headingPart2, "headingPart2");
            this.headingPart2.BackColor = System.Drawing.Color.Transparent;
            this.headingPart2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.headingPart2.Name = "headingPart2";
            // 
            // headingPart3
            // 
            resources.ApplyResources(this.headingPart3, "headingPart3");
            this.headingPart3.BackColor = System.Drawing.Color.Transparent;
            this.headingPart3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.headingPart3.Name = "headingPart3";
            // 
            // settingButtonLabel
            // 
            resources.ApplyResources(this.settingButtonLabel, "settingButtonLabel");
            this.settingButtonLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.settingButtonLabel.Name = "settingButtonLabel";
            this.settingButtonLabel.Click += new System.EventHandler(this.settingButtonLabel_Click);
            // 
            // aboutButtonLabel
            // 
            resources.ApplyResources(this.aboutButtonLabel, "aboutButtonLabel");
            this.aboutButtonLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.aboutButtonLabel.Name = "aboutButtonLabel";
            // 
            // selectDurationChoice
            // 
            this.selectDurationChoice.AutoCompleteCustomSource.AddRange(new string[] {
            resources.GetString("selectDurationChoice.AutoCompleteCustomSource"),
            resources.GetString("selectDurationChoice.AutoCompleteCustomSource1"),
            resources.GetString("selectDurationChoice.AutoCompleteCustomSource2"),
            resources.GetString("selectDurationChoice.AutoCompleteCustomSource3"),
            resources.GetString("selectDurationChoice.AutoCompleteCustomSource4"),
            resources.GetString("selectDurationChoice.AutoCompleteCustomSource5")});
            this.selectDurationChoice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.selectDurationChoice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.selectDurationChoice.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.selectDurationChoice, "selectDurationChoice");
            this.selectDurationChoice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.selectDurationChoice.FormattingEnabled = true;
            this.selectDurationChoice.Items.AddRange(new object[] {
            resources.GetString("selectDurationChoice.Items"),
            resources.GetString("selectDurationChoice.Items1"),
            resources.GetString("selectDurationChoice.Items2"),
            resources.GetString("selectDurationChoice.Items3"),
            resources.GetString("selectDurationChoice.Items4"),
            resources.GetString("selectDurationChoice.Items5")});
            this.selectDurationChoice.Name = "selectDurationChoice";
            // 
            // selectDurationLabel
            // 
            resources.ApplyResources(this.selectDurationLabel, "selectDurationLabel");
            this.selectDurationLabel.ForeColor = System.Drawing.Color.Navy;
            this.selectDurationLabel.Name = "selectDurationLabel";
            // 
            // remainingTimeLabel
            // 
            resources.ApplyResources(this.remainingTimeLabel, "remainingTimeLabel");
            this.remainingTimeLabel.ForeColor = System.Drawing.Color.Blue;
            this.remainingTimeLabel.Name = "remainingTimeLabel";
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.startButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.startButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            resources.ApplyResources(this.startButton, "startButton");
            this.startButton.ForeColor = System.Drawing.Color.White;
            this.startButton.Name = "startButton";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // textView
            // 
            this.textView.AcceptsTab = true;
            this.textView.BackColor = System.Drawing.Color.White;
            this.textView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textView.DetectUrls = false;
            resources.ApplyResources(this.textView, "textView");
            this.textView.HideSelection = false;
            this.textView.Name = "textView";
            this.textView.ReadOnly = true;
            this.textView.ShortcutsEnabled = false;
            // 
            // textWrite
            // 
            this.textWrite.AcceptsTab = true;
            this.textWrite.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textWrite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textWrite.CausesValidation = false;
            resources.ApplyResources(this.textWrite, "textWrite");
            this.textWrite.Name = "textWrite";
            this.textWrite.TextChanged += new System.EventHandler(this.TextWrite_TextChanged);
            // 
            // statisticsButtonLabel
            // 
            resources.ApplyResources(this.statisticsButtonLabel, "statisticsButtonLabel");
            this.statisticsButtonLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.statisticsButtonLabel.Name = "statisticsButtonLabel";
            // 
            // statisticsButton
            // 
            this.statisticsButton.BackColor = System.Drawing.Color.Transparent;
            this.statisticsButton.BackgroundImage = global::Typing_Practice.Properties.Resources.statistics_icon;
            resources.ApplyResources(this.statisticsButton, "statisticsButton");
            this.statisticsButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.statisticsButton.FlatAppearance.BorderSize = 0;
            this.statisticsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.statisticsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.statisticsButton.Name = "statisticsButton";
            this.statisticsButton.UseVisualStyleBackColor = false;
            // 
            // aboutButton
            // 
            this.aboutButton.BackColor = System.Drawing.Color.Transparent;
            this.aboutButton.BackgroundImage = global::Typing_Practice.Properties.Resources.about_icon;
            resources.ApplyResources(this.aboutButton, "aboutButton");
            this.aboutButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.aboutButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.aboutButton.FlatAppearance.BorderSize = 0;
            this.aboutButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.aboutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.UseVisualStyleBackColor = false;
            // 
            // settingButton
            // 
            this.settingButton.BackColor = System.Drawing.Color.Transparent;
            this.settingButton.BackgroundImage = global::Typing_Practice.Properties.Resources.settings_icon;
            resources.ApplyResources(this.settingButton, "settingButton");
            this.settingButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.settingButton.FlatAppearance.BorderSize = 0;
            this.settingButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.settingButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.settingButton.Name = "settingButton";
            this.settingButton.UseVisualStyleBackColor = false;
            this.settingButton.Click += new System.EventHandler(this.settingButton_Click);
            // 
            // nevigationBar_line2
            // 
            this.nevigationBar_line2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.nevigationBar_line2, "nevigationBar_line2");
            this.nevigationBar_line2.Name = "nevigationBar_line2";
            this.nevigationBar_line2.TabStop = false;
            // 
            // nevigationBar_line1
            // 
            this.nevigationBar_line1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.nevigationBar_line1, "nevigationBar_line1");
            this.nevigationBar_line1.Name = "nevigationBar_line1";
            this.nevigationBar_line1.TabStop = false;
            // 
            // touchTypingPicture
            // 
            this.touchTypingPicture.BackColor = System.Drawing.Color.Transparent;
            this.touchTypingPicture.Image = global::Typing_Practice.Properties.Resources.touch_type;
            resources.ApplyResources(this.touchTypingPicture, "touchTypingPicture");
            this.touchTypingPicture.Name = "touchTypingPicture";
            this.touchTypingPicture.TabStop = false;
            // 
            // endLabel
            // 
            resources.ApplyResources(this.endLabel, "endLabel");
            this.endLabel.ForeColor = System.Drawing.Color.White;
            this.endLabel.Name = "endLabel";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.headingPart3);
            this.Controls.Add(this.headingPart2);
            this.Controls.Add(this.settingButtonLabel);
            this.Controls.Add(this.headingPart1);
            this.Controls.Add(this.endLabel);
            this.Controls.Add(this.statisticsButton);
            this.Controls.Add(this.statisticsButtonLabel);
            this.Controls.Add(this.textWrite);
            this.Controls.Add(this.remainingTimeLabel);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.textView);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.selectDurationLabel);
            this.Controls.Add(this.selectDurationChoice);
            this.Controls.Add(this.aboutButtonLabel);
            this.Controls.Add(this.settingButton);
            this.Controls.Add(this.nevigationBar_line2);
            this.Controls.Add(this.nevigationBar_line1);
            this.Controls.Add(this.touchTypingPicture);
            this.Name = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.nevigationBar_line2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nevigationBar_line1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.touchTypingPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox touchTypingPicture;
        private System.Windows.Forms.Label headingPart1;
        private System.Windows.Forms.Label headingPart2;
        private System.Windows.Forms.Label headingPart3;
        private System.Windows.Forms.PictureBox nevigationBar_line1;
        private System.Windows.Forms.Button settingButton;
        private System.Windows.Forms.PictureBox nevigationBar_line2;
        private System.Windows.Forms.Label settingButtonLabel;
        private System.Windows.Forms.Label aboutButtonLabel;
        private System.Windows.Forms.ComboBox selectDurationChoice;
        private System.Windows.Forms.Label selectDurationLabel;
        private System.Windows.Forms.Label remainingTimeLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.RichTextBox textView;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.RichTextBox textWrite;
        private System.Windows.Forms.Button statisticsButton;
        private System.Windows.Forms.Label statisticsButtonLabel;
        private System.Windows.Forms.Label endLabel;
        private System.Windows.Forms.Timer timer;
    }
}

