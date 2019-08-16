using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using COMP123Assignment5.Data;
using COMP123Assignment5.Views;


/// <summary>
/// Application Name: Dollar Computers Form
/// Student Name: Shijun Sui
/// Student ID: 301027587
/// Date Created: Aug. 15, 2019
/// Description: Assignment 5 windows form application for order items for company Dollar Computers
/// </summary>


namespace COMP123Assignment5
{
    public static class Program
    {
        public static Product product;

        public static SplashScreenForm splashScreenForm;
        public static StartForm startForm;
        public static SelectForm selectForm;
        public static OrderForm orderForm;
        public static ProductInfoForm productInfoForm;
        public static DollarComputersAboutBox dollarComputersAboutBox;
        
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            splashScreenForm = new SplashScreenForm();
            startForm = new StartForm();
            selectForm = new SelectForm();
            productInfoForm = new ProductInfoForm();
            orderForm = new OrderForm();
            dollarComputersAboutBox = new DollarComputersAboutBox();

            product = new Product();

            Application.Run(new SplashScreenForm());
        }
    }
}
