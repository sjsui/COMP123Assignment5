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
/// Description: Order Form of the Dollar Computers windows form app
/// </summary>

namespace COMP123Assignment5.Views
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// this is the event handler for the about menu click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.dollarComputersAboutBox.ShowDialog();
        }

        /// <summary>
        /// this is the event handler for the OrderForm Load event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrderForm_Load(object sender, EventArgs e)
        {
            
            OrderFormConditionInfoLabel.Text = Program.product.condition;
            OrderFormPlatformInfoLabel.Text = Program.product.platform;
            OrderFormOSInfoLabel.Text = Program.product.OS;
            OrderFormManufacturerInfoLabel.Text = Program.product.manufacturer;
            OrderFormModelInfoLabel.Text = Program.product.model;
            OrderFormMemoryInfoLabel.Text = Program.product.RAM_size;
            OrderFormLCDSizeInfoLabel.Text = Program.product.screensize;


            OrderFormCostInfoLabel.Text = Convert.ToString(Program.product.cost);
            OrderFormTaxInfoLabel.Text = Convert.ToString((decimal)0.13 *(Program.product.cost));
            OrderFormTotalCostInfoLabel.Text = Convert.ToString((decimal)1.13 * (Program.product.cost));


        }

        /// <summary>
        /// this is the event handler for the menu strip print option click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string printMessage = "Your section is printing";
            MessageBox.Show(printMessage);

        }

        /// <summary>
        /// this is the event handler for the exit option and cancel button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitOrderForm(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// this is the event handler for the OrderForm Back Button and back menu option click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrderFormBack(object sender, EventArgs e)
        {
            this.Hide();
            SelectForm selectForm = new SelectForm();
            selectForm.Show();
        }

        /// <summary>
        /// this is the event hander for the OrderForm Finish Button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrderFormFinishButton_Click(object sender, EventArgs e)
        {
            string finishMessage = "Thank you for shopping with us! " +
                "Your order will be processed in 7 to 10 business days. ";
            
            DialogResult result = MessageBox.Show(finishMessage);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
            MessageBox.Show(finishMessage);
            
        }
    }
}
