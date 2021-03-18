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
        static int timerGlobal = 5;
        Difficulty currentDiff;
        public Form1()
        {
            InitializeComponent();           
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
          //  label2.Text = timerGlobal.ToString();
            if(timerGlobal == 0)
            {               
                ((Timer)sender).Stop();
                ((Timer)sender).Dispose();
                MessageBox.Show("Game over");
            }
        }


        static void EvaluateTimer(int reward)
        {
            timerGlobal += reward;
        }






    }
    
}
