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

    public partial class GameForm : Form
    {
        Random rand = new Random();
        static int timerGlobal = 5;
        static readonly Difficulty Easy = new Difficulty(30, 15, 200, 200, 400, 400, 40, 60);
        static readonly Difficulty Medium = new Difficulty(22, 12, 300, 300, 700, 400, 30, 60);
        static readonly Difficulty Hard = new Difficulty(15, 7, 400, 400, 1400, 861, 20, 60);
        Bitmap bitmapImg = new Bitmap("duck.png");
        static Bitmap[] pics = new Bitmap[3] ;
        
        Difficulty currentDiff;
        public GameForm(string name)
        {
            InitializeComponent();
            easyRadioButton.Checked = true;
            welcomeLabel.Text = "Welcome " + name;
            pics[0] = new Bitmap("duck.png");
            pics[1] = new Bitmap("duck2.png");
            pics[2] = new Bitmap("duck_3.png");
            gameObject.BackColor = Color.Black;


        }
        private void SetTimer()
        {
            //timerGlobal = currentDiff.StartTime;
            Timer aTimer = new Timer();
            aTimer.Interval = 1000;
            aTimer.Tick += new EventHandler(OnTimedEvent);
            aTimer.Enabled = true;
        }
        private void OnTimedEvent(object sender, EventArgs e)
        {
            timerGlobal--;
            timerLabel.Text = timerGlobal.ToString();
            if (timerGlobal == 0)
            {
                diffGroupBox.Enabled = true;
                startButton.Enabled = true;
                ((Timer)sender).Stop();
                ((Timer)sender).Dispose();
                MessageBox.Show("Game over");
            }
        }


        static void EvaluateTimer(int reward)
        {
            timerGlobal += reward;
        }
        private void EasyRadioButtonOnCheck(object sender, EventArgs e)
        {

            if (((RadioButton)sender).Checked) { currentDiff = Easy; }
            SetValues();
        }
        private void MediumRadioButtonOnCheck(object sender, EventArgs e)
        {

            if (((RadioButton)sender).Checked) { currentDiff = Medium; }
            SetValues();

        }

        private void HardRadioButtonOnCheck(object sender, EventArgs e)
        {

            if (((RadioButton)sender).Checked) { currentDiff = Hard; }
            SetValues();

        }


        private void SetValues()
        {
            timerLabel.Text = (timerGlobal = currentDiff.StartTime).ToString();
            gameField.Size = new Size(currentDiff.MinSizeX, currentDiff.MinSizeY);
            gameObject.Size = new Size(currentDiff.MaxPicSize, currentDiff.MaxPicSize);
            gameField.Location = new Point(200, 0);
            bitmapImg = new Bitmap("duck.png");
           



        }

        private void startButton_Click(object sender, EventArgs e)
        {
            SetValues();
            SetTimer();
            diffGroupBox.Enabled = false;
            startButton.Enabled = false;
            // gameField.Size = new Size( gameField.Size.Width+10,gameField.Size.Height+10);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private Point RandPoint()
        {
            return new Point(rand.Next(gameField.Width - gameObject.Width ), rand.Next(gameField.Height - gameObject.Height ));
        }
        private Bitmap Resize(int width, int height) {
            Bitmap result = new Bitmap(width, height);
            Bitmap bmp = pics[rand.Next(3)];
            using (Graphics g = Graphics.FromImage(result))
            {
                g.DrawImage(bmp, 0, 0, width, height);
            }

            return result;

        }

        private void gameObject_Click(object sender, EventArgs e)
        {
            gameObject.BackColor = Color.Transparent;
            gameObject.Image=Resize(currentDiff.MaxPicSize, currentDiff.MaxPicSize);
            gameObject.Location = RandPoint();
        }
    }

}
