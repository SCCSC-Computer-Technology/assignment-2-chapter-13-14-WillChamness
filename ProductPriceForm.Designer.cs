
namespace William_Chamness_206_assignment2
{
    partial class ProductPriceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.productDBDataGrid = new System.Windows.Forms.DataGridView();
            this.productDBDataSet = new William_Chamness_206_assignment2.ProductDBDataSet();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new William_Chamness_206_assignment2.ProductDBDataSetTableAdapters.ProductTableAdapter();
            this.productNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitsOnHandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minimumPriceLabel = new System.Windows.Forms.Label();
            this.maximumPriceLabel = new System.Windows.Forms.Label();
            this.minimumPriceTextbox = new System.Windows.Forms.TextBox();
            this.maximumPriceTextbox = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productDBDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // productDBDataGrid
            // 
            this.productDBDataGrid.AutoGenerateColumns = false;
            this.productDBDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDBDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productNumberDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.unitsOnHandDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.productDBDataGrid.DataSource = this.productBindingSource;
            this.productDBDataGrid.Location = new System.Drawing.Point(37, 33);
            this.productDBDataGrid.Name = "productDBDataGrid";
            this.productDBDataGrid.Size = new System.Drawing.Size(647, 150);
            this.productDBDataGrid.TabIndex = 0;
            // 
            // productDBDataSet
            // 
            this.productDBDataSet.DataSetName = "ProductDBDataSet";
            this.productDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.productDBDataSet;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // productNumberDataGridViewTextBoxColumn
            // 
            this.productNumberDataGridViewTextBoxColumn.DataPropertyName = "Product_Number";
            this.productNumberDataGridViewTextBoxColumn.HeaderText = "Product_Number";
            this.productNumberDataGridViewTextBoxColumn.Name = "productNumberDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // unitsOnHandDataGridViewTextBoxColumn
            // 
            this.unitsOnHandDataGridViewTextBoxColumn.DataPropertyName = "Units_On_Hand";
            this.unitsOnHandDataGridViewTextBoxColumn.HeaderText = "Units_On_Hand";
            this.unitsOnHandDataGridViewTextBoxColumn.Name = "unitsOnHandDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // minimumPriceLabel
            // 
            this.minimumPriceLabel.AutoSize = true;
            this.minimumPriceLabel.Location = new System.Drawing.Point(236, 227);
            this.minimumPriceLabel.Name = "minimumPriceLabel";
            this.minimumPriceLabel.Size = new System.Drawing.Size(78, 13);
            this.minimumPriceLabel.TabIndex = 1;
            this.minimumPriceLabel.Text = "Minimum Price:";
            // 
            // maximumPriceLabel
            // 
            this.maximumPriceLabel.AutoSize = true;
            this.maximumPriceLabel.Location = new System.Drawing.Point(236, 253);
            this.maximumPriceLabel.Name = "maximumPriceLabel";
            this.maximumPriceLabel.Size = new System.Drawing.Size(81, 13);
            this.maximumPriceLabel.TabIndex = 2;
            this.maximumPriceLabel.Text = "Maximum Price:";
            // 
            // minimumPriceTextbox
            // 
            this.minimumPriceTextbox.Location = new System.Drawing.Point(320, 224);
            this.minimumPriceTextbox.Name = "minimumPriceTextbox";
            this.minimumPriceTextbox.Size = new System.Drawing.Size(100, 20);
            this.minimumPriceTextbox.TabIndex = 3;
            // 
            // maximumPriceTextbox
            // 
            this.maximumPriceTextbox.Location = new System.Drawing.Point(320, 250);
            this.maximumPriceTextbox.Name = "maximumPriceTextbox";
            this.maximumPriceTextbox.Size = new System.Drawing.Size(100, 20);
            this.maximumPriceTextbox.TabIndex = 4;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(551, 415);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(632, 415);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "C&lear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(713, 415);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 7;
            this.searchButton.Text = "&Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // ProductPriceForm
            // 
            this.AcceptButton = this.searchButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.maximumPriceTextbox);
            this.Controls.Add(this.minimumPriceTextbox);
            this.Controls.Add(this.maximumPriceLabel);
            this.Controls.Add(this.minimumPriceLabel);
            this.Controls.Add(this.productDBDataGrid);
            this.Name = "ProductPriceForm";
            this.Text = "ProductPriceForm";
            this.Load += new System.EventHandler(this.ProductPriceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productDBDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView productDBDataGrid;
        private ProductDBDataSet productDBDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private ProductDBDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitsOnHandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label minimumPriceLabel;
        private System.Windows.Forms.Label maximumPriceLabel;
        private System.Windows.Forms.TextBox minimumPriceTextbox;
        private System.Windows.Forms.TextBox maximumPriceTextbox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button searchButton;
    }
}