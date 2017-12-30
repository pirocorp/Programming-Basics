using System;
using System.Drawing;
using System.Windows.Forms;

namespace PointFigureForm
{
    public partial class FormPointAndRectangle : Form
    {
             
        public FormPointAndRectangle()
        {
        InitializeComponent();
        }

        private void FormPointAndRectangle_Load(object sender, EventArgs e)
        {
            Draw();
        }

        private void numericUpDownH_ValueChanged(object sender, EventArgs e)
        {
            Draw();
        }

        private void numericUpDownX_ValueChanged(object sender, EventArgs e)
        {
            Draw();
        }

        private void numericUpDownY_ValueChanged(object sender, EventArgs e)
        {
            Draw();
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            Draw();
        }

        private void Draw()
        {
            int h = (int)this.numericUpDownH.Value;
            int x = (int)this.numericUpDownX.Value;
            int y = (int)this.numericUpDownY.Value;

            int z = DisplayPointLocation(h, x, y);

            // Calculate the scale factor (ratio) for the diagram holding the
            // rectangle and point in order to fit them well in the picture box

            //double ratio;
            //int offset = 0;
            //ratio = pictureBox.Width / 4 * h;
            //ratio = Math.Floor(ratio);

            //int r = 1; //(int)ratio;

            int x1 = 0;
            int y1 = 0;
            int w1 = 3 * h *10;
            int h1 = h * 10;
            var rect = new Rectangle(x1, y1, w1, h1);
            int x2 = h * 10;
            int y2 = 4 * h * 10;
            int w2 = h * 10;
            int h2 = 3* h * 10;
            var rect2 = new Rectangle(x2, x2, w2, h2);

            // Calculate the scalled point coordinates
            var pointX = x;
            var pointY = y;
            var pointRect = new Rectangle(pointX * 10 - 1, pointY * 10 - 1, 2, 2);

            // Draw the rectangle and point
            if(pictureBox.Width > 0 && pictureBox.Height > 0)
            pictureBox.Image = new Bitmap(pictureBox.Width, pictureBox.Height);
            using (var g = Graphics.FromImage(pictureBox.Image))
            {
                // Draw diagram background (white area)
                g.Clear(Color.White);

                // Draw the rectangle (scalled to the picture box size)
                var pen = new Pen(Color.Blue, 3);
                if (z == 4 || z == 3) { pen = new Pen(Color.Orange, 3);}
                SolidBrush Brush = new SolidBrush(Color.PaleGreen);
                if (z == 1) g.FillRectangle(Brush, rect);
                g.DrawRectangle(pen, rect);

                pen = new Pen(Color.Red, 3);
                if (z == 4 || z == 3) { pen = new Pen(Color.Orange, 3);}
                if (z == 2) g.FillRectangle(Brush, rect2);
                g.DrawRectangle(pen, rect2);

                // Draw the point (scalled to the picture box size)
                pen = new Pen(Color.DarkBlue, 5);
                g.DrawEllipse(pen, pointRect);
            }



        }

        private decimal Min(decimal val1, decimal val2, decimal val3)
        {
            return Math.Min(val1, Math.Min(val2, val3));
        }

        private decimal Max(decimal val1, decimal val2, decimal val3)
        {
            return Math.Max(val1, Math.Max(val2, val3));
        }

        private int DisplayPointLocation(int h, int x, int y)
        {
            bool inRectangle1 = ((x > 0 && x < 3 * h) && (y > 0 && y < h)); // <=> ((x > 0 && y > 0) && (x < 3h && y < h))
            bool inRectangle2 = ((x > h && x < 2 * h) && (y > h && y < 4 * h)); // <=> ((x > h && y > h) && (x < 2h && y < 4h))
            bool outRectangle1 = ((x < 0 || x > 3 * h) || (y < 0 || y > h));
            bool outRectangle2 = ((x < h || x > 2 * h) || (y < h || y > 4 * h));

            bool commonBorder = ((x >= h && x <= 2 * h) && y == h);

            if (outRectangle1 && outRectangle2)
            {
                this.labelResult.Text = "Outside";
                this.labelResult.BackColor = Color.LightSalmon;
                return 0;
            }
            else if (inRectangle1 || inRectangle2)
            {
                this.labelResult.Text = "Inside";
                this.labelResult.BackColor = Color.LightGreen;
                if(inRectangle1)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
            else if (commonBorder)
            {
                this.labelResult.Text = "Common";
                this.labelResult.BackColor = Color.LightPink;
                return 3;
            }
            else
            {
                this.labelResult.Text = "Border";
                this.labelResult.BackColor = Color.Gold;
                return 4;
            }
        }

        private void FormPointAndRectangle_Resize(object sender, EventArgs e)
        {
            Draw();
        }

        private void numericUpDownY_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void numericUpDownX_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                if (this.numericUpDownX.Value < this.pictureBox.Width / 10) this.numericUpDownX.Value++;
                else this.numericUpDownX.Value = 0;
            }
            else if (e.KeyCode == Keys.Left)
            {
                if (this.numericUpDownX.Value > 0) this.numericUpDownX.Value--;
                else
                {
                    this.numericUpDownX.Value = this.pictureBox.Width / 10;
                }
            }
            else if (e.KeyCode == Keys.Up)
            {
                if (this.numericUpDownY.Value > 0) this.numericUpDownY.Value--;
                else
                {
                    this.numericUpDownY.Value = this.pictureBox.Height / 10;
                }
            }
            else if (e.KeyCode == Keys.Down)
            {
                if (this.numericUpDownY.Value < this.pictureBox.Height / 10) this.numericUpDownY.Value++;
                else this.numericUpDownY.Value = 0;
            }

            Draw();
        }

        private void numericUpDownY_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                if (this.numericUpDownX.Value < this.pictureBox.Width / 10) this.numericUpDownX.Value++;
                else this.numericUpDownX.Value = 0;
            }
            else if (e.KeyCode == Keys.Left)
            {
                if (this.numericUpDownX.Value > 0) this.numericUpDownX.Value--;
                else
                {
                    this.numericUpDownX.Value = this.pictureBox.Width / 10;
                }
            }
            else if (e.KeyCode == Keys.Up)
            {
                if (this.numericUpDownY.Value > 0) this.numericUpDownY.Value--;
                else
                {
                    this.numericUpDownY.Value = this.pictureBox.Height / 10;
                }
            }
            else if (e.KeyCode == Keys.Down)
            {
                if (this.numericUpDownY.Value < this.pictureBox.Height / 10) this.numericUpDownY.Value++;
                else this.numericUpDownY.Value = 0;
            }

            Draw();
        }

    }
}
