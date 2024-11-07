namespace FishingBee_CounterSales.Views
{
    partial class ProductManager
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
            dgv_lstProduct = new DataGridView();
            txt_Name = new TextBox();
            btn_Create = new Button();
            btn_Update = new Button();
            btn_Delete = new Button();
            btn_Detail = new Button();
            btn_AddOrder = new Button();
            label1 = new Label();
            label2 = new Label();
            cbo_Category = new ComboBox();
            txt_Price = new TextBox();
            label3 = new Label();
            txt_Descriptions = new TextBox();
            label4 = new Label();
            txt_Length = new TextBox();
            txt_Material = new TextBox();
            txt_Weight = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label9 = new Label();
            label10 = new Label();
            txt_Manufacturer = new TextBox();
            txt_Color = new TextBox();
            txt_Quantity = new TextBox();
            label5 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_lstProduct).BeginInit();
            SuspendLayout();
            // 
            // dgv_lstProduct
            // 
            dgv_lstProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_lstProduct.Location = new Point(12, 300);
            dgv_lstProduct.Name = "dgv_lstProduct";
            dgv_lstProduct.RowHeadersWidth = 51;
            dgv_lstProduct.RowTemplate.Height = 29;
            dgv_lstProduct.Size = new Size(1398, 441);
            dgv_lstProduct.TabIndex = 0;
            dgv_lstProduct.CellContentClick += dgv_lstProduct_CellContentClick;
            // 
            // txt_Name
            // 
            txt_Name.Location = new Point(133, 12);
            txt_Name.Name = "txt_Name";
            txt_Name.Size = new Size(221, 27);
            txt_Name.TabIndex = 1;
            // 
            // btn_Create
            // 
            btn_Create.Location = new Point(791, 49);
            btn_Create.Name = "btn_Create";
            btn_Create.Size = new Size(137, 46);
            btn_Create.TabIndex = 2;
            btn_Create.Text = "Tạo mới";
            btn_Create.UseVisualStyleBackColor = true;
            // 
            // btn_Update
            // 
            btn_Update.Location = new Point(934, 49);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(137, 46);
            btn_Update.TabIndex = 2;
            btn_Update.Text = "Sửa sản phẩm";
            btn_Update.UseVisualStyleBackColor = true;
            // 
            // btn_Delete
            // 
            btn_Delete.Location = new Point(791, 101);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(137, 46);
            btn_Delete.TabIndex = 2;
            btn_Delete.Text = "Xóa sản phẩm";
            btn_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_Detail
            // 
            btn_Detail.Location = new Point(934, 101);
            btn_Detail.Name = "btn_Detail";
            btn_Detail.Size = new Size(137, 46);
            btn_Detail.TabIndex = 2;
            btn_Detail.Text = "Chi tiết sản phẩm";
            btn_Detail.UseVisualStyleBackColor = true;
            // 
            // btn_AddOrder
            // 
            btn_AddOrder.Location = new Point(791, 153);
            btn_AddOrder.Name = "btn_AddOrder";
            btn_AddOrder.Size = new Size(280, 46);
            btn_AddOrder.TabIndex = 2;
            btn_AddOrder.Text = "Tạo hóa đơn";
            btn_AddOrder.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 3;
            label1.Text = "Tên sản phẩm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 62);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 3;
            label2.Text = "Danh mục";
            // 
            // cbo_Category
            // 
            cbo_Category.FormattingEnabled = true;
            cbo_Category.Items.AddRange(new object[] { "Cần câu,", "Phao,", "Lưỡi câu,", "Dây câu" });
            cbo_Category.Location = new Point(133, 54);
            cbo_Category.Name = "cbo_Category";
            cbo_Category.Size = new Size(221, 28);
            cbo_Category.TabIndex = 4;
            // 
            // txt_Price
            // 
            txt_Price.Location = new Point(133, 107);
            txt_Price.Name = "txt_Price";
            txt_Price.Size = new Size(221, 27);
            txt_Price.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 159);
            label3.Name = "label3";
            label3.Size = new Size(118, 20);
            label3.TabIndex = 3;
            label3.Text = "Mô tả Sản phẩm";
            // 
            // txt_Descriptions
            // 
            txt_Descriptions.Location = new Point(133, 156);
            txt_Descriptions.Name = "txt_Descriptions";
            txt_Descriptions.Size = new Size(221, 27);
            txt_Descriptions.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 208);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 3;
            label4.Text = "Màu sắc";
            // 
            // txt_Length
            // 
            txt_Length.Location = new Point(513, 12);
            txt_Length.Name = "txt_Length";
            txt_Length.Size = new Size(221, 27);
            txt_Length.TabIndex = 1;
            // 
            // txt_Material
            // 
            txt_Material.Location = new Point(513, 107);
            txt_Material.Name = "txt_Material";
            txt_Material.Size = new Size(221, 27);
            txt_Material.TabIndex = 1;
            // 
            // txt_Weight
            // 
            txt_Weight.Location = new Point(513, 156);
            txt_Weight.Name = "txt_Weight";
            txt_Weight.Size = new Size(221, 27);
            txt_Weight.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(405, 19);
            label6.Name = "label6";
            label6.Size = new Size(54, 20);
            label6.TabIndex = 3;
            label6.Text = "Độ dài";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(407, 114);
            label7.Name = "label7";
            label7.Size = new Size(67, 20);
            label7.TabIndex = 3;
            label7.Text = "Chất liệu";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(407, 159);
            label9.Name = "label9";
            label9.Size = new Size(82, 20);
            label9.TabIndex = 3;
            label9.Text = "Khối lượng";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(405, 62);
            label10.Name = "label10";
            label10.Size = new Size(94, 20);
            label10.TabIndex = 3;
            label10.Text = "Nhà sản xuất";
            // 
            // txt_Manufacturer
            // 
            txt_Manufacturer.Location = new Point(513, 55);
            txt_Manufacturer.Name = "txt_Manufacturer";
            txt_Manufacturer.Size = new Size(221, 27);
            txt_Manufacturer.TabIndex = 1;
            // 
            // txt_Color
            // 
            txt_Color.Location = new Point(133, 205);
            txt_Color.Name = "txt_Color";
            txt_Color.Size = new Size(221, 27);
            txt_Color.TabIndex = 1;
            // 
            // txt_Quantity
            // 
            txt_Quantity.Location = new Point(513, 205);
            txt_Quantity.Name = "txt_Quantity";
            txt_Quantity.Size = new Size(221, 27);
            txt_Quantity.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 114);
            label5.Name = "label5";
            label5.Size = new Size(31, 20);
            label5.TabIndex = 3;
            label5.Text = "Giá";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(407, 208);
            label8.Name = "label8";
            label8.Size = new Size(69, 20);
            label8.TabIndex = 3;
            label8.Text = "Số lượng";
            // 
            // ProductManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1422, 753);
            Controls.Add(cbo_Category);
            Controls.Add(label10);
            Controls.Add(label2);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(btn_Detail);
            Controls.Add(btn_AddOrder);
            Controls.Add(btn_Delete);
            Controls.Add(btn_Update);
            Controls.Add(btn_Create);
            Controls.Add(txt_Quantity);
            Controls.Add(txt_Color);
            Controls.Add(txt_Weight);
            Controls.Add(txt_Descriptions);
            Controls.Add(txt_Manufacturer);
            Controls.Add(txt_Material);
            Controls.Add(txt_Price);
            Controls.Add(txt_Length);
            Controls.Add(txt_Name);
            Controls.Add(dgv_lstProduct);
            Name = "ProductManager";
            Text = "ProductManager";
            Load += ProductManager_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_lstProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_lstProduct;
        private TextBox txt_Name;
        private Button btn_Create;
        private Button btn_Update;
        private Button btn_Delete;
        private Button btn_Detail;
        private Button btn_AddOrder;
        private Label label1;
        private Label label2;
        private ComboBox cbo_Category;
        private TextBox txt_Price;
        private Label label3;
        private TextBox txt_Descriptions;
        private Label label4;
        private TextBox txt_Length;
        private TextBox txt_Material;
        private TextBox txt_Weight;
        private Label label6;
        private Label label7;
        private Label label9;
        private Label label10;
        private TextBox txt_Manufacturer;
        private TextBox txt_Color;
        private TextBox txt_Quantity;
        private Label label5;
        private Label label8;
    }
}