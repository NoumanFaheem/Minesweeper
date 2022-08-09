using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class Form2 : Form
    {
        private const string Bomb = "*";

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //var random = new Random();
            //var randomBool = random.Next(2);

           /*
            if (randomBool == 0)
            {
                btn11.Text = Bomb;
            }

            if (randomBool == 1)
            {
                btn12.Text = Bomb;
            }*/


             for (int i = 1; i < 4; i++)
            {
                

                for (int j = 1; j < 9; j++)
                {
                    var random = new Random();
                    var randomBool = random.Next(0,2); 
                    
                    if ( randomBool == 0)
                    {

                         Button btnName = Controls.Find($"btn{i}{j}", true).FirstOrDefault() as Button;

                        btnName.Text = Bomb;

                    }
                }
            }
             
            // btn11.Text = AdjacentMineChecker(btn11);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void btn14_Click(object sender, EventArgs e)
        {

        }
    }
}
