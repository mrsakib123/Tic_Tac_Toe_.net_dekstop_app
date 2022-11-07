using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Tic_Tca_Toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int tn = 1;
        int clk1 = 0, clk2 = 0, clk3 = 0, clk4 = 0, clk5 = 0, clk6 = 0, clk7 = 0, clk8 = 0, clk9 = 0;
		int plr1 = 0, plr2 = 0;

		private void button1_Click(object sender, EventArgs e)
		{
			if (clk1 == 0)
			{
				if (tn % 2 != 0)
				{
					button1.Text = "X";
					clk1++;
				}
				else
				{
					button1.Text = "O";
					clk1++;
				}
				tn++;
			}
			else
			{
				button1.Text = button1.Text;
			}
			display();
			check();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (clk2 == 0)
			{
				if (tn % 2 != 0)
				{
					button2.Text = "X";
					clk2++;
				}
				else
				{
					button2.Text = "O";
					clk2++;
				}
				tn++;
			}
			else
			{
				button2.Text = button2.Text;
			}
			display();
			check();
		}

		

		private void button3_Click(object sender, EventArgs e)
        {
			if (clk3 == 0)
			{
				if (tn % 2 != 0)
				{
					button3.Text = "X";
					clk3++;
				}
				else
				{
					button3.Text = "O";
					clk3++;
				}
				tn++;
			}
			else
			{
				button3.Text = button3.Text;
			}
			display();
			check();
		}

        private void button4_Click(object sender, EventArgs e)
        {
			if (clk4 == 0)
			{
				if (tn % 2 != 0)
				{
					button4.Text = "X";
					clk4++;
				}
				else
				{
					button4.Text = "O";
					clk4++;
				}
				tn++;
			}
			else
			{
				button4.Text = button4.Text;
			}
			display();
			check();
		}

        

        private void button5_Click(object sender, EventArgs e)
        {
			if (clk5 == 0)
			{
				if (tn % 2 != 0)
				{
					button5.Text = "X";
					clk5++;
				}
				else
				{
					button5.Text = "O";
					clk5++;
				}
				tn++;
			}
			else
			{
				button5.Text = button5.Text;
			}
			display();
			check();
		}

        private void p2_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
			cleargame();
		}

        private void button11_Click(object sender, EventArgs e)
        {
			player1score.Text = "";
			player2score.Text = "";
			plr1 = 0;
			plr2 = 0;
			cleargame();
		}

        private void button6_Click(object sender, EventArgs e)
        {
			if (clk6 == 0)
			{
				if (tn % 2 != 0)
				{
					button6.Text = "X";
					clk6++;
				}
				else
				{
					button6.Text = "O";
					clk6++;
				}
				tn++;
			}
			else
			{
				button6.Text = button6.Text;
			}
			display();
			check();
		}

        private void button7_Click(object sender, EventArgs e)
        {
			if (clk7 == 0)
			{
				if (tn % 2 != 0)
				{
					button7.Text = "X";
					clk7++;
				}
				else
				{
					button7.Text = "O";
					clk7++;
				}
				tn++;
			}
			else
			{
				button7.Text = button7.Text;
			}
			display();
			check();
		}

        private void button8_Click(object sender, EventArgs e)
        {
			if (clk8 == 0)
			{
				if (tn % 2 != 0)
				{
					button8.Text = "X";
					clk8++;
				}
				else
				{
					button8.Text = "O";
					clk8++;
				}
				tn++;
			}
			else
			{
				button8.Text = button8.Text;
			}
			display();
			check();
		}

		private void button9_Click(object sender, EventArgs e)
		{
			if (clk9 == 0)
			{
				if (tn % 2 != 0)
				{
					button9.Text = "X";
					clk9++;
				}
				else
				{
					button9.Text = "O";
					clk9++;
				}
				tn++;
			}
			else
			{
				button9.Text = button9.Text;
			}
			display();
			check();
		}



		private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
		public void display()
		{
			if (tn % 2 != 0)
			{
				displayturn.Text = "Player 1";
			}
			else
			{
				displayturn.Text = "Player 2";
			}
		}


		public void check()
		{
			if (button1.Text != "" && button2.Text != "" && button3.Text != "")
			{
				if (button1.Text == button2.Text && button1.Text == button3.Text)
				{
					button1.BackColor = Color.Blue;
					button1.ForeColor = Color.White;
					button2.BackColor = Color.Blue;
					button2.ForeColor = Color.White;
					button3.BackColor = Color.Blue;
					button3.ForeColor = Color.White;
					if (button1.Text == "X")
					{
						MessageBox.Show("Player 1 Wins!");
						plr1++;
						player1score.Text = plr1.ToString();
					}
					else
					{
						MessageBox.Show("Player 2 Wins!");
						plr2++;
						player2score.Text = plr2.ToString();
					}
					cleargame();

				}
			}
			if (button4.Text != "" && button5.Text != "" && button6.Text != "")
			{
				if (button4.Text == button5.Text && button4.Text == button6.Text)
				{
					button4.BackColor = Color.Blue;
					button4.ForeColor = Color.White;
					button5.BackColor = Color.Blue;
					button5.ForeColor = Color.White;
					button6.BackColor = Color.Blue;
					button6.ForeColor = Color.White;
					if (button4.Text == "X")
					{
						MessageBox.Show("Player 1 Wins!");
						plr1++;
						player1score.Text = plr1.ToString();

					}
					else
					{
						MessageBox.Show("Player 2 Wins!");
						plr2++;
						player2score.Text = plr2.ToString();

					}
					cleargame();
				}
			}
			if (button7.Text != "" && button8.Text != "" && button9.Text != "")
			{
				if (button7.Text == button8.Text && button7.Text == button9.Text)
				{
					button7.BackColor = Color.Blue;
					button7.ForeColor = Color.White;
					button8.BackColor = Color.Blue;
					button8.ForeColor = Color.White;
					button9.BackColor = Color.Blue;
					button9.ForeColor = Color.White;
					if (button7.Text == "X")
					{
						MessageBox.Show("Player 1 Wins!");
						plr1++;
						player1score.Text = plr1.ToString();

					}
					else
					{
						MessageBox.Show("Player 2 Wins!");
						plr2++;
						player2score.Text = plr2.ToString();

					}
					cleargame();
				}
			}
			if (button1.Text != "" && button4.Text != "" && button7.Text != "")
			{
				if (button1.Text == button4.Text && button1.Text == button7.Text)
				{
					button1.BackColor = Color.Blue;
					button1.ForeColor = Color.White;
					button4.BackColor = Color.Blue;
					button4.ForeColor = Color.White;
					button7.BackColor = Color.Blue;
					button7.ForeColor = Color.White;
					if (button1.Text == "X")
					{
						MessageBox.Show("Player 1 Wins!");
						plr1++;
						player1score.Text = plr1.ToString();

					}
					else
					{
						MessageBox.Show("Player 2 Wins!");
						plr2++;
						player2score.Text = plr2.ToString();

					}
					cleargame();
				}
			}
			if (button2.Text != "" && button5.Text != "" && button8.Text != "")
			{
				if (button2.Text == button5.Text && button2.Text == button8.Text)
				{
					button2.BackColor = Color.Blue;
					button2.ForeColor = Color.White;
					button5.BackColor = Color.Blue;
					button5.ForeColor = Color.White;
					button8.BackColor = Color.Blue;
					button8.ForeColor = Color.White;
					if (button2.Text == "X")
					{
						MessageBox.Show("Player 1 Wins!");
						plr1++;
						player1score.Text = plr1.ToString();

					}
					else
					{
						MessageBox.Show("Player 2 Wins!");
						plr2++;
						player2score.Text = plr2.ToString();

					}
					cleargame();
				}
			}
			if (button3.Text != "" && button6.Text != "" && button9.Text != "")
			{
				if (button3.Text == button6.Text && button3.Text == button9.Text)
				{
					button3.BackColor = Color.Blue;
					button3.ForeColor = Color.White;
					button6.BackColor = Color.Blue;
					button6.ForeColor = Color.White;
					button9.BackColor = Color.Blue;
					button9.ForeColor = Color.White;
					if (button3.Text == "X")
					{
						MessageBox.Show("Player 1 Wins!");
						plr1++;
						player1score.Text = plr1.ToString();

					}
					else
					{
						MessageBox.Show("Player 2 Wins!");
						plr2++;
						player2score.Text = plr2.ToString();

					}
					cleargame();
				}
			}
			if (button1.Text != "" && button5.Text != "" && button9.Text != "")
			{
				if (button1.Text == button5.Text && button1.Text == button9.Text)
				{
					button1.BackColor = Color.Blue;
					button1.ForeColor = Color.White;
					button5.BackColor = Color.Blue;
					button5.ForeColor = Color.White;
					button9.BackColor = Color.Blue;
					button9.ForeColor = Color.White;
					if (button1.Text == "X")
					{
						MessageBox.Show("Player 1 Wins!");
						plr1++;
						player1score.Text = plr1.ToString();

					}
					else
					{
						MessageBox.Show("Player 2 Wins!");
						plr2++;
						player2score.Text = plr2.ToString();

					}
					cleargame();
				}
			}
			if (button3.Text != "" && button5.Text != "" && button7.Text != "")
			{
				if (button3.Text == button5.Text && button3.Text == button7.Text)
				{
					button3.BackColor = Color.Blue;
					button3.ForeColor = Color.White;
					button5.BackColor = Color.Blue;
					button5.ForeColor = Color.White;
					button7.BackColor = Color.Blue;
					button7.ForeColor = Color.White;
					if (button3.Text == "X")
					{
						MessageBox.Show("Player 1 Wins!");
						plr1++;
						player1score.Text = plr1.ToString();

					}
					else
					{
						MessageBox.Show("Player 2 Wins!");
						plr2++;
						player2score.Text = plr2.ToString();

					}
					cleargame();
				}
			}
			if (button1.Text != "" && button2.Text != "" && button3.Text != "" && button4.Text != "" && button5.Text != "" && button6.Text != "" && button7.Text != "" && button8.Text != "" && button9.Text != "")
			{

				MessageBox.Show("Match is Draw!");
				cleargame();
			}
		}
		public void cleargame()
		{
			displayturn.Text = "";
			tn = 1;
			clk1 = 0; clk2 = 0; clk3 = 0; clk4 = 0; clk5 = 0; clk6 = 0; clk7 = 0; clk8 = 0; clk9 = 0;
			button1.Text = "";
			button2.Text = "";
			button3.Text = "";
			button4.Text = "";
			button5.Text = "";
			button6.Text = "";
			button7.Text = "";
			button8.Text = "";
			button9.Text = "";
			button1.BackColor = Color.Empty;
			button1.ForeColor = Color.Black;
			button1.UseVisualStyleBackColor = true;
			button2.BackColor = Color.Empty;
			button2.ForeColor = Color.Black;
			button2.UseVisualStyleBackColor = true;
			button3.BackColor = Color.Empty;
			button3.ForeColor = Color.Black;
			button3.UseVisualStyleBackColor = true;
			button4.BackColor = Color.Empty;
			button4.ForeColor = Color.Black;
			button4.UseVisualStyleBackColor = true;
			button5.BackColor = Color.Empty;
			button5.ForeColor = Color.Black;
			button5.UseVisualStyleBackColor = true;
			button6.BackColor = Color.Empty;
			button6.ForeColor = Color.Black;
			button6.UseVisualStyleBackColor = true;
			button7.BackColor = Color.Empty;
			button7.ForeColor = Color.Black;
			button7.UseVisualStyleBackColor = true;
			button8.BackColor = Color.Empty;
			button8.ForeColor = Color.Black;
			button8.UseVisualStyleBackColor = true;
			button9.BackColor = Color.Empty;
			button9.ForeColor = Color.Black;
			button9.UseVisualStyleBackColor = true;
		}
	}
}
