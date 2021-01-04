namespace Docs_Haus
{
    partial class newProducts
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
            this.btn_products_remItem = new FontAwesome.Sharp.IconButton();
            this.txb_sales_value_cost = new MetroFramework.Controls.MetroTextBox();
            this.txb_sales_quant = new MetroFramework.Controls.MetroTextBox();
            this.txb_sales_products = new MetroFramework.Controls.MetroTextBox();
            this.btn_products_addItem = new FontAwesome.Sharp.IconButton();
            this.ListViewProducts = new MetroFramework.Controls.MetroListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txb_sales_code = new MetroFramework.Controls.MetroTextBox();
            this.btn_products_editItem = new FontAwesome.Sharp.IconButton();
            this.txb_sales_value_final = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // btn_products_remItem
            // 
            this.btn_products_remItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_products_remItem.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_products_remItem.FlatAppearance.BorderSize = 0;
            this.btn_products_remItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_products_remItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_products_remItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_products_remItem.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_products_remItem.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_products_remItem.ForeColor = System.Drawing.Color.White;
            this.btn_products_remItem.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btn_products_remItem.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(41)))), ((int)(((byte)(88)))));
            this.btn_products_remItem.IconSize = 37;
            this.btn_products_remItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_products_remItem.Location = new System.Drawing.Point(323, 391);
            this.btn_products_remItem.Name = "btn_products_remItem";
            this.btn_products_remItem.Rotation = 0D;
            this.btn_products_remItem.Size = new System.Drawing.Size(122, 42);
            this.btn_products_remItem.TabIndex = 6;
            this.btn_products_remItem.Text = "Remover";
            this.btn_products_remItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_products_remItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_products_remItem.UseVisualStyleBackColor = true;
            this.btn_products_remItem.Click += new System.EventHandler(this.btn_products_remItem_Click);
            // 
            // txb_sales_value_cost
            // 
            this.txb_sales_value_cost.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txb_sales_value_cost.CustomButton.Image = null;
            this.txb_sales_value_cost.CustomButton.Location = new System.Drawing.Point(62, 1);
            this.txb_sales_value_cost.CustomButton.Name = "";
            this.txb_sales_value_cost.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txb_sales_value_cost.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txb_sales_value_cost.CustomButton.TabIndex = 1;
            this.txb_sales_value_cost.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txb_sales_value_cost.CustomButton.UseSelectable = true;
            this.txb_sales_value_cost.CustomButton.Visible = false;
            this.txb_sales_value_cost.Lines = new string[0];
            this.txb_sales_value_cost.Location = new System.Drawing.Point(511, 367);
            this.txb_sales_value_cost.MaxLength = 32767;
            this.txb_sales_value_cost.Name = "txb_sales_value_cost";
            this.txb_sales_value_cost.PasswordChar = '\0';
            this.txb_sales_value_cost.PromptText = "Preço de custo";
            this.txb_sales_value_cost.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txb_sales_value_cost.SelectedText = "";
            this.txb_sales_value_cost.SelectionLength = 0;
            this.txb_sales_value_cost.SelectionStart = 0;
            this.txb_sales_value_cost.ShortcutsEnabled = true;
            this.txb_sales_value_cost.Size = new System.Drawing.Size(84, 23);
            this.txb_sales_value_cost.Style = MetroFramework.MetroColorStyle.Red;
            this.txb_sales_value_cost.TabIndex = 3;
            this.txb_sales_value_cost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txb_sales_value_cost.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txb_sales_value_cost.UseSelectable = true;
            this.txb_sales_value_cost.WaterMark = "Preço de custo";
            this.txb_sales_value_cost.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txb_sales_value_cost.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txb_sales_quant
            // 
            this.txb_sales_quant.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txb_sales_quant.CustomButton.Image = null;
            this.txb_sales_quant.CustomButton.Location = new System.Drawing.Point(55, 1);
            this.txb_sales_quant.CustomButton.Name = "";
            this.txb_sales_quant.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txb_sales_quant.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txb_sales_quant.CustomButton.TabIndex = 1;
            this.txb_sales_quant.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txb_sales_quant.CustomButton.UseSelectable = true;
            this.txb_sales_quant.CustomButton.Visible = false;
            this.txb_sales_quant.Lines = new string[0];
            this.txb_sales_quant.Location = new System.Drawing.Point(322, 367);
            this.txb_sales_quant.MaxLength = 32767;
            this.txb_sales_quant.Name = "txb_sales_quant";
            this.txb_sales_quant.PasswordChar = '\0';
            this.txb_sales_quant.PromptText = "Quant";
            this.txb_sales_quant.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txb_sales_quant.SelectedText = "";
            this.txb_sales_quant.SelectionLength = 0;
            this.txb_sales_quant.SelectionStart = 0;
            this.txb_sales_quant.ShortcutsEnabled = true;
            this.txb_sales_quant.Size = new System.Drawing.Size(77, 23);
            this.txb_sales_quant.Style = MetroFramework.MetroColorStyle.Red;
            this.txb_sales_quant.TabIndex = 1;
            this.txb_sales_quant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txb_sales_quant.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txb_sales_quant.UseSelectable = true;
            this.txb_sales_quant.WaterMark = "Quant";
            this.txb_sales_quant.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txb_sales_quant.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txb_sales_products
            // 
            this.txb_sales_products.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txb_sales_products.CustomButton.Image = null;
            this.txb_sales_products.CustomButton.Location = new System.Drawing.Point(242, 1);
            this.txb_sales_products.CustomButton.Name = "";
            this.txb_sales_products.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txb_sales_products.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txb_sales_products.CustomButton.TabIndex = 1;
            this.txb_sales_products.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txb_sales_products.CustomButton.UseSelectable = true;
            this.txb_sales_products.CustomButton.Visible = false;
            this.txb_sales_products.Lines = new string[0];
            this.txb_sales_products.Location = new System.Drawing.Point(58, 367);
            this.txb_sales_products.MaxLength = 32767;
            this.txb_sales_products.Name = "txb_sales_products";
            this.txb_sales_products.PasswordChar = '\0';
            this.txb_sales_products.PromptText = "Produto";
            this.txb_sales_products.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txb_sales_products.SelectedText = "";
            this.txb_sales_products.SelectionLength = 0;
            this.txb_sales_products.SelectionStart = 0;
            this.txb_sales_products.ShortcutsEnabled = true;
            this.txb_sales_products.Size = new System.Drawing.Size(264, 23);
            this.txb_sales_products.Style = MetroFramework.MetroColorStyle.Red;
            this.txb_sales_products.TabIndex = 0;
            this.txb_sales_products.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txb_sales_products.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txb_sales_products.UseSelectable = true;
            this.txb_sales_products.WaterMark = "Produto";
            this.txb_sales_products.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txb_sales_products.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_products_addItem
            // 
            this.btn_products_addItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_products_addItem.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_products_addItem.FlatAppearance.BorderSize = 0;
            this.btn_products_addItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_products_addItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_products_addItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_products_addItem.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_products_addItem.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_products_addItem.ForeColor = System.Drawing.Color.White;
            this.btn_products_addItem.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.btn_products_addItem.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(41)))), ((int)(((byte)(88)))));
            this.btn_products_addItem.IconSize = 37;
            this.btn_products_addItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_products_addItem.Location = new System.Drawing.Point(202, 391);
            this.btn_products_addItem.Name = "btn_products_addItem";
            this.btn_products_addItem.Rotation = 0D;
            this.btn_products_addItem.Size = new System.Drawing.Size(122, 42);
            this.btn_products_addItem.TabIndex = 5;
            this.btn_products_addItem.Text = "Adicionar";
            this.btn_products_addItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_products_addItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_products_addItem.UseVisualStyleBackColor = true;
            this.btn_products_addItem.Click += new System.EventHandler(this.btn_products_addItem_Click);
            // 
            // ListViewProducts
            // 
            this.ListViewProducts.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.ListViewProducts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ListViewProducts.BackColor = System.Drawing.Color.Black;
            this.ListViewProducts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListViewProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.ListViewProducts.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ListViewProducts.FullRowSelect = true;
            this.ListViewProducts.Location = new System.Drawing.Point(58, 35);
            this.ListViewProducts.Name = "ListViewProducts";
            this.ListViewProducts.OwnerDraw = true;
            this.ListViewProducts.Size = new System.Drawing.Size(651, 331);
            this.ListViewProducts.Style = MetroFramework.MetroColorStyle.Red;
            this.ListViewProducts.TabIndex = 7;
            this.ListViewProducts.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ListViewProducts.UseCompatibleStateImageBehavior = false;
            this.ListViewProducts.UseCustomBackColor = true;
            this.ListViewProducts.UseSelectable = true;
            this.ListViewProducts.UseStyleColors = true;
            this.ListViewProducts.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Produtos";
            this.columnHeader1.Width = 164;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Quant";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 99;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Preço de Custo";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 121;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Preço Final";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 90;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Código";
            this.columnHeader5.Width = 92;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Investido";
            this.columnHeader6.Width = 83;
            // 
            // txb_sales_code
            // 
            this.txb_sales_code.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txb_sales_code.CustomButton.Image = null;
            this.txb_sales_code.CustomButton.Location = new System.Drawing.Point(90, 1);
            this.txb_sales_code.CustomButton.Name = "";
            this.txb_sales_code.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txb_sales_code.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txb_sales_code.CustomButton.TabIndex = 1;
            this.txb_sales_code.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txb_sales_code.CustomButton.UseSelectable = true;
            this.txb_sales_code.CustomButton.Visible = false;
            this.txb_sales_code.Lines = new string[0];
            this.txb_sales_code.Location = new System.Drawing.Point(399, 367);
            this.txb_sales_code.MaxLength = 32767;
            this.txb_sales_code.Name = "txb_sales_code";
            this.txb_sales_code.PasswordChar = '\0';
            this.txb_sales_code.PromptText = "Código";
            this.txb_sales_code.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txb_sales_code.SelectedText = "";
            this.txb_sales_code.SelectionLength = 0;
            this.txb_sales_code.SelectionStart = 0;
            this.txb_sales_code.ShortcutsEnabled = true;
            this.txb_sales_code.Size = new System.Drawing.Size(112, 23);
            this.txb_sales_code.Style = MetroFramework.MetroColorStyle.Red;
            this.txb_sales_code.TabIndex = 2;
            this.txb_sales_code.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txb_sales_code.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txb_sales_code.UseSelectable = true;
            this.txb_sales_code.WaterMark = "Código";
            this.txb_sales_code.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txb_sales_code.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_products_editItem
            // 
            this.btn_products_editItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_products_editItem.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_products_editItem.FlatAppearance.BorderSize = 0;
            this.btn_products_editItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_products_editItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_products_editItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_products_editItem.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_products_editItem.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_products_editItem.ForeColor = System.Drawing.Color.White;
            this.btn_products_editItem.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.btn_products_editItem.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(41)))), ((int)(((byte)(88)))));
            this.btn_products_editItem.IconSize = 37;
            this.btn_products_editItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_products_editItem.Location = new System.Drawing.Point(442, 391);
            this.btn_products_editItem.Name = "btn_products_editItem";
            this.btn_products_editItem.Rotation = 0D;
            this.btn_products_editItem.Size = new System.Drawing.Size(122, 42);
            this.btn_products_editItem.TabIndex = 7;
            this.btn_products_editItem.Text = "Alterar";
            this.btn_products_editItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_products_editItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_products_editItem.UseVisualStyleBackColor = true;
            this.btn_products_editItem.Click += new System.EventHandler(this.btn_products_editItem_Click);
            // 
            // txb_sales_value_final
            // 
            this.txb_sales_value_final.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txb_sales_value_final.CustomButton.Image = null;
            this.txb_sales_value_final.CustomButton.Location = new System.Drawing.Point(92, 1);
            this.txb_sales_value_final.CustomButton.Name = "";
            this.txb_sales_value_final.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txb_sales_value_final.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txb_sales_value_final.CustomButton.TabIndex = 1;
            this.txb_sales_value_final.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txb_sales_value_final.CustomButton.UseSelectable = true;
            this.txb_sales_value_final.CustomButton.Visible = false;
            this.txb_sales_value_final.Lines = new string[0];
            this.txb_sales_value_final.Location = new System.Drawing.Point(595, 367);
            this.txb_sales_value_final.MaxLength = 32767;
            this.txb_sales_value_final.Name = "txb_sales_value_final";
            this.txb_sales_value_final.PasswordChar = '\0';
            this.txb_sales_value_final.PromptText = "Preço final";
            this.txb_sales_value_final.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txb_sales_value_final.SelectedText = "";
            this.txb_sales_value_final.SelectionLength = 0;
            this.txb_sales_value_final.SelectionStart = 0;
            this.txb_sales_value_final.ShortcutsEnabled = true;
            this.txb_sales_value_final.Size = new System.Drawing.Size(114, 23);
            this.txb_sales_value_final.Style = MetroFramework.MetroColorStyle.Red;
            this.txb_sales_value_final.TabIndex = 4;
            this.txb_sales_value_final.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txb_sales_value_final.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txb_sales_value_final.UseSelectable = true;
            this.txb_sales_value_final.WaterMark = "Preço final";
            this.txb_sales_value_final.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txb_sales_value_final.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // newProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.Controls.Add(this.txb_sales_value_final);
            this.Controls.Add(this.btn_products_editItem);
            this.Controls.Add(this.txb_sales_code);
            this.Controls.Add(this.btn_products_remItem);
            this.Controls.Add(this.txb_sales_value_cost);
            this.Controls.Add(this.txb_sales_quant);
            this.Controls.Add(this.txb_sales_products);
            this.Controls.Add(this.btn_products_addItem);
            this.Controls.Add(this.ListViewProducts);
            this.Name = "newProducts";
            this.Size = new System.Drawing.Size(767, 469);
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btn_products_remItem;
        private MetroFramework.Controls.MetroTextBox txb_sales_value_cost;
        private MetroFramework.Controls.MetroTextBox txb_sales_quant;
        private MetroFramework.Controls.MetroTextBox txb_sales_products;
        private FontAwesome.Sharp.IconButton btn_products_addItem;
        private MetroFramework.Controls.MetroListView ListViewProducts;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private MetroFramework.Controls.MetroTextBox txb_sales_code;
        private FontAwesome.Sharp.IconButton btn_products_editItem;
        private MetroFramework.Controls.MetroTextBox txb_sales_value_final;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}
