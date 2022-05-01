using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market
{
    public partial class Stok : Form
    {
        public Stok()
        {
            InitializeComponent();
            List();
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            listView1.Columns.Add("Name", 100);
            listView1.Columns.Add("Brand", 70);
            listView1.Columns.Add("Qty", 50);
            listView1.Columns.Add("Model", 70);
            listView1.Columns.Add("SerialNumber", 150);
        }
        MarketEntities mEF = new MarketEntities();
        void List()
        {
            var deneme = mEF.Products.ToList();
            foreach(var item in deneme)
            {
                //string[] row = { StokName.Text, BranBox.Text, QtyBox.Text, ModelBox.Text, SerialBox.Text };
                string[] row = { item.Name, item.Brand, item.Quantity.ToString(), item.Model, item.SerialNumber };
                var satir = new ListViewItem(row);
                listView1.Items.Add(satir);
            }
        }
        private void StokAdd_Click(object sender, EventArgs e)
        {
            Products tempProp = new Products();
            tempProp.Name = StokName.Text;
            tempProp.Brand = BranBox.Text;
            tempProp.Quantity = Int32.Parse(QtyBox.Text);
            tempProp.Model = SerialBox.Text;
            mEF.Products.Add(tempProp);
            mEF.SaveChanges();
            string[] row = { StokName.Text, BranBox.Text, QtyBox.Text, ModelBox.Text, SerialBox.Text };
            var satir = new ListViewItem(row);
            listView1.Items.Add(satir);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            //var deneme = listView1.SelectedItems[0] as Products;
        }

        private void Stok_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'marketAppDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.marketAppDataSet.Products);

        }
    }
}
