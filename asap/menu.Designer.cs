
using System.Media;

namespace asap
{
    partial class menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>Counter for animated background tile frames</summary>
        private int tile_counter = 1;
        /// <summary>Contains information about displayed text language</summary>
        private string lang = "pl"; 
        /// <summary>Menu button width</summary>
        private int menubutton_width;
        /// <summary>Menu button height</summary>
        private int menubutton_height;
        /// <summary>Background music file</summary>
        public SoundPlayer music;
        /// <summary>If background music shall be playing; true if yes</summary>
        public bool musicPlaying = true;

        /// <summary>Game window form</summary>
        public game GameWindow;
        /// <summary>Education window form</summary>
        public education EduWindow;
        /// <summary>Tutorial window form</summary>
        public tutorial TutWindow;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.bgImage = new System.Windows.Forms.PictureBox();
            this.playButton = new System.Windows.Forms.PictureBox();
            this.tutorialButton = new System.Windows.Forms.PictureBox();
            this.educationButton = new System.Windows.Forms.PictureBox();
            this.exitButton = new System.Windows.Forms.PictureBox();
            this.gear = new System.Windows.Forms.PictureBox();
            this.credits = new System.Windows.Forms.PictureBox();
            this.TextBox = new System.Windows.Forms.RichTextBox();
            this.radioLang1 = new System.Windows.Forms.RadioButton();
            this.radioLang2 = new System.Windows.Forms.RadioButton();
            this.buttonClose = new System.Windows.Forms.Button();
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.musicControl = new System.Windows.Forms.CheckBox();
            this.musicLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bgImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tutorialButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.credits)).BeginInit();
            this.settingsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 40;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // bgImage
            // 
            this.bgImage.BackColor = System.Drawing.Color.Transparent;
            this.bgImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bgImage.BackgroundImage")));
            this.bgImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bgImage.Location = new System.Drawing.Point(0, 0);
            this.bgImage.Name = "bgImage";
            this.bgImage.Size = new System.Drawing.Size(1920, 1080);
            this.bgImage.TabIndex = 0;
            this.bgImage.TabStop = false;
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.Transparent;
            this.playButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("playButton.BackgroundImage")));
            this.playButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playButton.Location = new System.Drawing.Point(133, 376);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(717, 156);
            this.playButton.TabIndex = 2;
            this.playButton.TabStop = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            this.playButton.MouseEnter += new System.EventHandler(this.menubutton_MouseEnter);
            this.playButton.MouseLeave += new System.EventHandler(this.menubutton_MouseLeave);
            // 
            // tutorialButton
            // 
            this.tutorialButton.BackColor = System.Drawing.Color.Transparent;
            this.tutorialButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tutorialButton.BackgroundImage")));
            this.tutorialButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tutorialButton.Location = new System.Drawing.Point(203, 589);
            this.tutorialButton.Name = "tutorialButton";
            this.tutorialButton.Size = new System.Drawing.Size(580, 110);
            this.tutorialButton.TabIndex = 3;
            this.tutorialButton.TabStop = false;
            this.tutorialButton.Click += new System.EventHandler(this.tutorialButton_Click);
            this.tutorialButton.MouseEnter += new System.EventHandler(this.menubutton_MouseEnter);
            this.tutorialButton.MouseLeave += new System.EventHandler(this.menubutton_MouseLeave);
            // 
            // educationButton
            // 
            this.educationButton.BackColor = System.Drawing.Color.Transparent;
            this.educationButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("educationButton.BackgroundImage")));
            this.educationButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.educationButton.Location = new System.Drawing.Point(103, 720);
            this.educationButton.Name = "educationButton";
            this.educationButton.Size = new System.Drawing.Size(580, 110);
            this.educationButton.TabIndex = 4;
            this.educationButton.TabStop = false;
            this.educationButton.Click += new System.EventHandler(this.educationButton_Click);
            this.educationButton.MouseEnter += new System.EventHandler(this.menubutton_MouseEnter);
            this.educationButton.MouseLeave += new System.EventHandler(this.menubutton_MouseLeave);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitButton.BackgroundImage")));
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitButton.Location = new System.Drawing.Point(243, 851);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(580, 110);
            this.exitButton.TabIndex = 5;
            this.exitButton.TabStop = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            this.exitButton.MouseEnter += new System.EventHandler(this.menubutton_MouseEnter);
            this.exitButton.MouseLeave += new System.EventHandler(this.menubutton_MouseLeave);
            // 
            // gear
            // 
            this.gear.BackColor = System.Drawing.Color.Transparent;
            this.gear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gear.BackgroundImage")));
            this.gear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gear.Location = new System.Drawing.Point(1773, 32);
            this.gear.Name = "gear";
            this.gear.Size = new System.Drawing.Size(100, 100);
            this.gear.TabIndex = 6;
            this.gear.TabStop = false;
            this.gear.Click += new System.EventHandler(this.gear_Click);
            this.gear.MouseEnter += new System.EventHandler(this.menubutton_MouseEnter);
            this.gear.MouseLeave += new System.EventHandler(this.menubutton_MouseLeave);
            // 
            // credits
            // 
            this.credits.BackColor = System.Drawing.Color.Transparent;
            this.credits.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("credits.BackgroundImage")));
            this.credits.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.credits.Location = new System.Drawing.Point(1773, 906);
            this.credits.Name = "credits";
            this.credits.Size = new System.Drawing.Size(100, 100);
            this.credits.TabIndex = 7;
            this.credits.TabStop = false;
            this.credits.Click += new System.EventHandler(this.credits_Click);
            this.credits.MouseEnter += new System.EventHandler(this.menubutton_MouseEnter);
            this.credits.MouseLeave += new System.EventHandler(this.menubutton_MouseLeave);
            // 
            // TextBox
            // 
            this.TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox.Enabled = false;
            this.TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBox.Location = new System.Drawing.Point(100, 220);
            this.TextBox.Margin = new System.Windows.Forms.Padding(10);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(1720, 653);
            this.TextBox.TabIndex = 11;
            this.TextBox.Text = "";
            this.TextBox.Visible = false;
            // 
            // radioLang1
            // 
            this.radioLang1.AutoSize = true;
            this.radioLang1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioLang1.Location = new System.Drawing.Point(31, 19);
            this.radioLang1.Name = "radioLang1";
            this.radioLang1.Size = new System.Drawing.Size(86, 30);
            this.radioLang1.TabIndex = 12;
            this.radioLang1.TabStop = true;
            this.radioLang1.Text = "polski";
            this.radioLang1.UseVisualStyleBackColor = true;
            this.radioLang1.CheckedChanged += new System.EventHandler(this.radioLang_CheckedChanged);
            // 
            // radioLang2
            // 
            this.radioLang2.AutoSize = true;
            this.radioLang2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioLang2.Location = new System.Drawing.Point(31, 55);
            this.radioLang2.Name = "radioLang2";
            this.radioLang2.Size = new System.Drawing.Size(102, 30);
            this.radioLang2.TabIndex = 13;
            this.radioLang2.TabStop = true;
            this.radioLang2.Text = "English";
            this.radioLang2.UseVisualStyleBackColor = true;
            this.radioLang2.CheckedChanged += new System.EventHandler(this.radioLang_CheckedChanged);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Salmon;
            this.buttonClose.Enabled = false;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonClose.ForeColor = System.Drawing.Color.White;
            this.buttonClose.Location = new System.Drawing.Point(1753, 237);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(46, 44);
            this.buttonClose.TabIndex = 14;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Visible = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // settingsPanel
            // 
            this.settingsPanel.BackColor = System.Drawing.SystemColors.MenuBar;
            this.settingsPanel.Controls.Add(this.musicControl);
            this.settingsPanel.Controls.Add(this.musicLabel);
            this.settingsPanel.Controls.Add(this.radioLang1);
            this.settingsPanel.Controls.Add(this.radioLang2);
            this.settingsPanel.Enabled = false;
            this.settingsPanel.Location = new System.Drawing.Point(133, 288);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(767, 482);
            this.settingsPanel.TabIndex = 15;
            this.settingsPanel.Visible = false;
            // 
            // musicControl
            // 
            this.musicControl.AutoSize = true;
            this.musicControl.Checked = true;
            this.musicControl.CheckState = System.Windows.Forms.CheckState.Checked;
            this.musicControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.musicControl.Location = new System.Drawing.Point(31, 187);
            this.musicControl.Name = "musicControl";
            this.musicControl.Size = new System.Drawing.Size(15, 14);
            this.musicControl.TabIndex = 17;
            this.musicControl.UseVisualStyleBackColor = true;
            this.musicControl.CheckedChanged += new System.EventHandler(this.musicControl_CheckedChanged);
            // 
            // musicLabel
            // 
            this.musicLabel.AutoSize = true;
            this.musicLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.musicLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.musicLabel.Location = new System.Drawing.Point(12, 145);
            this.musicLabel.Name = "musicLabel";
            this.musicLabel.Size = new System.Drawing.Size(93, 26);
            this.musicLabel.TabIndex = 16;
            this.musicLabel.Text = "Muzyka:";
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.settingsPanel);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.credits);
            this.Controls.Add(this.gear);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.educationButton);
            this.Controls.Add(this.tutorialButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.bgImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ASAP - As Soon As Possible";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.bgImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tutorialButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.credits)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        /// <summary>Background image</summary>
        private System.Windows.Forms.PictureBox bgImage;
        /// <summary>Menu button to start the game</summary>
        private System.Windows.Forms.PictureBox playButton;
        /// <summary>Menu button to open the tutorial</summary>
        private System.Windows.Forms.PictureBox tutorialButton;
        /// <summary>Menu button to open education section</summary>
        private System.Windows.Forms.PictureBox educationButton;
        /// <summary>Menu button to close the program</summary>
        private System.Windows.Forms.PictureBox exitButton;
        /// <summary>Opens game settings</summary>
        private System.Windows.Forms.PictureBox gear;
        /// <summary>Opens game credits</summary>
        private System.Windows.Forms.PictureBox credits;
        /// <summary>Displays settings/credits text</summary>
        private System.Windows.Forms.RichTextBox TextBox;
        /// <summary>Language 1 radiobutton</summary>
        private System.Windows.Forms.RadioButton radioLang1;
        /// <summary>Language 2 radiobutton</summary>
        private System.Windows.Forms.RadioButton radioLang2;
        /// <summary>Closing the settings / credits</summary>
        private System.Windows.Forms.Button buttonClose;
        /// <summary>Menu form timer for background animation</summary>
        public System.Windows.Forms.Timer timer;
        /// <summary>Panel for settings objects</summary>
        private System.Windows.Forms.Panel settingsPanel;
        /// <summary>Label displaying music setting text</summary>
        private System.Windows.Forms.Label musicLabel;
        /// <summary>For enabling/disabling the music</summary>
        private System.Windows.Forms.CheckBox musicControl;
    }
}