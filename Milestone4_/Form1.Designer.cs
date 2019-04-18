namespace Milestone4_
{
    partial class Form1
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.viewTab = new System.Windows.Forms.TabPage();
            this.btn_updateGrid = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox_searchBrand = new System.Windows.Forms.CheckBox();
            this.checkBox_searchPrice = new System.Windows.Forms.CheckBox();
            this.comboBox_brandSearch = new System.Windows.Forms.ComboBox();
            this.textBox_highPriceSearch = new System.Windows.Forms.TextBox();
            this.textBox_lowPriceSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_low = new System.Windows.Forms.Label();
            this.label_high = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.addRemoveProduct = new System.Windows.Forms.TabPage();
            this.comboBox_removeProductID = new System.Windows.Forms.ComboBox();
            this.label_removeID = new System.Windows.Forms.Label();
            this.btn_removeProduct = new System.Windows.Forms.Button();
            this.btn_addProduct = new System.Windows.Forms.Button();
            this.richTextBox_newDescription = new System.Windows.Forms.RichTextBox();
            this.label_newDescription = new System.Windows.Forms.Label();
            this.textBox_newPrice = new System.Windows.Forms.TextBox();
            this.label_newPrice = new System.Windows.Forms.Label();
            this.textBox_newStock = new System.Windows.Forms.TextBox();
            this.label_newStock = new System.Windows.Forms.Label();
            this.textBox_newBrand = new System.Windows.Forms.TextBox();
            this.textBox_newName = new System.Windows.Forms.TextBox();
            this.label_newName = new System.Windows.Forms.Label();
            this.label_newBrand = new System.Windows.Forms.Label();
            this.addRemoveStock = new System.Windows.Forms.TabPage();
            this.comboBox_stockToAddRemove = new System.Windows.Forms.ComboBox();
            this.btn_addRemove = new System.Windows.Forms.Button();
            this.label_stock = new System.Windows.Forms.Label();
            this.label_currentStock = new System.Windows.Forms.Label();
            this.label_amntAddRemove = new System.Windows.Forms.Label();
            this.comboBox_addRemove = new System.Windows.Forms.ComboBox();
            this.label_addRemove = new System.Windows.Forms.Label();
            this.comboBox_productToAddRemove = new System.Windows.Forms.ComboBox();
            this.label_productToAddRemove = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabControl.SuspendLayout();
            this.viewTab.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.addRemoveProduct.SuspendLayout();
            this.addRemoveStock.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.viewTab);
            this.tabControl.Controls.Add(this.addRemoveProduct);
            this.tabControl.Controls.Add(this.addRemoveStock);
            this.tabControl.Location = new System.Drawing.Point(46, 24);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(664, 410);
            this.tabControl.TabIndex = 0;
            // 
            // viewTab
            // 
            this.viewTab.Controls.Add(this.btn_updateGrid);
            this.viewTab.Controls.Add(this.groupBox1);
            this.viewTab.Controls.Add(this.dataGridView);
            this.viewTab.Location = new System.Drawing.Point(4, 22);
            this.viewTab.Name = "viewTab";
            this.viewTab.Padding = new System.Windows.Forms.Padding(3);
            this.viewTab.Size = new System.Drawing.Size(656, 384);
            this.viewTab.TabIndex = 0;
            this.viewTab.Text = "View Inventory";
            this.viewTab.UseVisualStyleBackColor = true;
            // 
            // btn_updateGrid
            // 
            this.btn_updateGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_updateGrid.Location = new System.Drawing.Point(474, 266);
            this.btn_updateGrid.Name = "btn_updateGrid";
            this.btn_updateGrid.Size = new System.Drawing.Size(156, 74);
            this.btn_updateGrid.TabIndex = 6;
            this.btn_updateGrid.Text = "Update Grid";
            this.btn_updateGrid.UseVisualStyleBackColor = true;
            this.btn_updateGrid.Click += new System.EventHandler(this.btn_updateGrid_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox_searchBrand);
            this.groupBox1.Controls.Add(this.checkBox_searchPrice);
            this.groupBox1.Controls.Add(this.comboBox_brandSearch);
            this.groupBox1.Controls.Add(this.textBox_highPriceSearch);
            this.groupBox1.Controls.Add(this.textBox_lowPriceSearch);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label_low);
            this.groupBox1.Controls.Add(this.label_high);
            this.groupBox1.Location = new System.Drawing.Point(21, 250);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(432, 126);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // checkBox_searchBrand
            // 
            this.checkBox_searchBrand.AutoSize = true;
            this.checkBox_searchBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_searchBrand.Location = new System.Drawing.Point(18, 83);
            this.checkBox_searchBrand.Name = "checkBox_searchBrand";
            this.checkBox_searchBrand.Size = new System.Drawing.Size(66, 20);
            this.checkBox_searchBrand.TabIndex = 10;
            this.checkBox_searchBrand.Text = "Brand:";
            this.checkBox_searchBrand.UseVisualStyleBackColor = true;
            // 
            // checkBox_searchPrice
            // 
            this.checkBox_searchPrice.AutoSize = true;
            this.checkBox_searchPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_searchPrice.Location = new System.Drawing.Point(18, 49);
            this.checkBox_searchPrice.Name = "checkBox_searchPrice";
            this.checkBox_searchPrice.Size = new System.Drawing.Size(61, 20);
            this.checkBox_searchPrice.TabIndex = 9;
            this.checkBox_searchPrice.Text = "Price:";
            this.checkBox_searchPrice.UseVisualStyleBackColor = true;
            // 
            // comboBox_brandSearch
            // 
            this.comboBox_brandSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_brandSearch.FormattingEnabled = true;
            this.comboBox_brandSearch.Location = new System.Drawing.Point(108, 83);
            this.comboBox_brandSearch.Name = "comboBox_brandSearch";
            this.comboBox_brandSearch.Size = new System.Drawing.Size(121, 21);
            this.comboBox_brandSearch.TabIndex = 8;
            // 
            // textBox_highPriceSearch
            // 
            this.textBox_highPriceSearch.Location = new System.Drawing.Point(309, 46);
            this.textBox_highPriceSearch.Name = "textBox_highPriceSearch";
            this.textBox_highPriceSearch.Size = new System.Drawing.Size(100, 20);
            this.textBox_highPriceSearch.TabIndex = 7;
            // 
            // textBox_lowPriceSearch
            // 
            this.textBox_lowPriceSearch.Location = new System.Drawing.Point(146, 46);
            this.textBox_lowPriceSearch.Name = "textBox_lowPriceSearch";
            this.textBox_lowPriceSearch.Size = new System.Drawing.Size(100, 20);
            this.textBox_lowPriceSearch.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Search";
            // 
            // label_low
            // 
            this.label_low.AutoSize = true;
            this.label_low.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_low.Location = new System.Drawing.Point(105, 50);
            this.label_low.Name = "label_low";
            this.label_low.Size = new System.Drawing.Size(35, 16);
            this.label_low.TabIndex = 1;
            this.label_low.Text = "Low:";
            // 
            // label_high
            // 
            this.label_high.AutoSize = true;
            this.label_high.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_high.Location = new System.Drawing.Point(264, 50);
            this.label_high.Name = "label_high";
            this.label_high.Size = new System.Drawing.Size(39, 16);
            this.label_high.TabIndex = 3;
            this.label_high.Text = "High:";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(6, 6);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(644, 238);
            this.dataGridView.TabIndex = 0;
            // 
            // addRemoveProduct
            // 
            this.addRemoveProduct.Controls.Add(this.comboBox_removeProductID);
            this.addRemoveProduct.Controls.Add(this.label_removeID);
            this.addRemoveProduct.Controls.Add(this.btn_removeProduct);
            this.addRemoveProduct.Controls.Add(this.btn_addProduct);
            this.addRemoveProduct.Controls.Add(this.richTextBox_newDescription);
            this.addRemoveProduct.Controls.Add(this.label_newDescription);
            this.addRemoveProduct.Controls.Add(this.textBox_newPrice);
            this.addRemoveProduct.Controls.Add(this.label_newPrice);
            this.addRemoveProduct.Controls.Add(this.textBox_newStock);
            this.addRemoveProduct.Controls.Add(this.label_newStock);
            this.addRemoveProduct.Controls.Add(this.textBox_newBrand);
            this.addRemoveProduct.Controls.Add(this.textBox_newName);
            this.addRemoveProduct.Controls.Add(this.label_newName);
            this.addRemoveProduct.Controls.Add(this.label_newBrand);
            this.addRemoveProduct.Location = new System.Drawing.Point(4, 22);
            this.addRemoveProduct.Name = "addRemoveProduct";
            this.addRemoveProduct.Padding = new System.Windows.Forms.Padding(3);
            this.addRemoveProduct.Size = new System.Drawing.Size(656, 384);
            this.addRemoveProduct.TabIndex = 1;
            this.addRemoveProduct.Text = "Add/Remove Product";
            this.addRemoveProduct.UseVisualStyleBackColor = true;
            // 
            // comboBox_removeProductID
            // 
            this.comboBox_removeProductID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_removeProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_removeProductID.FormattingEnabled = true;
            this.comboBox_removeProductID.Location = new System.Drawing.Point(114, 224);
            this.comboBox_removeProductID.Name = "comboBox_removeProductID";
            this.comboBox_removeProductID.Size = new System.Drawing.Size(407, 32);
            this.comboBox_removeProductID.TabIndex = 23;
            // 
            // label_removeID
            // 
            this.label_removeID.AutoSize = true;
            this.label_removeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_removeID.Location = new System.Drawing.Point(20, 224);
            this.label_removeID.Name = "label_removeID";
            this.label_removeID.Size = new System.Drawing.Size(80, 24);
            this.label_removeID.TabIndex = 20;
            this.label_removeID.Text = "Product:";
            // 
            // btn_removeProduct
            // 
            this.btn_removeProduct.Location = new System.Drawing.Point(545, 224);
            this.btn_removeProduct.Name = "btn_removeProduct";
            this.btn_removeProduct.Size = new System.Drawing.Size(77, 54);
            this.btn_removeProduct.TabIndex = 19;
            this.btn_removeProduct.Text = "Remove";
            this.btn_removeProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_removeProduct.UseVisualStyleBackColor = true;
            this.btn_removeProduct.Click += new System.EventHandler(this.btn_removeProduct_Click);
            // 
            // btn_addProduct
            // 
            this.btn_addProduct.Location = new System.Drawing.Point(545, 69);
            this.btn_addProduct.Name = "btn_addProduct";
            this.btn_addProduct.Size = new System.Drawing.Size(77, 54);
            this.btn_addProduct.TabIndex = 18;
            this.btn_addProduct.Text = "Add";
            this.btn_addProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_addProduct.UseVisualStyleBackColor = true;
            this.btn_addProduct.Click += new System.EventHandler(this.btn_addProduct_Click);
            // 
            // richTextBox_newDescription
            // 
            this.richTextBox_newDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_newDescription.Location = new System.Drawing.Point(378, 88);
            this.richTextBox_newDescription.Name = "richTextBox_newDescription";
            this.richTextBox_newDescription.Size = new System.Drawing.Size(143, 85);
            this.richTextBox_newDescription.TabIndex = 17;
            this.richTextBox_newDescription.Text = "";
            // 
            // label_newDescription
            // 
            this.label_newDescription.AutoSize = true;
            this.label_newDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_newDescription.Location = new System.Drawing.Point(263, 82);
            this.label_newDescription.Name = "label_newDescription";
            this.label_newDescription.Size = new System.Drawing.Size(109, 24);
            this.label_newDescription.TabIndex = 16;
            this.label_newDescription.Text = "Description:";
            // 
            // textBox_newPrice
            // 
            this.textBox_newPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_newPrice.Location = new System.Drawing.Point(378, 40);
            this.textBox_newPrice.Name = "textBox_newPrice";
            this.textBox_newPrice.Size = new System.Drawing.Size(143, 29);
            this.textBox_newPrice.TabIndex = 15;
            // 
            // label_newPrice
            // 
            this.label_newPrice.AutoSize = true;
            this.label_newPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_newPrice.Location = new System.Drawing.Point(312, 43);
            this.label_newPrice.Name = "label_newPrice";
            this.label_newPrice.Size = new System.Drawing.Size(58, 24);
            this.label_newPrice.TabIndex = 14;
            this.label_newPrice.Text = "Price:";
            // 
            // textBox_newStock
            // 
            this.textBox_newStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_newStock.Location = new System.Drawing.Point(106, 124);
            this.textBox_newStock.Name = "textBox_newStock";
            this.textBox_newStock.Size = new System.Drawing.Size(143, 29);
            this.textBox_newStock.TabIndex = 13;
            // 
            // label_newStock
            // 
            this.label_newStock.AutoSize = true;
            this.label_newStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_newStock.Location = new System.Drawing.Point(39, 127);
            this.label_newStock.Name = "label_newStock";
            this.label_newStock.Size = new System.Drawing.Size(61, 24);
            this.label_newStock.TabIndex = 12;
            this.label_newStock.Text = "Stock:";
            // 
            // textBox_newBrand
            // 
            this.textBox_newBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_newBrand.Location = new System.Drawing.Point(106, 85);
            this.textBox_newBrand.Name = "textBox_newBrand";
            this.textBox_newBrand.Size = new System.Drawing.Size(143, 29);
            this.textBox_newBrand.TabIndex = 11;
            // 
            // textBox_newName
            // 
            this.textBox_newName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_newName.Location = new System.Drawing.Point(106, 46);
            this.textBox_newName.Name = "textBox_newName";
            this.textBox_newName.Size = new System.Drawing.Size(143, 29);
            this.textBox_newName.TabIndex = 10;
            // 
            // label_newName
            // 
            this.label_newName.AutoSize = true;
            this.label_newName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_newName.Location = new System.Drawing.Point(34, 49);
            this.label_newName.Name = "label_newName";
            this.label_newName.Size = new System.Drawing.Size(66, 24);
            this.label_newName.TabIndex = 8;
            this.label_newName.Text = "Name:";
            // 
            // label_newBrand
            // 
            this.label_newBrand.AutoSize = true;
            this.label_newBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_newBrand.Location = new System.Drawing.Point(35, 88);
            this.label_newBrand.Name = "label_newBrand";
            this.label_newBrand.Size = new System.Drawing.Size(65, 24);
            this.label_newBrand.TabIndex = 9;
            this.label_newBrand.Text = "Brand:";
            // 
            // addRemoveStock
            // 
            this.addRemoveStock.Controls.Add(this.comboBox_stockToAddRemove);
            this.addRemoveStock.Controls.Add(this.btn_addRemove);
            this.addRemoveStock.Controls.Add(this.label_stock);
            this.addRemoveStock.Controls.Add(this.label_currentStock);
            this.addRemoveStock.Controls.Add(this.label_amntAddRemove);
            this.addRemoveStock.Controls.Add(this.comboBox_addRemove);
            this.addRemoveStock.Controls.Add(this.label_addRemove);
            this.addRemoveStock.Controls.Add(this.comboBox_productToAddRemove);
            this.addRemoveStock.Controls.Add(this.label_productToAddRemove);
            this.addRemoveStock.Location = new System.Drawing.Point(4, 22);
            this.addRemoveStock.Name = "addRemoveStock";
            this.addRemoveStock.Padding = new System.Windows.Forms.Padding(3);
            this.addRemoveStock.Size = new System.Drawing.Size(656, 384);
            this.addRemoveStock.TabIndex = 2;
            this.addRemoveStock.Text = "Add/Remove Stock";
            this.addRemoveStock.UseVisualStyleBackColor = true;
            // 
            // comboBox_stockToAddRemove
            // 
            this.comboBox_stockToAddRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_stockToAddRemove.FormattingEnabled = true;
            this.comboBox_stockToAddRemove.Items.AddRange(new object[] {
            "1",
            "5",
            "10",
            "50",
            "100",
            "500"});
            this.comboBox_stockToAddRemove.Location = new System.Drawing.Point(183, 157);
            this.comboBox_stockToAddRemove.Name = "comboBox_stockToAddRemove";
            this.comboBox_stockToAddRemove.Size = new System.Drawing.Size(153, 28);
            this.comboBox_stockToAddRemove.TabIndex = 9;
            // 
            // btn_addRemove
            // 
            this.btn_addRemove.Location = new System.Drawing.Point(374, 107);
            this.btn_addRemove.Name = "btn_addRemove";
            this.btn_addRemove.Size = new System.Drawing.Size(131, 87);
            this.btn_addRemove.TabIndex = 8;
            this.btn_addRemove.Text = "Add/Remove";
            this.btn_addRemove.UseVisualStyleBackColor = true;
            this.btn_addRemove.Click += new System.EventHandler(this.btn_addRemove_Click);
            // 
            // label_stock
            // 
            this.label_stock.AutoSize = true;
            this.label_stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_stock.Location = new System.Drawing.Point(142, 65);
            this.label_stock.Name = "label_stock";
            this.label_stock.Size = new System.Drawing.Size(18, 20);
            this.label_stock.TabIndex = 7;
            this.label_stock.Text = "_";
            // 
            // label_currentStock
            // 
            this.label_currentStock.AutoSize = true;
            this.label_currentStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_currentStock.Location = new System.Drawing.Point(25, 65);
            this.label_currentStock.Name = "label_currentStock";
            this.label_currentStock.Size = new System.Drawing.Size(111, 20);
            this.label_currentStock.TabIndex = 6;
            this.label_currentStock.Text = "Current Stock:";
            // 
            // label_amntAddRemove
            // 
            this.label_amntAddRemove.AutoSize = true;
            this.label_amntAddRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_amntAddRemove.Location = new System.Drawing.Point(108, 157);
            this.label_amntAddRemove.Name = "label_amntAddRemove";
            this.label_amntAddRemove.Size = new System.Drawing.Size(69, 20);
            this.label_amntAddRemove.TabIndex = 5;
            this.label_amntAddRemove.Text = "Amount:";
            // 
            // comboBox_addRemove
            // 
            this.comboBox_addRemove.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_addRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_addRemove.FormattingEnabled = true;
            this.comboBox_addRemove.Items.AddRange(new object[] {
            "Add",
            "Remove"});
            this.comboBox_addRemove.Location = new System.Drawing.Point(183, 116);
            this.comboBox_addRemove.Name = "comboBox_addRemove";
            this.comboBox_addRemove.Size = new System.Drawing.Size(153, 28);
            this.comboBox_addRemove.TabIndex = 3;
            // 
            // label_addRemove
            // 
            this.label_addRemove.AutoSize = true;
            this.label_addRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_addRemove.Location = new System.Drawing.Point(27, 116);
            this.label_addRemove.Name = "label_addRemove";
            this.label_addRemove.Size = new System.Drawing.Size(150, 20);
            this.label_addRemove.TabIndex = 2;
            this.label_addRemove.Text = "Add/Remove Stock:";
            // 
            // comboBox_productToAddRemove
            // 
            this.comboBox_productToAddRemove.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_productToAddRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_productToAddRemove.FormattingEnabled = true;
            this.comboBox_productToAddRemove.Location = new System.Drawing.Point(98, 22);
            this.comboBox_productToAddRemove.Name = "comboBox_productToAddRemove";
            this.comboBox_productToAddRemove.Size = new System.Drawing.Size(527, 28);
            this.comboBox_productToAddRemove.TabIndex = 1;
            // 
            // label_productToAddRemove
            // 
            this.label_productToAddRemove.AutoSize = true;
            this.label_productToAddRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_productToAddRemove.Location = new System.Drawing.Point(25, 25);
            this.label_productToAddRemove.Name = "label_productToAddRemove";
            this.label_productToAddRemove.Size = new System.Drawing.Size(68, 20);
            this.label_productToAddRemove.TabIndex = 0;
            this.label_productToAddRemove.Text = "Product:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 467);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl.ResumeLayout(false);
            this.viewTab.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.addRemoveProduct.ResumeLayout(false);
            this.addRemoveProduct.PerformLayout();
            this.addRemoveStock.ResumeLayout(false);
            this.addRemoveStock.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage viewTab;
        private System.Windows.Forms.TabPage addRemoveProduct;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox_brandSearch;
        private System.Windows.Forms.TextBox textBox_highPriceSearch;
        private System.Windows.Forms.TextBox textBox_lowPriceSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_low;
        private System.Windows.Forms.Label label_high;
        private System.Windows.Forms.Button btn_updateGrid;
        private System.Windows.Forms.TextBox textBox_newBrand;
        private System.Windows.Forms.TextBox textBox_newName;
        private System.Windows.Forms.Label label_newName;
        private System.Windows.Forms.Label label_newBrand;
        private System.Windows.Forms.TextBox textBox_newStock;
        private System.Windows.Forms.Label label_newStock;
        private System.Windows.Forms.TabPage addRemoveStock;
        private System.Windows.Forms.TextBox textBox_newPrice;
        private System.Windows.Forms.Label label_newPrice;
        private System.Windows.Forms.RichTextBox richTextBox_newDescription;
        private System.Windows.Forms.Label label_newDescription;
        private System.Windows.Forms.Label label_amntAddRemove;
        private System.Windows.Forms.ComboBox comboBox_addRemove;
        private System.Windows.Forms.Label label_addRemove;
        private System.Windows.Forms.ComboBox comboBox_productToAddRemove;
        private System.Windows.Forms.Label label_productToAddRemove;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btn_addProduct;
        private System.Windows.Forms.Label label_currentStock;
        private System.Windows.Forms.Label label_stock;
        private System.Windows.Forms.Button btn_addRemove;
        private System.Windows.Forms.CheckBox checkBox_searchBrand;
        private System.Windows.Forms.CheckBox checkBox_searchPrice;
        private System.Windows.Forms.ComboBox comboBox_removeProductID;
        private System.Windows.Forms.Label label_removeID;
        private System.Windows.Forms.Button btn_removeProduct;
        private System.Windows.Forms.ComboBox comboBox_stockToAddRemove;
    }
}

