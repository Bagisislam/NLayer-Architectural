using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Northwind.Business.Abstract;
using Northwind.Business.Concrete;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.DataAccess.Concrete.NHibernate;
using Northwind.Entities.Concrete;

namespace Northwind.WebFormsUI
{
    public partial class Form1 : Form
    {
        IProductService _productMeneger = new ProductMeneger(new EfProductDal());
        private ICategoryService _categoryService = new CategoryMeneger(new EfCategoryDal());
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadUpdateTexts()
        {
            if (dgwProduct.CurrentRow != null)
            {
                tbxUpdateProductName.Text = dgwProduct.CurrentRow.Cells[2].Value.ToString();
                cbxUpdateCategoryId.SelectedValue = dgwProduct.CurrentRow.Cells[1].Value;
                tbxUpdateUnitPrice.Text = dgwProduct.CurrentRow.Cells[3].Value.ToString();
                tbxUpdateUnitsInStock.Text = dgwProduct.CurrentRow.Cells[4].Value.ToString();
                tbxUpdateQuantityPerUnit.Text = dgwProduct.CurrentRow.Cells[5].Value.ToString();
            }
        }

        private void LoadCatalog()
        {
            dgwProduct.DataSource = _categoryService.GetAll();
        }

        private void LoadProducts()
        {
            dgwProduct.DataSource = _productMeneger.GetAll();
        }

        private void LoadCbx(ComboBox comboBox,string categoryname,string categoryıd)
        {
            comboBox.DataSource = _categoryService.GetAll();
            comboBox.DisplayMember = categoryname;
            comboBox.ValueMember = categoryıd;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadCbx(cbxSearchByCategories, "CategoryName", "CategoryId");
            LoadCbx(cbxUpdateCategoryId, "CategoryName", "CategoryId");
            LoadCbx(cbxAddCategoryId, "CategoryName", "CategoryId");
        }

        private void UpdateProduct()
        {
            if (dgwProduct.CurrentRow != null)
                _productMeneger.UpdateProduct(new Product()
                {
                    ProductID = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value),
                    CategoryID = Convert.ToInt32(cbxUpdateCategoryId.SelectedValue),
                    ProductName = tbxUpdateProductName.Text,
                    UnitPrice = Convert.ToDecimal(tbxUpdateUnitPrice.Text),
                    UnitsInStock = Convert.ToInt16(tbxUpdateUnitsInStock.Text),
                    QuantityPerUnit = tbxUpdateQuantityPerUnit.Text,
                });
            MessageBox.Show("The Product Has Been Updated");
            LoadProducts();
        }
        private void SearchByName()
        {
            dgwProduct.DataSource = _productMeneger.GetByName(tbxSearchByProductName.Text);
        }

        private void dgwProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadUpdateTexts();
        }

        private void SearchByCategoryID()
        {
            try
            {
                dgwProduct.DataSource = _productMeneger.SearchByCategoryId(Convert.ToInt32(cbxSearchByCategories.SelectedValue));
            }
            catch
            {

            }
        }

        private void AddProduct()
        {
            if (dgwProduct.CurrentRow != null)
                _productMeneger.AddProduct(new Product()
                {
                    ProductID = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value),
                    CategoryID = Convert.ToInt32(cbxAddCategoryId.SelectedValue),
                    ProductName = tbxAddProductName.Text,
                    UnitPrice = Convert.ToDecimal(tbxAddUnitPrice.Text),
                    UnitsInStock = Convert.ToInt16(tbxAddUnitInStock.Text),
                    QuantityPerUnit = tbxAddQuantityPerUnit.Text
                });

            MessageBox.Show("The Product Has been Added");
            LoadProducts();
        }

        private void tbxSearchByProductName_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbxSearchByProductName.Text))
            {
                SearchByName();
            }
            else
            {
                LoadProducts();
            }
        }

        private void cbxSearchByCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchByCategoryID();
        }

        private void btnResetData_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void DeleteProduct()
        {
            if (dgwProduct.CurrentRow != null) 
            {
                try
                {
                    _productMeneger.DeleteProduct(new Product()
                    {
                        ProductID = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value),
                    });
                    MessageBox.Show("The Product Has been Deleted");
                    LoadProducts();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            AddProduct();
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            UpdateProduct();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteProduct();
        }
    }
}
