namespace Docs_Haus
{
    partial class newConfigs
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txb_discount_item = new MetroFramework.Controls.MetroTextBox();
            this.txb_discount_input = new MetroFramework.Controls.MetroTextBox();
            this.btn_descont_apply = new FontAwesome.Sharp.IconButton();
            this.btn_sales_resetItens = new FontAwesome.Sharp.IconButton();
            this.btn_sales_trashHistory = new FontAwesome.Sharp.IconButton();
            this.btn_sales_exportFile = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_sales_importFile = new FontAwesome.Sharp.IconButton();
            this.btn_geral_update = new FontAwesome.Sharp.IconButton();
            this.btn_geral_optimize = new FontAwesome.Sharp.IconButton();
            this.btn_geral_resetProgram = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btn_sales_resetItens);
            this.panel1.Controls.Add(this.btn_sales_trashHistory);
            this.panel1.Location = new System.Drawing.Point(67, 170);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(379, 137);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(135, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Desconto";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txb_discount_item);
            this.panel3.Controls.Add(this.txb_discount_input);
            this.panel3.Controls.Add(this.btn_descont_apply);
            this.panel3.Location = new System.Drawing.Point(133, 29);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(230, 84);
            this.panel3.TabIndex = 9;
            // 
            // txb_discount_item
            // 
            // 
            // 
            // 
            this.txb_discount_item.CustomButton.Image = null;
            this.txb_discount_item.CustomButton.Location = new System.Drawing.Point(88, 1);
            this.txb_discount_item.CustomButton.Name = "";
            this.txb_discount_item.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txb_discount_item.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txb_discount_item.CustomButton.TabIndex = 1;
            this.txb_discount_item.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txb_discount_item.CustomButton.UseSelectable = true;
            this.txb_discount_item.CustomButton.Visible = false;
            this.txb_discount_item.Lines = new string[0];
            this.txb_discount_item.Location = new System.Drawing.Point(8, 15);
            this.txb_discount_item.MaxLength = 32767;
            this.txb_discount_item.Name = "txb_discount_item";
            this.txb_discount_item.PasswordChar = '\0';
            this.txb_discount_item.PromptText = "Item";
            this.txb_discount_item.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txb_discount_item.SelectedText = "";
            this.txb_discount_item.SelectionLength = 0;
            this.txb_discount_item.SelectionStart = 0;
            this.txb_discount_item.ShortcutsEnabled = true;
            this.txb_discount_item.Size = new System.Drawing.Size(110, 23);
            this.txb_discount_item.Style = MetroFramework.MetroColorStyle.Red;
            this.txb_discount_item.TabIndex = 0;
            this.txb_discount_item.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txb_discount_item.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txb_discount_item.UseSelectable = true;
            this.txb_discount_item.WaterMark = "Item";
            this.txb_discount_item.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txb_discount_item.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txb_discount_item.TextChanged += new System.EventHandler(this.txb_descont_item_TextChanged);
            // 
            // txb_discount_input
            // 
            // 
            // 
            // 
            this.txb_discount_input.CustomButton.Image = null;
            this.txb_discount_input.CustomButton.Location = new System.Drawing.Point(88, 1);
            this.txb_discount_input.CustomButton.Name = "";
            this.txb_discount_input.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txb_discount_input.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txb_discount_input.CustomButton.TabIndex = 1;
            this.txb_discount_input.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txb_discount_input.CustomButton.UseSelectable = true;
            this.txb_discount_input.CustomButton.Visible = false;
            this.txb_discount_input.Lines = new string[0];
            this.txb_discount_input.Location = new System.Drawing.Point(8, 44);
            this.txb_discount_input.MaxLength = 32767;
            this.txb_discount_input.Name = "txb_discount_input";
            this.txb_discount_input.PasswordChar = '\0';
            this.txb_discount_input.PromptText = "Desconto %";
            this.txb_discount_input.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txb_discount_input.SelectedText = "";
            this.txb_discount_input.SelectionLength = 0;
            this.txb_discount_input.SelectionStart = 0;
            this.txb_discount_input.ShortcutsEnabled = true;
            this.txb_discount_input.Size = new System.Drawing.Size(110, 23);
            this.txb_discount_input.Style = MetroFramework.MetroColorStyle.Red;
            this.txb_discount_input.TabIndex = 1;
            this.txb_discount_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txb_discount_input.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txb_discount_input.UseSelectable = true;
            this.txb_discount_input.WaterMark = "Desconto %";
            this.txb_discount_input.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txb_discount_input.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_descont_apply
            // 
            this.btn_descont_apply.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_descont_apply.FlatAppearance.BorderSize = 0;
            this.btn_descont_apply.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_descont_apply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_descont_apply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_descont_apply.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_descont_apply.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_descont_apply.ForeColor = System.Drawing.Color.White;
            this.btn_descont_apply.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.btn_descont_apply.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(41)))), ((int)(((byte)(88)))));
            this.btn_descont_apply.IconSize = 30;
            this.btn_descont_apply.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_descont_apply.Location = new System.Drawing.Point(124, 21);
            this.btn_descont_apply.Name = "btn_descont_apply";
            this.btn_descont_apply.Rotation = 0D;
            this.btn_descont_apply.Size = new System.Drawing.Size(96, 41);
            this.btn_descont_apply.TabIndex = 2;
            this.btn_descont_apply.Text = "Concluir";
            this.btn_descont_apply.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_descont_apply.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_descont_apply.UseVisualStyleBackColor = true;
            this.btn_descont_apply.Click += new System.EventHandler(this.btn_descont_apply_Click);
            // 
            // btn_sales_resetItens
            // 
            this.btn_sales_resetItens.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_sales_resetItens.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_sales_resetItens.FlatAppearance.BorderSize = 0;
            this.btn_sales_resetItens.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_sales_resetItens.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_sales_resetItens.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sales_resetItens.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_sales_resetItens.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sales_resetItens.ForeColor = System.Drawing.Color.White;
            this.btn_sales_resetItens.IconChar = FontAwesome.Sharp.IconChar.MinusCircle;
            this.btn_sales_resetItens.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(41)))), ((int)(((byte)(88)))));
            this.btn_sales_resetItens.IconSize = 30;
            this.btn_sales_resetItens.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sales_resetItens.Location = new System.Drawing.Point(14, 70);
            this.btn_sales_resetItens.Name = "btn_sales_resetItens";
            this.btn_sales_resetItens.Rotation = 0D;
            this.btn_sales_resetItens.Size = new System.Drawing.Size(108, 41);
            this.btn_sales_resetItens.TabIndex = 2;
            this.btn_sales_resetItens.Text = "Resetar Itens";
            this.btn_sales_resetItens.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sales_resetItens.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_sales_resetItens.UseVisualStyleBackColor = true;
            this.btn_sales_resetItens.Click += new System.EventHandler(this.btn_sales_resetItens_Click);
            // 
            // btn_sales_trashHistory
            // 
            this.btn_sales_trashHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_sales_trashHistory.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_sales_trashHistory.FlatAppearance.BorderSize = 0;
            this.btn_sales_trashHistory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_sales_trashHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_sales_trashHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sales_trashHistory.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_sales_trashHistory.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sales_trashHistory.ForeColor = System.Drawing.Color.White;
            this.btn_sales_trashHistory.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btn_sales_trashHistory.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(41)))), ((int)(((byte)(88)))));
            this.btn_sales_trashHistory.IconSize = 30;
            this.btn_sales_trashHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sales_trashHistory.Location = new System.Drawing.Point(14, 30);
            this.btn_sales_trashHistory.Name = "btn_sales_trashHistory";
            this.btn_sales_trashHistory.Rotation = 0D;
            this.btn_sales_trashHistory.Size = new System.Drawing.Size(108, 41);
            this.btn_sales_trashHistory.TabIndex = 1;
            this.btn_sales_trashHistory.Text = "Remover histórico";
            this.btn_sales_trashHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sales_trashHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_sales_trashHistory.UseVisualStyleBackColor = true;
            this.btn_sales_trashHistory.Click += new System.EventHandler(this.btn_sales_trashHistory_Click);
            // 
            // btn_sales_exportFile
            // 
            this.btn_sales_exportFile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_sales_exportFile.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_sales_exportFile.FlatAppearance.BorderSize = 0;
            this.btn_sales_exportFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_sales_exportFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_sales_exportFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sales_exportFile.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_sales_exportFile.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sales_exportFile.ForeColor = System.Drawing.Color.White;
            this.btn_sales_exportFile.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btn_sales_exportFile.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(41)))), ((int)(((byte)(88)))));
            this.btn_sales_exportFile.IconSize = 30;
            this.btn_sales_exportFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sales_exportFile.Location = new System.Drawing.Point(126, 8);
            this.btn_sales_exportFile.Name = "btn_sales_exportFile";
            this.btn_sales_exportFile.Rotation = 0D;
            this.btn_sales_exportFile.Size = new System.Drawing.Size(107, 58);
            this.btn_sales_exportFile.TabIndex = 0;
            this.btn_sales_exportFile.Text = "Exportar Banco de Dados";
            this.btn_sales_exportFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sales_exportFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_sales_exportFile.UseVisualStyleBackColor = true;
            this.btn_sales_exportFile.Click += new System.EventHandler(this.btn_sales_saveFile_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(69, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vendas";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(456, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Gerais";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_sales_importFile);
            this.panel2.Controls.Add(this.btn_geral_update);
            this.panel2.Controls.Add(this.btn_geral_optimize);
            this.panel2.Controls.Add(this.btn_geral_resetProgram);
            this.panel2.Controls.Add(this.btn_sales_exportFile);
            this.panel2.Location = new System.Drawing.Point(454, 170);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(246, 137);
            this.panel2.TabIndex = 2;
            // 
            // btn_sales_importFile
            // 
            this.btn_sales_importFile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_sales_importFile.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_sales_importFile.FlatAppearance.BorderSize = 0;
            this.btn_sales_importFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_sales_importFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_sales_importFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sales_importFile.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_sales_importFile.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sales_importFile.ForeColor = System.Drawing.Color.White;
            this.btn_sales_importFile.IconChar = FontAwesome.Sharp.IconChar.TrashRestoreAlt;
            this.btn_sales_importFile.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(41)))), ((int)(((byte)(88)))));
            this.btn_sales_importFile.IconSize = 30;
            this.btn_sales_importFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sales_importFile.Location = new System.Drawing.Point(126, 72);
            this.btn_sales_importFile.Name = "btn_sales_importFile";
            this.btn_sales_importFile.Rotation = 0D;
            this.btn_sales_importFile.Size = new System.Drawing.Size(107, 53);
            this.btn_sales_importFile.TabIndex = 3;
            this.btn_sales_importFile.Text = "Importar Banco de Dados";
            this.btn_sales_importFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sales_importFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_sales_importFile.UseVisualStyleBackColor = true;
            // 
            // btn_geral_update
            // 
            this.btn_geral_update.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_geral_update.FlatAppearance.BorderSize = 0;
            this.btn_geral_update.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_geral_update.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_geral_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_geral_update.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_geral_update.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_geral_update.ForeColor = System.Drawing.Color.White;
            this.btn_geral_update.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            this.btn_geral_update.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(41)))), ((int)(((byte)(88)))));
            this.btn_geral_update.IconSize = 30;
            this.btn_geral_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_geral_update.Location = new System.Drawing.Point(4, 89);
            this.btn_geral_update.Name = "btn_geral_update";
            this.btn_geral_update.Rotation = 0D;
            this.btn_geral_update.Size = new System.Drawing.Size(118, 41);
            this.btn_geral_update.TabIndex = 2;
            this.btn_geral_update.Text = "Checar Atualização";
            this.btn_geral_update.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_geral_update.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_geral_update.UseVisualStyleBackColor = true;
            this.btn_geral_update.Click += new System.EventHandler(this.btn_geral_update_Click);
            // 
            // btn_geral_optimize
            // 
            this.btn_geral_optimize.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_geral_optimize.FlatAppearance.BorderSize = 0;
            this.btn_geral_optimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_geral_optimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_geral_optimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_geral_optimize.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_geral_optimize.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_geral_optimize.ForeColor = System.Drawing.Color.White;
            this.btn_geral_optimize.IconChar = FontAwesome.Sharp.IconChar.Laptop;
            this.btn_geral_optimize.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(41)))), ((int)(((byte)(88)))));
            this.btn_geral_optimize.IconSize = 30;
            this.btn_geral_optimize.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_geral_optimize.Location = new System.Drawing.Point(4, 49);
            this.btn_geral_optimize.Name = "btn_geral_optimize";
            this.btn_geral_optimize.Rotation = 0D;
            this.btn_geral_optimize.Size = new System.Drawing.Size(108, 41);
            this.btn_geral_optimize.TabIndex = 1;
            this.btn_geral_optimize.Text = "Otimizar PC";
            this.btn_geral_optimize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_geral_optimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_geral_optimize.UseVisualStyleBackColor = true;
            this.btn_geral_optimize.Click += new System.EventHandler(this.btn_geral_optimize_Click);
            // 
            // btn_geral_resetProgram
            // 
            this.btn_geral_resetProgram.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_geral_resetProgram.FlatAppearance.BorderSize = 0;
            this.btn_geral_resetProgram.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_geral_resetProgram.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_geral_resetProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_geral_resetProgram.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_geral_resetProgram.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_geral_resetProgram.ForeColor = System.Drawing.Color.White;
            this.btn_geral_resetProgram.IconChar = FontAwesome.Sharp.IconChar.TrashRestoreAlt;
            this.btn_geral_resetProgram.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(41)))), ((int)(((byte)(88)))));
            this.btn_geral_resetProgram.IconSize = 30;
            this.btn_geral_resetProgram.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_geral_resetProgram.Location = new System.Drawing.Point(4, 9);
            this.btn_geral_resetProgram.Name = "btn_geral_resetProgram";
            this.btn_geral_resetProgram.Rotation = 0D;
            this.btn_geral_resetProgram.Size = new System.Drawing.Size(108, 41);
            this.btn_geral_resetProgram.TabIndex = 0;
            this.btn_geral_resetProgram.Text = "Resetar Programa";
            this.btn_geral_resetProgram.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_geral_resetProgram.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_geral_resetProgram.UseVisualStyleBackColor = true;
            this.btn_geral_resetProgram.Click += new System.EventHandler(this.btn_geral_resetProgram_Click);
            // 
            // newConfigs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "newConfigs";
            this.Size = new System.Drawing.Size(767, 469);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btn_sales_exportFile;
        private FontAwesome.Sharp.IconButton btn_sales_trashHistory;
        private FontAwesome.Sharp.IconButton btn_sales_resetItens;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btn_geral_resetProgram;
        private FontAwesome.Sharp.IconButton btn_geral_optimize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton btn_descont_apply;
        private MetroFramework.Controls.MetroTextBox txb_discount_input;
        private MetroFramework.Controls.MetroTextBox txb_discount_item;
        private FontAwesome.Sharp.IconButton btn_geral_update;
        private FontAwesome.Sharp.IconButton btn_sales_importFile;
    }
}
