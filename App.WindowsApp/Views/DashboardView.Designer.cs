using System.Windows.Forms;

namespace App.WindowsApp.Views
{
    partial class DashboardView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("produ....");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("stock");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Order Id");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Stock");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("Total");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("Status");
            this.tblDashboard = new System.Windows.Forms.TableLayoutPanel();
            this.flpKpi = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlSales = new System.Windows.Forms.Panel();
            this.lblsalesV = new System.Windows.Forms.Label();
            this.lblsalesT = new System.Windows.Forms.Label();
            this.pnlorders = new System.Windows.Forms.Panel();
            this.lblOrdersV = new System.Windows.Forms.Label();
            this.lblOrdersT = new System.Windows.Forms.Label();
            this.plnRevenue = new System.Windows.Forms.Panel();
            this.lblRevenueV = new System.Windows.Forms.Label();
            this.lblRevenueT = new System.Windows.Forms.Label();
            this.pnlstock = new System.Windows.Forms.Panel();
            this.lvLowStock = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.ColProduct = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlRecentOrders = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lvRecentOrder = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tblDashboard.SuspendLayout();
            this.flpKpi.SuspendLayout();
            this.pnlSales.SuspendLayout();
            this.pnlorders.SuspendLayout();
            this.plnRevenue.SuspendLayout();
            this.pnlstock.SuspendLayout();
            this.pnlRecentOrders.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblDashboard
            // 
            this.tblDashboard.ColumnCount = 1;
            this.tblDashboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblDashboard.Controls.Add(this.flpKpi, 0, 0);
            this.tblDashboard.Controls.Add(this.pnlstock, 0, 1);
            this.tblDashboard.Controls.Add(this.pnlRecentOrders, 0, 2);
            this.tblDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblDashboard.Location = new System.Drawing.Point(0, 0);
            this.tblDashboard.Name = "tblDashboard";
            this.tblDashboard.RowCount = 4;
            this.tblDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tblDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblDashboard.Size = new System.Drawing.Size(767, 488);
            this.tblDashboard.TabIndex = 0;
            // 
            // flpKpi
            // 
            this.flpKpi.Controls.Add(this.pnlSales);
            this.flpKpi.Controls.Add(this.pnlorders);
            this.flpKpi.Controls.Add(this.plnRevenue);
            this.flpKpi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpKpi.Location = new System.Drawing.Point(3, 3);
            this.flpKpi.Name = "flpKpi";
            this.flpKpi.Size = new System.Drawing.Size(761, 114);
            this.flpKpi.TabIndex = 0;
            // 
            // pnlSales
            // 
            this.pnlSales.BackColor = System.Drawing.Color.White;
            this.pnlSales.Controls.Add(this.lblsalesV);
            this.pnlSales.Controls.Add(this.lblsalesT);
            this.pnlSales.Location = new System.Drawing.Point(3, 3);
            this.pnlSales.Name = "pnlSales";
            this.pnlSales.Size = new System.Drawing.Size(200, 100);
            this.pnlSales.TabIndex = 0;
            // 
            // lblsalesV
            // 
            this.lblsalesV.AutoSize = true;
            this.lblsalesV.Location = new System.Drawing.Point(101, 13);
            this.lblsalesV.Name = "lblsalesV";
            this.lblsalesV.Size = new System.Drawing.Size(36, 20);
            this.lblsalesV.TabIndex = 1;
            this.lblsalesV.Text = "163";
            // 
            // lblsalesT
            // 
            this.lblsalesT.AutoSize = true;
            this.lblsalesT.Location = new System.Drawing.Point(25, 13);
            this.lblsalesT.Name = "lblsalesT";
            this.lblsalesT.Size = new System.Drawing.Size(49, 20);
            this.lblsalesT.TabIndex = 0;
            this.lblsalesT.Text = "Sales";
            // 
            // pnlorders
            // 
            this.pnlorders.BackColor = System.Drawing.Color.White;
            this.pnlorders.Controls.Add(this.lblOrdersV);
            this.pnlorders.Controls.Add(this.lblOrdersT);
            this.pnlorders.Location = new System.Drawing.Point(209, 3);
            this.pnlorders.Name = "pnlorders";
            this.pnlorders.Size = new System.Drawing.Size(200, 100);
            this.pnlorders.TabIndex = 2;
            // 
            // lblOrdersV
            // 
            this.lblOrdersV.AutoSize = true;
            this.lblOrdersV.Location = new System.Drawing.Point(97, 12);
            this.lblOrdersV.Name = "lblOrdersV";
            this.lblOrdersV.Size = new System.Drawing.Size(27, 20);
            this.lblOrdersV.TabIndex = 1;
            this.lblOrdersV.Text = "33";
            this.lblOrdersV.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblOrdersT
            // 
            this.lblOrdersT.AutoSize = true;
            this.lblOrdersT.Location = new System.Drawing.Point(14, 13);
            this.lblOrdersT.Name = "lblOrdersT";
            this.lblOrdersT.Size = new System.Drawing.Size(57, 20);
            this.lblOrdersT.TabIndex = 0;
            this.lblOrdersT.Text = "Orders";
            // 
            // plnRevenue
            // 
            this.plnRevenue.BackColor = System.Drawing.Color.White;
            this.plnRevenue.Controls.Add(this.lblRevenueV);
            this.plnRevenue.Controls.Add(this.lblRevenueT);
            this.plnRevenue.Location = new System.Drawing.Point(415, 3);
            this.plnRevenue.Name = "plnRevenue";
            this.plnRevenue.Size = new System.Drawing.Size(200, 100);
            this.plnRevenue.TabIndex = 3;
            // 
            // lblRevenueV
            // 
            this.lblRevenueV.AutoSize = true;
            this.lblRevenueV.Location = new System.Drawing.Point(107, 13);
            this.lblRevenueV.Name = "lblRevenueV";
            this.lblRevenueV.Size = new System.Drawing.Size(90, 20);
            this.lblRevenueV.TabIndex = 1;
            this.lblRevenueV.Text = "37,356PKR";
            // 
            // lblRevenueT
            // 
            this.lblRevenueT.AutoSize = true;
            this.lblRevenueT.Location = new System.Drawing.Point(18, 13);
            this.lblRevenueT.Name = "lblRevenueT";
            this.lblRevenueT.Size = new System.Drawing.Size(73, 20);
            this.lblRevenueT.TabIndex = 0;
            this.lblRevenueT.Text = "Revenue";
            // 
            // pnlstock
            // 
            this.pnlstock.BackColor = System.Drawing.Color.White;
            this.pnlstock.Controls.Add(this.label1);
            this.pnlstock.Controls.Add(this.lvLowStock);
            this.pnlstock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlstock.Location = new System.Drawing.Point(3, 123);
            this.pnlstock.Name = "pnlstock";
            this.pnlstock.Size = new System.Drawing.Size(761, 168);
            this.pnlstock.TabIndex = 1;
            // 
            // lvLowStock
            // 
            this.lvLowStock.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColProduct});
            this.lvLowStock.HideSelection = false;
            this.lvLowStock.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.lvLowStock.Location = new System.Drawing.Point(32, 84);
            this.lvLowStock.Name = "lvLowStock";
            this.lvLowStock.Size = new System.Drawing.Size(699, 39);
            this.lvLowStock.TabIndex = 0;
            this.lvLowStock.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Low Stock";
            // 
            // ColProduct
            // 
            this.ColProduct.Text = "produ...";
            // 
            // pnlRecentOrders
            // 
            this.pnlRecentOrders.BackColor = System.Drawing.Color.White;
            this.pnlRecentOrders.Controls.Add(this.lvRecentOrder);
            this.pnlRecentOrders.Controls.Add(this.label2);
            this.pnlRecentOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRecentOrders.Location = new System.Drawing.Point(3, 297);
            this.pnlRecentOrders.Name = "pnlRecentOrders";
            this.pnlRecentOrders.Size = new System.Drawing.Size(761, 168);
            this.pnlRecentOrders.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Recent Orders";
            // 
            // lvRecentOrder
            // 
            this.lvRecentOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvRecentOrder.HideSelection = false;
            this.lvRecentOrder.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6});
            this.lvRecentOrder.Location = new System.Drawing.Point(31, 49);
            this.lvRecentOrder.Name = "lvRecentOrder";
            this.lvRecentOrder.Size = new System.Drawing.Size(699, 39);
            this.lvRecentOrder.TabIndex = 3;
            this.lvRecentOrder.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "produ...";
            // 
            // DashboardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblDashboard);
            this.Name = "DashboardView";
            this.Size = new System.Drawing.Size(767, 488);
            this.tblDashboard.ResumeLayout(false);
            this.flpKpi.ResumeLayout(false);
            this.pnlSales.ResumeLayout(false);
            this.pnlSales.PerformLayout();
            this.pnlorders.ResumeLayout(false);
            this.pnlorders.PerformLayout();
            this.plnRevenue.ResumeLayout(false);
            this.plnRevenue.PerformLayout();
            this.pnlstock.ResumeLayout(false);
            this.pnlstock.PerformLayout();
            this.pnlRecentOrders.ResumeLayout(false);
            this.pnlRecentOrders.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblDashboard;
        private System.Windows.Forms.FlowLayoutPanel flpKpi;
        private System.Windows.Forms.Panel pnlSales;
        private System.Windows.Forms.Label lblsalesV;
        private System.Windows.Forms.Label lblsalesT;
        private System.Windows.Forms.Panel pnlorders;
        private System.Windows.Forms.Label lblOrdersV;
        private System.Windows.Forms.Label lblOrdersT;
        private System.Windows.Forms.Panel plnRevenue;
        private System.Windows.Forms.Label lblRevenueV;
        private System.Windows.Forms.Label lblRevenueT;
        private System.Windows.Forms.Panel pnlstock;
        private System.Windows.Forms.ListView lvLowStock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader ColProduct;
        private System.Windows.Forms.Panel pnlRecentOrders;
        private System.Windows.Forms.ListView lvRecentOrder;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label label2;
    }
}
