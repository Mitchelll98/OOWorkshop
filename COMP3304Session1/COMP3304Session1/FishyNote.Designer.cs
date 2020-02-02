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
            this.SuspendLayout();
            // 
            // textNote
            // 
            this.textNote.Location = new System.Drawing.Point(50, 50);
            this.textNote.Name = "textNote";
            this.textNote.Size = new System.Drawing.Size(286, 31);
            this.textNote.TabIndex = 0;
            this.textNote.Text = "Enter your note text here...";
            this.textNote.TextChanged += new System.EventHandler(this.textNote_TextChanged);
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
    }
}