using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


/// <summary>
/// Application Name: Dollar Computers Form
/// Student Name: Shijun Sui
/// Student ID: 301027587
/// Date Created: Aug. 15, 2019
/// Description: Assignment 5 windows form application for order items for company Dollar Computers
/// </summary>


namespace COMP123Assignment5
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SplashScreenForm());
        }
    }
}
