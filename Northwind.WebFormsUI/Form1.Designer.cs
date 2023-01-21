namespace Northwind.WebFormsUI
{
    partial class Form1
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
            this.dgwProduct = new System.Windows.Forms.DataGridView();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblUnitsInStock = new System.Windows.Forms.Label();
            this.lblQuantityPerUnit = new System.Windows.Forms.Label();
            this.tbxAddProductName = new System.Windows.Forms.TextBox();
            this.tbxAddUnitPrice = new System.Windows.Forms.TextBox();
            this.tbxAddUnitInStock = new System.Windows.Forms.TextBox();
            this.tbxAddQuantityPerUnit = new System.Windows.Forms.TextBox();
            this.gbxProductAdd = new System.Windows.Forms.GroupBox();
            this.cbxAddCategoryId = new System.Windows.Forms.ComboBox();
            this.lblCategoryId = new System.Windows.Forms.Label();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cbxSearchByCategories = new System.Windows.Forms.ComboBox();
            this.lblCategories = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxSearchByProductName = new System.Windows.Forms.TextBox();
            this.gbxSearch = new System.Windows.Forms.GroupBox();
            this.btnResetData = new System.Windows.Forms.Button();
            this.gbxUpdate = new System.Windows.Forms.GroupBox();
            this.cbxUpdateCategoryId = new System.Windows.Forms.ComboBox();
            this.lblUpdataProductCategoryId = new System.Windows.Forms.Label();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.tbxUpdateUnitPrice = new System.Windows.Forms.TextBox();
            this.tbxUpdateQuantityPerUnit = new System.Windows.Forms.TextBox();
            this.lblUpdateProductName = new System.Windows.Forms.Label();
            this.tbxUpdateUnitsInStock = new System.Windows.Forms.TextBox();
            this.lblUpdateUnitPrice = new System.Windows.Forms.Label();
            this.lblUpdateUnitsInStock = new System.Windows.Forms.Label();
            this.tbxUpdateProductName = new System.Windows.Forms.TextBox();
            this.lblUpdateQuantityPerUnit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
            this.gbxProductAdd.SuspendLayout();
            this.gbxSearch.SuspendLayout();
            this.gbxUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwProduct
            // 
            this.dgwProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProduct.Location = new System.Drawing.Point(12, 12);
            this.dgwProduct.Name = "dgwProduct";
            this.dgwProduct.Size = new System.Drawing.Size(1013, 286);
            this.dgwProduct.TabIndex = 0;
            this.dgwProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProduct_CellClick);
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(38, 33);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(81, 13);
            this.lblProductName.TabIndex = 1;
            this.lblProductName.Text = "Product Name :";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(38, 105);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(59, 13);
            this.lblUnitPrice.TabIndex = 2;
            this.lblUnitPrice.Text = "Unit Price :";
            // 
            // lblUnitsInStock
            // 
            this.lblUnitsInStock.AutoSize = true;
            this.lblUnitsInStock.Location = new System.Drawing.Point(38, 143);
            this.lblUnitsInStock.Name = "lblUnitsInStock";
            this.lblUnitsInStock.Size = new System.Drawing.Size(80, 13);
            this.lblUnitsInStock.TabIndex = 3;
            this.lblUnitsInStock.Text = "Units In Stock :";
            // 
            // lblQuantityPerUnit
            // 
            this.lblQuantityPerUnit.AutoSize = true;
            this.lblQuantityPerUnit.Location = new System.Drawing.Point(38, 187);
            this.lblQuantityPerUnit.Name = "lblQuantityPerUnit";
            this.lblQuantityPerUnit.Size = new System.Drawing.Size(93, 13);
            this.lblQuantityPerUnit.TabIndex = 4;
            this.lblQuantityPerUnit.Text = "Quantity Per Unit :";
            // 
            // tbxAddProductName
            // 
            this.tbxAddProductName.Location = new System.Drawing.Point(171, 30);
            this.tbxAddProductName.Name = "tbxAddProductName";
            this.tbxAddProductName.Size = new System.Drawing.Size(121, 20);
            this.tbxAddProductName.TabIndex = 5;
            // 
            // tbxAddUnitPrice
            // 
            this.tbxAddUnitPrice.Location = new System.Drawing.Point(171, 102);
            this.tbxAddUnitPrice.Name = "tbxAddUnitPrice";
            this.tbxAddUnitPrice.Size = new System.Drawing.Size(121, 20);
            this.tbxAddUnitPrice.TabIndex = 6;
            // 
            // tbxAddUnitInStock
            // 
            this.tbxAddUnitInStock.Location = new System.Drawing.Point(171, 140);
            this.tbxAddUnitInStock.Name = "tbxAddUnitInStock";
            this.tbxAddUnitInStock.Size = new System.Drawing.Size(121, 20);
            this.tbxAddUnitInStock.TabIndex = 7;
            // 
            // tbxAddQuantityPerUnit
            // 
            this.tbxAddQuantityPerUnit.Location = new System.Drawing.Point(171, 180);
            this.tbxAddQuantityPerUnit.Name = "tbxAddQuantityPerUnit";
            this.tbxAddQuantityPerUnit.Size = new System.Drawing.Size(121, 20);
            this.tbxAddQuantityPerUnit.TabIndex = 8;
            // 
            // gbxProductAdd
            // 
            this.gbxProductAdd.Controls.Add(this.cbxAddCategoryId);
            this.gbxProductAdd.Controls.Add(this.lblCategoryId);
            this.gbxProductAdd.Controls.Add(this.btnAddProduct);
            this.gbxProductAdd.Controls.Add(this.tbxAddUnitPrice);
            this.gbxProductAdd.Controls.Add(this.tbxAddQuantityPerUnit);
            this.gbxProductAdd.Controls.Add(this.lblProductName);
            this.gbxProductAdd.Controls.Add(this.tbxAddUnitInStock);
            this.gbxProductAdd.Controls.Add(this.lblUnitPrice);
            this.gbxProductAdd.Controls.Add(this.lblUnitsInStock);
            this.gbxProductAdd.Controls.Add(this.tbxAddProductName);
            this.gbxProductAdd.Controls.Add(this.lblQuantityPerUnit);
            this.gbxProductAdd.Location = new System.Drawing.Point(12, 321);
            this.gbxProductAdd.Name = "gbxProductAdd";
            this.gbxProductAdd.Size = new System.Drawing.Size(320, 251);
            this.gbxProductAdd.TabIndex = 9;
            this.gbxProductAdd.TabStop = false;
            this.gbxProductAdd.Text = "Add Product Field";
            // 
            // cbxAddCategoryId
            // 
            this.cbxAddCategoryId.FormattingEnabled = true;
            this.cbxAddCategoryId.Location = new System.Drawing.Point(171, 69);
            this.cbxAddCategoryId.Name = "cbxAddCategoryId";
            this.cbxAddCategoryId.Size = new System.Drawing.Size(121, 21);
            this.cbxAddCategoryId.TabIndex = 12;
            // 
            // lblCategoryId
            // 
            this.lblCategoryId.AutoSize = true;
            this.lblCategoryId.Location = new System.Drawing.Point(38, 72);
            this.lblCategoryId.Name = "lblCategoryId";
            this.lblCategoryId.Size = new System.Drawing.Size(67, 13);
            this.lblCategoryId.TabIndex = 11;
            this.lblCategoryId.Text = "Category Id :";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(35, 222);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(96, 23);
            this.btnAddProduct.TabIndex = 9;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(215, 222);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(96, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete Product";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cbxSearchByCategories
            // 
            this.cbxSearchByCategories.FormattingEnabled = true;
            this.cbxSearchByCategories.Location = new System.Drawing.Point(191, 57);
            this.cbxSearchByCategories.Name = "cbxSearchByCategories";
            this.cbxSearchByCategories.Size = new System.Drawing.Size(120, 21);
            this.cbxSearchByCategories.TabIndex = 12;
            this.cbxSearchByCategories.SelectedIndexChanged += new System.EventHandler(this.cbxSearchByCategories_SelectedIndexChanged);
            // 
            // lblCategories
            // 
            this.lblCategories.AutoSize = true;
            this.lblCategories.Location = new System.Drawing.Point(14, 60);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(115, 13);
            this.lblCategories.TabIndex = 13;
            this.lblCategories.Text = "Search By Categories :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Search By Product Name :";
            // 
            // tbxSearchByProductName
            // 
            this.tbxSearchByProductName.Location = new System.Drawing.Point(191, 114);
            this.tbxSearchByProductName.Name = "tbxSearchByProductName";
            this.tbxSearchByProductName.Size = new System.Drawing.Size(120, 20);
            this.tbxSearchByProductName.TabIndex = 15;
            this.tbxSearchByProductName.TextChanged += new System.EventHandler(this.tbxSearchByProductName_TextChanged);
            // 
            // gbxSearch
            // 
            this.gbxSearch.Controls.Add(this.btnResetData);
            this.gbxSearch.Controls.Add(this.tbxSearchByProductName);
            this.gbxSearch.Controls.Add(this.btnDelete);
            this.gbxSearch.Controls.Add(this.cbxSearchByCategories);
            this.gbxSearch.Controls.Add(this.lblCategories);
            this.gbxSearch.Controls.Add(this.label1);
            this.gbxSearch.Location = new System.Drawing.Point(697, 321);
            this.gbxSearch.Name = "gbxSearch";
            this.gbxSearch.Size = new System.Drawing.Size(328, 251);
            this.gbxSearch.TabIndex = 16;
            this.gbxSearch.TabStop = false;
            this.gbxSearch.Text = "Search Field";
            // 
            // btnResetData
            // 
            this.btnResetData.Location = new System.Drawing.Point(17, 221);
            this.btnResetData.Name = "btnResetData";
            this.btnResetData.Size = new System.Drawing.Size(101, 23);
            this.btnResetData.TabIndex = 16;
            this.btnResetData.Text = "Reset Data";
            this.btnResetData.UseVisualStyleBackColor = true;
            this.btnResetData.Click += new System.EventHandler(this.btnResetData_Click);
            // 
            // gbxUpdate
            // 
            this.gbxUpdate.Controls.Add(this.cbxUpdateCategoryId);
            this.gbxUpdate.Controls.Add(this.lblUpdataProductCategoryId);
            this.gbxUpdate.Controls.Add(this.btnUpdateProduct);
            this.gbxUpdate.Controls.Add(this.tbxUpdateUnitPrice);
            this.gbxUpdate.Controls.Add(this.tbxUpdateQuantityPerUnit);
            this.gbxUpdate.Controls.Add(this.lblUpdateProductName);
            this.gbxUpdate.Controls.Add(this.tbxUpdateUnitsInStock);
            this.gbxUpdate.Controls.Add(this.lblUpdateUnitPrice);
            this.gbxUpdate.Controls.Add(this.lblUpdateUnitsInStock);
            this.gbxUpdate.Controls.Add(this.tbxUpdateProductName);
            this.gbxUpdate.Controls.Add(this.lblUpdateQuantityPerUnit);
            this.gbxUpdate.Location = new System.Drawing.Point(353, 321);
            this.gbxUpdate.Name = "gbxUpdate";
            this.gbxUpdate.Size = new System.Drawing.Size(320, 251);
            this.gbxUpdate.TabIndex = 13;
            this.gbxUpdate.TabStop = false;
            this.gbxUpdate.Text = "Update Product Field";
            // 
            // cbxUpdateCategoryId
            // 
            this.cbxUpdateCategoryId.FormattingEnabled = true;
            this.cbxUpdateCategoryId.Location = new System.Drawing.Point(171, 69);
            this.cbxUpdateCategoryId.Name = "cbxUpdateCategoryId";
            this.cbxUpdateCategoryId.Size = new System.Drawing.Size(121, 21);
            this.cbxUpdateCategoryId.TabIndex = 12;
            // 
            // lblUpdataProductCategoryId
            // 
            this.lblUpdataProductCategoryId.AutoSize = true;
            this.lblUpdataProductCategoryId.Location = new System.Drawing.Point(38, 72);
            this.lblUpdataProductCategoryId.Name = "lblUpdataProductCategoryId";
            this.lblUpdataProductCategoryId.Size = new System.Drawing.Size(67, 13);
            this.lblUpdataProductCategoryId.TabIndex = 11;
            this.lblUpdataProductCategoryId.Text = "Category Id :";
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.Location = new System.Drawing.Point(196, 222);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(96, 23);
            this.btnUpdateProduct.TabIndex = 10;
            this.btnUpdateProduct.Text = "Update Product";
            this.btnUpdateProduct.UseVisualStyleBackColor = true;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // tbxUpdateUnitPrice
            // 
            this.tbxUpdateUnitPrice.Location = new System.Drawing.Point(171, 102);
            this.tbxUpdateUnitPrice.Name = "tbxUpdateUnitPrice";
            this.tbxUpdateUnitPrice.Size = new System.Drawing.Size(121, 20);
            this.tbxUpdateUnitPrice.TabIndex = 6;
            // 
            // tbxUpdateQuantityPerUnit
            // 
            this.tbxUpdateQuantityPerUnit.Location = new System.Drawing.Point(171, 180);
            this.tbxUpdateQuantityPerUnit.Name = "tbxUpdateQuantityPerUnit";
            this.tbxUpdateQuantityPerUnit.Size = new System.Drawing.Size(121, 20);
            this.tbxUpdateQuantityPerUnit.TabIndex = 8;
            // 
            // lblUpdateProductName
            // 
            this.lblUpdateProductName.AutoSize = true;
            this.lblUpdateProductName.Location = new System.Drawing.Point(38, 33);
            this.lblUpdateProductName.Name = "lblUpdateProductName";
            this.lblUpdateProductName.Size = new System.Drawing.Size(81, 13);
            this.lblUpdateProductName.TabIndex = 1;
            this.lblUpdateProductName.Text = "Product Name :";
            // 
            // tbxUpdateUnitsInStock
            // 
            this.tbxUpdateUnitsInStock.Location = new System.Drawing.Point(171, 140);
            this.tbxUpdateUnitsInStock.Name = "tbxUpdateUnitsInStock";
            this.tbxUpdateUnitsInStock.Size = new System.Drawing.Size(121, 20);
            this.tbxUpdateUnitsInStock.TabIndex = 7;
            // 
            // lblUpdateUnitPrice
            // 
            this.lblUpdateUnitPrice.AutoSize = true;
            this.lblUpdateUnitPrice.Location = new System.Drawing.Point(38, 105);
            this.lblUpdateUnitPrice.Name = "lblUpdateUnitPrice";
            this.lblUpdateUnitPrice.Size = new System.Drawing.Size(59, 13);
            this.lblUpdateUnitPrice.TabIndex = 2;
            this.lblUpdateUnitPrice.Text = "Unit Price :";
            // 
            // lblUpdateUnitsInStock
            // 
            this.lblUpdateUnitsInStock.AutoSize = true;
            this.lblUpdateUnitsInStock.Location = new System.Drawing.Point(38, 143);
            this.lblUpdateUnitsInStock.Name = "lblUpdateUnitsInStock";
            this.lblUpdateUnitsInStock.Size = new System.Drawing.Size(80, 13);
            this.lblUpdateUnitsInStock.TabIndex = 3;
            this.lblUpdateUnitsInStock.Text = "Units In Stock :";
            // 
            // tbxUpdateProductName
            // 
            this.tbxUpdateProductName.Location = new System.Drawing.Point(171, 30);
            this.tbxUpdateProductName.Name = "tbxUpdateProductName";
            this.tbxUpdateProductName.Size = new System.Drawing.Size(121, 20);
            this.tbxUpdateProductName.TabIndex = 5;
            // 
            // lblUpdateQuantityPerUnit
            // 
            this.lblUpdateQuantityPerUnit.AutoSize = true;
            this.lblUpdateQuantityPerUnit.Location = new System.Drawing.Point(38, 187);
            this.lblUpdateQuantityPerUnit.Name = "lblUpdateQuantityPerUnit";
            this.lblUpdateQuantityPerUnit.Size = new System.Drawing.Size(93, 13);
            this.lblUpdateQuantityPerUnit.TabIndex = 4;
            this.lblUpdateQuantityPerUnit.Text = "Quantity Per Unit :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 604);
            this.Controls.Add(this.gbxUpdate);
            this.Controls.Add(this.gbxSearch);
            this.Controls.Add(this.gbxProductAdd);
            this.Controls.Add(this.dgwProduct);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).EndInit();
            this.gbxProductAdd.ResumeLayout(false);
            this.gbxProductAdd.PerformLayout();
            this.gbxSearch.ResumeLayout(false);
            this.gbxSearch.PerformLayout();
            this.gbxUpdate.ResumeLayout(false);
            this.gbxUpdate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwProduct;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label lblUnitsInStock;
        private System.Windows.Forms.Label lblQuantityPerUnit;
        private System.Windows.Forms.TextBox tbxAddProductName;
        private System.Windows.Forms.TextBox tbxAddUnitPrice;
        private System.Windows.Forms.TextBox tbxAddUnitInStock;
        private System.Windows.Forms.TextBox tbxAddQuantityPerUnit;
        private System.Windows.Forms.GroupBox gbxProductAdd;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cbxSearchByCategories;
        private System.Windows.Forms.Label lblCategories;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxSearchByProductName;
        private System.Windows.Forms.GroupBox gbxSearch;
        private System.Windows.Forms.ComboBox cbxAddCategoryId;
        private System.Windows.Forms.Label lblCategoryId;
        private System.Windows.Forms.GroupBox gbxUpdate;
        private System.Windows.Forms.ComboBox cbxUpdateCategoryId;
        private System.Windows.Forms.Label lblUpdataProductCategoryId;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.TextBox tbxUpdateUnitPrice;
        private System.Windows.Forms.TextBox tbxUpdateQuantityPerUnit;
        private System.Windows.Forms.Label lblUpdateProductName;
        private System.Windows.Forms.TextBox tbxUpdateUnitsInStock;
        private System.Windows.Forms.Label lblUpdateUnitPrice;
        private System.Windows.Forms.Label lblUpdateUnitsInStock;
        private System.Windows.Forms.TextBox tbxUpdateProductName;
        private System.Windows.Forms.Label lblUpdateQuantityPerUnit;
        private System.Windows.Forms.Button btnResetData;
    }
}

