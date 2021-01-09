
using System.Collections.Generic;
using System.Media;
using System.Windows.Forms;

namespace asap
{
    partial class game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>Menu window form</summary>
        public menu MenuWindow;
        /// <summary>Finish window form</summary>
        public finish FinishWindow;
        /// <summary>Contains information about displayed text language</summary>
        public string lang;
        /// <summary>Contains generated random scenario number</summary>
        public int scenario_number;
        /// <summary>Array containing scenarios</summary>
        public static string[] scenarios = {"ha","hs","st"};
        /// <summary>Custom lens cursos</summary>
        private Cursor curs;
        /// <summary>For displaying phone time</summary>
        private int[] time = new int[2];
        /// <summary>For counting scenario time</summary>
        public int time_counter = 0;
        /// <summary>Maximal scenario time where game automatically ends</summary>
        public int maxtime;
        /// <summary>Contains the illness suspected by the user</summary>
        private string suspected_illness = "";
        /// <summary>True if user calls the ambulance before the game ends</summary>
        private bool called = false;
        /// <summary>Background music file</summary>
        public SoundPlayer music;

        /// <summary>List containing all possible symptoms</summary>
        private List<string> symptoms = new List<string>();
        /// <summary>List containing symptoms suspected by the player</summary>
        private List<string> suspected_symptoms = new List<string>();
        /// <summary>List of all possible illnesses</summary>
        private List<string> illnesses = new List<string>();
        /// <summary>List of all the symptoms that have appeared during this scenario</summary>
        public List<string> scenario_symptoms = new List<string>();


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(game));
            this.buttonExit = new System.Windows.Forms.Button();
            this.symptomPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.symptomsContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.symptomsComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.time_label = new System.Windows.Forms.Label();
            this.charText = new System.Windows.Forms.Button();
            this.suspectedIllnessList = new System.Windows.Forms.ComboBox();
            this.susIllnessLabel = new System.Windows.Forms.Label();
            this.dialogue2 = new System.Windows.Forms.Button();
            this.dialogue1 = new System.Windows.Forms.Button();
            this.character = new System.Windows.Forms.PictureBox();
            this.lens = new System.Windows.Forms.PictureBox();
            this.phone = new System.Windows.Forms.PictureBox();
            this.notepad = new System.Windows.Forms.PictureBox();
            this.speechBubbleTail = new System.Windows.Forms.PictureBox();
            this.symptomsContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.character)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notepad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speechBubbleTail)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Salmon;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Location = new System.Drawing.Point(25, 25);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(50, 50);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // symptomPanel
            // 
            this.symptomPanel.BackColor = System.Drawing.Color.White;
            this.symptomPanel.Location = new System.Drawing.Point(1589, 78);
            this.symptomPanel.Name = "symptomPanel";
            this.symptomPanel.Size = new System.Drawing.Size(269, 339);
            this.symptomPanel.TabIndex = 2;
            // 
            // symptomsContextMenu
            // 
            this.symptomsContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.symptomsComboBox});
            this.symptomsContextMenu.Name = "contextMenuStrip1";
            this.symptomsContextMenu.Size = new System.Drawing.Size(182, 31);
            // 
            // symptomsComboBox
            // 
            this.symptomsComboBox.Name = "symptomsComboBox";
            this.symptomsComboBox.Size = new System.Drawing.Size(121, 23);
            // 
            // time_label
            // 
            this.time_label.AutoSize = true;
            this.time_label.BackColor = System.Drawing.Color.Black;
            this.time_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.time_label.ForeColor = System.Drawing.Color.White;
            this.time_label.Location = new System.Drawing.Point(1669, 646);
            this.time_label.Name = "time_label";
            this.time_label.Size = new System.Drawing.Size(140, 54);
            this.time_label.TabIndex = 5;
            this.time_label.Text = "12:00";
            this.time_label.Click += new System.EventHandler(this.phone_Click);
            this.time_label.MouseEnter += new System.EventHandler(this.phone_MouseEnter);
            this.time_label.MouseLeave += new System.EventHandler(this.phone_MouseLeave);
            // 
            // charText
            // 
            this.charText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.charText.Enabled = false;
            this.charText.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.charText.FlatAppearance.BorderSize = 3;
            this.charText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.charText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.charText.ForeColor = System.Drawing.Color.Black;
            this.charText.Location = new System.Drawing.Point(326, 700);
            this.charText.Name = "charText";
            this.charText.Size = new System.Drawing.Size(1203, 100);
            this.charText.TabIndex = 8;
            this.charText.Text = "Wypowiedź postaci";
            this.charText.UseVisualStyleBackColor = false;
            this.charText.MouseClick += new System.Windows.Forms.MouseEventHandler(this.game_MouseClick);
            this.charText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.game_MouseClick);
            // 
            // suspectedIllnessList
            // 
            this.suspectedIllnessList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.suspectedIllnessList.Enabled = false;
            this.suspectedIllnessList.FormattingEnabled = true;
            this.suspectedIllnessList.Location = new System.Drawing.Point(1601, 455);
            this.suspectedIllnessList.Name = "suspectedIllnessList";
            this.suspectedIllnessList.Size = new System.Drawing.Size(250, 21);
            this.suspectedIllnessList.TabIndex = 12;
            this.suspectedIllnessList.Visible = false;
            // 
            // susIllnessLabel
            // 
            this.susIllnessLabel.AutoSize = true;
            this.susIllnessLabel.BackColor = System.Drawing.Color.White;
            this.susIllnessLabel.Enabled = false;
            this.susIllnessLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.susIllnessLabel.Location = new System.Drawing.Point(1598, 429);
            this.susIllnessLabel.Name = "susIllnessLabel";
            this.susIllnessLabel.Size = new System.Drawing.Size(194, 20);
            this.susIllnessLabel.TabIndex = 13;
            this.susIllnessLabel.Text = "Podejrzewane schorzenie:";
            this.susIllnessLabel.Visible = false;
            // 
            // dialogue2
            // 
            this.dialogue2.AccessibleDescription = "2";
            this.dialogue2.BackColor = System.Drawing.Color.Transparent;
            this.dialogue2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dialogue2.BackgroundImage")));
            this.dialogue2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dialogue2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dialogue2.FlatAppearance.BorderSize = 0;
            this.dialogue2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.dialogue2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.dialogue2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dialogue2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dialogue2.Location = new System.Drawing.Point(326, 917);
            this.dialogue2.Name = "dialogue2";
            this.dialogue2.Size = new System.Drawing.Size(1182, 66);
            this.dialogue2.TabIndex = 10;
            this.dialogue2.Text = "Odpowiedź 2";
            this.dialogue2.UseVisualStyleBackColor = false;
            this.dialogue2.Click += new System.EventHandler(this.dialogue_Click);
            this.dialogue2.MouseEnter += new System.EventHandler(this.dialogue_MouseEnter);
            this.dialogue2.MouseLeave += new System.EventHandler(this.dialogue_MouseLeave);
            // 
            // dialogue1
            // 
            this.dialogue1.AccessibleDescription = "1";
            this.dialogue1.BackColor = System.Drawing.Color.Transparent;
            this.dialogue1.BackgroundImage = global::asap.Properties.Resources.sp;
            this.dialogue1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dialogue1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dialogue1.FlatAppearance.BorderSize = 0;
            this.dialogue1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.dialogue1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.dialogue1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dialogue1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dialogue1.Location = new System.Drawing.Point(336, 831);
            this.dialogue1.Name = "dialogue1";
            this.dialogue1.Size = new System.Drawing.Size(1193, 66);
            this.dialogue1.TabIndex = 9;
            this.dialogue1.Text = "Odpowiedź 1";
            this.dialogue1.UseVisualStyleBackColor = false;
            this.dialogue1.Click += new System.EventHandler(this.dialogue_Click);
            this.dialogue1.MouseEnter += new System.EventHandler(this.dialogue_MouseEnter);
            this.dialogue1.MouseLeave += new System.EventHandler(this.dialogue_MouseLeave);
            // 
            // character
            // 
            this.character.BackColor = System.Drawing.Color.Transparent;
            this.character.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("character.BackgroundImage")));
            this.character.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.character.Location = new System.Drawing.Point(523, 39);
            this.character.Name = "character";
            this.character.Size = new System.Drawing.Size(657, 1018);
            this.character.TabIndex = 7;
            this.character.TabStop = false;
            this.character.MouseClick += new System.Windows.Forms.MouseEventHandler(this.game_MouseClick);
            // 
            // lens
            // 
            this.lens.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lens.BackColor = System.Drawing.Color.Transparent;
            this.lens.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lens.Image = ((System.Drawing.Image)(resources.GetObject("lens.Image")));
            this.lens.Location = new System.Drawing.Point(25, 722);
            this.lens.Name = "lens";
            this.lens.Size = new System.Drawing.Size(240, 240);
            this.lens.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.lens.TabIndex = 6;
            this.lens.TabStop = false;
            this.lens.Click += new System.EventHandler(this.lens_Click);
            this.lens.MouseEnter += new System.EventHandler(this.lens_MouseEnter);
            this.lens.MouseLeave += new System.EventHandler(this.lens_MouseLeave);
            // 
            // phone
            // 
            this.phone.BackColor = System.Drawing.Color.Transparent;
            this.phone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.phone.Image = ((System.Drawing.Image)(resources.GetObject("phone.Image")));
            this.phone.Location = new System.Drawing.Point(1608, 533);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(250, 460);
            this.phone.TabIndex = 4;
            this.phone.TabStop = false;
            this.phone.Click += new System.EventHandler(this.phone_Click);
            this.phone.MouseEnter += new System.EventHandler(this.phone_MouseEnter);
            this.phone.MouseLeave += new System.EventHandler(this.phone_MouseLeave);
            // 
            // notepad
            // 
            this.notepad.BackColor = System.Drawing.Color.Transparent;
            this.notepad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("notepad.BackgroundImage")));
            this.notepad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.notepad.Location = new System.Drawing.Point(1552, 12);
            this.notepad.Name = "notepad";
            this.notepad.Size = new System.Drawing.Size(340, 515);
            this.notepad.TabIndex = 3;
            this.notepad.TabStop = false;
            // 
            // speechBubbleTail
            // 
            this.speechBubbleTail.BackColor = System.Drawing.Color.Transparent;
            this.speechBubbleTail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("speechBubbleTail.BackgroundImage")));
            this.speechBubbleTail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.speechBubbleTail.Location = new System.Drawing.Point(1438, 628);
            this.speechBubbleTail.Name = "speechBubbleTail";
            this.speechBubbleTail.Size = new System.Drawing.Size(120, 73);
            this.speechBubbleTail.TabIndex = 14;
            this.speechBubbleTail.TabStop = false;
            this.speechBubbleTail.MouseClick += new System.Windows.Forms.MouseEventHandler(this.game_MouseClick);
            // 
            // game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.ControlBox = false;
            this.Controls.Add(this.susIllnessLabel);
            this.Controls.Add(this.suspectedIllnessList);
            this.Controls.Add(this.dialogue2);
            this.Controls.Add(this.dialogue1);
            this.Controls.Add(this.charText);
            this.Controls.Add(this.character);
            this.Controls.Add(this.lens);
            this.Controls.Add(this.time_label);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.symptomPanel);
            this.Controls.Add(this.notepad);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.speechBubbleTail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ASAP - As Soon As Possible";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.game_MouseClick);
            this.symptomsContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.character)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notepad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speechBubbleTail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        /// <summary>Exit button to go back to the main menu</summary>
        private System.Windows.Forms.Button buttonExit;
        /// <summary>Notepad panel for suspectedSymptom objects</summary>
        private System.Windows.Forms.FlowLayoutPanel symptomPanel;
        /// <summary>Context menu with symptoms combobox in it</summary>
        private System.Windows.Forms.ContextMenuStrip symptomsContextMenu;
        /// <summary>ComboBox list with symptoms to choose from</summary>
        private System.Windows.Forms.ToolStripComboBox symptomsComboBox;
        /// <summary>Notepad image</summary>
        private System.Windows.Forms.PictureBox notepad;
        /// <summary>Phone image</summary>
        private System.Windows.Forms.PictureBox phone;
        /// <summary>For displaying time on the phone</summary>
        private System.Windows.Forms.Label time_label;
        /// <summary>Lens image</summary>
        private System.Windows.Forms.PictureBox lens;
        /// <summary>ComboBox to choose an illness the player suspects</summary>
        private ComboBox suspectedIllnessList;
        /// <summary>Title label for choosing the suspected illness</summary>
        private Label susIllnessLabel;
        /// <summary>Activates the dialogue option number 1</summary>
        public Button dialogue1;
        /// <summary>Activates the dialogue option number 2</summary>
        public Button dialogue2;
        /// <summary>Displays the character text</summary>
        public Button charText;
        /// <summary>Character image</summary>
        public PictureBox character;
        /// <summary>Part of the character speech bubble</summary>
        private PictureBox speechBubbleTail;
    }
}