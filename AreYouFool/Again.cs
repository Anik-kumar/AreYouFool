using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreYouFool
{
    public partial class Again : Form
    {
        public Again()
        {
            InitializeComponent();
        }

        private void yesBtn_Click(object sender, EventArgs e)
        {
            Game g = new Game();
            g.Show();
            this.Hide();
            
        }

        private void noBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void playLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
