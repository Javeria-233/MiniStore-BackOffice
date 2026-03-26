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
            var categories = new List<object> { "--ALL--" };
            categories.AddRange(Enum.GetValues(typeof(ProductsCategoryEnum)).Cast<object>());
            cmbCategory.DataSource = categories;
            cmbCategory.SelectedIndex = 0;

            cmbStockStatus.Items.Clear();
            var stockStatus = new List<object> { "--ALL--" };
            stockStatus.AddRange(Enum.GetValues(typeof(ProductStatusEnum)).Cast<object>());
            cmbStockStatus.DataSource = stockStatus;
            cmbStockStatus.SelectedIndex = 0;

            if (_service == null)
                return;
            //_service.GetAll();
            _dgvbindingSource.DataSource = _service.GetAll();
        } 

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            ProductForm prodForm = new ProductForm(ProductFormModeEnum.Add, null, _service);
            prodForm.ShowDialog();
            RefreshGrid();

        }
        private void tsbEdit_Click(object sender, EventArgs e)
        {
            Product? selectedProduct = _dgvbindingSource.Current as Product;
            if (selectedProduct != null)
            {
                ProductForm prodForm = new ProductForm(ProductFormModeEnum.Edit, selectedProduct, _service);
                prodForm.ShowDialog();
                RefreshGrid();
            }
        }

        private void tsbView_Click(object sender, EventArgs e)
        {
            Product? selectedProduct = _dgvbindingSource.Current as Product;
            if (selectedProduct != null)
            {

                ProductForm prodForm = new ProductForm(ProductFormModeEnum.View, selectedProduct, _service);
                prodForm.ShowDialog();
            }
        }
        private void RefreshGrid()
        {
            string searchText = txtSearch.Text;

            ProductsCategoryEnum? selectedCategory = null;

            if (cmbCategory.SelectedItem != null)
            {
                if (cmbCategory.SelectedItem.ToString().Equals("--ALL--"))
                {
                    selectedCategory = null;
                }
                else
                {
                    selectedCategory = (ProductsCategoryEnum)cmbCategory.SelectedItem;
                }
            }

            ProductStatusEnum? selectedStatus = null;

            if (cmbStockStatus.SelectedItem != null)
            {
                if (cmbStockStatus.SelectedItem.ToString().Equals("--ALL--"))
                {
                    selectedStatus = null;
                }
                else
                {
                    selectedStatus = (ProductStatusEnum)cmbStockStatus.SelectedItem;
                }
            }


            _dgvbindingSource.DataSource = _service.Search(searchText, selectedCategory, selectedStatus);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void cmbStockStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }
    }
}
