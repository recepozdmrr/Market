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
    public partial class EditProductPage : Form
    {
        public EditProductPage()
        {
            InitializeComponent();
            gridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            List();
        }
        MarketEntities mEF = new MarketEntities();
        void List()
        {
            gridView.DataSource = mEF.Products.ToList();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (gridView.SelectedRows.Count != 0)
            {
                Products updateData = new Products();
                DataGridViewRow row = this.gridView.SelectedRows[0];
                updateData.Id = Int32.Parse(row.Cells["id"].Value.ToString());
                updateData.Model = ModelBox.Text;
                updateData.Brand = BranBox.Text;
                updateData.Name = StokName.Text;
                updateData.Quantity = Int32.Parse(QtyBox.Text);
                updateData.SerialNumber = SerialBox.Text;
                mEF.Products.Remove(mEF.Products.First(p => p.Id == updateData.Id));
                mEF.Products.Add(updateData);
                mEF.SaveChanges();
                List();
            }
            else
            {
                MessageBox.Show("Please select a row to update item.");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Products updateData = new Products();
                DataGridViewRow row = this.gridView.SelectedRows[0];
                //updateData.Id = Int32.Parse(row.Cells["id"].Value.ToString());
                //Idbox.Text = row.Cells["id"].Value.ToString();
                ModelBox.Text = row.Cells["model"].Value.ToString();
                BranBox.Text = row.Cells["brand"].Value.ToString();
                StokName.Text = row.Cells["name"].Value.ToString();
                QtyBox.Text = row.Cells["qty"].Value.ToString();
                SerialBox.Text = row.Cells["serial"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata!");
            }
        }
    }
}
