using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.Core.Contracts;
using App.Core.Utilities;
using App.Core.Models;

using App.WindowsApp.Forms;


namespace App.WindowsApp.Views
{
    public partial class ProductView : UserControl
    {
        IProductService _service;
        BindingSource _dgvbindingSource = new BindingSource();

        public ProductView(IProductService _ser)
        {
            _service = _ser;
            InitializeComponent();
            dgvProducts.DataSource = _dgvbindingSource;

        }

        private void ProductView_Load(object sender, EventArgs e)
        {
            cmbCategory.Items.Clear();
            cmbCategory.Items.Add("--ALL--");
            cmbCategory.Items.AddRange(Enum.GetNames(typeof(ProductsCategoryEnum)));
            cmbCategory.SelectedIndex = 0;

            cmbStockStatus.Items.Clear();
            cmbStockStatus.Items.Add("--ALL--");
            cmbStockStatus.Items.AddRange(Enum.GetNames(typeof(ProductStatusEnum)));
            cmbStockStatus.SelectedIndex = 0;

            if (_service == null)
                return;
            _service.GetAll();
            _dgvbindingSource.DataSource = _service.GetAll();
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            ProductForm prodForm = new ProductForm(ProductFormModeEnum.Add, null);
            prodForm.ShowDialog();

        }
        private void tsbEdit_Click(object sender, EventArgs e)
        {
           Product? selectedProduct = _dgvbindingSource.Current as Product;
            if (selectedProduct != null)
            {
                ProductForm prodForm = new ProductForm(ProductFormModeEnum.Edit, selectedProduct);
                prodForm.ShowDialog();
            }
        }

        private void tsbView_Click(object sender, EventArgs e)
        {
            Product? selectedProduct = _dgvbindingSource.Current as Product;
            if (selectedProduct != null)
            {

                ProductForm prodForm = new ProductForm(ProductFormModeEnum.View, selectedProduct);
                prodForm.ShowDialog();
            }
        }
    }
}
