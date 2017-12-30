namespace CatchMe
{
    partial class CatchMeForm
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
            this.CatchMeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CatchMeButton
            // 
            this.CatchMeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CatchMeButton.Location = new System.Drawing.Point(31, 36);
            this.CatchMeButton.Name = "CatchMeButton";
            this.CatchMeButton.Size = new System.Drawing.Size(75, 59);
            this.CatchMeButton.TabIndex = 0;
            this.CatchMeButton.Text = "Catch Me!";
            this.CatchMeButton.UseVisualStyleBackColor = true;
            this.CatchMeButton.Click += new System.EventHandler(this.CatchMeButton_Click);
            this.CatchMeButton.MouseEnter += new System.EventHandler(this.CatchMeButton_MouseEnter);
            // 
            // CatchMeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 316);
            this.Controls.Add(this.CatchMeButton);
            this.Name = "CatchMeForm";
            this.Text = "Catch Me";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CatchMeButton;
    }
}

