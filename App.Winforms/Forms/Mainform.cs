using App.Winforms.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace App.Winforms.Forms
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Mainform_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.pnlContent.Controls.Clear();
            this.pnlContent.Controls.Add(new DashboardView());
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            this.pnlContent.Controls.Clear();
            this.pnlContent.Controls.Add(new ProductView());
        }

        private void ShowView<T>(Func<T> factory) where T : UserControl
        {
            var key = typeof(DashboardView);
            if (!_views.TryGetValue(key, out var view))
            {
                view = factory();
                view.Dock = DockStyle.Fill;
                // var view=DashboradView
                _views[key] = view;
            }

            if (!pnlContent.Controls.Contains(view))
            {
                pnlContent.Controls.Clear();
                pnlContent.Controls.Add(view);
            }

            //view.visible = true;
            view.BringToFront();
        }
    }
}
