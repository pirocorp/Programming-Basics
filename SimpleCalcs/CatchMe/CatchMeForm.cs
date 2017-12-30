using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatchMe
{
    public partial class CatchMeForm : Form
    {
        public CatchMeForm()
        {
            InitializeComponent();
        }

        private void CatchMeButton_MouseEnter(object sender, EventArgs e)
        {
            Random rand = new Random();
            var maxWidth = ClientSize.Width - CatchMeButton.ClientSize.Width;
            var maxHeight = ClientSize.Height - CatchMeButton.ClientSize.Height;
            CatchMeButton.Location = new Point(
                rand.Next(maxWidth), rand.Next(maxHeight));
        }

        private void CatchMeButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You Win", "Congratulations");
        }
    }
}
