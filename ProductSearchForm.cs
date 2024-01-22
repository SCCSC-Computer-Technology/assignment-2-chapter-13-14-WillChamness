using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace William_Chamness_206_assignment2
{
    public partial class ProductSearchForm : Form
    {
        private ProductDBDataContext db = new ProductDBDataContext();
        public ProductSearchForm()
        {
            InitializeComponent();
        }

        private void ProductSearchForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'productDBDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.productDBDataSet.Product);

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            // get the 'product' table
            var products = db.Products;

            // match the product number
            // if the textbox is empty, don't remove anything from the results
            var result = productNumberTextbox.Text != "" ? products.Where((product) => product.Product_Number == productNumberTextbox.Text) : products; 

            // search for substring containing description 
            result = result.Where((product) => product.Description.Contains(descriptionTextbox.Text));

            // display the result
            productDBDataGrid.DataSource = result;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            productDBDataGrid.DataSource = db.Products;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void unitsOnHandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new UnitsOnHandForm();
            form.ShowDialog();
        }

        private void priceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new ProductPriceForm();
            form.ShowDialog();
        }
    }
}
