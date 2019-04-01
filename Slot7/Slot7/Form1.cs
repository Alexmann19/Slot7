using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slot7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random zufall = new Random();

        public static int punkte = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            int zufallzahl = Convert.ToInt32(zufall.Next(1, 11));

            if (zufallzahl == 1)
            {
                tbslot1.Text = "7";
            }
            else
            if (zufallzahl > 1 & zufallzahl <= 3)
            {
                tbslot1.Text = "S";
            }
            else
            if (zufallzahl > 3 & zufallzahl <= 5)
            {
                tbslot1.Text = "+";
            }
            else
            if (zufallzahl > 5 & zufallzahl <= 7)
            {
                tbslot1.Text = "!";
            }
            else
            if (zufallzahl > 7 & zufallzahl <= 10)
            {
                tbslot1.Text = "#";
            }

            zufallzahl = Convert.ToInt32(zufall.Next(1, 11));

            if (zufallzahl == 1)
            {
                tbslot2.Text = "7";
            }
            else
            if (zufallzahl > 1 & zufallzahl <= 3)
            {
                tbslot2.Text = "S";
            }
            else
            if (zufallzahl > 3 & zufallzahl <= 5)
            {
                tbslot2.Text = "+";
            }
            else
            if (zufallzahl > 5 & zufallzahl <= 7)
            {
                tbslot2.Text = "!";
            }
            else
            if (zufallzahl > 7 & zufallzahl <= 10)
            {
                tbslot2.Text = "#";
            }

            zufallzahl = Convert.ToInt32(zufall.Next(1, 11));

            if (zufallzahl == 1)
            {
                tbslot3.Text = "7";
            }
            else
            if (zufallzahl > 1 & zufallzahl <= 3)
            {
                tbslot3.Text = "S";
            }
            else
            if (zufallzahl > 3 & zufallzahl <= 5)
            {
                tbslot3.Text = "+";
            }
            else
            if (zufallzahl > 5 & zufallzahl <= 7)
            {
                tbslot3.Text = "!";
            }
            else
            if (zufallzahl > 7 & zufallzahl <= 10)
            {
                tbslot3.Text = "#";
            }

            if (tbslot1.Text == "7" & tbslot2.Text == "7" & tbslot3.Text == "7")
            {
                punkte = punkte + 60;
                tbpunkte.Text = Convert.ToString(punkte);
                MessageBox.Show("7 7 7", "7 7 7", MessageBoxButtons.OK);
            }

            if (tbslot1.Text == "S" & tbslot2.Text == "S" & tbslot3.Text == "S")
            {
                punkte = punkte + 30;
                tbpunkte.Text = Convert.ToString(punkte);
            }

            if (tbslot1.Text == "+" & tbslot2.Text == "+" & tbslot3.Text == "+")
            {
                punkte = punkte + 20;
                tbpunkte.Text = Convert.ToString(punkte);
            }

            if (tbslot1.Text == "!" & tbslot2.Text == "!" & tbslot3.Text == "!")
            {
                punkte = punkte + 10;
                tbpunkte.Text = Convert.ToString(punkte);
            }

            if (tbslot1.Text == "#" & tbslot2.Text == "#" & tbslot3.Text == "#")
            {
                punkte = punkte + 5;
                tbpunkte.Text = Convert.ToString(punkte);
            }
        }
    }
}
