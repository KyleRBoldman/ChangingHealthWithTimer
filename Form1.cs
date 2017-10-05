using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangingHealthWithTimer
{
    public partial class MadDuckFight : Form
    {
        int health = 100;

        public MadDuckFight()
        {
            InitializeComponent();
            do
            {
                healthLabel.Text = "Health = " + health;
                attackTimer.Start();
                if (attackTimer.Equals(0))
                {
                    health -= 5;
                }
            } while (health > 0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
