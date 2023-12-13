namespace DevinPerdueFinal
{
    partial class Modify_Part
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
            this.inhouse = new System.Windows.Forms.RadioButton();
            this.outsourced = new System.Windows.Forms.RadioButton();
            this.partID = new System.Windows.Forms.Label();
            this.partName = new System.Windows.Forms.Label();
            this.partInventory = new System.Windows.Forms.Label();
            this.partPrice = new System.Windows.Forms.Label();
            this.partMin = new System.Windows.Forms.Label();
            this.partMax = new System.Windows.Forms.Label();
            this.Source = new System.Windows.Forms.Label();
            this.txtPartID = new System.Windows.Forms.TextBox();
            this.txtPartName = new System.Windows.Forms.TextBox();
            this.txtInventory = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saveModifiedPart = new System.Windows.Forms.Button();
            this.cancelModifiedPart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inhouse
            // 
            this.inhouse.AutoSize = true;
            this.inhouse.Location = new System.Drawing.Point(170, 51);
            this.inhouse.Name = "inhouse";
            this.inhouse.Size = new System.Drawing.Size(63, 17);
            this.inhouse.TabIndex = 0;
            this.inhouse.TabStop = true;
            this.inhouse.Text = "Inhouse";
            this.inhouse.UseVisualStyleBackColor = true;
            this.inhouse.CheckedChanged += new System.EventHandler(this.inhouse_CheckedChanged);
            // 
            // outsourced
            // 
            this.outsourced.AutoSize = true;
            this.outsourced.Location = new System.Drawing.Point(306, 51);
            this.outsourced.Name = "outsourced";
            this.outsourced.Size = new System.Drawing.Size(80, 17);
            this.outsourced.TabIndex = 1;
            this.outsourced.TabStop = true;
            this.outsourced.Text = "Outsourced";
            this.outsourced.UseVisualStyleBackColor = true;
            this.outsourced.CheckedChanged += new System.EventHandler(this.outsourced_CheckedChanged);
            // 
            // partID
            // 
            this.partID.AutoSize = true;
            this.partID.Location = new System.Drawing.Point(49, 107);
            this.partID.Name = "partID";
            this.partID.Size = new System.Drawing.Size(40, 13);
            this.partID.TabIndex = 2;
            this.partID.Text = "Part ID";
            // 
            // partName
            // 
            this.partName.AutoSize = true;
            this.partName.Location = new System.Drawing.Point(46, 149);
            this.partName.Name = "partName";
            this.partName.Size = new System.Drawing.Size(57, 13);
            this.partName.TabIndex = 3;
            this.partName.Text = "Part Name";
            // 
            // partInventory
            // 
            this.partInventory.AutoSize = true;
            this.partInventory.Location = new System.Drawing.Point(49, 201);
            this.partInventory.Name = "partInventory";
            this.partInventory.Size = new System.Drawing.Size(51, 13);
            this.partInventory.TabIndex = 4;
            this.partInventory.Text = "Inventory";
            // 
            // partPrice
            // 
            this.partPrice.AutoSize = true;
            this.partPrice.Location = new System.Drawing.Point(49, 247);
            this.partPrice.Name = "partPrice";
            this.partPrice.Size = new System.Drawing.Size(31, 13);
            this.partPrice.TabIndex = 5;
            this.partPrice.Text = "Price";
            this.partPrice.Click += new System.EventHandler(this.partPrice_Click);
            // 
            // partMin
            // 
            this.partMin.AutoSize = true;
            this.partMin.Location = new System.Drawing.Point(49, 293);
            this.partMin.Name = "partMin";
            this.partMin.Size = new System.Drawing.Size(24, 13);
            this.partMin.TabIndex = 6;
            this.partMin.Text = "Min";
            // 
            // partMax
            // 
            this.partMax.AutoSize = true;
            this.partMax.Location = new System.Drawing.Point(184, 293);
            this.partMax.Name = "partMax";
            this.partMax.Size = new System.Drawing.Size(27, 13);
            this.partMax.TabIndex = 7;
            this.partMax.Text = "Max";
            // 
            // Source
            // 
            this.Source.AutoSize = true;
            this.Source.Location = new System.Drawing.Point(49, 345);
            this.Source.Name = "Source";
            this.Source.Size = new System.Drawing.Size(59, 13);
            this.Source.TabIndex = 8;
            this.Source.Text = "MachineID";
            this.Source.Click += new System.EventHandler(this.Source_Click);
            // 
            // txtPartID
            // 
            this.txtPartID.Enabled = false;
            this.txtPartID.Location = new System.Drawing.Point(139, 107);
            this.txtPartID.Name = "txtPartID";
            this.txtPartID.Size = new System.Drawing.Size(100, 20);
            this.txtPartID.TabIndex = 9;
            this.txtPartID.TextChanged += new System.EventHandler(this.txtPartID_TextChanged);
            // 
            // txtPartName
            // 
            this.txtPartName.Location = new System.Drawing.Point(139, 149);
            this.txtPartName.Name = "txtPartName";
            this.txtPartName.Size = new System.Drawing.Size(100, 20);
            this.txtPartName.TabIndex = 10;
            this.txtPartName.TextChanged += new System.EventHandler(this.txtPartName_TextChanged);
            // 
            // txtInventory
            // 
            this.txtInventory.Location = new System.Drawing.Point(139, 201);
            this.txtInventory.Name = "txtInventory";
            this.txtInventory.Size = new System.Drawing.Size(100, 20);
            this.txtInventory.TabIndex = 11;
            this.txtInventory.TextChanged += new System.EventHandler(this.txtInventory_TextChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(139, 247);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 12;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(79, 293);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(100, 20);
            this.txtMin.TabIndex = 13;
            this.txtMin.TextChanged += new System.EventHandler(this.txtMin_TextChanged);
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(217, 293);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(100, 20);
            this.txtMax.TabIndex = 14;
            this.txtMax.TextChanged += new System.EventHandler(this.txtMax_TextChanged);
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(139, 337);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(100, 20);
            this.txtSource.TabIndex = 15;
            this.txtSource.TextChanged += new System.EventHandler(this.txtSource_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 26);
            this.label1.TabIndex = 16;
            this.label1.Text = "Modify Part";
            // 
            // saveModifiedPart
            // 
            this.saveModifiedPart.Location = new System.Drawing.Point(103, 413);
            this.saveModifiedPart.Name = "saveModifiedPart";
            this.saveModifiedPart.Size = new System.Drawing.Size(75, 23);
            this.saveModifiedPart.TabIndex = 17;
            this.saveModifiedPart.Text = "Save";
            this.saveModifiedPart.UseVisualStyleBackColor = true;
            this.saveModifiedPart.Click += new System.EventHandler(this.saveModifiedPart_Click);
            // 
            // cancelModifiedPart
            // 
            this.cancelModifiedPart.Location = new System.Drawing.Point(187, 413);
            this.cancelModifiedPart.Name = "cancelModifiedPart";
            this.cancelModifiedPart.Size = new System.Drawing.Size(75, 23);
            this.cancelModifiedPart.TabIndex = 18;
            this.cancelModifiedPart.Text = "Cancel";
            this.cancelModifiedPart.UseVisualStyleBackColor = true;
            this.cancelModifiedPart.Click += new System.EventHandler(this.cancelModifiedPart_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 465);
            this.Controls.Add(this.cancelModifiedPart);
            this.Controls.Add(this.saveModifiedPart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtInventory);
            this.Controls.Add(this.txtPartName);
            this.Controls.Add(this.txtPartID);
            this.Controls.Add(this.Source);
            this.Controls.Add(this.partMax);
            this.Controls.Add(this.partMin);
            this.Controls.Add(this.partPrice);
            this.Controls.Add(this.partInventory);
            this.Controls.Add(this.partName);
            this.Controls.Add(this.partID);
            this.Controls.Add(this.outsourced);
            this.Controls.Add(this.inhouse);
            this.Name = "Form3";
            this.Text = "Modify Part";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton inhouse;
        private System.Windows.Forms.RadioButton outsourced;
        private System.Windows.Forms.Label partID;
        private System.Windows.Forms.Label partName;
        private System.Windows.Forms.Label partInventory;
        private System.Windows.Forms.Label partPrice;
        private System.Windows.Forms.Label partMin;
        private System.Windows.Forms.Label partMax;
        private System.Windows.Forms.Label Source;
        private System.Windows.Forms.TextBox txtPartID;
        private System.Windows.Forms.TextBox txtPartName;
        private System.Windows.Forms.TextBox txtInventory;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveModifiedPart;
        private System.Windows.Forms.Button cancelModifiedPart;
    }
}