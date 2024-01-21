using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WilliamChamness_CPT_206_assignment2
{
    public partial class Form1 : Form
    {
        private ProductDataContext db = new ProductDataContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'productDBDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.productDBDataSet.Product);

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            // get the 'product' table
            var products = db.Products;


            // match the product number
            var result = productNumberTextbox.Text != "" ? products.Where((product) => product.Product_Number == productNumberTextbox.Text) : products; // Product_Number is string; no need to convert to int

            // search for substring containing description 
            result = result.Where((product) => product.Description.Contains(descriptionTextbox.Text));



            // display the result
            productDataGrid.DataSource = result;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            productDataGrid.DataSource = productBindingSource;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
