using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramingProject4
{
    public partial class Form1 : Form
    {
        //Creating arry and random generator for vertical and horizontal buttons. 
        Random sim = new Random();
        //Constant ints for values of our array.
        const int vert = 3;
        const int hori = 3;
        //2d Array for simulating each box in each row and column. 
        int[,] simulate = new int[vert, hori];
        //If there is a draw had trouble with the draw..
        bool isDraw = (0 > 0 && 1 > 1);





        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //formula for generating a random value in the vert or hori buttons. 
            for (int verts = 0; verts < vert; verts++)
            {
                for (int horis = 0; horis < hori; horis++)
                {

                    simulate[verts, horis] = sim.Next(2);
                }
            }
            //Randoming a value for each box within the array
            A1.Text = simulate[0, 0].ToString();
            A2.Text = simulate[0, 1].ToString();
            A3.Text = simulate[0, 2].ToString();
            B1.Text = simulate[1, 0].ToString();
            B2.Text = simulate[1, 1].ToString();
            B3.Text = simulate[1, 2].ToString();
            C1.Text = simulate[2, 0].ToString();
            C2.Text = simulate[2, 1].ToString();
            C3.Text = simulate[2, 2].ToString();

            //All possible instance of winners for O or 0 and X or 1. 
            if (simulate[0, 0] == 0 && (simulate[0, 0] == simulate[0, 1]) && (simulate[0, 1] == simulate[0, 2]))
            {
                resultBox.Text = "O wins!";
            }
            if (simulate[0, 0] == 1 && (simulate[0, 0] == simulate[0, 1]) && (simulate[0, 1] == simulate[0, 2]))
            {
                resultBox.Text = "X wins!";
            }
            else if (simulate[1, 0] == 0 && (simulate[1, 0] == simulate[1, 1]) && (simulate[1, 1] == simulate[1, 2]))
            {
                resultBox.Text = "O wins!";
            }
            else if (simulate[2, 0] == 0 && (simulate[2, 0] == simulate[2, 1]) && (simulate[2, 1] == simulate[2, 2]))
            {
                resultBox.Text = "O wins!";
            }
            else if (simulate[0, 0] == 0 && (simulate[0, 0] == simulate[1, 0]) && (simulate[1, 0] == simulate[2, 0]))
            {
                resultBox.Text = "O wins!";
            }
            else if (simulate[0, 1] == 0 && (simulate[0, 1] == simulate[1, 1]) && (simulate[1, 1] == simulate[2, 1]))
            {
                resultBox.Text = "O wins!";
            }
            else if (simulate[0, 2] == 0 && (simulate[0, 2] == simulate[1, 2]) && (simulate[1, 2] == simulate[2, 2]))
            {
                resultBox.Text = "O wins!";
            }
            else if (simulate[0, 0] == 0 && (simulate[0, 0] == simulate[1, 1]) && (simulate[1, 1] == simulate[2, 2]))
            {
                resultBox.Text = "O wins!";
            }
            else if (simulate[0, 2] == 0 && (simulate[0, 2] == simulate[1, 1]) && (simulate[0, 1] == simulate[2, 0]))
            {
                resultBox.Text = "O wins!";
            }
            else if (simulate[0, 2] == 1 && (simulate[0, 2] == simulate[1, 1]) && (simulate[0, 1] == simulate[2, 0]))
            {
                resultBox.Text = "X wins!";
            }
            else if (simulate[1, 0] == 1 && (simulate[1, 0] == simulate[1, 1]) && (simulate[1, 1] == simulate[1, 2]))
            {
                resultBox.Text = "X wins!";
            }
            else if (simulate[2, 0] == 1 && (simulate[2, 0] == simulate[2, 1]) && (simulate[2, 1] == simulate[2, 2]))
            {
                resultBox.Text = "X wins!";
            }
            else if (simulate[0, 0] == 1 && (simulate[0, 0] == simulate[1, 0]) && (simulate[1, 0] == simulate[2, 0]))
            {
                resultBox.Text = "X wins!";
            }
            else if (simulate[0, 1] == 1 && (simulate[0, 1] == simulate[1, 1]) && (simulate[1, 1] == simulate[2, 1]))
            {
                resultBox.Text = "X wins!";
            }
            else if (simulate[0, 2] == 1 && (simulate[0, 2] == simulate[1, 2]) && (simulate[1, 2] == simulate[2, 2]))
            {
                resultBox.Text = "X wins!";
            }
            else if (simulate[0, 0] == 1 && (simulate[0, 0] == simulate[1, 1]) && (simulate[1, 1] == simulate[2, 2]))
            {
                resultBox.Text = "X wins!";
            }
            else if (isDraw)
                resultBox.Text = "Draw";
        }
    }
}