
namespace asap
{
    partial class tutorial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public menu MenuWindow;
        public string lang;
        private string file_path;
        private int tutorial_count = 1;

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
            this.tutorialButtonExit = new System.Windows.Forms.Button();
            this.tutorialButtonPrevious = new System.Windows.Forms.Button();
            this.tutorialButtonNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tutorialButtonExit
            // 
            this.tutorialButtonExit.BackColor = System.Drawing.Color.Salmon;
            this.tutorialButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tutorialButtonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tutorialButtonExit.ForeColor = System.Drawing.Color.White;
            this.tutorialButtonExit.Location = new System.Drawing.Point(31, 26);
            this.tutorialButtonExit.Name = "tutorialButtonExit";
            this.tutorialButtonExit.Size = new System.Drawing.Size(59, 52);
            this.tutorialButtonExit.TabIndex = 19;
            this.tutorialButtonExit.Text = "X";
            this.tutorialButtonExit.UseVisualStyleBackColor = false;
            this.tutorialButtonExit.Click += new System.EventHandler(this.tutorialButtonExit_Click);
            // 
            // tutorialButtonPrevious
            // 
            this.tutorialButtonPrevious.BackColor = System.Drawing.Color.Salmon;
            this.tutorialButtonPrevious.Enabled = false;
            this.tutorialButtonPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tutorialButtonPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tutorialButtonPrevious.ForeColor = System.Drawing.Color.White;
            this.tutorialButtonPrevious.Location = new System.Drawing.Point(70, 943);
            this.tutorialButtonPrevious.Name = "tutorialButtonPrevious";
            this.tutorialButtonPrevious.Size = new System.Drawing.Size(158, 52);
            this.tutorialButtonPrevious.TabIndex = 20;
            this.tutorialButtonPrevious.Text = "button1";
            this.tutorialButtonPrevious.UseVisualStyleBackColor = false;
            this.tutorialButtonPrevious.Visible = false;
            this.tutorialButtonPrevious.Click += new System.EventHandler(this.tutorialButtonPrevious_Click);
            // 
            // tutorialButtonNext
            // 
            this.tutorialButtonNext.BackColor = System.Drawing.Color.Salmon;
            this.tutorialButtonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tutorialButtonNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tutorialButtonNext.ForeColor = System.Drawing.Color.White;
            this.tutorialButtonNext.Location = new System.Drawing.Point(1672, 943);
            this.tutorialButtonNext.Name = "tutorialButtonNext";
            this.tutorialButtonNext.Size = new System.Drawing.Size(158, 52);
            this.tutorialButtonNext.TabIndex = 21;
            this.tutorialButtonNext.Text = "button1";
            this.tutorialButtonNext.UseVisualStyleBackColor = false;
            this.tutorialButtonNext.Click += new System.EventHandler(this.tutorialButtonNext_Click);
            // 
            // tutorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.ControlBox = false;
            this.Controls.Add(this.tutorialButtonNext);
            this.Controls.Add(this.tutorialButtonPrevious);
            this.Controls.Add(this.tutorialButtonExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "tutorial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ASAP - As Soon As Possible";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.tutorial_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tutorialButtonExit;
        private System.Windows.Forms.Button tutorialButtonPrevious;
        private System.Windows.Forms.Button tutorialButtonNext;
    }
}