
namespace asap
{
    partial class menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private int tile_counter = 1;
        private string lang = "pl";
        private int menubutton_width;
        private int menubutton_height;

        public game GameWindow;
        public education EduWindow;
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tutorialButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.credits)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1920, 1080);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            this.TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
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
            this.radioLang1.Enabled = false;
            this.radioLang1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioLang1.Location = new System.Drawing.Point(203, 318);
            this.radioLang1.Name = "radioLang1";
            this.radioLang1.Size = new System.Drawing.Size(67, 24);
            this.radioLang1.TabIndex = 12;
            this.radioLang1.TabStop = true;
            this.radioLang1.Text = "polski";
            this.radioLang1.UseVisualStyleBackColor = true;
            this.radioLang1.Visible = false;
            this.radioLang1.CheckedChanged += new System.EventHandler(this.radioLang_CheckedChanged);
            // 
            // radioLang2
            // 
            this.radioLang2.AutoSize = true;
            this.radioLang2.Enabled = false;
            this.radioLang2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioLang2.Location = new System.Drawing.Point(203, 360);
            this.radioLang2.Name = "radioLang2";
            this.radioLang2.Size = new System.Drawing.Size(79, 24);
            this.radioLang2.TabIndex = 13;
            this.radioLang2.TabStop = true;
            this.radioLang2.Text = "English";
            this.radioLang2.UseVisualStyleBackColor = true;
            this.radioLang2.Visible = false;
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
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.radioLang2);
            this.Controls.Add(this.radioLang1);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.credits);
            this.Controls.Add(this.gear);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.educationButton);
            this.Controls.Add(this.tutorialButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ASAP - As Soon As Possible";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tutorialButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.credits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox playButton;
        private System.Windows.Forms.PictureBox tutorialButton;
        private System.Windows.Forms.PictureBox educationButton;
        private System.Windows.Forms.PictureBox exitButton;
        private System.Windows.Forms.PictureBox gear;
        private System.Windows.Forms.PictureBox credits;
        private System.Windows.Forms.RichTextBox TextBox;
        private System.Windows.Forms.RadioButton radioLang1;
        private System.Windows.Forms.RadioButton radioLang2;
        private System.Windows.Forms.Button buttonClose;
        public System.Windows.Forms.Timer timer1;
    }
}