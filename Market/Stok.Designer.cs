namespace Market
{
    partial class Stok
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
            this.StokName = new System.Windows.Forms.TextBox();
            this.StokAddButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BranBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ModelBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SerialBox = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.QtyBox = new System.Windows.Forms.NumericUpDown();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.marketAppDataSet = new Market.MarketAppDataSet();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new Market.MarketAppDataSetTableAdapters.ProductsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.QtyBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketAppDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // StokName
            // 
            this.StokName.Location = new System.Drawing.Point(127, 51);
            this.StokName.Name = "StokName";
            this.StokName.Size = new System.Drawing.Size(221, 20);
            this.StokName.TabIndex = 0;
            // 
            // StokAddButton
            // 
            this.StokAddButton.BackColor = System.Drawing.Color.SpringGreen;
            this.StokAddButton.Location = new System.Drawing.Point(87, 321);
            this.StokAddButton.Name = "StokAddButton";
            this.StokAddButton.Size = new System.Drawing.Size(105, 40);
            this.StokAddButton.TabIndex = 1;
            this.StokAddButton.Text = "Save Product";
            this.StokAddButton.UseVisualStyleBackColor = false;
            this.StokAddButton.Click += new System.EventHandler(this.StokAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Brand";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // BranBox
            // 
            this.BranBox.Location = new System.Drawing.Point(127, 97);
            this.BranBox.Name = "BranBox";
            this.BranBox.Size = new System.Drawing.Size(221, 20);
            this.BranBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Qty";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Model";
            // 
            // ModelBox
            // 
            this.ModelBox.Location = new System.Drawing.Point(127, 190);
            this.ModelBox.Name = "ModelBox";
            this.ModelBox.Size = new System.Drawing.Size(221, 20);
            this.ModelBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Serial Number";
            // 
            // SerialBox
            // 
            this.SerialBox.Location = new System.Drawing.Point(127, 237);
            this.SerialBox.Name = "SerialBox";
            this.SerialBox.Size = new System.Drawing.Size(221, 20);
            this.SerialBox.TabIndex = 10;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(413, 51);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(516, 497);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // QtyBox
            // 
            this.QtyBox.Location = new System.Drawing.Point(127, 144);
            this.QtyBox.Name = "QtyBox";
            this.QtyBox.Size = new System.Drawing.Size(221, 20);
            this.QtyBox.TabIndex = 13;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.IndianRed;
            this.DeleteButton.Location = new System.Drawing.Point(220, 321);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(105, 40);
            this.DeleteButton.TabIndex = 14;
            this.DeleteButton.Text = "Delete Product";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // marketAppDataSet
            // 
            this.marketAppDataSet.DataSetName = "MarketAppDataSet";
            this.marketAppDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.marketAppDataSet;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // Stok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(960, 575);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.QtyBox);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SerialBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ModelBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BranBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StokAddButton);
            this.Controls.Add(this.StokName);
            this.Name = "Stok";
            this.Text = "Stok";
            this.Load += new System.EventHandler(this.Stok_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QtyBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketAppDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox StokName;
        private System.Windows.Forms.Button StokAddButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BranBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ModelBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SerialBox;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.NumericUpDown QtyBox;
        private System.Windows.Forms.Button DeleteButton;
        private MarketAppDataSet marketAppDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private MarketAppDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
    }
}