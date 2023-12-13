namespace DevinPerdueFinal
{
    partial class Main_Menu
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
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addPart = new System.Windows.Forms.Button();
            this.modifyPart = new System.Windows.Forms.Button();
            this.deletePart = new System.Windows.Forms.Button();
            this.addProduct = new System.Windows.Forms.Button();
            this.modifyProduct = new System.Windows.Forms.Button();
            this.deleteProduct = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.searchPart = new System.Windows.Forms.Button();
            this.searchProduct = new System.Windows.Forms.Button();
            this.partSearch = new System.Windows.Forms.TextBox();
            this.productSearch = new System.Windows.Forms.TextBox();
            this.exitProgram = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPart
            // 
            this.dgvPart.AllowUserToResizeRows = false;
            this.dgvPart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvPart.Location = new System.Drawing.Point(17, 147);
            this.dgvPart.Name = "dgvPart";
            this.dgvPart.Size = new System.Drawing.Size(545, 355);
            this.dgvPart.TabIndex = 0;
            this.dgvPart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPart_CellClick);
            this.dgvPart.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.myBindingComplete);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "pID";
            this.Column1.HeaderText = "Part ID";
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Name";
            this.Column2.HeaderText = "Part Name";
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Stock";
            this.Column3.HeaderText = "Inventory";
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Price";
            this.Column4.HeaderText = "Price";
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Min";
            this.Column5.HeaderText = "Min";
            this.Column5.Name = "Column5";
            this.Column5.Visible = false;
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Max";
            this.Column6.HeaderText = "Max";
            this.Column6.Name = "Column6";
            this.Column6.Visible = false;
            this.Column6.Width = 125;
            // 
            // dgvProduct
            // 
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dgvProduct.Location = new System.Drawing.Point(709, 147);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.Size = new System.Drawing.Size(544, 355);
            this.dgvProduct.TabIndex = 1;
            this.dgvProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellContentClick);
            this.dgvProduct.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.myBindingComplete1);
            this.dgvProduct.Click += new System.EventHandler(this.dgvProduct_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ProductID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Product ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Product Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Inventory";
            this.dataGridViewTextBoxColumn3.HeaderText = "Inventory";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn4.HeaderText = "Price";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Min";
            this.dataGridViewTextBoxColumn5.HeaderText = "Min";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Visible = false;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Max";
            this.dataGridViewTextBoxColumn6.HeaderText = "Max";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Visible = false;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // addPart
            // 
            this.addPart.Location = new System.Drawing.Point(305, 533);
            this.addPart.Name = "addPart";
            this.addPart.Size = new System.Drawing.Size(75, 23);
            this.addPart.TabIndex = 2;
            this.addPart.Text = "Add";
            this.addPart.UseVisualStyleBackColor = true;
            this.addPart.Click += new System.EventHandler(this.addPart_Click);
            // 
            // modifyPart
            // 
            this.modifyPart.Location = new System.Drawing.Point(401, 533);
            this.modifyPart.Name = "modifyPart";
            this.modifyPart.Size = new System.Drawing.Size(75, 23);
            this.modifyPart.TabIndex = 3;
            this.modifyPart.Text = "Modify";
            this.modifyPart.UseVisualStyleBackColor = true;
            this.modifyPart.Click += new System.EventHandler(this.modifyPart_Click);
            // 
            // deletePart
            // 
            this.deletePart.Location = new System.Drawing.Point(487, 533);
            this.deletePart.Name = "deletePart";
            this.deletePart.Size = new System.Drawing.Size(75, 23);
            this.deletePart.TabIndex = 4;
            this.deletePart.Text = "Delete";
            this.deletePart.UseVisualStyleBackColor = true;
            this.deletePart.Click += new System.EventHandler(this.deletePart_Click);
            // 
            // addProduct
            // 
            this.addProduct.Location = new System.Drawing.Point(994, 533);
            this.addProduct.Name = "addProduct";
            this.addProduct.Size = new System.Drawing.Size(75, 23);
            this.addProduct.TabIndex = 5;
            this.addProduct.Text = "Add";
            this.addProduct.UseVisualStyleBackColor = true;
            this.addProduct.Click += new System.EventHandler(this.addProduct_Click);
            // 
            // modifyProduct
            // 
            this.modifyProduct.Location = new System.Drawing.Point(1086, 533);
            this.modifyProduct.Name = "modifyProduct";
            this.modifyProduct.Size = new System.Drawing.Size(75, 23);
            this.modifyProduct.TabIndex = 6;
            this.modifyProduct.Text = "Modify";
            this.modifyProduct.UseVisualStyleBackColor = true;
            this.modifyProduct.Click += new System.EventHandler(this.modifyProduct_Click);
            // 
            // deleteProduct
            // 
            this.deleteProduct.Location = new System.Drawing.Point(1178, 533);
            this.deleteProduct.Name = "deleteProduct";
            this.deleteProduct.Size = new System.Drawing.Size(75, 23);
            this.deleteProduct.TabIndex = 7;
            this.deleteProduct.Text = "Delete";
            this.deleteProduct.UseVisualStyleBackColor = true;
            this.deleteProduct.Click += new System.EventHandler(this.deleteProduct_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Inventory Management System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(13, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Parts";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(705, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Products";
            // 
            // searchPart
            // 
            this.searchPart.Location = new System.Drawing.Point(374, 110);
            this.searchPart.Name = "searchPart";
            this.searchPart.Size = new System.Drawing.Size(75, 23);
            this.searchPart.TabIndex = 11;
            this.searchPart.Text = "Search";
            this.searchPart.UseVisualStyleBackColor = true;
            this.searchPart.Click += new System.EventHandler(this.searchPart_Click);
            // 
            // searchProduct
            // 
            this.searchProduct.Location = new System.Drawing.Point(1063, 111);
            this.searchProduct.Name = "searchProduct";
            this.searchProduct.Size = new System.Drawing.Size(75, 23);
            this.searchProduct.TabIndex = 12;
            this.searchProduct.Text = "Search";
            this.searchProduct.UseVisualStyleBackColor = true;
            this.searchProduct.Click += new System.EventHandler(this.searchProduct_Click);
            // 
            // partSearch
            // 
            this.partSearch.Location = new System.Drawing.Point(462, 110);
            this.partSearch.Name = "partSearch";
            this.partSearch.Size = new System.Drawing.Size(100, 20);
            this.partSearch.TabIndex = 13;
            // 
            // productSearch
            // 
            this.productSearch.Location = new System.Drawing.Point(1153, 113);
            this.productSearch.Name = "productSearch";
            this.productSearch.Size = new System.Drawing.Size(100, 20);
            this.productSearch.TabIndex = 14;
            this.productSearch.TextChanged += new System.EventHandler(this.productSearch_TextChanged);
            // 
            // exitProgram
            // 
            this.exitProgram.Location = new System.Drawing.Point(1178, 581);
            this.exitProgram.Name = "exitProgram";
            this.exitProgram.Size = new System.Drawing.Size(75, 23);
            this.exitProgram.TabIndex = 15;
            this.exitProgram.Text = "Exit";
            this.exitProgram.UseVisualStyleBackColor = true;
            this.exitProgram.Click += new System.EventHandler(this.exitProgram_Click);
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 674);
            this.Controls.Add(this.exitProgram);
            this.Controls.Add(this.productSearch);
            this.Controls.Add(this.partSearch);
            this.Controls.Add(this.searchProduct);
            this.Controls.Add(this.searchPart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteProduct);
            this.Controls.Add(this.modifyProduct);
            this.Controls.Add(this.addProduct);
            this.Controls.Add(this.deletePart);
            this.Controls.Add(this.modifyPart);
            this.Controls.Add(this.addPart);
            this.Controls.Add(this.dgvProduct);
            this.Controls.Add(this.dgvPart);
            this.Name = "Main_Menu";
            this.Text = "Main Menu";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addPart;
        private System.Windows.Forms.Button modifyPart;
        private System.Windows.Forms.Button deletePart;
        private System.Windows.Forms.Button addProduct;
        private System.Windows.Forms.Button modifyProduct;
        private System.Windows.Forms.Button deleteProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button searchPart;
        private System.Windows.Forms.Button searchProduct;
        private System.Windows.Forms.TextBox partSearch;
        private System.Windows.Forms.TextBox productSearch;
        private System.Windows.Forms.Button exitProgram;
        public System.Windows.Forms.DataGridView dgvPart;
        public System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}

