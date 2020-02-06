namespace COMP3304Session1
{
    partial class FishyNote
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
            this.textNote = new System.Windows.Forms.TextBox();
            this.ActionNote = new System.Windows.Forms.Button();
            this.ExitNote = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textNote
            // 
            this.textNote.AcceptsReturn = true;
            this.textNote.Location = new System.Drawing.Point(12, 81);
            this.textNote.Multiline = true;
            this.textNote.Name = "textNote";
            this.textNote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textNote.Size = new System.Drawing.Size(377, 357);
            this.textNote.TabIndex = 0;
            this.textNote.Text = "Enter your note text here...";
            this.textNote.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textNote.Click += new System.EventHandler(this.textNote_Click);
            this.textNote.TextChanged += new System.EventHandler(this.textNote_TextChanged);
            // 
            // ActionNote
            // 
            this.ActionNote.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ActionNote.Location = new System.Drawing.Point(12, 12);
            this.ActionNote.Name = "ActionNote";
            this.ActionNote.Size = new System.Drawing.Size(269, 63);
            this.ActionNote.TabIndex = 1;
            this.ActionNote.Text = "Collaspe / Enlarge";
            this.ActionNote.UseVisualStyleBackColor = false;
            this.ActionNote.Click += new System.EventHandler(this.ActionNote_Click);
            // 
            // ExitNote
            // 
            this.ExitNote.BackColor = System.Drawing.Color.Red;
            this.ExitNote.Location = new System.Drawing.Point(321, 13);
            this.ExitNote.Name = "ExitNote";
            this.ExitNote.Size = new System.Drawing.Size(67, 62);
            this.ExitNote.TabIndex = 2;
            this.ExitNote.Text = "X";
            this.ExitNote.UseVisualStyleBackColor = false;
            this.ExitNote.Click += new System.EventHandler(this.ExitNote_Click);
            // 
            // FishyNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(401, 450);
            this.ControlBox = false;
            this.Controls.Add(this.ExitNote);
            this.Controls.Add(this.ActionNote);
            this.Controls.Add(this.textNote);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FishyNote";
            this.Text = "FishyNote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textNote;
        private System.Windows.Forms.Button ActionNote;
        private System.Windows.Forms.Button ExitNote;
    }
}