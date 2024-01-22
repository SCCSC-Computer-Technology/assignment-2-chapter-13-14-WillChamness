
namespace William_Chamness_206_assignment2
{
    partial class UnitsOnHandForm
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
            this.productNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitsOnHandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productDBDataSet = new William_Chamness_206_assignment2.ProductDBDataSet();
            this.productTableAdapter = new William_Chamness_206_assignment2.ProductDBDataSetTableAdapters.ProductTableAdapter();
            this.minimumUnitsLabel = new System.Windows.Forms.Label();
            this.maximumUnitsLabel = new System.Windows.Forms.Label();
            this.minimumUnitsTextbox = new System.Windows.Forms.TextBox();
            this.maximumUnitsTextbox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productDBDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDBDataSet)).BeginInit();
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
            this.productDBDataGrid.Location = new System.Drawing.Point(95, 25);
            this.productDBDataGrid.Name = "productDBDataGrid";
            this.productDBDataGrid.Size = new System.Drawing.Size(543, 150);
            this.productDBDataGrid.TabIndex = 0;
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
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.productDBDataSet;
            // 
            // productDBDataSet
            // 
            this.productDBDataSet.DataSetName = "ProductDBDataSet";
            this.productDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // minimumUnitsLabel
            // 
            this.minimumUnitsLabel.AutoSize = true;
            this.minimumUnitsLabel.Location = new System.Drawing.Point(276, 257);
            this.minimumUnitsLabel.Name = "minimumUnitsLabel";
            this.minimumUnitsLabel.Size = new System.Drawing.Size(78, 13);
            this.minimumUnitsLabel.TabIndex = 1;
            this.minimumUnitsLabel.Text = "Minimum Units:";
            // 
            // maximumUnitsLabel
            // 
            this.maximumUnitsLabel.AutoSize = true;
            this.maximumUnitsLabel.Location = new System.Drawing.Point(273, 283);
            this.maximumUnitsLabel.Name = "maximumUnitsLabel";
            this.maximumUnitsLabel.Size = new System.Drawing.Size(81, 13);
            this.maximumUnitsLabel.TabIndex = 2;
            this.maximumUnitsLabel.Text = "Maximum Units:";
            // 
            // minimumUnitsTextbox
            // 
            this.minimumUnitsTextbox.Location = new System.Drawing.Point(360, 254);
            this.minimumUnitsTextbox.Name = "minimumUnitsTextbox";
            this.minimumUnitsTextbox.Size = new System.Drawing.Size(100, 20);
            this.minimumUnitsTextbox.TabIndex = 3;
            // 
            // maximumUnitsTextbox
            // 
            this.maximumUnitsTextbox.Location = new System.Drawing.Point(360, 280);
            this.maximumUnitsTextbox.Name = "maximumUnitsTextbox";
            this.maximumUnitsTextbox.Size = new System.Drawing.Size(100, 20);
            this.maximumUnitsTextbox.TabIndex = 4;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(632, 415);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "C&lear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(551, 415);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
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
            // UnitsOnHandForm
            // 
            this.AcceptButton = this.searchButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.maximumUnitsTextbox);
            this.Controls.Add(this.minimumUnitsTextbox);
            this.Controls.Add(this.maximumUnitsLabel);
            this.Controls.Add(this.minimumUnitsLabel);
            this.Controls.Add(this.productDBDataGrid);
            this.Name = "UnitsOnHandForm";
            this.Text = "UnitsOnHandForm";
            this.Load += new System.EventHandler(this.UnitsOnHandForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productDBDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDBDataSet)).EndInit();
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
        private System.Windows.Forms.Label minimumUnitsLabel;
        private System.Windows.Forms.Label maximumUnitsLabel;
        private System.Windows.Forms.TextBox minimumUnitsTextbox;
        private System.Windows.Forms.TextBox maximumUnitsTextbox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button searchButton;
    }
}