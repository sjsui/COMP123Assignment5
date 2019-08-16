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
/// Description: Product Info Form of the Dollar Computers windows form app
/// </summary>

namespace COMP123Assignment5.Views
{
    public partial class ProductInfoForm : Form
    {
        public ProductInfoForm()
        {
            InitializeComponent();
        }


        /// <summary>
        /// This is the event handler for the open toolstrip menu item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog productInfoOpenFileDialog = new OpenFileDialog();
            productInfoOpenFileDialog.Filter = "TXT File|*.txt";
            productInfoOpenFileDialog.ShowDialog();
        }

        /// <summary>
        /// This is the event handler for the save toolstrip menu item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog productInfoSaveFileDialog = new SaveFileDialog();
            productInfoSaveFileDialog.Filter = "TXT File|*.txt";
            productInfoSaveFileDialog.FileName = "Product.txt";
            productInfoSaveFileDialog.ShowDialog();
           
        }

        /// <summary>
        /// This is the event handler for the exit toolstrip menu item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        /// <summary>
        /// this is the event handler for the ProductInfo Form close event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductInfoForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// This is the event handler for the ProductInfoForm load event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductInfoForm_Load(object sender, EventArgs e)
        {
            if(Program.product.productID == 0)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.ShowDialog();
                this.Show();

                       }
            else
            {
                ProductInfoProductIDTextbox.Text = Convert.ToString(Program.product.productID);
                ProductInfoConditionTextbox.Text = Program.product.condition;
                ProductInfoCostTextbox.Text = Convert.ToString(Program.product.cost);
                ProductInfoPlatformTextbox.Text = Program.product.platform;
                ProductInfoOSTextbox.Text = Program.product.OS;
                ProductInfoManufacturerTextbox.Text = Program.product.manufacturer;
                ProductInfoModelTextbox.Text = Program.product.model;
                ProductInfoMemoryTextbox.Text = Program.product.RAM_size;
                ProductInfoLCDSizeTextbox.Text = Program.product.screensize;
                ProductInfoHDDTextbox.Text = Program.product.HDD_size;
                ProductInfoCPUBrandTextbox.Text = Program.product.CPU_brand;
                ProductInfoCPUNumberTextbox.Text = Program.product.CPU_number;
                ProductInfoGPUTypeTextbox.Text = Program.product.GPU_Type;
                ProductInfoCPUTypeTextbox.Text = Program.product.CPU_type;
                ProductInfoCPUSpeedTextbox.Text = Program.product.CPU_speed;
                ProductInfoWebCamTextbox.Text = Program.product.webcam;

                ProductInfoNextButton.Enabled = true;
            }
            

            
        }

        /// <summary>
        /// this is the event handler for the SelectAnotherProductButton click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectAnotherProduct(object sender, EventArgs e)
        {
            this.Hide();
            SelectForm selectForm = new SelectForm();
            selectForm.Show();
        }

        /// <summary>
        /// this is the shared event handler for the exit menu option and cancel button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitProductInfo(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// this is the event handler for the ProductInfoNextButton click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductInfoNextButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderForm orderForm = new OrderForm();
            orderForm.Show();
        }
    }
}
