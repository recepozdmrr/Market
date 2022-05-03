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
        }
        MarketEntities mEF = new MarketEntities();
        void List()
        {
            gridView.DataSource = mEF.Products.ToList();
        }
        private void StokAdd_Click(object sender, EventArgs e)
        {
            Products tempProp = new Products();
            tempProp.Name = StokName.Text;
            tempProp.Brand = BranBox.Text;
            tempProp.Quantity = Int32.Parse(QtyBox.Text);
            tempProp.Model = ModelBox.Text;
            tempProp.SerialNumber = SerialBox.Text;
            if (tempProp.Name != "" && tempProp.Brand != "" && tempProp.Quantity.ToString() != "" && tempProp.Model != "" && tempProp.SerialNumber != "")
            {
                
                mEF.Products.Add(tempProp);
                mEF.SaveChanges();
                List();
            }
            else
            {
                MessageBox.Show("Check all empty fields");
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            //var deneme = this.gridView.SelectedItem as Products;
            if (gridView.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.gridView.SelectedRows[0];
                int propId = Int32.Parse(row.Cells["idColumn"].Value.ToString());
                mEF.Products.Remove(mEF.Products.First(p => p.Id == propId));
                mEF.SaveChanges();
                List();
            }
            else
            {
                MessageBox.Show("Please select a row to delete item.");
            }
        }
    }
}
