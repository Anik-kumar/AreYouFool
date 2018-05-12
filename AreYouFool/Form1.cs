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
    public partial class Game : Form
    {
        Random r = new Random();

        public Game()
        {
            InitializeComponent(); 
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void decline_Click(object sender, EventArgs e)
        {
            Congrats nf = new Congrats();
            nf.Show();            
            this.Hide();
        }

        private void accept_Click(object sender, EventArgs e)
        {
            Fool f = new Fool();
            this.Hide();
            f.Show();
            
        }

        private void declineHover(object sender, EventArgs e)
        {

            int x = r.Next(this.Size.Width - this.decline.Size.Width - 10);
            int y = r.Next(this.Size.Height - this.decline.Size.Height - 39);
            //Console.WriteLine(this.Size.Width + " " + this.decline.Size.Width + " " + x);
            //Console.WriteLine(this.Size.Height + " " + this.decline.Size.Height + " " + y);

            this.decline.Location = new System.Drawing.Point(x, y);
                
            


        }

        
    }
}
