namespace PointFigureForm
{
    partial class FormPointAndRectangle
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
            this.labelPointInFigure = new System.Windows.Forms.Label();
            this.labelH = new System.Windows.Forms.Label();
            this.numericUpDownH = new System.Windows.Forms.NumericUpDown();
            this.labelPoint = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.numericUpDownX = new System.Windows.Forms.NumericUpDown();
            this.labelY = new System.Windows.Forms.Label();
            this.numericUpDownY = new System.Windows.Forms.NumericUpDown();
            this.buttonDraw = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPointInFigure
            // 
            this.labelPointInFigure.AutoSize = true;
            this.labelPointInFigure.Location = new System.Drawing.Point(13, 13);
            this.labelPointInFigure.Name = "labelPointInFigure";
            this.labelPointInFigure.Size = new System.Drawing.Size(116, 20);
            this.labelPointInFigure.TabIndex = 0;
            this.labelPointInFigure.Text = "Point In Figure:";
            // 
            // labelH
            // 
            this.labelH.AutoSize = true;
            this.labelH.Location = new System.Drawing.Point(14, 38);
            this.labelH.Name = "labelH";
            this.labelH.Size = new System.Drawing.Size(35, 20);
            this.labelH.TabIndex = 1;
            this.labelH.Text = "h = ";
            // 
            // numericUpDownH
            // 
            this.numericUpDownH.Location = new System.Drawing.Point(55, 36);
            this.numericUpDownH.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownH.Name = "numericUpDownH";
            this.numericUpDownH.Size = new System.Drawing.Size(70, 26);
            this.numericUpDownH.TabIndex = 2;
            this.numericUpDownH.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDownH.ValueChanged += new System.EventHandler(this.numericUpDownH_ValueChanged);
            // 
            // labelPoint
            // 
            this.labelPoint.AutoSize = true;
            this.labelPoint.Location = new System.Drawing.Point(17, 83);
            this.labelPoint.Name = "labelPoint";
            this.labelPoint.Size = new System.Drawing.Size(49, 20);
            this.labelPoint.TabIndex = 3;
            this.labelPoint.Text = "Point:";
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(17, 114);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(33, 20);
            this.labelX.TabIndex = 4;
            this.labelX.Text = "x = ";
            // 
            // numericUpDownX
            // 
            this.numericUpDownX.InterceptArrowKeys = false;
            this.numericUpDownX.Location = new System.Drawing.Point(55, 113);
            this.numericUpDownX.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownX.Name = "numericUpDownX";
            this.numericUpDownX.Size = new System.Drawing.Size(70, 26);
            this.numericUpDownX.TabIndex = 5;
            this.numericUpDownX.ValueChanged += new System.EventHandler(this.numericUpDownX_ValueChanged);
            this.numericUpDownX.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numericUpDownX_KeyDown);
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(18, 152);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(33, 20);
            this.labelY.TabIndex = 6;
            this.labelY.Text = "y = ";
            // 
            // numericUpDownY
            // 
            this.numericUpDownY.InterceptArrowKeys = false;
            this.numericUpDownY.Location = new System.Drawing.Point(55, 151);
            this.numericUpDownY.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownY.Name = "numericUpDownY";
            this.numericUpDownY.Size = new System.Drawing.Size(70, 26);
            this.numericUpDownY.TabIndex = 7;
            this.numericUpDownY.ValueChanged += new System.EventHandler(this.numericUpDownY_ValueChanged);
            this.numericUpDownY.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numericUpDownY_KeyDown);
            // 
            // buttonDraw
            // 
            this.buttonDraw.Location = new System.Drawing.Point(15, 196);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(109, 33);
            this.buttonDraw.TabIndex = 8;
            this.buttonDraw.Text = "Draw";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
            // 
            // labelResult
            // 
            this.labelResult.BackColor = System.Drawing.Color.PaleGreen;
            this.labelResult.Location = new System.Drawing.Point(15, 242);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(109, 31);
            this.labelResult.TabIndex = 9;
            this.labelResult.Text = "Result";
            this.labelResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.Location = new System.Drawing.Point(135, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(537, 347);
            this.pictureBox.TabIndex = 10;
            this.pictureBox.TabStop = false;
            // 
            // FormPointAndRectangle
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(684, 371);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.buttonDraw);
            this.Controls.Add(this.numericUpDownY);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.numericUpDownX);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.labelPoint);
            this.Controls.Add(this.numericUpDownH);
            this.Controls.Add(this.labelH);
            this.Controls.Add(this.labelPointInFigure);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(500, 410);
            this.Name = "FormPointAndRectangle";
            this.Text = "Point in the Figure";
            this.Load += new System.EventHandler(this.FormPointAndRectangle_Load);
            this.Resize += new System.EventHandler(this.FormPointAndRectangle_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPointInFigure;
        private System.Windows.Forms.Label labelH;
        private System.Windows.Forms.NumericUpDown numericUpDownH;
        private System.Windows.Forms.Label labelPoint;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.NumericUpDown numericUpDownX;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.NumericUpDown numericUpDownY;
        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}

