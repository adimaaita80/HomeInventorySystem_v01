using HomeInventorySystem_v01.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeInventorySystem_v01
{
    public partial class frmMain : Form
    {
        private Form currentActiveForm = null;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            treeViewNavigation.ExpandAll();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to exit this application?";
            string title = "Exit Application";

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            DialogResult result = MessageBox.Show(message, title, buttons);

            if (result == DialogResult.Yes)
                Application.Exit();
        }

        private void treeViewNavigation_AfterSelect(object sender, TreeViewEventArgs e)
        {
            Form frm = null;

            TreeNode node = e.Node;

            if (node.Name == "NodeUserProfile")
                frm = new frmUserProfile();
            else if (node.Name == "NodeShoppingItems")
                frm = new frmShoppingItems();
            else if (node.Name == "NodeMyInventory")
                frm = new frmMyInventory();
            else if (node.Name == "NodeStatisticsAndCharts")
                frm = new frmStatisticsAndCharts();


            if(frm != null)
            {
                if(currentActiveForm != null && currentActiveForm != frm)
                {
                    currentActiveForm.Close();
                    panelContent.Controls.Remove(currentActiveForm);
                }

                frm.FormBorderStyle = FormBorderStyle.None;
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.BackColor = Color.White;
                currentActiveForm = frm;

                panelContent.Controls.Add(frm);
                frm.Show();
            }
            
        }
    }
}
