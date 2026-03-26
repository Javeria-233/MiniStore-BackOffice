namespace App.WindowsApp.Forms
{
    partial class Mainform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.flpLeft = new System.Windows.Forms.FlowLayoutPanel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.flpRight = new System.Windows.Forms.FlowLayoutPanel();
            this.pickUserIcon = new System.Windows.Forms.PictureBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.pnlSider = new System.Windows.Forms.Panel();
            this.flpNav = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnSync = new System.Windows.Forms.Button();
            this.btnLogs = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.statusStrip1.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.flpLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.flpRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pickUserIcon)).BeginInit();
            this.pnlSider.SuspendLayout();
            this.flpNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 568);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1135, 32);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "Ready";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(60, 25);
            this.toolStripStatusLabel1.Text = "Ready";
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.flpLeft);
            this.pnlHeader.Controls.Add(this.flpRight);
            this.pnlHeader.Location = new System.Drawing.Point(0, 2);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1111, 132);
            this.pnlHeader.TabIndex = 2;
            // 
            // flpLeft
            // 
            this.flpLeft.Controls.Add(this.pbLogo);
            this.flpLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpLeft.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flpLeft.Location = new System.Drawing.Point(0, 0);
            this.flpLeft.Margin = new System.Windows.Forms.Padding(4, 3, 3, 3);
            this.flpLeft.Name = "flpLeft";
            this.flpLeft.Size = new System.Drawing.Size(191, 132);
            this.flpLeft.TabIndex = 1;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(3, 3);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(48, 37);
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // flpRight
            // 
            this.flpRight.Controls.Add(this.pickUserIcon);
            this.flpRight.Controls.Add(this.lblUser);
            this.flpRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.flpRight.Location = new System.Drawing.Point(982, 0);
            this.flpRight.Margin = new System.Windows.Forms.Padding(4, 3, 3, 3);
            this.flpRight.Name = "flpRight";
            this.flpRight.Size = new System.Drawing.Size(129, 132);
            this.flpRight.TabIndex = 0;
            // 
            // pickUserIcon
            // 
            this.pickUserIcon.Image = ((System.Drawing.Image)(resources.GetObject("pickUserIcon.Image")));
            this.pickUserIcon.Location = new System.Drawing.Point(3, 3);
            this.pickUserIcon.Name = "pickUserIcon";
            this.pickUserIcon.Size = new System.Drawing.Size(44, 37);
            this.pickUserIcon.TabIndex = 0;
            this.pickUserIcon.TabStop = false;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblUser.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblUser.Location = new System.Drawing.Point(53, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(54, 43);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "Admin";
            // 
            // pnlSider
            // 
            this.pnlSider.Controls.Add(this.flpNav);
            this.pnlSider.Location = new System.Drawing.Point(3, 140);
            this.pnlSider.Name = "pnlSider";
            this.pnlSider.Size = new System.Drawing.Size(188, 415);
            this.pnlSider.TabIndex = 3;
            // 
            // flpNav
            // 
            this.flpNav.Controls.Add(this.btnDashboard);
            this.flpNav.Controls.Add(this.btnProducts);
            this.flpNav.Controls.Add(this.btnOrders);
            this.flpNav.Controls.Add(this.btnReports);
            this.flpNav.Controls.Add(this.btnSync);
            this.flpNav.Controls.Add(this.btnLogs);
            this.flpNav.Controls.Add(this.btnSettings);
            this.flpNav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpNav.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpNav.Location = new System.Drawing.Point(0, 0);
            this.flpNav.Margin = new System.Windows.Forms.Padding(4, 3, 3, 3);
            this.flpNav.Name = "flpNav";
            this.flpNav.Size = new System.Drawing.Size(188, 415);
            this.flpNav.TabIndex = 0;
            // 
            // btnDashboard
            // 
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(3, 3);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(118, 38);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducts.Image = ((System.Drawing.Image)(resources.GetObject("btnProducts.Image")));
            this.btnProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducts.Location = new System.Drawing.Point(3, 47);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(117, 41);
            this.btnProducts.TabIndex = 1;
            this.btnProducts.Text = "Products";
            this.btnProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrders.Image = ((System.Drawing.Image)(resources.GetObject("btnOrders.Image")));
            this.btnOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrders.Location = new System.Drawing.Point(3, 94);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(117, 35);
            this.btnOrders.TabIndex = 2;
            this.btnOrders.Text = "Orders";
            this.btnOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOrders.UseVisualStyleBackColor = true;
            // 
            // btnReports
            // 
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Image = ((System.Drawing.Image)(resources.GetObject("btnReports.Image")));
            this.btnReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.Location = new System.Drawing.Point(3, 135);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(117, 33);
            this.btnReports.TabIndex = 3;
            this.btnReports.Text = "Reports";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReports.UseVisualStyleBackColor = true;
            // 
            // btnSync
            // 
            this.btnSync.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSync.Image = ((System.Drawing.Image)(resources.GetObject("btnSync.Image")));
            this.btnSync.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSync.Location = new System.Drawing.Point(3, 174);
            this.btnSync.Name = "btnSync";
            this.btnSync.Size = new System.Drawing.Size(117, 38);
            this.btnSync.TabIndex = 4;
            this.btnSync.Text = "Sync";
            this.btnSync.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSync.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSync.UseVisualStyleBackColor = true;
            // 
            // btnLogs
            // 
            this.btnLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogs.Image = ((System.Drawing.Image)(resources.GetObject("btnLogs.Image")));
            this.btnLogs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogs.Location = new System.Drawing.Point(3, 218);
            this.btnLogs.Name = "btnLogs";
            this.btnLogs.Size = new System.Drawing.Size(117, 44);
            this.btnLogs.TabIndex = 5;
            this.btnLogs.Text = "Logs";
            this.btnLogs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogs.UseVisualStyleBackColor = true;
            // 
            // btnSettings
            // 
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(3, 268);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(117, 42);
            this.btnSettings.TabIndex = 6;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettings.UseVisualStyleBackColor = true;
            // 
            // pnlContent
            // 
            this.pnlContent.Location = new System.Drawing.Point(197, 140);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(914, 415);
            this.pnlContent.TabIndex = 4;
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 600);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlSider);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Mainform";
            this.Text = "Mainform";
           //this.Load += new System.EventHandler(this.Mainform_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.flpLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.flpRight.ResumeLayout(false);
            this.flpRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pickUserIcon)).EndInit();
            this.pnlSider.ResumeLayout(false);
            this.flpNav.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlSider;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.FlowLayoutPanel flpLeft;
        private System.Windows.Forms.FlowLayoutPanel flpRight;
        private System.Windows.Forms.FlowLayoutPanel flpNav;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnSync;
        private System.Windows.Forms.Button btnLogs;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.PictureBox pickUserIcon;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}