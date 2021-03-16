using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeleteWin32___Project_2
{
    public partial class Form1 : Form
    {
        int x, y, score=0, timer = 10, count = 0;
        public Form1()
        {
            InitializeComponent();
            label6.Text = "Game Over"+ Environment.NewLine+"Your score:";
            label1.Text = "Score: " + score;
        }

        private void button2_Click(object sender, EventArgs e) //stop button
        {
            Game_over();
        }

        private void pictureBox1_Click(object sender, EventArgs e) //picture button
        {
            RandomLocation(); //moves randomly with each click
            score++;
            count++;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e) //start(restart) button - starts a timer, duck becomes visible
        {
            timer1.Tick += new EventHandler(timer1_Tick_1);
            pictureBox1.Visible = true;
            pictureBox1.Enabled = true;
            label6.Visible = false;
            timer1.Start();
            label5.Text = "Time remaining: " + timer.ToString();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            timer-=1;
            if(timer==0)
            {
                Game_over();
            }
            label5.Text = "Time remaining: " + timer.ToString();
        }
        private void Game_over()
        {
            label5.Text = "Time remaining: 0";
            button1.Text = "restart";
            timer1.Stop();
            label6.Visible = true;
            pictureBox1.Visible = false;
            pictureBox1.Enabled = false;
        }

        private void RandomLocation()
        {
            Random random = new Random();
            x = random.Next(60, 690);
            y = random.Next(60, 440);
            pictureBox1.Location = new Point(x, y);
        }
        private void level()
        {
            if(count == 10)
            {

            }
        }
    }
}
