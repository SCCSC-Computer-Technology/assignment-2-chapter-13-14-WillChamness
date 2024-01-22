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
    public partial class UnitsOnHandForm : Form
    {
        private ProductDBDataContext db = new ProductDBDataContext();
        public UnitsOnHandForm()
        {
            InitializeComponent();
        }

        private void UnitsOnHandForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'productDBDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.productDBDataSet.Product);

            productDBDataGrid.DataSource = db.Products.OrderBy((product) => product.Units_On_Hand);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            // get the min and max units from the user
            int minVal = -1;
            int maxVal = -1;

            try
            {
                minVal = minimumUnitsTextbox.Text != ""
                    ? int.Parse(minimumUnitsTextbox.Text)
                    : 0;
                maxVal = maximumUnitsTextbox.Text != ""
                    ? int.Parse(maximumUnitsTextbox.Text)
                    : int.MaxValue;
            }
            catch(FormatException ex)
            {
                MessageBox.Show("Bad input");
                return;
            }

            // guard clause for negative values
            if(minVal < 0 || maxVal < 0)
            {
                MessageBox.Show("Cannot have negative units");
                return;
            }

            // get the product table
            var products = db.Products;

            // search each row for units in between minVal and maxVal and sort by units
            var result = products.Where((product) => minVal <= product.Units_On_Hand && product.Units_On_Hand <= maxVal);
            result = result.OrderBy((product) => product.Units_On_Hand);

            // display the result
            productDBDataGrid.DataSource = result;
        }
    }
}
