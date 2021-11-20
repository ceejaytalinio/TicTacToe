using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        bool turn = true;
        int turn_count = 0;
        public Form1()
        {
            InitializeComponent();
        }


        private void tile_click(object sender, EventArgs e)
        {
            Button x = (Button)sender;
            if (turn)
                x.Text = "X";
            else
                x.Text = "O";

            turn = !turn;
            x.Enabled = false;
            winningCombo();
        }
        private void winningCombo()
        {
            bool winner = false;
            turn_count++;

            //WIN CONDITIONS
            if ((R1A.Text == R2A.Text) && (R2A.Text == R3A.Text) && (R1A.Enabled == false))
                winner = true;
            if ((R1B.Text == R2B.Text) && (R2B.Text == R3B.Text) && (R1B.Enabled == false))
                winner = true;
            if ((R1C.Text == R2C.Text) && (R2C.Text == R3C.Text) && (R1C.Enabled == false))
                winner = true;
            if ((R1A.Text == R1B.Text) && (R1B.Text == R1C.Text) && (R1A.Enabled == false))
                winner = true;
            if ((R2A.Text == R2B.Text) && (R2B.Text == R2C.Text) && (R2A.Enabled == false))
                winner = true;
            if ((R3A.Text == R3B.Text) && (R3B.Text == R3C.Text) && (R3A.Enabled == false))
                winner = true;
            if ((R1A.Text == R2B.Text) && (R2B.Text == R3C.Text) && (R1A.Enabled == false))
                winner = true;
            if ((R1C.Text == R2B.Text) && (R2B.Text == R3A.Text) && (R3A.Enabled == false))
                winner = true;

            if (winner)
            {
                String player = "";
                if (!turn)
                    player = "X";
                else
                    player = "O";

                MessageBox.Show(player + " Is The Victor!");
                Application.Exit();
            }
            if (turn_count == 9)
            {
                MessageBox.Show("Sorry! No Winners Today");
                Application.Exit();
            }
        }
    }
}
