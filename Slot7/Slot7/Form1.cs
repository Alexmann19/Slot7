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

        public void Neu ()
        {
            klicks = 0;
            tbklicks.Text = Convert.ToString(klicks);
            punkte = 50;
            tbpunkte.Text = Convert.ToString(punkte);
            MessageBox.Show("Neues Spiel gestartet!", "Neues Spiel", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        Random zufall = new Random();

        public static int punkte = 50;
        public static int klicks = 0;
        

        private void button1_Click(object sender, EventArgs e)
        {
            
            tbpunkte.Text = Convert.ToString(punkte);

            if (punkte <= 0)
            {
                DialogResult x = MessageBox.Show("Sie haben keine Punkte mehr wollen sie Neustarten, Game Over", "Game Over", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (x == DialogResult.No)
                {
                    this.Close();
                }
                else if (x == DialogResult.Yes)
                {
                    Neu();
                    return;
                }
            }

            klicks = klicks + 1;
            tbklicks.Text = Convert.ToString(klicks);
            punkte = punkte - 5;
            tbpunkte.Text = Convert.ToString(punkte);

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
            else
            if (tbslot1.Text == "S" & tbslot2.Text == "S" & tbslot3.Text == "S")
            {
                punkte = punkte + 30;
                tbpunkte.Text = Convert.ToString(punkte);
            }
            else
            if (tbslot1.Text == "+" & tbslot2.Text == "+" & tbslot3.Text == "+")
            {
                punkte = punkte + 20;
                tbpunkte.Text = Convert.ToString(punkte);
            }
            else
            if (tbslot1.Text == "!" & tbslot2.Text == "!" & tbslot3.Text == "!")
            {
                punkte = punkte + 10;
                tbpunkte.Text = Convert.ToString(punkte);
            }
            else
            if (tbslot1.Text == "#" & tbslot2.Text == "#" & tbslot3.Text == "#")
            {
                punkte = punkte + 5;
                tbpunkte.Text = Convert.ToString(punkte);
            }
        }
    }
}
