namespace DevinPerdueFinal
{
    partial class Add_Part
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
            this.label1 = new System.Windows.Forms.Label();
            this.inhouse = new System.Windows.Forms.RadioButton();
            this.outsourced = new System.Windows.Forms.RadioButton();
            this.partID = new System.Windows.Forms.Label();
            this.partName = new System.Windows.Forms.Label();
            this.inventory = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.min = new System.Windows.Forms.Label();
            this.max = new System.Windows.Forms.Label();
            this.source = new System.Windows.Forms.Label();
            this.partIDTxt = new System.Windows.Forms.TextBox();
            this.partNameTxt = new System.Windows.Forms.TextBox();
            this.inventoryTxt = new System.Windows.Forms.TextBox();
            this.priceTxt = new System.Windows.Forms.TextBox();
            this.minTxt = new System.Windows.Forms.TextBox();
            this.maxTxt = new System.Windows.Forms.TextBox();
            this.sourceTxt = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Part";
            // 
            // inhouse
            // 
            this.inhouse.AutoSize = true;
            this.inhouse.Location = new System.Drawing.Point(223, 38);
            this.inhouse.Name = "inhouse";
            this.inhouse.Size = new System.Drawing.Size(63, 17);
            this.inhouse.TabIndex = 1;
            this.inhouse.TabStop = true;
            this.inhouse.Text = "Inhouse";
            this.inhouse.UseVisualStyleBackColor = true;
            this.inhouse.CheckedChanged += new System.EventHandler(this.inhouse_CheckedChanged);
            // 
            // outsourced
            // 
            this.outsourced.AutoSize = true;
            this.outsourced.Location = new System.Drawing.Point(351, 38);
            this.outsourced.Name = "outsourced";
            this.outsourced.Size = new System.Drawing.Size(80, 17);
            this.outsourced.TabIndex = 2;
            this.outsourced.TabStop = true;
            this.outsourced.Text = "Outsourced";
            this.outsourced.UseVisualStyleBackColor = true;
            this.outsourced.CheckedChanged += new System.EventHandler(this.outsourced_CheckedChanged);
            // 
            // partID
            // 
            this.partID.AutoSize = true;
            this.partID.Location = new System.Drawing.Point(91, 89);
            this.partID.Name = "partID";
            this.partID.Size = new System.Drawing.Size(40, 13);
            this.partID.TabIndex = 3;
            this.partID.Text = "Part ID";
            // 
            // partName
            // 
            this.partName.AutoSize = true;
            this.partName.Location = new System.Drawing.Point(94, 143);
            this.partName.Name = "partName";
            this.partName.Size = new System.Drawing.Size(57, 13);
            this.partName.TabIndex = 4;
            this.partName.Text = "Part Name";
            // 
            // inventory
            // 
            this.inventory.AutoSize = true;
            this.inventory.Location = new System.Drawing.Point(94, 197);
            this.inventory.Name = "inventory";
            this.inventory.Size = new System.Drawing.Size(51, 13);
            this.inventory.TabIndex = 5;
            this.inventory.Text = "Inventory";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Location = new System.Drawing.Point(94, 254);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(31, 13);
            this.price.TabIndex = 6;
            this.price.Text = "Price";
            // 
            // min
            // 
            this.min.AutoSize = true;
            this.min.Location = new System.Drawing.Point(97, 299);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(24, 13);
            this.min.TabIndex = 7;
            this.min.Text = "Min";
            // 
            // max
            // 
            this.max.AutoSize = true;
            this.max.Location = new System.Drawing.Point(264, 299);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(27, 13);
            this.max.TabIndex = 8;
            this.max.Text = "Max";
            this.max.Click += new System.EventHandler(this.max_Click);
            // 
            // source
            // 
            this.source.AutoSize = true;
            this.source.Location = new System.Drawing.Point(100, 358);
            this.source.Name = "source";
            this.source.Size = new System.Drawing.Size(62, 13);
            this.source.TabIndex = 9;
            this.source.Text = "Machine ID";
            // 
            // partIDTxt
            // 
            this.partIDTxt.Enabled = false;
            this.partIDTxt.Location = new System.Drawing.Point(169, 89);
            this.partIDTxt.Name = "partIDTxt";
            this.partIDTxt.Size = new System.Drawing.Size(100, 20);
            this.partIDTxt.TabIndex = 10;
            // 
            // partNameTxt
            // 
            this.partNameTxt.Location = new System.Drawing.Point(169, 136);
            this.partNameTxt.Name = "partNameTxt";
            this.partNameTxt.Size = new System.Drawing.Size(100, 20);
            this.partNameTxt.TabIndex = 11;
            this.partNameTxt.TextChanged += new System.EventHandler(this.partNameTxt_TextChanged);
            // 
            // inventoryTxt
            // 
            this.inventoryTxt.Location = new System.Drawing.Point(169, 197);
            this.inventoryTxt.Name = "inventoryTxt";
            this.inventoryTxt.Size = new System.Drawing.Size(100, 20);
            this.inventoryTxt.TabIndex = 12;
            this.inventoryTxt.TextChanged += new System.EventHandler(this.inventoryTxt_TextChanged);
            // 
            // priceTxt
            // 
            this.priceTxt.Location = new System.Drawing.Point(169, 254);
            this.priceTxt.Name = "priceTxt";
            this.priceTxt.Size = new System.Drawing.Size(100, 20);
            this.priceTxt.TabIndex = 13;
            this.priceTxt.TextChanged += new System.EventHandler(this.priceTxt_TextChanged);
            // 
            // minTxt
            // 
            this.minTxt.Location = new System.Drawing.Point(127, 296);
            this.minTxt.Name = "minTxt";
            this.minTxt.Size = new System.Drawing.Size(100, 20);
            this.minTxt.TabIndex = 14;
            this.minTxt.TextChanged += new System.EventHandler(this.minTxt_TextChanged);
            // 
            // maxTxt
            // 
            this.maxTxt.Location = new System.Drawing.Point(308, 299);
            this.maxTxt.Name = "maxTxt";
            this.maxTxt.Size = new System.Drawing.Size(100, 20);
            this.maxTxt.TabIndex = 15;
            this.maxTxt.TextChanged += new System.EventHandler(this.maxTxt_TextChanged);
            // 
            // sourceTxt
            // 
            this.sourceTxt.Location = new System.Drawing.Point(201, 355);
            this.sourceTxt.Name = "sourceTxt";
            this.sourceTxt.Size = new System.Drawing.Size(100, 20);
            this.sourceTxt.TabIndex = 16;
            this.sourceTxt.TextChanged += new System.EventHandler(this.sourceTxt_TextChanged);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(152, 411);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 17;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(298, 411);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 18;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 494);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.save);
            this.Controls.Add(this.sourceTxt);
            this.Controls.Add(this.maxTxt);
            this.Controls.Add(this.minTxt);
            this.Controls.Add(this.priceTxt);
            this.Controls.Add(this.inventoryTxt);
            this.Controls.Add(this.partNameTxt);
            this.Controls.Add(this.partIDTxt);
            this.Controls.Add(this.source);
            this.Controls.Add(this.max);
            this.Controls.Add(this.min);
            this.Controls.Add(this.price);
            this.Controls.Add(this.inventory);
            this.Controls.Add(this.partName);
            this.Controls.Add(this.partID);
            this.Controls.Add(this.outsourced);
            this.Controls.Add(this.inhouse);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Add Part";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton inhouse;
        private System.Windows.Forms.RadioButton outsourced;
        private System.Windows.Forms.Label partID;
        private System.Windows.Forms.Label partName;
        private System.Windows.Forms.Label inventory;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label min;
        private System.Windows.Forms.Label max;
        private System.Windows.Forms.Label source;
        private System.Windows.Forms.TextBox partIDTxt;
        private System.Windows.Forms.TextBox partNameTxt;
        private System.Windows.Forms.TextBox inventoryTxt;
        private System.Windows.Forms.TextBox priceTxt;
        private System.Windows.Forms.TextBox minTxt;
        private System.Windows.Forms.TextBox maxTxt;
        private System.Windows.Forms.TextBox sourceTxt;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button cancel;
    }
}