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
/// Description: Start Form of the Dollar Computers windows form app
/// </summary>

namespace COMP123Assignment5.Views

{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        
        private void StartForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

       
        /// <summary>
        /// This is the event handler for the StartForm StartNewOrderButton click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartNewOrderButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SelectForm selectForm = new SelectForm();
            selectForm.Show();
        }

        /// <summary>
        /// This is the event handler for the StartForm LoadSavedOrderButton click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadSavedOrderButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProductInfoForm productInfoForm = new ProductInfoForm();
            productInfoForm.Show();
        }

        
        

        /// <summary>
        /// This is the shared event handler for all exit/cancel button clicks. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
