
using System.Collections.Generic;
using System.Windows.Forms;

namespace asap
{
    partial class game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public menu MenuWindow;
        public finish FinishWindow;

        public string lang;
        public int scenario_number;
        private int number_of_scenarios = 3;
        private Cursor curs;
        private int[] time = { 12, 0 };
        private int time_counter = 0;
        private int maxtime;
        private string suspected_illness;
        private bool called = false;

        private List<string> symptoms = new List<string>();
        private List<string> suspected_symptoms = new List<string>();
        private List<string> illnesses = new List<string>();


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
            this.label1 = new System.Windows.Forms.Label();
            this.symptomPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.symptomsContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.symptomsComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.notepad = new System.Windows.Forms.PictureBox();
            this.phone = new System.Windows.Forms.PictureBox();
            this.time_label = new System.Windows.Forms.Label();
            this.lens = new System.Windows.Forms.PictureBox();
            this.character = new System.Windows.Forms.PictureBox();
            this.charText = new System.Windows.Forms.Button();
            this.dialogue1 = new System.Windows.Forms.Button();
            this.dialogue2 = new System.Windows.Forms.Button();
            this.dialogue3 = new System.Windows.Forms.Button();
            this.suspectedIllnessList = new System.Windows.Forms.ComboBox();
            this.susIllnessLabel = new System.Windows.Forms.Label();
            this.symptomsContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notepad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.character)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Salmon;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Location = new System.Drawing.Point(28, 24);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(62, 43);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(174, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // symptomPanel
            // 
            this.symptomPanel.BackColor = System.Drawing.Color.White;
            this.symptomPanel.Location = new System.Drawing.Point(1610, 90);
            this.symptomPanel.Name = "symptomPanel";
            this.symptomPanel.Size = new System.Drawing.Size(223, 339);
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
            // notepad
            // 
            this.notepad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("notepad.BackgroundImage")));
            this.notepad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.notepad.Location = new System.Drawing.Point(1563, 24);
            this.notepad.Name = "notepad";
            this.notepad.Size = new System.Drawing.Size(320, 515);
            this.notepad.TabIndex = 3;
            this.notepad.TabStop = false;
            // 
            // phone
            // 
            this.phone.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("phone.BackgroundImage")));
            this.phone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.phone.Location = new System.Drawing.Point(1619, 545);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(250, 460);
            this.phone.TabIndex = 4;
            this.phone.TabStop = false;
            this.phone.Click += new System.EventHandler(this.phone_Click);
            this.phone.MouseEnter += new System.EventHandler(this.phone_MouseEnter);
            this.phone.MouseLeave += new System.EventHandler(this.phone_MouseLeave);
            // 
            // time_label
            // 
            this.time_label.AutoSize = true;
            this.time_label.BackColor = System.Drawing.Color.Black;
            this.time_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.time_label.ForeColor = System.Drawing.Color.White;
            this.time_label.Location = new System.Drawing.Point(1680, 658);
            this.time_label.Name = "time_label";
            this.time_label.Size = new System.Drawing.Size(140, 54);
            this.time_label.TabIndex = 5;
            this.time_label.Text = "12:00";
            // 
            // lens
            // 
            this.lens.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lens.BackColor = System.Drawing.Color.Transparent;
            this.lens.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lens.BackgroundImage")));
            this.lens.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lens.Location = new System.Drawing.Point(1328, 702);
            this.lens.Name = "lens";
            this.lens.Size = new System.Drawing.Size(280, 280);
            this.lens.TabIndex = 6;
            this.lens.TabStop = false;
            this.lens.Click += new System.EventHandler(this.lens_Click);
            this.lens.MouseEnter += new System.EventHandler(this.lens_MouseEnter);
            this.lens.MouseLeave += new System.EventHandler(this.lens_MouseLeave);
            // 
            // character
            // 
            this.character.BackColor = System.Drawing.Color.Transparent;
            this.character.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("character.BackgroundImage")));
            this.character.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.character.Location = new System.Drawing.Point(523, 24);
            this.character.Name = "character";
            this.character.Size = new System.Drawing.Size(657, 703);
            this.character.TabIndex = 7;
            this.character.TabStop = false;
            this.character.MouseClick += new System.Windows.Forms.MouseEventHandler(this.game_MouseClick);
            // 
            // charText
            // 
            this.charText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.charText.Enabled = false;
            this.charText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.charText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.charText.ForeColor = System.Drawing.Color.Black;
            this.charText.Location = new System.Drawing.Point(12, 658);
            this.charText.Name = "charText";
            this.charText.Size = new System.Drawing.Size(1295, 100);
            this.charText.TabIndex = 8;
            this.charText.Text = "Wypowiedź postaci";
            this.charText.UseVisualStyleBackColor = false;
            this.charText.MouseClick += new System.Windows.Forms.MouseEventHandler(this.game_MouseClick);
            this.charText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.game_MouseClick);
            // 
            // dialogue1
            // 
            this.dialogue1.BackColor = System.Drawing.Color.Salmon;
            this.dialogue1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dialogue1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dialogue1.Location = new System.Drawing.Point(65, 786);
            this.dialogue1.Name = "dialogue1";
            this.dialogue1.Size = new System.Drawing.Size(1222, 66);
            this.dialogue1.TabIndex = 9;
            this.dialogue1.Text = "Odpowiedź 1";
            this.dialogue1.UseVisualStyleBackColor = false;
            this.dialogue1.Click += new System.EventHandler(this.dialogue_Click);
            // 
            // dialogue2
            // 
            this.dialogue2.BackColor = System.Drawing.Color.Salmon;
            this.dialogue2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dialogue2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dialogue2.Location = new System.Drawing.Point(34, 858);
            this.dialogue2.Name = "dialogue2";
            this.dialogue2.Size = new System.Drawing.Size(1222, 66);
            this.dialogue2.TabIndex = 10;
            this.dialogue2.Text = "Odpowiedź 2";
            this.dialogue2.UseVisualStyleBackColor = false;
            this.dialogue2.Click += new System.EventHandler(this.dialogue_Click);
            // 
            // dialogue3
            // 
            this.dialogue3.BackColor = System.Drawing.Color.Salmon;
            this.dialogue3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dialogue3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dialogue3.Location = new System.Drawing.Point(81, 930);
            this.dialogue3.Name = "dialogue3";
            this.dialogue3.Size = new System.Drawing.Size(1222, 66);
            this.dialogue3.TabIndex = 11;
            this.dialogue3.Text = "Odpowiedź 3";
            this.dialogue3.UseVisualStyleBackColor = false;
            this.dialogue3.Click += new System.EventHandler(this.dialogue_Click);
            // 
            // suspectedIllnessList
            // 
            this.suspectedIllnessList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.suspectedIllnessList.Enabled = false;
            this.suspectedIllnessList.FormattingEnabled = true;
            this.suspectedIllnessList.Location = new System.Drawing.Point(1612, 467);
            this.suspectedIllnessList.Name = "suspectedIllnessList";
            this.suspectedIllnessList.Size = new System.Drawing.Size(220, 21);
            this.suspectedIllnessList.TabIndex = 12;
            this.suspectedIllnessList.Visible = false;
            // 
            // susIllnessLabel
            // 
            this.susIllnessLabel.AutoSize = true;
            this.susIllnessLabel.Enabled = false;
            this.susIllnessLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.susIllnessLabel.Location = new System.Drawing.Point(1609, 441);
            this.susIllnessLabel.Name = "susIllnessLabel";
            this.susIllnessLabel.Size = new System.Drawing.Size(194, 20);
            this.susIllnessLabel.TabIndex = 13;
            this.susIllnessLabel.Text = "Podejrzewane schorzenie:";
            this.susIllnessLabel.Visible = false;
            // 
            // game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.ControlBox = false;
            this.Controls.Add(this.susIllnessLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.suspectedIllnessList);
            this.Controls.Add(this.dialogue3);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ASAP - As Soon As Possible";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.game_FormClosing);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.game_MouseClick);
            this.symptomsContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.notepad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.character)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel symptomPanel;
        private System.Windows.Forms.ContextMenuStrip symptomsContextMenu;
        private System.Windows.Forms.ToolStripComboBox symptomsComboBox;
        private System.Windows.Forms.PictureBox notepad;
        private System.Windows.Forms.PictureBox phone;
        private System.Windows.Forms.Label time_label;
        private System.Windows.Forms.PictureBox lens;
        private System.Windows.Forms.PictureBox character;
        private System.Windows.Forms.Button charText;
        private System.Windows.Forms.Button dialogue1;
        private Button dialogue2;
        private Button dialogue3;
        private ComboBox suspectedIllnessList;
        private Label susIllnessLabel;
    }
}