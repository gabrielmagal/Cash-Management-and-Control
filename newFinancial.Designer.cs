namespace Docs_Buger
{
    partial class newFinancial
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
            this.ListViewFinancial = new MetroFramework.Controls.MetroListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cb_form_payment = new MetroFramework.Controls.MetroComboBox();
            this.txb_financial_quant = new MetroFramework.Controls.MetroTextBox();
            this.txb_financial_item = new MetroFramework.Controls.MetroTextBox();
            this.btn_products_editItem = new FontAwesome.Sharp.IconButton();
            this.btn_products_remItem = new FontAwesome.Sharp.IconButton();
            this.btn_products_addItem = new FontAwesome.Sharp.IconButton();
            this.lb_profit_amount = new System.Windows.Forms.Label();
            this.txb_financial_value = new MetroFramework.Controls.MetroTextBox();
            this.txb_financial_date = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // ListViewFinancial
            // 
            this.ListViewFinancial.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.ListViewFinancial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ListViewFinancial.BackColor = System.Drawing.Color.Black;
            this.ListViewFinancial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListViewFinancial.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.ListViewFinancial.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ListViewFinancial.FullRowSelect = true;
            this.ListViewFinancial.Location = new System.Drawing.Point(24, 31);
            this.ListViewFinancial.MultiSelect = false;
            this.ListViewFinancial.Name = "ListViewFinancial";
            this.ListViewFinancial.OwnerDraw = true;
            this.ListViewFinancial.Size = new System.Drawing.Size(718, 331);
            this.ListViewFinancial.Style = MetroFramework.MetroColorStyle.Red;
            this.ListViewFinancial.TabIndex = 8;
            this.ListViewFinancial.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ListViewFinancial.UseCompatibleStateImageBehavior = false;
            this.ListViewFinancial.UseCustomBackColor = true;
            this.ListViewFinancial.UseSelectable = true;
            this.ListViewFinancial.UseStyleColors = true;
            this.ListViewFinancial.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Item";
            this.columnHeader1.Width = 234;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Quantidade";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 115;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Forma de Pagamento";
            this.columnHeader3.Width = 160;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Valor";
            this.columnHeader4.Width = 90;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Data";
            this.columnHeader5.Width = 118;
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
            "Cartão C.",
            "Cartão D.",
            "PicPay"});
            this.cb_form_payment.Location = new System.Drawing.Point(352, 364);
            this.cb_form_payment.Name = "cb_form_payment";
            this.cb_form_payment.PromptText = "Forma de pagamento";
            this.cb_form_payment.Size = new System.Drawing.Size(188, 25);
            this.cb_form_payment.Style = MetroFramework.MetroColorStyle.Red;
            this.cb_form_payment.TabIndex = 2;
            this.cb_form_payment.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cb_form_payment.UseSelectable = true;
            // 
            // txb_financial_quant
            // 
            this.txb_financial_quant.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txb_financial_quant.CustomButton.Image = null;
            this.txb_financial_quant.CustomButton.Location = new System.Drawing.Point(64, 1);
            this.txb_financial_quant.CustomButton.Name = "";
            this.txb_financial_quant.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txb_financial_quant.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txb_financial_quant.CustomButton.TabIndex = 1;
            this.txb_financial_quant.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txb_financial_quant.CustomButton.UseSelectable = true;
            this.txb_financial_quant.CustomButton.Visible = false;
            this.txb_financial_quant.Lines = new string[0];
            this.txb_financial_quant.Location = new System.Drawing.Point(264, 364);
            this.txb_financial_quant.MaxLength = 32767;
            this.txb_financial_quant.Multiline = true;
            this.txb_financial_quant.Name = "txb_financial_quant";
            this.txb_financial_quant.PasswordChar = '\0';
            this.txb_financial_quant.PromptText = "Quantidade";
            this.txb_financial_quant.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txb_financial_quant.SelectedText = "";
            this.txb_financial_quant.SelectionLength = 0;
            this.txb_financial_quant.SelectionStart = 0;
            this.txb_financial_quant.ShortcutsEnabled = true;
            this.txb_financial_quant.Size = new System.Drawing.Size(88, 25);
            this.txb_financial_quant.Style = MetroFramework.MetroColorStyle.Red;
            this.txb_financial_quant.TabIndex = 1;
            this.txb_financial_quant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txb_financial_quant.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txb_financial_quant.UseSelectable = true;
            this.txb_financial_quant.WaterMark = "Quantidade";
            this.txb_financial_quant.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txb_financial_quant.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txb_financial_item
            // 
            this.txb_financial_item.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txb_financial_item.CustomButton.Image = null;
            this.txb_financial_item.CustomButton.Location = new System.Drawing.Point(216, 1);
            this.txb_financial_item.CustomButton.Name = "";
            this.txb_financial_item.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txb_financial_item.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txb_financial_item.CustomButton.TabIndex = 1;
            this.txb_financial_item.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txb_financial_item.CustomButton.UseSelectable = true;
            this.txb_financial_item.CustomButton.Visible = false;
            this.txb_financial_item.Lines = new string[0];
            this.txb_financial_item.Location = new System.Drawing.Point(24, 364);
            this.txb_financial_item.MaxLength = 32767;
            this.txb_financial_item.Multiline = true;
            this.txb_financial_item.Name = "txb_financial_item";
            this.txb_financial_item.PasswordChar = '\0';
            this.txb_financial_item.PromptText = "Item";
            this.txb_financial_item.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txb_financial_item.SelectedText = "";
            this.txb_financial_item.SelectionLength = 0;
            this.txb_financial_item.SelectionStart = 0;
            this.txb_financial_item.ShortcutsEnabled = true;
            this.txb_financial_item.Size = new System.Drawing.Size(240, 25);
            this.txb_financial_item.Style = MetroFramework.MetroColorStyle.Red;
            this.txb_financial_item.TabIndex = 0;
            this.txb_financial_item.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txb_financial_item.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txb_financial_item.UseSelectable = true;
            this.txb_financial_item.WaterMark = "Item";
            this.txb_financial_item.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txb_financial_item.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.btn_products_editItem.Location = new System.Drawing.Point(439, 395);
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
            this.btn_products_remItem.Location = new System.Drawing.Point(320, 395);
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
            this.btn_products_addItem.Location = new System.Drawing.Point(199, 395);
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
            // lb_profit_amount
            // 
            this.lb_profit_amount.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lb_profit_amount.AutoSize = true;
            this.lb_profit_amount.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_profit_amount.ForeColor = System.Drawing.Color.White;
            this.lb_profit_amount.Location = new System.Drawing.Point(211, 449);
            this.lb_profit_amount.Name = "lb_profit_amount";
            this.lb_profit_amount.Size = new System.Drawing.Size(344, 15);
            this.lb_profit_amount.TabIndex = 22;
            this.lb_profit_amount.Text = "Total de Gastos: 5000           Total de Lucro: 5000";
            // 
            // txb_financial_value
            // 
            this.txb_financial_value.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txb_financial_value.CustomButton.Image = null;
            this.txb_financial_value.CustomButton.Location = new System.Drawing.Point(75, 1);
            this.txb_financial_value.CustomButton.Name = "";
            this.txb_financial_value.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txb_financial_value.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txb_financial_value.CustomButton.TabIndex = 1;
            this.txb_financial_value.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txb_financial_value.CustomButton.UseSelectable = true;
            this.txb_financial_value.CustomButton.Visible = false;
            this.txb_financial_value.Lines = new string[0];
            this.txb_financial_value.Location = new System.Drawing.Point(541, 364);
            this.txb_financial_value.MaxLength = 32767;
            this.txb_financial_value.Multiline = true;
            this.txb_financial_value.Name = "txb_financial_value";
            this.txb_financial_value.PasswordChar = '\0';
            this.txb_financial_value.PromptText = "Valor";
            this.txb_financial_value.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txb_financial_value.SelectedText = "";
            this.txb_financial_value.SelectionLength = 0;
            this.txb_financial_value.SelectionStart = 0;
            this.txb_financial_value.ShortcutsEnabled = true;
            this.txb_financial_value.Size = new System.Drawing.Size(99, 25);
            this.txb_financial_value.Style = MetroFramework.MetroColorStyle.Red;
            this.txb_financial_value.TabIndex = 3;
            this.txb_financial_value.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txb_financial_value.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txb_financial_value.UseSelectable = true;
            this.txb_financial_value.WaterMark = "Valor";
            this.txb_financial_value.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txb_financial_value.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txb_financial_date
            // 
            this.txb_financial_date.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txb_financial_date.CustomButton.Image = null;
            this.txb_financial_date.CustomButton.Location = new System.Drawing.Point(78, 1);
            this.txb_financial_date.CustomButton.Name = "";
            this.txb_financial_date.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txb_financial_date.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txb_financial_date.CustomButton.TabIndex = 1;
            this.txb_financial_date.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txb_financial_date.CustomButton.UseSelectable = true;
            this.txb_financial_date.CustomButton.Visible = false;
            this.txb_financial_date.Lines = new string[0];
            this.txb_financial_date.Location = new System.Drawing.Point(640, 364);
            this.txb_financial_date.MaxLength = 32767;
            this.txb_financial_date.Multiline = true;
            this.txb_financial_date.Name = "txb_financial_date";
            this.txb_financial_date.PasswordChar = '\0';
            this.txb_financial_date.PromptText = "Data";
            this.txb_financial_date.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txb_financial_date.SelectedText = "";
            this.txb_financial_date.SelectionLength = 0;
            this.txb_financial_date.SelectionStart = 0;
            this.txb_financial_date.ShortcutsEnabled = true;
            this.txb_financial_date.Size = new System.Drawing.Size(102, 25);
            this.txb_financial_date.Style = MetroFramework.MetroColorStyle.Red;
            this.txb_financial_date.TabIndex = 4;
            this.txb_financial_date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txb_financial_date.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txb_financial_date.UseSelectable = true;
            this.txb_financial_date.WaterMark = "Data";
            this.txb_financial_date.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txb_financial_date.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // newFinancial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.Controls.Add(this.txb_financial_date);
            this.Controls.Add(this.txb_financial_value);
            this.Controls.Add(this.lb_profit_amount);
            this.Controls.Add(this.btn_products_editItem);
            this.Controls.Add(this.btn_products_remItem);
            this.Controls.Add(this.btn_products_addItem);
            this.Controls.Add(this.cb_form_payment);
            this.Controls.Add(this.txb_financial_quant);
            this.Controls.Add(this.txb_financial_item);
            this.Controls.Add(this.ListViewFinancial);
            this.Name = "newFinancial";
            this.Size = new System.Drawing.Size(767, 469);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroListView ListViewFinancial;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private MetroFramework.Controls.MetroComboBox cb_form_payment;
        private MetroFramework.Controls.MetroTextBox txb_financial_quant;
        private MetroFramework.Controls.MetroTextBox txb_financial_item;
        private FontAwesome.Sharp.IconButton btn_products_editItem;
        private FontAwesome.Sharp.IconButton btn_products_remItem;
        private FontAwesome.Sharp.IconButton btn_products_addItem;
        private System.Windows.Forms.Label lb_profit_amount;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private MetroFramework.Controls.MetroTextBox txb_financial_value;
        private MetroFramework.Controls.MetroTextBox txb_financial_date;
    }
}
