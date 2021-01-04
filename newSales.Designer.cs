namespace Docs_Haus
{
    partial class newSales
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
            this.ListViewSales = new MetroFramework.Controls.MetroListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_saleAddItem = new FontAwesome.Sharp.IconButton();
            this.txb_sales_products = new MetroFramework.Controls.MetroTextBox();
            this.txb_sales_quant = new MetroFramework.Controls.MetroTextBox();
            this.txb_sales_value = new MetroFramework.Controls.MetroTextBox();
            this.btn_saleFinally = new FontAwesome.Sharp.IconButton();
            this.txb_sales_details = new MetroFramework.Controls.MetroTextBox();
            this.txb_sales_subTotal = new MetroFramework.Controls.MetroTextBox();
            this.txb_sales_inputClient = new MetroFramework.Controls.MetroTextBox();
            this.btn_saleRemovItem = new FontAwesome.Sharp.IconButton();
            this.txb_sales_client = new MetroFramework.Controls.MetroTextBox();
            this.cb_form_payment = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // ListViewSales
            // 
            this.ListViewSales.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.ListViewSales.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ListViewSales.BackColor = System.Drawing.Color.Black;
            this.ListViewSales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListViewSales.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.ListViewSales.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ListViewSales.FullRowSelect = true;
            this.ListViewSales.Location = new System.Drawing.Point(42, 17);
            this.ListViewSales.MultiSelect = false;
            this.ListViewSales.Name = "ListViewSales";
            this.ListViewSales.OwnerDraw = true;
            this.ListViewSales.Size = new System.Drawing.Size(682, 331);
            this.ListViewSales.Style = MetroFramework.MetroColorStyle.Red;
            this.ListViewSales.TabIndex = 9;
            this.ListViewSales.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ListViewSales.UseCompatibleStateImageBehavior = false;
            this.ListViewSales.UseCustomBackColor = true;
            this.ListViewSales.UseSelectable = true;
            this.ListViewSales.UseStyleColors = true;
            this.ListViewSales.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Produtos";
            this.columnHeader1.Width = 128;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Quant";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 58;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Código";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 70;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Valor";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Desconto";
            this.columnHeader5.Width = 81;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Detalhes";
            this.columnHeader6.Width = 158;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Cliente";
            this.columnHeader7.Width = 125;
            // 
            // btn_saleAddItem
            // 
            this.btn_saleAddItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_saleAddItem.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_saleAddItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_saleAddItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_saleAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_saleAddItem.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_saleAddItem.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saleAddItem.ForeColor = System.Drawing.Color.White;
            this.btn_saleAddItem.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.btn_saleAddItem.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(41)))), ((int)(((byte)(88)))));
            this.btn_saleAddItem.IconSize = 37;
            this.btn_saleAddItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_saleAddItem.Location = new System.Drawing.Point(201, 399);
            this.btn_saleAddItem.Name = "btn_saleAddItem";
            this.btn_saleAddItem.Rotation = 0D;
            this.btn_saleAddItem.Size = new System.Drawing.Size(122, 42);
            this.btn_saleAddItem.TabIndex = 8;
            this.btn_saleAddItem.Text = "Adicionar";
            this.btn_saleAddItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_saleAddItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_saleAddItem.UseVisualStyleBackColor = true;
            this.btn_saleAddItem.Click += new System.EventHandler(this.btn_saleAddItem_Click);
            // 
            // txb_sales_products
            // 
            this.txb_sales_products.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txb_sales_products.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txb_sales_products.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            // 
            // 
            // 
            this.txb_sales_products.CustomButton.Image = null;
            this.txb_sales_products.CustomButton.Location = new System.Drawing.Point(206, 1);
            this.txb_sales_products.CustomButton.Name = "";
            this.txb_sales_products.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txb_sales_products.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txb_sales_products.CustomButton.TabIndex = 1;
            this.txb_sales_products.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txb_sales_products.CustomButton.UseSelectable = true;
            this.txb_sales_products.CustomButton.Visible = false;
            this.txb_sales_products.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txb_sales_products.Lines = new string[0];
            this.txb_sales_products.Location = new System.Drawing.Point(248, 349);
            this.txb_sales_products.MaxLength = 32767;
            this.txb_sales_products.Name = "txb_sales_products";
            this.txb_sales_products.PasswordChar = '\0';
            this.txb_sales_products.PromptText = "Produto";
            this.txb_sales_products.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txb_sales_products.SelectedText = "";
            this.txb_sales_products.SelectionLength = 0;
            this.txb_sales_products.SelectionStart = 0;
            this.txb_sales_products.ShortcutsEnabled = true;
            this.txb_sales_products.Size = new System.Drawing.Size(228, 23);
            this.txb_sales_products.Style = MetroFramework.MetroColorStyle.Red;
            this.txb_sales_products.TabIndex = 1;
            this.txb_sales_products.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txb_sales_products.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txb_sales_products.UseSelectable = true;
            this.txb_sales_products.WaterMark = "Produto";
            this.txb_sales_products.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txb_sales_products.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.txb_sales_quant.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txb_sales_quant.Lines = new string[0];
            this.txb_sales_quant.Location = new System.Drawing.Point(474, 349);
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
            this.txb_sales_quant.TabIndex = 2;
            this.txb_sales_quant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txb_sales_quant.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txb_sales_quant.UseSelectable = true;
            this.txb_sales_quant.WaterMark = "Quant";
            this.txb_sales_quant.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txb_sales_quant.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txb_sales_value
            // 
            this.txb_sales_value.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txb_sales_value.CustomButton.Image = null;
            this.txb_sales_value.CustomButton.Location = new System.Drawing.Point(65, 1);
            this.txb_sales_value.CustomButton.Name = "";
            this.txb_sales_value.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txb_sales_value.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txb_sales_value.CustomButton.TabIndex = 1;
            this.txb_sales_value.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txb_sales_value.CustomButton.UseSelectable = true;
            this.txb_sales_value.CustomButton.Visible = false;
            this.txb_sales_value.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txb_sales_value.Lines = new string[0];
            this.txb_sales_value.Location = new System.Drawing.Point(549, 349);
            this.txb_sales_value.MaxLength = 32767;
            this.txb_sales_value.Name = "txb_sales_value";
            this.txb_sales_value.PasswordChar = '\0';
            this.txb_sales_value.PromptText = "Valor";
            this.txb_sales_value.ReadOnly = true;
            this.txb_sales_value.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txb_sales_value.SelectedText = "";
            this.txb_sales_value.SelectionLength = 0;
            this.txb_sales_value.SelectionStart = 0;
            this.txb_sales_value.ShortcutsEnabled = true;
            this.txb_sales_value.Size = new System.Drawing.Size(87, 23);
            this.txb_sales_value.Style = MetroFramework.MetroColorStyle.Red;
            this.txb_sales_value.TabIndex = 3;
            this.txb_sales_value.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txb_sales_value.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txb_sales_value.UseSelectable = true;
            this.txb_sales_value.WaterMark = "Valor";
            this.txb_sales_value.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txb_sales_value.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_saleFinally
            // 
            this.btn_saleFinally.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_saleFinally.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_saleFinally.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_saleFinally.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_saleFinally.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_saleFinally.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_saleFinally.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saleFinally.ForeColor = System.Drawing.Color.White;
            this.btn_saleFinally.IconChar = FontAwesome.Sharp.IconChar.PiggyBank;
            this.btn_saleFinally.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(41)))), ((int)(((byte)(88)))));
            this.btn_saleFinally.IconSize = 37;
            this.btn_saleFinally.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_saleFinally.Location = new System.Drawing.Point(443, 399);
            this.btn_saleFinally.Name = "btn_saleFinally";
            this.btn_saleFinally.Rotation = 0D;
            this.btn_saleFinally.Size = new System.Drawing.Size(122, 42);
            this.btn_saleFinally.TabIndex = 10;
            this.btn_saleFinally.Text = "Finalizar";
            this.btn_saleFinally.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_saleFinally.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_saleFinally.UseVisualStyleBackColor = true;
            this.btn_saleFinally.Click += new System.EventHandler(this.btn_saleFinally_Click);
            // 
            // txb_sales_details
            // 
            this.txb_sales_details.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txb_sales_details.CustomButton.Image = null;
            this.txb_sales_details.CustomButton.Location = new System.Drawing.Point(346, 1);
            this.txb_sales_details.CustomButton.Name = "";
            this.txb_sales_details.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txb_sales_details.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txb_sales_details.CustomButton.TabIndex = 1;
            this.txb_sales_details.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txb_sales_details.CustomButton.UseSelectable = true;
            this.txb_sales_details.CustomButton.Visible = false;
            this.txb_sales_details.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txb_sales_details.Lines = new string[0];
            this.txb_sales_details.Location = new System.Drawing.Point(42, 373);
            this.txb_sales_details.MaxLength = 32767;
            this.txb_sales_details.Multiline = true;
            this.txb_sales_details.Name = "txb_sales_details";
            this.txb_sales_details.PasswordChar = '\0';
            this.txb_sales_details.PromptText = "Detalhes do Pedido";
            this.txb_sales_details.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txb_sales_details.SelectedText = "";
            this.txb_sales_details.SelectionLength = 0;
            this.txb_sales_details.SelectionStart = 0;
            this.txb_sales_details.ShortcutsEnabled = true;
            this.txb_sales_details.Size = new System.Drawing.Size(370, 25);
            this.txb_sales_details.Style = MetroFramework.MetroColorStyle.Red;
            this.txb_sales_details.TabIndex = 5;
            this.txb_sales_details.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txb_sales_details.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txb_sales_details.UseSelectable = true;
            this.txb_sales_details.WaterMark = "Detalhes do Pedido";
            this.txb_sales_details.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txb_sales_details.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txb_sales_subTotal
            // 
            this.txb_sales_subTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txb_sales_subTotal.CustomButton.Image = null;
            this.txb_sales_subTotal.CustomButton.Location = new System.Drawing.Point(68, 1);
            this.txb_sales_subTotal.CustomButton.Name = "";
            this.txb_sales_subTotal.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txb_sales_subTotal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txb_sales_subTotal.CustomButton.TabIndex = 1;
            this.txb_sales_subTotal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txb_sales_subTotal.CustomButton.UseSelectable = true;
            this.txb_sales_subTotal.CustomButton.Visible = false;
            this.txb_sales_subTotal.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txb_sales_subTotal.Lines = new string[0];
            this.txb_sales_subTotal.Location = new System.Drawing.Point(634, 349);
            this.txb_sales_subTotal.MaxLength = 32767;
            this.txb_sales_subTotal.Name = "txb_sales_subTotal";
            this.txb_sales_subTotal.PasswordChar = '\0';
            this.txb_sales_subTotal.PromptText = "SubTotal";
            this.txb_sales_subTotal.ReadOnly = true;
            this.txb_sales_subTotal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txb_sales_subTotal.SelectedText = "";
            this.txb_sales_subTotal.SelectionLength = 0;
            this.txb_sales_subTotal.SelectionStart = 0;
            this.txb_sales_subTotal.ShortcutsEnabled = true;
            this.txb_sales_subTotal.Size = new System.Drawing.Size(90, 23);
            this.txb_sales_subTotal.Style = MetroFramework.MetroColorStyle.Red;
            this.txb_sales_subTotal.TabIndex = 4;
            this.txb_sales_subTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txb_sales_subTotal.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txb_sales_subTotal.UseSelectable = true;
            this.txb_sales_subTotal.WaterMark = "SubTotal";
            this.txb_sales_subTotal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txb_sales_subTotal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txb_sales_inputClient
            // 
            this.txb_sales_inputClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txb_sales_inputClient.CustomButton.Image = null;
            this.txb_sales_inputClient.CustomButton.Location = new System.Drawing.Point(126, 1);
            this.txb_sales_inputClient.CustomButton.Name = "";
            this.txb_sales_inputClient.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txb_sales_inputClient.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txb_sales_inputClient.CustomButton.TabIndex = 1;
            this.txb_sales_inputClient.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txb_sales_inputClient.CustomButton.UseSelectable = true;
            this.txb_sales_inputClient.CustomButton.Visible = false;
            this.txb_sales_inputClient.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txb_sales_inputClient.Lines = new string[0];
            this.txb_sales_inputClient.Location = new System.Drawing.Point(574, 373);
            this.txb_sales_inputClient.MaxLength = 32767;
            this.txb_sales_inputClient.Multiline = true;
            this.txb_sales_inputClient.Name = "txb_sales_inputClient";
            this.txb_sales_inputClient.PasswordChar = '\0';
            this.txb_sales_inputClient.PromptText = "Entrada do Cliente";
            this.txb_sales_inputClient.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txb_sales_inputClient.SelectedText = "";
            this.txb_sales_inputClient.SelectionLength = 0;
            this.txb_sales_inputClient.SelectionStart = 0;
            this.txb_sales_inputClient.ShortcutsEnabled = true;
            this.txb_sales_inputClient.Size = new System.Drawing.Size(150, 25);
            this.txb_sales_inputClient.Style = MetroFramework.MetroColorStyle.Red;
            this.txb_sales_inputClient.TabIndex = 7;
            this.txb_sales_inputClient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txb_sales_inputClient.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txb_sales_inputClient.UseSelectable = true;
            this.txb_sales_inputClient.WaterMark = "Entrada do Cliente";
            this.txb_sales_inputClient.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txb_sales_inputClient.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_saleRemovItem
            // 
            this.btn_saleRemovItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_saleRemovItem.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_saleRemovItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_saleRemovItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_saleRemovItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_saleRemovItem.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_saleRemovItem.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saleRemovItem.ForeColor = System.Drawing.Color.White;
            this.btn_saleRemovItem.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btn_saleRemovItem.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(41)))), ((int)(((byte)(88)))));
            this.btn_saleRemovItem.IconSize = 37;
            this.btn_saleRemovItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_saleRemovItem.Location = new System.Drawing.Point(322, 399);
            this.btn_saleRemovItem.Name = "btn_saleRemovItem";
            this.btn_saleRemovItem.Rotation = 0D;
            this.btn_saleRemovItem.Size = new System.Drawing.Size(122, 42);
            this.btn_saleRemovItem.TabIndex = 9;
            this.btn_saleRemovItem.Text = "Remover";
            this.btn_saleRemovItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_saleRemovItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_saleRemovItem.UseVisualStyleBackColor = true;
            this.btn_saleRemovItem.Click += new System.EventHandler(this.btn_saleRemovItem_Click);
            // 
            // txb_sales_client
            // 
            this.txb_sales_client.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txb_sales_client.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txb_sales_client.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            // 
            // 
            // 
            this.txb_sales_client.CustomButton.Image = null;
            this.txb_sales_client.CustomButton.Location = new System.Drawing.Point(185, 1);
            this.txb_sales_client.CustomButton.Name = "";
            this.txb_sales_client.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txb_sales_client.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txb_sales_client.CustomButton.TabIndex = 1;
            this.txb_sales_client.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txb_sales_client.CustomButton.UseSelectable = true;
            this.txb_sales_client.CustomButton.Visible = false;
            this.txb_sales_client.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txb_sales_client.Lines = new string[0];
            this.txb_sales_client.Location = new System.Drawing.Point(42, 349);
            this.txb_sales_client.MaxLength = 32767;
            this.txb_sales_client.Name = "txb_sales_client";
            this.txb_sales_client.PasswordChar = '\0';
            this.txb_sales_client.PromptText = "Cliente";
            this.txb_sales_client.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txb_sales_client.SelectedText = "";
            this.txb_sales_client.SelectionLength = 0;
            this.txb_sales_client.SelectionStart = 0;
            this.txb_sales_client.ShortcutsEnabled = true;
            this.txb_sales_client.Size = new System.Drawing.Size(207, 23);
            this.txb_sales_client.Style = MetroFramework.MetroColorStyle.Red;
            this.txb_sales_client.TabIndex = 0;
            this.txb_sales_client.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txb_sales_client.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txb_sales_client.UseSelectable = true;
            this.txb_sales_client.WaterMark = "Cliente";
            this.txb_sales_client.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txb_sales_client.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cb_form_payment
            // 
            this.cb_form_payment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_form_payment.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cb_form_payment.FontWeight = MetroFramework.MetroComboBoxWeight.Bold;
            this.cb_form_payment.FormattingEnabled = true;
            this.cb_form_payment.ItemHeight = 19;
            this.cb_form_payment.Items.AddRange(new object[] {
            "Dinheiro",
            "Cartão"});
            this.cb_form_payment.Location = new System.Drawing.Point(410, 373);
            this.cb_form_payment.Name = "cb_form_payment";
            this.cb_form_payment.PromptText = "Forma de pagamento";
            this.cb_form_payment.Size = new System.Drawing.Size(165, 25);
            this.cb_form_payment.Style = MetroFramework.MetroColorStyle.Red;
            this.cb_form_payment.TabIndex = 6;
            this.cb_form_payment.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cb_form_payment.UseSelectable = true;
            // 
            // newSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.cb_form_payment);
            this.Controls.Add(this.txb_sales_client);
            this.Controls.Add(this.btn_saleRemovItem);
            this.Controls.Add(this.txb_sales_inputClient);
            this.Controls.Add(this.txb_sales_subTotal);
            this.Controls.Add(this.txb_sales_details);
            this.Controls.Add(this.btn_saleFinally);
            this.Controls.Add(this.txb_sales_value);
            this.Controls.Add(this.txb_sales_quant);
            this.Controls.Add(this.txb_sales_products);
            this.Controls.Add(this.btn_saleAddItem);
            this.Controls.Add(this.ListViewSales);
            this.Name = "newSales";
            this.Size = new System.Drawing.Size(767, 469);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroListView ListViewSales;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private FontAwesome.Sharp.IconButton btn_saleAddItem;
        private MetroFramework.Controls.MetroTextBox txb_sales_products;
        private MetroFramework.Controls.MetroTextBox txb_sales_quant;
        private MetroFramework.Controls.MetroTextBox txb_sales_value;
        private FontAwesome.Sharp.IconButton btn_saleFinally;
        private MetroFramework.Controls.MetroTextBox txb_sales_details;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private MetroFramework.Controls.MetroTextBox txb_sales_subTotal;
        private MetroFramework.Controls.MetroTextBox txb_sales_inputClient;
        private FontAwesome.Sharp.IconButton btn_saleRemovItem;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private MetroFramework.Controls.MetroTextBox txb_sales_client;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private MetroFramework.Controls.MetroComboBox cb_form_payment;
    }
}
