using Data_FishingBee.Models;
using Data_FishingBee.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FishingBee_CounterSales.Views
{
    public partial class ProductManager : Form
    {
        ProductRepositories _pRepo;
        ProductDetailRepositories _pdRepo;
        public ProductManager()
        {
            InitializeComponent();
        }

        public ProductManager(ProductRepositories pRepo, ProductDetailRepositories pdRepo)
        {
            _pRepo = pRepo;
            _pdRepo = pdRepo;
        }

        public async void LoadDGV()
        {
            var products = await _pRepo.GetAll();
            var productDetails = await _pdRepo.GetAll();

            var lstMain = from p in products
                          join pd in productDetails
                          on p.Id equals pd.ProductId
                          select
                          new
                          {
                              Name = p.Name,
                              CategoryName = p.CategoryName,
                              Price = pd.Price,
                              Stock = pd.Stock,
                              Color = pd.Color,
                              Length = pd.Length,
                              Material = pd.Material,
                              Weigth = pd.Weight,
                              Description = pd.Description
                             
                          };
            dgv_lstProduct.DataSource = lstMain.ToList();
        }
        private void ProductManager_Load(object sender, EventArgs e)
        {
            LoadDGV();
        }
        private void dgv_lstProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu người dùng click vào một ô hợp lệ (tránh trường hợp header row bị click)
            if (e.RowIndex >= 0)
            {
                // Lấy hàng hiện tại (current row)
                DataGridViewRow row = dgv_lstProduct.Rows[e.RowIndex];

                // Lấy các giá trị từ hàng và hiển thị chúng
                string name = row.Cells["Name"].Value.ToString();
                string categoryName = row.Cells["CategoryName"].Value.ToString();
                decimal price = Convert.ToDecimal(row.Cells["Price"].Value);
                int stock = Convert.ToInt32(row.Cells["Stock"].Value);
                string color = row.Cells["Color"].Value.ToString();
                decimal length = Convert.ToDecimal(row.Cells["Length"].Value);
                string material = row.Cells["Material"].Value.ToString();
                decimal weight = Convert.ToDecimal(row.Cells["Weigth"].Value);
                string description = row.Cells["Description"].Value.ToString();

                //// Hiển thị thông tin
                //MessageBox.Show($"Name: {name}\n" +
                //                $"Category Name: {categoryName}\n" +
                //                $"Price: {price}\n" +
                //                $"Stock: {stock}\n" +
                //                $"Color: {color}\n" +
                //                $"Length: {length}\n" +
                //                $"Material: {material}\n" +
                //                $"Weight: {weight}\n" +
                //                $"Description: {description}",
                //                "Product Details",
                //                MessageBoxButtons.OK,
                //                MessageBoxIcon.Information);
            }
        }

      
    }
}
