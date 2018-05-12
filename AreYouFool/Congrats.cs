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
    public partial class Congrats : Form
    {
        public Congrats()
        {
            InitializeComponent();
        }

        private void Congrats_Load(object sender, EventArgs e)
        {

        }

        private void next_Click(object sender, EventArgs e)
        {
            Again a = new Again();
            a.Show();
            this.Hide();
        }

        private void displayBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
