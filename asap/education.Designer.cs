
using System.Collections.Generic;

namespace asap
{
    partial class education
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>Menu window form</summary>
        public menu MenuWindow;
        /// <summary>Contains information about displayed text language</summary>
        public string lang;
        /// <summary>List containing arrays with info strings for all the illnesses</summary>
        private List<string[]> illnesses = new List<string[]>();
        /// <summary>List containing arrays with symptoms strings for all the illnesses</summary>
        private List<string[]> illnesses_symptoms = new List<string[]>(); 

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(education));
            this.buttonExit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.IllnessLabel = new System.Windows.Forms.Label();
            this.IllnessDescription = new System.Windows.Forms.Button();
            this.PossibleSymptoms = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Salmon;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Location = new System.Drawing.Point(29, 26);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(62, 57);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // button1
            // 
            this.button1.AccessibleDescription = "0";
            this.button1.BackColor = System.Drawing.Color.Salmon;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(65, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(315, 73);
            this.button1.TabIndex = 1;
            this.button1.Text = "Choroba 1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button_Click);
            // 
            // button2
            // 
            this.button2.AccessibleDescription = "1";
            this.button2.BackColor = System.Drawing.Color.Salmon;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(65, 478);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(315, 73);
            this.button2.TabIndex = 3;
            this.button2.Text = "Choroba 2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button_Click);
            // 
            // button3
            // 
            this.button3.AccessibleDescription = "2";
            this.button3.BackColor = System.Drawing.Color.Salmon;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(65, 580);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(315, 73);
            this.button3.TabIndex = 4;
            this.button3.Text = "Choroba 3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button_Click);
            // 
            // IllnessLabel
            // 
            this.IllnessLabel.AutoSize = true;
            this.IllnessLabel.BackColor = System.Drawing.Color.Transparent;
            this.IllnessLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IllnessLabel.Location = new System.Drawing.Point(995, 49);
            this.IllnessLabel.Name = "IllnessLabel";
            this.IllnessLabel.Size = new System.Drawing.Size(287, 63);
            this.IllnessLabel.TabIndex = 2;
            this.IllnessLabel.Text = "Choroba 1";
            // 
            // IllnessDescription
            // 
            this.IllnessDescription.Enabled = false;
            this.IllnessDescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IllnessDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IllnessDescription.Location = new System.Drawing.Point(432, 143);
            this.IllnessDescription.Name = "IllnessDescription";
            this.IllnessDescription.Padding = new System.Windows.Forms.Padding(20);
            this.IllnessDescription.Size = new System.Drawing.Size(915, 831);
            this.IllnessDescription.TabIndex = 7;
            this.IllnessDescription.Text = "Opis choroby";
            this.IllnessDescription.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.IllnessDescription.UseVisualStyleBackColor = true;
            // 
            // PossibleSymptoms
            // 
            this.PossibleSymptoms.BackColor = System.Drawing.Color.MistyRose;
            this.PossibleSymptoms.Enabled = false;
            this.PossibleSymptoms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PossibleSymptoms.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PossibleSymptoms.Location = new System.Drawing.Point(1383, 143);
            this.PossibleSymptoms.Name = "PossibleSymptoms";
            this.PossibleSymptoms.Padding = new System.Windows.Forms.Padding(20);
            this.PossibleSymptoms.Size = new System.Drawing.Size(477, 831);
            this.PossibleSymptoms.TabIndex = 8;
            this.PossibleSymptoms.Text = "Możliwe symptomy";
            this.PossibleSymptoms.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.PossibleSymptoms.UseVisualStyleBackColor = false;
            // 
            // education
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.ControlBox = false;
            this.Controls.Add(this.PossibleSymptoms);
            this.Controls.Add(this.IllnessDescription);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.IllnessLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "education";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ASAP - As Soon As Possible";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.education_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        /// <summary>Button for exiting the education section and going back to the main menu</summary>
        private System.Windows.Forms.Button buttonExit;
        /// <summary>Button for selecting illness information 1</summary>
        private System.Windows.Forms.Button button1;
        /// <summary>Button for selecting illness information 2</summary>
        private System.Windows.Forms.Button button2;
        /// <summary>Button for selecting illness information 3</summary>
        private System.Windows.Forms.Button button3;
        /// <summary>Label displaying the illness name</summary>
        private System.Windows.Forms.Label IllnessLabel;
        /// <summary>Displays illness description</summary>
        private System.Windows.Forms.Button IllnessDescription;
        /// <summary>Displays illness symptoms</summary>
        private System.Windows.Forms.Button PossibleSymptoms;
    }
}