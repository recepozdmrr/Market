namespace Market
{
    partial class EditProductPage
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
            this.gridView = new System.Windows.Forms.DataGridView();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marketAppDataSet = new Market.MarketAppDataSet();
            this.productsTableAdapter = new Market.MarketAppDataSetTableAdapters.ProductsTableAdapter();
            this.QtyBox = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.SerialBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ModelBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BranBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StokName = new System.Windows.Forms.TextBox();
            this.Edit = new System.Windows.Forms.Button();
            this.productsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketAppDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QtyBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView
            // 
            this.gridView.AllowUserToOrderColumns = true;
            this.gridView.AutoGenerateColumns = false;
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.brand,
            this.qty,
            this.model,
            this.serial});
            this.gridView.DataSource = this.productsBindingSource2;
            this.gridView.Location = new System.Drawing.Point(12, 21);
            this.gridView.Name = "gridView";
            this.gridView.Size = new System.Drawing.Size(650, 512);
            this.gridView.TabIndex = 16;
            this.gridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.marketAppDataSet;
            // 
            // marketAppDataSet
            // 
            this.marketAppDataSet.DataSetName = "MarketAppDataSet";
            this.marketAppDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // QtyBox
            // 
            this.QtyBox.Location = new System.Drawing.Point(774, 137);
            this.QtyBox.Name = "QtyBox";
            this.QtyBox.Size = new System.Drawing.Size(221, 20);
            this.QtyBox.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(674, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Serial Number";
            // 
            // SerialBox
            // 
            this.SerialBox.Location = new System.Drawing.Point(774, 230);
            this.SerialBox.Name = "SerialBox";
            this.SerialBox.Size = new System.Drawing.Size(221, 20);
            this.SerialBox.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(674, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Model";
            // 
            // ModelBox
            // 
            this.ModelBox.Location = new System.Drawing.Point(774, 183);
            this.ModelBox.Name = "ModelBox";
            this.ModelBox.Size = new System.Drawing.Size(221, 20);
            this.ModelBox.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(674, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Qty";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(674, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Brand";
            // 
            // BranBox
            // 
            this.BranBox.Location = new System.Drawing.Point(774, 90);
            this.BranBox.Name = "BranBox";
            this.BranBox.Size = new System.Drawing.Size(221, 20);
            this.BranBox.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(674, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Name";
            // 
            // StokName
            // 
            this.StokName.Location = new System.Drawing.Point(774, 51);
            this.StokName.Name = "StokName";
            this.StokName.Size = new System.Drawing.Size(221, 20);
            this.StokName.TabIndex = 17;
            // 
            // Edit
            // 
            this.Edit.BackColor = System.Drawing.Color.DarkOrange;
            this.Edit.Location = new System.Drawing.Point(789, 311);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(95, 38);
            this.Edit.TabIndex = 27;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = false;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // productsBindingSource1
            // 
            this.productsBindingSource1.DataMember = "Products";
            this.productsBindingSource1.DataSource = this.marketAppDataSet;
            // 
            // productsBindingSource2
            // 
            this.productsBindingSource2.DataMember = "Products";
            this.productsBindingSource2.DataSource = this.marketAppDataSet;
            // 
            // id
            // 
            this.id.DataPropertyName = "Id";
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // name
            // 
            this.name.DataPropertyName = "Name";
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            // 
            // brand
            // 
            this.brand.DataPropertyName = "Brand";
            this.brand.HeaderText = "Brand";
            this.brand.Name = "brand";
            // 
            // qty
            // 
            this.qty.DataPropertyName = "Quantity";
            this.qty.HeaderText = "Quantity";
            this.qty.Name = "qty";
            // 
            // model
            // 
            this.model.DataPropertyName = "Model";
            this.model.HeaderText = "Model";
            this.model.Name = "model";
            // 
            // serial
            // 
            this.serial.DataPropertyName = "SerialNumber";
            this.serial.HeaderText = "SerialNumber";
            this.serial.Name = "serial";
            // 
            // EditProductPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(1007, 570);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.QtyBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SerialBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ModelBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BranBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StokName);
            this.Controls.Add(this.gridView);
            this.Name = "EditProductPage";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "EditProductPage";
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketAppDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QtyBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridView;
        private MarketAppDataSet marketAppDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private MarketAppDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.NumericUpDown QtyBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SerialBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ModelBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BranBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox StokName;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn model;
        private System.Windows.Forms.DataGridViewTextBoxColumn serial;
        private System.Windows.Forms.BindingSource productsBindingSource2;
        private System.Windows.Forms.BindingSource productsBindingSource1;
    }
}