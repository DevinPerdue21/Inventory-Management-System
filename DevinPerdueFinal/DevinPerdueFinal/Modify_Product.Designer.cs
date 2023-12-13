namespace DevinPerdueFinal
{
    partial class Modify_Product
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
            this.dgvPart = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAssociatedParts = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addPart = new System.Windows.Forms.Button();
            this.deletePart = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.saveProduct = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.productID = new System.Windows.Forms.Label();
            this.productName = new System.Windows.Forms.Label();
            this.productInventory = new System.Windows.Forms.Label();
            this.productPrice = new System.Windows.Forms.Label();
            this.productMin = new System.Windows.Forms.Label();
            this.productMax = new System.Windows.Forms.Label();
            this.prodID = new System.Windows.Forms.TextBox();
            this.prodName = new System.Windows.Forms.TextBox();
            this.prodInventory = new System.Windows.Forms.TextBox();
            this.prodPrice = new System.Windows.Forms.TextBox();
            this.prodMin = new System.Windows.Forms.TextBox();
            this.prodMax = new System.Windows.Forms.TextBox();
            this.searchPartsAssociated = new System.Windows.Forms.Button();
            this.partsAssociated = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssociatedParts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPart
            // 
            this.dgvPart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvPart.Location = new System.Drawing.Point(585, 97);
            this.dgvPart.Name = "dgvPart";
            this.dgvPart.Size = new System.Drawing.Size(444, 158);
            this.dgvPart.TabIndex = 0;
            this.dgvPart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPart_CellClick);
            this.dgvPart.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPart_CellContentClick);
            this.dgvPart.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvPart_DataBindingComplete);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "pID";
            this.Column1.HeaderText = "Part ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Name";
            this.Column2.HeaderText = "Part Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Stock";
            this.Column3.HeaderText = "Inventory";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Price";
            this.Column4.HeaderText = "Price";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Min";
            this.Column5.HeaderText = "Min";
            this.Column5.Name = "Column5";
            this.Column5.Visible = false;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Max";
            this.Column6.HeaderText = "Max";
            this.Column6.Name = "Column6";
            this.Column6.Visible = false;
            // 
            // dgvAssociatedParts
            // 
            this.dgvAssociatedParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssociatedParts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12});
            this.dgvAssociatedParts.Location = new System.Drawing.Point(582, 347);
            this.dgvAssociatedParts.Name = "dgvAssociatedParts";
            this.dgvAssociatedParts.Size = new System.Drawing.Size(447, 155);
            this.dgvAssociatedParts.TabIndex = 1;
            this.dgvAssociatedParts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAssociatedParts_CellClick);
            this.dgvAssociatedParts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAssociatedParts_CellContentClick);
            this.dgvAssociatedParts.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvAssociatedParts_DataBindingComplete);
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "pID";
            this.Column7.HeaderText = "Part ID";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Name";
            this.Column8.HeaderText = "Part Name";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "Stock";
            this.Column9.HeaderText = "Inventory";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "Price";
            this.Column10.HeaderText = "Price";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "Min";
            this.Column11.HeaderText = "Min";
            this.Column11.Name = "Column11";
            this.Column11.Visible = false;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "Max";
            this.Column12.HeaderText = "Max";
            this.Column12.Name = "Column12";
            this.Column12.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(582, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "All Parts";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(582, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Parts Associated with this Product";
            // 
            // addPart
            // 
            this.addPart.Location = new System.Drawing.Point(925, 281);
            this.addPart.Name = "addPart";
            this.addPart.Size = new System.Drawing.Size(75, 23);
            this.addPart.TabIndex = 4;
            this.addPart.Text = "Add";
            this.addPart.UseVisualStyleBackColor = true;
            this.addPart.Click += new System.EventHandler(this.addPart_Click);
            // 
            // deletePart
            // 
            this.deletePart.Location = new System.Drawing.Point(924, 528);
            this.deletePart.Name = "deletePart";
            this.deletePart.Size = new System.Drawing.Size(75, 23);
            this.deletePart.TabIndex = 5;
            this.deletePart.Text = "Delete";
            this.deletePart.UseVisualStyleBackColor = true;
            this.deletePart.Click += new System.EventHandler(this.deletePart_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(925, 578);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 6;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // saveProduct
            // 
            this.saveProduct.Location = new System.Drawing.Point(825, 578);
            this.saveProduct.Name = "saveProduct";
            this.saveProduct.Size = new System.Drawing.Size(75, 23);
            this.saveProduct.TabIndex = 7;
            this.saveProduct.Text = "Save";
            this.saveProduct.UseVisualStyleBackColor = true;
            this.saveProduct.Click += new System.EventHandler(this.saveProduct_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Modify Product";
            // 
            // productID
            // 
            this.productID.AutoSize = true;
            this.productID.Location = new System.Drawing.Point(18, 203);
            this.productID.Name = "productID";
            this.productID.Size = new System.Drawing.Size(58, 13);
            this.productID.TabIndex = 9;
            this.productID.Text = "Product ID";
            // 
            // productName
            // 
            this.productName.AutoSize = true;
            this.productName.Location = new System.Drawing.Point(18, 242);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(75, 13);
            this.productName.TabIndex = 10;
            this.productName.Text = "Product Name";
            // 
            // productInventory
            // 
            this.productInventory.AutoSize = true;
            this.productInventory.Location = new System.Drawing.Point(18, 287);
            this.productInventory.Name = "productInventory";
            this.productInventory.Size = new System.Drawing.Size(51, 13);
            this.productInventory.TabIndex = 11;
            this.productInventory.Text = "Inventory";
            // 
            // productPrice
            // 
            this.productPrice.AutoSize = true;
            this.productPrice.Location = new System.Drawing.Point(18, 324);
            this.productPrice.Name = "productPrice";
            this.productPrice.Size = new System.Drawing.Size(31, 13);
            this.productPrice.TabIndex = 12;
            this.productPrice.Text = "Price";
            // 
            // productMin
            // 
            this.productMin.AutoSize = true;
            this.productMin.Location = new System.Drawing.Point(18, 378);
            this.productMin.Name = "productMin";
            this.productMin.Size = new System.Drawing.Size(24, 13);
            this.productMin.TabIndex = 13;
            this.productMin.Text = "Min";
            // 
            // productMax
            // 
            this.productMax.AutoSize = true;
            this.productMax.Location = new System.Drawing.Point(200, 378);
            this.productMax.Name = "productMax";
            this.productMax.Size = new System.Drawing.Size(27, 13);
            this.productMax.TabIndex = 14;
            this.productMax.Text = "Max";
            // 
            // prodID
            // 
            this.prodID.Enabled = false;
            this.prodID.Location = new System.Drawing.Point(136, 200);
            this.prodID.Name = "prodID";
            this.prodID.Size = new System.Drawing.Size(100, 20);
            this.prodID.TabIndex = 15;
            this.prodID.TextChanged += new System.EventHandler(this.prodID_TextChanged);
            // 
            // prodName
            // 
            this.prodName.Location = new System.Drawing.Point(136, 239);
            this.prodName.Name = "prodName";
            this.prodName.Size = new System.Drawing.Size(100, 20);
            this.prodName.TabIndex = 16;
            this.prodName.TextChanged += new System.EventHandler(this.prodName_TextChanged);
            // 
            // prodInventory
            // 
            this.prodInventory.Location = new System.Drawing.Point(136, 279);
            this.prodInventory.Name = "prodInventory";
            this.prodInventory.Size = new System.Drawing.Size(100, 20);
            this.prodInventory.TabIndex = 17;
            this.prodInventory.TextChanged += new System.EventHandler(this.prodInventory_TextChanged);
            // 
            // prodPrice
            // 
            this.prodPrice.Location = new System.Drawing.Point(136, 324);
            this.prodPrice.Name = "prodPrice";
            this.prodPrice.Size = new System.Drawing.Size(100, 20);
            this.prodPrice.TabIndex = 18;
            this.prodPrice.TextChanged += new System.EventHandler(this.prodPrice_TextChanged);
            // 
            // prodMin
            // 
            this.prodMin.Location = new System.Drawing.Point(48, 378);
            this.prodMin.Name = "prodMin";
            this.prodMin.Size = new System.Drawing.Size(100, 20);
            this.prodMin.TabIndex = 19;
            this.prodMin.TextChanged += new System.EventHandler(this.prodMin_TextChanged);
            // 
            // prodMax
            // 
            this.prodMax.Location = new System.Drawing.Point(234, 378);
            this.prodMax.Name = "prodMax";
            this.prodMax.Size = new System.Drawing.Size(100, 20);
            this.prodMax.TabIndex = 20;
            this.prodMax.TextChanged += new System.EventHandler(this.prodMax_TextChanged);
            // 
            // searchPartsAssociated
            // 
            this.searchPartsAssociated.Location = new System.Drawing.Point(835, 40);
            this.searchPartsAssociated.Name = "searchPartsAssociated";
            this.searchPartsAssociated.Size = new System.Drawing.Size(75, 23);
            this.searchPartsAssociated.TabIndex = 21;
            this.searchPartsAssociated.Text = "Search";
            this.searchPartsAssociated.UseVisualStyleBackColor = true;
            this.searchPartsAssociated.Click += new System.EventHandler(this.searchPartsAssociated_Click);
            // 
            // partsAssociated
            // 
            this.partsAssociated.Location = new System.Drawing.Point(929, 42);
            this.partsAssociated.Name = "partsAssociated";
            this.partsAssociated.Size = new System.Drawing.Size(100, 20);
            this.partsAssociated.TabIndex = 22;
            // 
            // Modify_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 677);
            this.Controls.Add(this.partsAssociated);
            this.Controls.Add(this.searchPartsAssociated);
            this.Controls.Add(this.prodMax);
            this.Controls.Add(this.prodMin);
            this.Controls.Add(this.prodPrice);
            this.Controls.Add(this.prodInventory);
            this.Controls.Add(this.prodName);
            this.Controls.Add(this.prodID);
            this.Controls.Add(this.productMax);
            this.Controls.Add(this.productMin);
            this.Controls.Add(this.productPrice);
            this.Controls.Add(this.productInventory);
            this.Controls.Add(this.productName);
            this.Controls.Add(this.productID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.saveProduct);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.deletePart);
            this.Controls.Add(this.addPart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvAssociatedParts);
            this.Controls.Add(this.dgvPart);
            this.Name = "Modify_Product";
            this.Text = "Modify Product";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssociatedParts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPart;
        private System.Windows.Forms.DataGridView dgvAssociatedParts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addPart;
        private System.Windows.Forms.Button deletePart;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button saveProduct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label productID;
        private System.Windows.Forms.Label productName;
        private System.Windows.Forms.Label productInventory;
        private System.Windows.Forms.Label productPrice;
        private System.Windows.Forms.Label productMin;
        private System.Windows.Forms.Label productMax;
        private System.Windows.Forms.TextBox prodID;
        private System.Windows.Forms.TextBox prodName;
        private System.Windows.Forms.TextBox prodInventory;
        private System.Windows.Forms.TextBox prodPrice;
        private System.Windows.Forms.TextBox prodMin;
        private System.Windows.Forms.TextBox prodMax;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.Button searchPartsAssociated;
        private System.Windows.Forms.TextBox partsAssociated;
    }
}