using App.Core.Contracts;
using App.Core.Models;
using App.Core.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace App.WindowsApp.Forms
{
    public partial class ProductForm : Form
    {
        ProductFormModeEnum _mode;
        Product _product;
        IProductService _service;

        public ProductForm(ProductFormModeEnum mode, Product? p, IProductService service)
        {

            InitializeComponent();

            nuPrice.Maximum = Decimal.MaxValue;
            nuStock.Maximum = Int32.MaxValue;

            cmbCat.Items.Clear();
            cmbCat.DataSource = (Enum.GetValues(typeof(ProductsCategoryEnum)));
            cmbCat.SelectedIndex = 0;

            cmbProductStatus.Items.Clear();
            cmbProductStatus.DataSource = (Enum.GetValues(typeof(ProductStatusEnum)));
            cmbProductStatus.SelectedIndex = 0;

            _mode = mode;
            _product = p;
            _service = service;
            if (mode == ProductFormModeEnum.Edit)
            {
                btnSave.Text = " Update";
            }
            else if (mode == ProductFormModeEnum.View)
            {
                btnSave.Visible = false;

            }

            if (mode == ProductFormModeEnum.Edit || mode == ProductFormModeEnum.View)
            {

                txtId.Text = p.Id;
                txtName.Text = p.Name;
                cmbCat.SelectedItem = p.Category;
                cmbProductStatus.SelectedItem = p.Status;
                nuPrice.Value = p.Price;
                nuStock.Value = p.Stock;
            }

        }

        private void btnSave_Click(object sender, EventArgs e)

        {
            if (_mode == ProductFormModeEnum.Add)
            {
                Product newProduct = new Product();
                newProduct.Name = txtName.Text;
                newProduct.Category = (ProductsCategoryEnum)cmbCat.SelectedItem;
                newProduct.Status = (ProductStatusEnum)cmbProductStatus.SelectedItem;
                newProduct.Price = nuPrice.Value;
                newProduct.Stock = (int)nuStock.Value;


                //_product = _service.Add(newProduct);
                //txtId.Text = _product.Id;

                Product temp = _service.Add(newProduct);
                txtId.Text = temp?.Id ?? "";

            }
            else if (_mode == ProductFormModeEnum.Edit)
            {
                _product.Name = txtName.Text;
                _product.Category = (ProductsCategoryEnum)cmbCat.SelectedItem;
                _product.Status = (ProductStatusEnum)cmbProductStatus.SelectedItem;
                _product.Price = nuPrice.Value;
                _product.Stock = (int)nuStock.Value;

                bool isUpdated = _service.Update(_product);

            }
            this.Close();
        }

        private void ProductForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

