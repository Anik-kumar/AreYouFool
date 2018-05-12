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
    public partial class Fool : Form
    {
        public Fool()
        {
            InitializeComponent();
        }

        private void fool_Load(object sender, EventArgs e)
        {
                                    
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Again a = new Again();
            this.Hide();
            a.Show();
        }
    }
}
