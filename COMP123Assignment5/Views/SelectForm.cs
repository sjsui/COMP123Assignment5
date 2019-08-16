using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COMP123Assignment5.Data;

/// <summary>
/// Student Name: Shijun Sui
/// Student ID: 301027587
/// Date Created: Aug. 15, 2019
/// Description: Select Form of the Dollar Computers windows form app
/// </summary>

namespace COMP123Assignment5.Views
{
    public partial class SelectForm : Form
    {
        public SelectForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// this is the event handler for the form close event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {
            using (var db = new ProductModel())
            {
                db.products.Load();
                productBindingSource.DataSource = db.products.Local.ToBindingList();
            }

        }

        /// <summary>
        /// this is the event handler for the cancel button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectFormCancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SelectFormNextButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProductInfoForm productInfoForm = new ProductInfoForm();
            productInfoForm.Show();
        }

        /// <summary>
        /// This is the event handler for the ProductsDataGridView cell click event
        /// the whole row should be highlighted and info should be displayed in the box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void ProductsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            var rowIndex = ProductsDataGridView.CurrentCell.RowIndex;
            var rows = ProductsDataGridView.Rows;
            var columnCount = ProductsDataGridView.ColumnCount;
            var cells = rows[rowIndex].Cells;

            string outputstring = string.Empty;

            for (int index = 0; index < columnCount; index++)
            {


               if (index == 2 || index == 3 || index  == 1)
                {
                    outputstring += cells[index].Value.ToString() + " ";
                }

            }

            SelectionTextBox.Text = outputstring;

            ///assign value to the product object
            Program.product.productID = short.Parse(cells[0].Value.ToString());
            Program.product.condition = (cells[14].Value.ToString());
            Program.product.cost = decimal.Parse(cells[1].Value.ToString());
            Program.product.platform = (cells[16].Value.ToString());
            Program.product.OS = (cells[15].Value.ToString());
            Program.product.manufacturer = (cells[2].Value.ToString());
            Program.product.model = (cells[3].Value.ToString());
            Program.product.RAM_size = (cells[5].Value.ToString());
            Program.product.screensize = (cells[7].Value.ToString());
            Program.product.HDD_size = (cells[17].Value.ToString());
            Program.product.CPU_brand = (cells[10].Value.ToString());
            Program.product.CPU_number = (cells[13].Value.ToString());
            Program.product.GPU_Type = (cells[19].Value.ToString());
            Program.product.CPU_type = (cells[11].Value.ToString());
            Program.product.CPU_speed = (cells[12].Value.ToString());
            Program.product.webcam = (cells[30].Value.ToString());
        }

        /// <summary>
        /// this is the event handler for the DataGridView Cell Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var rowIndex = ProductsDataGridView.CurrentCell.RowIndex;
            var rows = ProductsDataGridView.Rows;
            var columnCount = ProductsDataGridView.ColumnCount;
            var cells = rows[rowIndex].Cells;

            rows[rowIndex].Selected = true;
        }
    }
}
