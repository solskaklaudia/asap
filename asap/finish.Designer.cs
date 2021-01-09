
using System.Collections.Generic;

namespace asap
{
    partial class finish
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>Game window form</summary>
        public game GameWindow;
        /// <summary>Menu window form</summary>
        public menu MenuWindow;
        /// <summary>Contains information about displayed text language</summary>
        public string lang;
        /// <summary>Contains generated random scenario number</summary>
        public int scenario_number;
        /// <summary>Contains the illness suspected by the user</summary>
        private string suspected_illness;
        /// <summary>True if user called the ambulance before the game ended</summary>
        private bool called;
        /// <summary>Contains final score</summary>
        private int score = 0;

        /// <summary>List containing all possible symptoms</summary>
        private List<string> illnesses = new List<string>();
        /// <summary>List containing symptoms suspected by the player</summary>
        private List<string> suspected_symptoms = new List<string>();
        /// <summary>List of all possible illnesses</summary>
        private List<string> illness_symptoms = new List<string>(); 

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(finish));
            this.buttonExit = new System.Windows.Forms.Button();
            this.resultText = new System.Windows.Forms.Label();
            this.selectedSymptomsLabel = new System.Windows.Forms.Label();
            this.remainingSymptomsLabel = new System.Windows.Forms.Label();
            this.finalScore = new System.Windows.Forms.Label();
            this.timeBonus = new System.Windows.Forms.Label();
            this.calledPoints = new System.Windows.Forms.Label();
            this.selectedSymptoms = new System.Windows.Forms.Button();
            this.remainingSymptoms = new System.Windows.Forms.Button();
            this.illnessPoints = new System.Windows.Forms.Label();
            this.illnessLabel = new System.Windows.Forms.Label();
            this.missedSymptomsLabel = new System.Windows.Forms.Label();
            this.missedSymptoms = new System.Windows.Forms.Button();
            this.image = new System.Windows.Forms.PictureBox();
            this.firstAid = new System.Windows.Forms.Button();
            this.firstAidLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Salmon;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Location = new System.Drawing.Point(1321, 930);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(370, 66);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.Text = "Powrót do menu głównego";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // resultText
            // 
            this.resultText.AutoSize = true;
            this.resultText.BackColor = System.Drawing.Color.Transparent;
            this.resultText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.resultText.Location = new System.Drawing.Point(102, 102);
            this.resultText.Name = "resultText";
            this.resultText.Size = new System.Drawing.Size(70, 26);
            this.resultText.TabIndex = 2;
            this.resultText.Text = "label1";
            // 
            // selectedSymptomsLabel
            // 
            this.selectedSymptomsLabel.AutoSize = true;
            this.selectedSymptomsLabel.BackColor = System.Drawing.Color.Transparent;
            this.selectedSymptomsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.selectedSymptomsLabel.Location = new System.Drawing.Point(47, 359);
            this.selectedSymptomsLabel.Name = "selectedSymptomsLabel";
            this.selectedSymptomsLabel.Size = new System.Drawing.Size(254, 26);
            this.selectedSymptomsLabel.TabIndex = 3;
            this.selectedSymptomsLabel.Text = "Oznaczone symptomy:";
            // 
            // remainingSymptomsLabel
            // 
            this.remainingSymptomsLabel.AutoSize = true;
            this.remainingSymptomsLabel.BackColor = System.Drawing.Color.Transparent;
            this.remainingSymptomsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.remainingSymptomsLabel.Location = new System.Drawing.Point(196, 669);
            this.remainingSymptomsLabel.Name = "remainingSymptomsLabel";
            this.remainingSymptomsLabel.Size = new System.Drawing.Size(618, 26);
            this.remainingSymptomsLabel.TabIndex = 7;
            this.remainingSymptomsLabel.Text = "Symptomy choroby, które nie pojawiły się w scenariuszu:";
            // 
            // finalScore
            // 
            this.finalScore.AutoSize = true;
            this.finalScore.BackColor = System.Drawing.Color.Transparent;
            this.finalScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.finalScore.ForeColor = System.Drawing.Color.DarkRed;
            this.finalScore.Location = new System.Drawing.Point(74, 177);
            this.finalScore.Name = "finalScore";
            this.finalScore.Size = new System.Drawing.Size(521, 46);
            this.finalScore.TabIndex = 9;
            this.finalScore.Text = "Końcowy wynik punktowy: ";
            // 
            // timeBonus
            // 
            this.timeBonus.AutoSize = true;
            this.timeBonus.BackColor = System.Drawing.Color.Transparent;
            this.timeBonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timeBonus.ForeColor = System.Drawing.Color.DarkRed;
            this.timeBonus.Location = new System.Drawing.Point(102, 286);
            this.timeBonus.Name = "timeBonus";
            this.timeBonus.Size = new System.Drawing.Size(166, 26);
            this.timeBonus.TabIndex = 10;
            this.timeBonus.Text = "Bonus za czas: ";
            // 
            // calledPoints
            // 
            this.calledPoints.AutoSize = true;
            this.calledPoints.BackColor = System.Drawing.Color.Transparent;
            this.calledPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.calledPoints.ForeColor = System.Drawing.Color.DarkRed;
            this.calledPoints.Location = new System.Drawing.Point(102, 234);
            this.calledPoints.Name = "calledPoints";
            this.calledPoints.Size = new System.Drawing.Size(366, 26);
            this.calledPoints.TabIndex = 11;
            this.calledPoints.Text = "Punkty za zadzwonienie po pomoc:  ";
            // 
            // selectedSymptoms
            // 
            this.selectedSymptoms.BackColor = System.Drawing.Color.MistyRose;
            this.selectedSymptoms.Enabled = false;
            this.selectedSymptoms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectedSymptoms.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.selectedSymptoms.Location = new System.Drawing.Point(52, 388);
            this.selectedSymptoms.Name = "selectedSymptoms";
            this.selectedSymptoms.Padding = new System.Windows.Forms.Padding(10);
            this.selectedSymptoms.Size = new System.Drawing.Size(543, 265);
            this.selectedSymptoms.TabIndex = 12;
            this.selectedSymptoms.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.selectedSymptoms.UseVisualStyleBackColor = false;
            // 
            // remainingSymptoms
            // 
            this.remainingSymptoms.BackColor = System.Drawing.Color.White;
            this.remainingSymptoms.Enabled = false;
            this.remainingSymptoms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.remainingSymptoms.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.remainingSymptoms.Location = new System.Drawing.Point(201, 698);
            this.remainingSymptoms.Name = "remainingSymptoms";
            this.remainingSymptoms.Padding = new System.Windows.Forms.Padding(10);
            this.remainingSymptoms.Size = new System.Drawing.Size(719, 298);
            this.remainingSymptoms.TabIndex = 13;
            this.remainingSymptoms.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.remainingSymptoms.UseVisualStyleBackColor = false;
            // 
            // illnessPoints
            // 
            this.illnessPoints.AutoSize = true;
            this.illnessPoints.BackColor = System.Drawing.Color.Transparent;
            this.illnessPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.illnessPoints.ForeColor = System.Drawing.Color.DarkRed;
            this.illnessPoints.Location = new System.Drawing.Point(102, 260);
            this.illnessPoints.Name = "illnessPoints";
            this.illnessPoints.Size = new System.Drawing.Size(319, 26);
            this.illnessPoints.TabIndex = 14;
            this.illnessPoints.Text = "Punkty za oznaczenie choroby: ";
            // 
            // illnessLabel
            // 
            this.illnessLabel.AutoSize = true;
            this.illnessLabel.BackColor = System.Drawing.Color.Transparent;
            this.illnessLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.illnessLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.illnessLabel.Location = new System.Drawing.Point(535, 21);
            this.illnessLabel.Name = "illnessLabel";
            this.illnessLabel.Size = new System.Drawing.Size(252, 46);
            this.illnessLabel.TabIndex = 15;
            this.illnessLabel.Text = "Scenariusz: ";
            // 
            // missedSymptomsLabel
            // 
            this.missedSymptomsLabel.AutoSize = true;
            this.missedSymptomsLabel.BackColor = System.Drawing.Color.Transparent;
            this.missedSymptomsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.missedSymptomsLabel.Location = new System.Drawing.Point(620, 359);
            this.missedSymptomsLabel.Name = "missedSymptomsLabel";
            this.missedSymptomsLabel.Size = new System.Drawing.Size(242, 26);
            this.missedSymptomsLabel.TabIndex = 16;
            this.missedSymptomsLabel.Text = "Pominięte symptomy:";
            // 
            // missedSymptoms
            // 
            this.missedSymptoms.BackColor = System.Drawing.Color.MistyRose;
            this.missedSymptoms.Enabled = false;
            this.missedSymptoms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.missedSymptoms.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.missedSymptoms.Location = new System.Drawing.Point(625, 388);
            this.missedSymptoms.Name = "missedSymptoms";
            this.missedSymptoms.Padding = new System.Windows.Forms.Padding(10);
            this.missedSymptoms.Size = new System.Drawing.Size(461, 265);
            this.missedSymptoms.TabIndex = 17;
            this.missedSymptoms.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.missedSymptoms.UseVisualStyleBackColor = false;
            // 
            // image
            // 
            this.image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.image.Location = new System.Drawing.Point(1317, 34);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(545, 375);
            this.image.TabIndex = 18;
            this.image.TabStop = false;
            // 
            // firstAid
            // 
            this.firstAid.BackColor = System.Drawing.Color.White;
            this.firstAid.Enabled = false;
            this.firstAid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.firstAid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.firstAid.Location = new System.Drawing.Point(1149, 475);
            this.firstAid.Name = "firstAid";
            this.firstAid.Padding = new System.Windows.Forms.Padding(10);
            this.firstAid.Size = new System.Drawing.Size(713, 420);
            this.firstAid.TabIndex = 19;
            this.firstAid.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.firstAid.UseVisualStyleBackColor = false;
            // 
            // firstAidLabel
            // 
            this.firstAidLabel.AutoSize = true;
            this.firstAidLabel.BackColor = System.Drawing.Color.Transparent;
            this.firstAidLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.firstAidLabel.Location = new System.Drawing.Point(1142, 433);
            this.firstAidLabel.Name = "firstAidLabel";
            this.firstAidLabel.Size = new System.Drawing.Size(291, 39);
            this.firstAidLabel.TabIndex = 20;
            this.firstAidLabel.Text = "Pierwsza pomoc:";
            // 
            // finish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.firstAidLabel);
            this.Controls.Add(this.firstAid);
            this.Controls.Add(this.image);
            this.Controls.Add(this.missedSymptoms);
            this.Controls.Add(this.missedSymptomsLabel);
            this.Controls.Add(this.illnessLabel);
            this.Controls.Add(this.illnessPoints);
            this.Controls.Add(this.remainingSymptoms);
            this.Controls.Add(this.selectedSymptoms);
            this.Controls.Add(this.calledPoints);
            this.Controls.Add(this.timeBonus);
            this.Controls.Add(this.finalScore);
            this.Controls.Add(this.remainingSymptomsLabel);
            this.Controls.Add(this.selectedSymptomsLabel);
            this.Controls.Add(this.resultText);
            this.Controls.Add(this.buttonExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "finish";
            this.Text = "ASAP - As Soon As Possible";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.finish_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        /// <summary>Exit button to go back to the main menu</summary>
        private System.Windows.Forms.Button buttonExit;
        /// <summary>Label for displaying final game result information</summary>
        private System.Windows.Forms.Label resultText;
        /// <summary>Title label for selected symptoms</summary>
        private System.Windows.Forms.Label selectedSymptomsLabel;
        /// <summary>Title label for remaining symptoms</summary>
        private System.Windows.Forms.Label remainingSymptomsLabel;
        /// <summary>For displaying final score</summary>
        private System.Windows.Forms.Label finalScore;
        /// <summary>For displaying information about time bonus points</summary>
        private System.Windows.Forms.Label timeBonus;
        /// <summary>For displaying information about points for calling (or not) the ambulance</summary>
        private System.Windows.Forms.Label calledPoints;
        /// <summary>Displays which symptoms the player has selected</summary>
        private System.Windows.Forms.Button selectedSymptoms;
        /// <summary>Displays wchich symptoms were not shown in the scenarip</summary>
        private System.Windows.Forms.Button remainingSymptoms;
        /// <summary>For displaying points for guessing the illness (or not)</summary>
        private System.Windows.Forms.Label illnessPoints;
        /// <summary>Label for displaying scenario name</summary>
        private System.Windows.Forms.Label illnessLabel;
        /// <summary>Title label for missed symptoms</summary>
        private System.Windows.Forms.Label missedSymptomsLabel;
        /// <summary>Displayed which symptoms were present but the player missed them</summary>
        private System.Windows.Forms.Button missedSymptoms;
        /// <summary>Displays illness-related image</summary>
        private System.Windows.Forms.PictureBox image;
        /// <summary>For displaying first-aid information</summary>
        private System.Windows.Forms.Button firstAid;
        /// <summary>Title label for first aid information</summary>
        private System.Windows.Forms.Label firstAidLabel;
    }
}