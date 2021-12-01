
namespace HomeInventorySystem_v01
{
    partial class frmMain
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("User Profile");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Shopping Items");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("My Inventory");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Statistics and Charts");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Home Inventory System", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.panelApplication = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblDisplayName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelNavigation = new System.Windows.Forms.Panel();
            this.treeViewNavigation = new System.Windows.Forms.TreeView();
            this.imageListNavigation = new System.Windows.Forms.ImageList(this.components);
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelHeader.SuspendLayout();
            this.panelApplication.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelNavigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHeader.Controls.Add(this.lblLogo);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1299, 115);
            this.panelHeader.TabIndex = 0;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.Location = new System.Drawing.Point(4, 40);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(304, 32);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "Home Inventory System";
            // 
            // panelApplication
            // 
            this.panelApplication.BackColor = System.Drawing.Color.White;
            this.panelApplication.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelApplication.Controls.Add(this.btnExit);
            this.panelApplication.Controls.Add(this.lblDisplayName);
            this.panelApplication.Controls.Add(this.pictureBox1);
            this.panelApplication.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelApplication.Location = new System.Drawing.Point(0, 115);
            this.panelApplication.Name = "panelApplication";
            this.panelApplication.Size = new System.Drawing.Size(1299, 115);
            this.panelApplication.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(1165, 74);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(121, 34);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblDisplayName
            // 
            this.lblDisplayName.AutoSize = true;
            this.lblDisplayName.Location = new System.Drawing.Point(122, 45);
            this.lblDisplayName.Name = "lblDisplayName";
            this.lblDisplayName.Size = new System.Drawing.Size(90, 19);
            this.lblDisplayName.TabIndex = 1;
            this.lblDisplayName.Text = "Adi Maaita";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HomeInventorySystem_v01.Properties.Resources.UserPhotoGeneric;
            this.pictureBox1.Location = new System.Drawing.Point(16, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelNavigation
            // 
            this.panelNavigation.BackColor = System.Drawing.Color.White;
            this.panelNavigation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelNavigation.Controls.Add(this.treeViewNavigation);
            this.panelNavigation.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNavigation.Location = new System.Drawing.Point(0, 230);
            this.panelNavigation.Name = "panelNavigation";
            this.panelNavigation.Size = new System.Drawing.Size(252, 496);
            this.panelNavigation.TabIndex = 2;
            // 
            // treeViewNavigation
            // 
            this.treeViewNavigation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewNavigation.HotTracking = true;
            this.treeViewNavigation.ImageIndex = 0;
            this.treeViewNavigation.ImageList = this.imageListNavigation;
            this.treeViewNavigation.Location = new System.Drawing.Point(0, 0);
            this.treeViewNavigation.Name = "treeViewNavigation";
            treeNode1.ImageKey = "UserInformation.jpg";
            treeNode1.Name = "NodeUserProfile";
            treeNode1.SelectedImageKey = "Check.png";
            treeNode1.Text = "User Profile";
            treeNode2.ImageKey = "schedule.png";
            treeNode2.Name = "NodeShoppingItems";
            treeNode2.SelectedImageKey = "Check.png";
            treeNode2.Text = "Shopping Items";
            treeNode3.ImageKey = "Registration.png";
            treeNode3.Name = "NodeMyInventory";
            treeNode3.SelectedImageKey = "Check.png";
            treeNode3.Text = "My Inventory";
            treeNode4.ImageKey = "Dashboard.jpg";
            treeNode4.Name = "NodeStatisticsAndCharts";
            treeNode4.SelectedImageKey = "Check.png";
            treeNode4.Text = "Statistics and Charts";
            treeNode5.ImageKey = "GeneralManagement.png";
            treeNode5.Name = "NodeRoot";
            treeNode5.SelectedImageKey = "GeneralManagement.png";
            treeNode5.Text = "Home Inventory System";
            this.treeViewNavigation.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5});
            this.treeViewNavigation.SelectedImageIndex = 0;
            this.treeViewNavigation.Size = new System.Drawing.Size(250, 494);
            this.treeViewNavigation.TabIndex = 0;
            this.treeViewNavigation.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewNavigation_AfterSelect);
            // 
            // imageListNavigation
            // 
            this.imageListNavigation.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListNavigation.ImageStream")));
            this.imageListNavigation.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListNavigation.Images.SetKeyName(0, "GeneralManagement.png");
            this.imageListNavigation.Images.SetKeyName(1, "UserInformation.jpg");
            this.imageListNavigation.Images.SetKeyName(2, "schedule.png");
            this.imageListNavigation.Images.SetKeyName(3, "Registration.png");
            this.imageListNavigation.Images.SetKeyName(4, "Dashboard.jpg");
            this.imageListNavigation.Images.SetKeyName(5, "Check.png");
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.White;
            this.panelContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(252, 230);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1047, 496);
            this.panelContent.TabIndex = 3;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1299, 726);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelNavigation);
            this.Controls.Add(this.panelApplication);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmMain";
            this.Text = "Home Inventroy System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelApplication.ResumeLayout(false);
            this.panelApplication.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelNavigation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelApplication;
        private System.Windows.Forms.Panel panelNavigation;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblDisplayName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TreeView treeViewNavigation;
        private System.Windows.Forms.ImageList imageListNavigation;
    }
}