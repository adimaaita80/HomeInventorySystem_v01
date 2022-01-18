using HomeInventorySystem_v01.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomeInventorySystem_v01.Entities;
using HomeInventorySystem_v01.DataAccessLayer;

namespace HomeInventorySystem_v01.GUI
{
    public partial class frmShoppingItems : Form
    {
        FormState frmState = FormState.Add;
        Item currentItem = new Item();

        public frmShoppingItems()
        {
            InitializeComponent();
        }

        private void frmShoppingItems_Load(object sender, EventArgs e)
        {
            SetFormState();
            RefreshItemGrid();
            txtItemName.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmState = FormState.WaitingToSave;
            SetFormState();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            if(frmState == FormState.WaitingToSave)
            {
                currentItem.ItemName = txtItemName.Text;
                currentItem.Unit = txtUnit.Text;
                currentItem.Quantity = double.Parse(txtQuantity.Text);
                currentItem.UserId = 1;

                ItemsDAL.CreateItem(currentItem);
            }
            else if(frmState == FormState.WaitingToSaveOrDelete)
            {
                currentItem.ItemName = txtItemName.Text;
                currentItem.Unit = txtUnit.Text;
                currentItem.Quantity = double.Parse(txtQuantity.Text);
                ItemsDAL.UpdateItem(currentItem);
            }
            

            frmState = FormState.Add;
            SetFormState();

            ClearForm();
            RefreshItemGrid();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ItemsDAL.DeleteItem(currentItem);

            frmState = FormState.Add;
            SetFormState();

            ClearForm();
            RefreshItemGrid();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmState = FormState.Add;
            SetFormState();

            ClearForm();
        }

        private void dataGridViewItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow currentRow = new DataGridViewRow();
            currentRow = dataGridViewItems.Rows[e.RowIndex];

            currentItem.ItemId = int.Parse(currentRow.Cells[0].Value.ToString());
            currentItem.ItemName = currentRow.Cells[1].Value.ToString();
            currentItem.Unit = currentRow.Cells[2].Value.ToString();
            currentItem.Quantity = double.Parse(currentRow.Cells[3].Value.ToString());
            currentItem.UserId = int.Parse(currentRow.Cells[4].Value.ToString());

            txtItemName.Text = currentItem.ItemName;
            txtUnit.Text = currentItem.Unit;
            txtQuantity.Text = currentItem.Quantity.ToString();


            frmState = FormState.WaitingToSaveOrDelete;
            SetFormState();
        }

        private void SetFormState()
        {
            if (frmState == FormState.Add)
            {
                btnAdd.Enabled = true;
                btnSave.Enabled = false;
                btnDelete.Enabled = false;
                btnCancel.Enabled = false;
            }
            else if (frmState == FormState.WaitingToSave)
            {
                btnAdd.Enabled = false;
                btnSave.Enabled = true;
                btnDelete.Enabled = false;
                btnCancel.Enabled = true;
            }
            else if (frmState == FormState.WaitingToSaveOrDelete)
            {
                btnAdd.Enabled = false;
                btnSave.Enabled = true;
                btnDelete.Enabled = true;
                btnCancel.Enabled = true;
            }
            txtItemName.Focus();
        }

        private void ClearForm()
        {
            txtItemName.Text = "";
            txtUnit.Text = "";
            txtQuantity.Text = "";

            txtItemName.Focus();
        }

        private void RefreshItemGrid()
        {
            dataGridViewItems.DataSource = ItemsDAL.GetAllItems();
        }

        
    }
}
