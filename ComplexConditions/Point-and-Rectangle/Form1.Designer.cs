﻿namespace Point_and_Rectangle
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
            this.labelRectangle = new System.Windows.Forms.Label();
            this.labelX1 = new System.Windows.Forms.Label();
            this.labelY1 = new System.Windows.Forms.Label();
            this.labelX2 = new System.Windows.Forms.Label();
            this.labelY2 = new System.Windows.Forms.Label();
            this.numericUpDownX1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownY1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownX2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownY2 = new System.Windows.Forms.NumericUpDown();
            this.labelPoint = new System.Windows.Forms.Label();
            this.numericUpDownX = new System.Windows.Forms.NumericUpDown();
            this.labelX = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.numericUpDownY = new System.Windows.Forms.NumericUpDown();
            this.buttonDraw = new System.Windows.Forms.Button();
            this.labelLocation = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // labelRectangle
            // 
            this.labelRectangle.AutoSize = true;
            this.labelRectangle.Location = new System.Drawing.Point(12, 9);
            this.labelRectangle.Name = "labelRectangle";
            this.labelRectangle.Size = new System.Drawing.Size(86, 20);
            this.labelRectangle.TabIndex = 0;
            this.labelRectangle.Text = "Rectangle:";
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.Location = new System.Drawing.Point(16, 41);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(38, 20);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "x1 =";
            // 
            // labelY1
            // 
            this.labelY1.AutoSize = true;
            this.labelY1.Location = new System.Drawing.Point(16, 75);
            this.labelY1.Name = "labelY1";
            this.labelY1.Size = new System.Drawing.Size(42, 20);
            this.labelY1.TabIndex = 2;
            this.labelY1.Text = "y1 = ";
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            this.labelX2.Location = new System.Drawing.Point(16, 108);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(42, 20);
            this.labelX2.TabIndex = 3;
            this.labelX2.Text = "x2 = ";
            // 
            // labelY2
            // 
            this.labelY2.AutoSize = true;
            this.labelY2.Location = new System.Drawing.Point(15, 139);
            this.labelY2.Name = "labelY2";
            this.labelY2.Size = new System.Drawing.Size(42, 20);
            this.labelY2.TabIndex = 4;
            this.labelY2.Text = "y2 = ";
            // 
            // numericUpDownX1
            // 
            this.numericUpDownX1.DecimalPlaces = 2;
            this.numericUpDownX1.Location = new System.Drawing.Point(60, 41);
            this.numericUpDownX1.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownX1.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.numericUpDownX1.Name = "numericUpDownX1";
            this.numericUpDownX1.Size = new System.Drawing.Size(61, 26);
            this.numericUpDownX1.TabIndex = 5;
            this.numericUpDownX1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownX1.ValueChanged += new System.EventHandler(this.numericUpDownX1_ValueChanged);
            // 
            // numericUpDownY1
            // 
            this.numericUpDownY1.DecimalPlaces = 2;
            this.numericUpDownY1.Location = new System.Drawing.Point(60, 73);
            this.numericUpDownY1.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownY1.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.numericUpDownY1.Name = "numericUpDownY1";
            this.numericUpDownY1.Size = new System.Drawing.Size(61, 26);
            this.numericUpDownY1.TabIndex = 6;
            this.numericUpDownY1.Value = new decimal(new int[] {
            3,
            0,
            0,
            -2147483648});
            this.numericUpDownY1.ValueChanged += new System.EventHandler(this.numericUpDownY1_ValueChanged);
            // 
            // numericUpDownX2
            // 
            this.numericUpDownX2.DecimalPlaces = 2;
            this.numericUpDownX2.Location = new System.Drawing.Point(60, 105);
            this.numericUpDownX2.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownX2.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.numericUpDownX2.Name = "numericUpDownX2";
            this.numericUpDownX2.Size = new System.Drawing.Size(61, 26);
            this.numericUpDownX2.TabIndex = 7;
            this.numericUpDownX2.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDownX2.ValueChanged += new System.EventHandler(this.numericUpDownX2_ValueChanged);
            // 
            // numericUpDownY2
            // 
            this.numericUpDownY2.DecimalPlaces = 2;
            this.numericUpDownY2.Location = new System.Drawing.Point(60, 137);
            this.numericUpDownY2.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownY2.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.numericUpDownY2.Name = "numericUpDownY2";
            this.numericUpDownY2.Size = new System.Drawing.Size(61, 26);
            this.numericUpDownY2.TabIndex = 8;
            this.numericUpDownY2.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownY2.ValueChanged += new System.EventHandler(this.numericUpDownY2_ValueChanged);
            // 
            // labelPoint
            // 
            this.labelPoint.AutoSize = true;
            this.labelPoint.Location = new System.Drawing.Point(12, 166);
            this.labelPoint.Name = "labelPoint";
            this.labelPoint.Size = new System.Drawing.Size(49, 20);
            this.labelPoint.TabIndex = 9;
            this.labelPoint.Text = "Point:";
            // 
            // numericUpDownX
            // 
            this.numericUpDownX.DecimalPlaces = 2;
            this.numericUpDownX.Location = new System.Drawing.Point(60, 189);
            this.numericUpDownX.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownX.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.numericUpDownX.Name = "numericUpDownX";
            this.numericUpDownX.Size = new System.Drawing.Size(61, 26);
            this.numericUpDownX.TabIndex = 10;
            this.numericUpDownX.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDownX.ValueChanged += new System.EventHandler(this.numericUpDownX_ValueChanged);
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(29, 191);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(33, 20);
            this.labelX.TabIndex = 11;
            this.labelX.Text = "x = ";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(29, 223);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(33, 20);
            this.labelY.TabIndex = 12;
            this.labelY.Text = "y = ";
            // 
            // numericUpDownY
            // 
            this.numericUpDownY.DecimalPlaces = 2;
            this.numericUpDownY.Location = new System.Drawing.Point(60, 221);
            this.numericUpDownY.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownY.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.numericUpDownY.Name = "numericUpDownY";
            this.numericUpDownY.Size = new System.Drawing.Size(61, 26);
            this.numericUpDownY.TabIndex = 13;
            this.numericUpDownY.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numericUpDownY.ValueChanged += new System.EventHandler(this.numericUpDownY_ValueChanged);
            // 
            // buttonDraw
            // 
            this.buttonDraw.Location = new System.Drawing.Point(12, 264);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(109, 36);
            this.buttonDraw.TabIndex = 14;
            this.buttonDraw.Text = "Draw";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
            // 
            // labelLocation
            // 
            this.labelLocation.BackColor = System.Drawing.Color.PaleGreen;
            this.labelLocation.Location = new System.Drawing.Point(12, 303);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(109, 36);
            this.labelLocation.TabIndex = 15;
            this.labelLocation.Text = "Result";
            this.labelLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.Location = new System.Drawing.Point(127, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(545, 347);
            this.pictureBox.TabIndex = 16;
            this.pictureBox.TabStop = false;
            // 
            // FormPointAndRectangle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 371);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.labelLocation);
            this.Controls.Add(this.buttonDraw);
            this.Controls.Add(this.numericUpDownY);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.numericUpDownX);
            this.Controls.Add(this.labelPoint);
            this.Controls.Add(this.numericUpDownY2);
            this.Controls.Add(this.numericUpDownX2);
            this.Controls.Add(this.numericUpDownY1);
            this.Controls.Add(this.numericUpDownX1);
            this.Controls.Add(this.labelY2);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelY1);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.labelRectangle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "FormPointAndRectangle";
            this.Text = "Point and Rectangle";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.FormPointAndRectangle_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRectangle;
        private System.Windows.Forms.Label labelX1;
        private System.Windows.Forms.Label labelY1;
        private System.Windows.Forms.Label labelX2;
        private System.Windows.Forms.Label labelY2;
        private System.Windows.Forms.NumericUpDown numericUpDownX1;
        private System.Windows.Forms.NumericUpDown numericUpDownY1;
        private System.Windows.Forms.NumericUpDown numericUpDownX2;
        private System.Windows.Forms.NumericUpDown numericUpDownY2;
        private System.Windows.Forms.Label labelPoint;
        private System.Windows.Forms.NumericUpDown numericUpDownX;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.NumericUpDown numericUpDownY;
        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}

