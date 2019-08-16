using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/// <summary>
/// Student Name: Shijun Sui
/// Student ID: 301027587
/// Date Created: Aug. 15, 2019
/// Description: Splash Screen for the Dollar Computers windows form app
/// </summary>

namespace COMP123Assignment5.Views

{
    public partial class SplashScreenForm : Form
    {
        public SplashScreenForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// define timer for the Splash Screen
        /// </summary>
        Timer SplashTimer;

        private void SplashScreenForm_Shown(object sender, EventArgs e)
        {
            

                SplashTimer = new Timer();

                SplashTimer.Interval = 3000; //3 seconds splash screen

                //starts the timer

                SplashTimer.Start();

                SplashTimer.Tick += SplashTimer_Tick;

        }

        void SplashTimer_Tick(object sender, EventArgs e)

        {

            //after 3 sec stop the timer

            SplashTimer.Stop();

            //display mainform

            StartForm mf = new StartForm();

            mf.Show();

            //hide this form

            this.Hide();

        }

    }
}

