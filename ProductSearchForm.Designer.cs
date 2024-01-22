
namespace William_Chamness_206_assignment2
{
    partial class ProductSearchForm
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
            this.productNumberLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.productNumberTextbox = new System.Windows.Forms.TextBox();
            this.descriptionTextbox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.searchByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unitsOnHandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.priceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.productDBDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDBDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
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
            this.productDBDataGrid.Location = new System.Drawing.Point(76, 72);
            this.productDBDataGrid.Name = "productDBDataGrid";
            this.productDBDataGrid.Size = new System.Drawing.Size(606, 150);
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
            // productNumberLabel
            // 
            this.productNumberLabel.AutoSize = true;
            this.productNumberLabel.Location = new System.Drawing.Point(253, 262);
            this.productNumberLabel.Name = "productNumberLabel";
            this.productNumberLabel.Size = new System.Drawing.Size(87, 13);
            this.productNumberLabel.TabIndex = 1;
            this.productNumberLabel.Text = "Product Number:";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(277, 288);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(63, 13);
            this.descriptionLabel.TabIndex = 2;
            this.descriptionLabel.Text = "Description:";
            // 
            // productNumberTextbox
            // 
            this.productNumberTextbox.Location = new System.Drawing.Point(346, 259);
            this.productNumberTextbox.Name = "productNumberTextbox";
            this.productNumberTextbox.Size = new System.Drawing.Size(100, 20);
            this.productNumberTextbox.TabIndex = 3;
            // 
            // descriptionTextbox
            // 
            this.descriptionTextbox.Location = new System.Drawing.Point(346, 285);
            this.descriptionTextbox.Name = "descriptionTextbox";
            this.descriptionTextbox.Size = new System.Drawing.Size(100, 20);
            this.descriptionTextbox.TabIndex = 4;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(713, 415);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "&Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
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
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(551, 415);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "&Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchByToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // searchByToolStripMenuItem
            // 
            this.searchByToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unitsOnHandToolStripMenuItem,
            this.priceToolStripMenuItem});
            this.searchByToolStripMenuItem.Name = "searchByToolStripMenuItem";
            this.searchByToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.searchByToolStripMenuItem.Text = "Search By";
            // 
            // unitsOnHandToolStripMenuItem
            // 
            this.unitsOnHandToolStripMenuItem.Name = "unitsOnHandToolStripMenuItem";
            this.unitsOnHandToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.unitsOnHandToolStripMenuItem.Text = "Units on hand";
            this.unitsOnHandToolStripMenuItem.Click += new System.EventHandler(this.unitsOnHandToolStripMenuItem_Click);
            // 
            // priceToolStripMenuItem
            // 
            this.priceToolStripMenuItem.Name = "priceToolStripMenuItem";
            this.priceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.priceToolStripMenuItem.Text = "Price";
            // 
            // ProductSearchForm
            // 
            this.AcceptButton = this.searchButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.descriptionTextbox);
            this.Controls.Add(this.productNumberTextbox);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.productNumberLabel);
            this.Controls.Add(this.productDBDataGrid);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ProductSearchForm";
            this.Text = "Product Search Form";
            this.Load += new System.EventHandler(this.ProductSearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productDBDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDBDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.Label productNumberLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox productNumberTextbox;
        private System.Windows.Forms.TextBox descriptionTextbox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem searchByToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unitsOnHandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem priceToolStripMenuItem;
    }
}

