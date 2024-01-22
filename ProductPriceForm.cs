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
    public partial class ProductPriceForm : Form
    {
        private ProductDBDataContext db = new ProductDBDataContext();
        public ProductPriceForm()
        {
            InitializeComponent();
        }

        private void ProductPriceForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'productDBDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.productDBDataSet.Product);

            productDBDataGrid.DataSource = db.Products.OrderBy((product) => product.Price);

            this.ActiveControl = minimumPriceTextbox;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            // get the min and max value from the user
            decimal minVal = -1;
            decimal maxVal = -1;

            try
            {
                minVal = minimumPriceTextbox.Text != ""
                    ? decimal.Parse(minimumPriceTextbox.Text)
                    : 0;
                maxVal = maximumPriceTextbox.Text != ""
                    ? decimal.Parse(maximumPriceTextbox.Text)
                    : int.MaxValue; // decimal.MaxValue causes overflow exception when displaying result; int.MaxValue should be good enough
            }
            catch(FormatException ex)
            {
                MessageBox.Show("Bad input");
                return;
            }

            // guard clause for negative values
            if(minVal < 0 || maxVal < 0)
            {
                MessageBox.Show("Cannot have negative price");
                return;
            }

            // get the product table
            var products = db.Products;

            // search for rows with price between minVal and maxVal, ordered by the price
            var result = products.Where((product) => minVal <= product.Price && product.Price <= maxVal)
                .OrderBy((product) => product.Price);

            // display the result
            productDBDataGrid.DataSource = result;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            productDBDataGrid.DataSource = db.Products.OrderBy((product) => product.Price);
            minimumPriceTextbox.Text = "";
            maximumPriceTextbox.Text = "";
            this.ActiveControl = minimumPriceTextbox;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
