namespace Docs_Buger
{
    partial class newRegisterClient
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
            this.btn_remove_client = new FontAwesome.Sharp.IconButton();
            this.txb_register_cep = new MetroFramework.Controls.MetroTextBox();
            this.chk_edit_contact = new MetroFramework.Controls.MetroCheckBox();
            this.btn_register_saveclient = new FontAwesome.Sharp.IconButton();
            this.txb_register_number = new MetroFramework.Controls.MetroTextBox();
            this.txb_register_reference = new MetroFramework.Controls.MetroTextBox();
            this.txb_register_phone2 = new MetroFramework.Controls.MetroTextBox();
            this.txb_register_phone1 = new MetroFramework.Controls.MetroTextBox();
            this.txb_register_bairro = new MetroFramework.Controls.MetroTextBox();
            this.txb_register_date = new MetroFramework.Controls.MetroTextBox();
            this.txb_register_email = new MetroFramework.Controls.MetroTextBox();
            this.txb_register_name = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_remove_client);
            this.panel1.Controls.Add(this.txb_register_cep);
            this.panel1.Controls.Add(this.chk_edit_contact);
            this.panel1.Controls.Add(this.btn_register_saveclient);
            this.panel1.Controls.Add(this.txb_register_number);
            this.panel1.Controls.Add(this.txb_register_reference);
            this.panel1.Controls.Add(this.txb_register_phone2);
            this.panel1.Controls.Add(this.txb_register_phone1);
            this.panel1.Controls.Add(this.txb_register_bairro);
            this.panel1.Controls.Add(this.txb_register_date);
            this.panel1.Controls.Add(this.txb_register_email);
            this.panel1.Controls.Add(this.txb_register_name);
            this.panel1.Location = new System.Drawing.Point(144, 146);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(479, 184);
            this.panel1.TabIndex = 1;
            // 
            // btn_remove_client
            // 
            this.btn_remove_client.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_remove_client.FlatAppearance.BorderSize = 0;
            this.btn_remove_client.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_remove_client.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_remove_client.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remove_client.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_remove_client.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remove_client.ForeColor = System.Drawing.Color.White;
            this.btn_remove_client.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btn_remove_client.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(41)))), ((int)(((byte)(88)))));
            this.btn_remove_client.IconSize = 30;
            this.btn_remove_client.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_remove_client.Location = new System.Drawing.Point(232, 142);
            this.btn_remove_client.Name = "btn_remove_client";
            this.btn_remove_client.Rotation = 0D;
            this.btn_remove_client.Size = new System.Drawing.Size(102, 36);
            this.btn_remove_client.TabIndex = 11;
            this.btn_remove_client.Text = "Remover";
            this.btn_remove_client.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_remove_client.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_remove_client.UseVisualStyleBackColor = true;
            this.btn_remove_client.Click += new System.EventHandler(this.btn_remove_client_Click);
            // 
            // txb_register_cep
            // 
            // 
            // 
            // 
            this.txb_register_cep.CustomButton.Image = null;
            this.txb_register_cep.CustomButton.Location = new System.Drawing.Point(123, 1);
            this.txb_register_cep.CustomButton.Name = "";
            this.txb_register_cep.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txb_register_cep.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txb_register_cep.CustomButton.TabIndex = 1;
            this.txb_register_cep.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txb_register_cep.CustomButton.UseSelectable = true;
            this.txb_register_cep.CustomButton.Visible = false;
            this.txb_register_cep.Lines = new string[0];
            this.txb_register_cep.Location = new System.Drawing.Point(238, 92);
            this.txb_register_cep.MaxLength = 32767;
            this.txb_register_cep.Name = "txb_register_cep";
            this.txb_register_cep.PasswordChar = '\0';
            this.txb_register_cep.PromptText = "Cep";
            this.txb_register_cep.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txb_register_cep.SelectedText = "";
            this.txb_register_cep.SelectionLength = 0;
            this.txb_register_cep.SelectionStart = 0;
            this.txb_register_cep.ShortcutsEnabled = true;
            this.txb_register_cep.Size = new System.Drawing.Size(145, 23);
            this.txb_register_cep.Style = MetroFramework.MetroColorStyle.Red;
            this.txb_register_cep.TabIndex = 7;
            this.txb_register_cep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txb_register_cep.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txb_register_cep.UseSelectable = true;
            this.txb_register_cep.WaterMark = "Cep";
            this.txb_register_cep.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txb_register_cep.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // chk_edit_contact
            // 
            this.chk_edit_contact.AutoSize = true;
            this.chk_edit_contact.Location = new System.Drawing.Point(305, 24);
            this.chk_edit_contact.Name = "chk_edit_contact";
            this.chk_edit_contact.Size = new System.Drawing.Size(130, 15);
            this.chk_edit_contact.Style = MetroFramework.MetroColorStyle.Red;
            this.chk_edit_contact.TabIndex = 1;
            this.chk_edit_contact.Text = "Editar Contato Salvo";
            this.chk_edit_contact.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.chk_edit_contact.UseSelectable = true;
            this.chk_edit_contact.CheckedChanged += new System.EventHandler(this.chk_edit_contact_CheckedChanged);
            // 
            // btn_register_saveclient
            // 
            this.btn_register_saveclient.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_register_saveclient.FlatAppearance.BorderSize = 0;
            this.btn_register_saveclient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_register_saveclient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_register_saveclient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_register_saveclient.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_register_saveclient.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_register_saveclient.ForeColor = System.Drawing.Color.White;
            this.btn_register_saveclient.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btn_register_saveclient.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(41)))), ((int)(((byte)(88)))));
            this.btn_register_saveclient.IconSize = 30;
            this.btn_register_saveclient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_register_saveclient.Location = new System.Drawing.Point(143, 142);
            this.btn_register_saveclient.Name = "btn_register_saveclient";
            this.btn_register_saveclient.Rotation = 0D;
            this.btn_register_saveclient.Size = new System.Drawing.Size(86, 36);
            this.btn_register_saveclient.TabIndex = 10;
            this.btn_register_saveclient.Text = "Salvar";
            this.btn_register_saveclient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_register_saveclient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_register_saveclient.UseVisualStyleBackColor = true;
            this.btn_register_saveclient.Click += new System.EventHandler(this.btn_register_saveclient_Click);
            // 
            // txb_register_number
            // 
            // 
            // 
            // 
            this.txb_register_number.CustomButton.Image = null;
            this.txb_register_number.CustomButton.Location = new System.Drawing.Point(31, 1);
            this.txb_register_number.CustomButton.Name = "";
            this.txb_register_number.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txb_register_number.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txb_register_number.CustomButton.TabIndex = 1;
            this.txb_register_number.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txb_register_number.CustomButton.UseSelectable = true;
            this.txb_register_number.CustomButton.Visible = false;
            this.txb_register_number.Lines = new string[0];
            this.txb_register_number.Location = new System.Drawing.Point(383, 92);
            this.txb_register_number.MaxLength = 32767;
            this.txb_register_number.Name = "txb_register_number";
            this.txb_register_number.PasswordChar = '\0';
            this.txb_register_number.PromptText = "Número";
            this.txb_register_number.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txb_register_number.SelectedText = "";
            this.txb_register_number.SelectionLength = 0;
            this.txb_register_number.SelectionStart = 0;
            this.txb_register_number.ShortcutsEnabled = true;
            this.txb_register_number.Size = new System.Drawing.Size(53, 23);
            this.txb_register_number.Style = MetroFramework.MetroColorStyle.Red;
            this.txb_register_number.TabIndex = 8;
            this.txb_register_number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txb_register_number.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txb_register_number.UseSelectable = true;
            this.txb_register_number.WaterMark = "Número";
            this.txb_register_number.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txb_register_number.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txb_register_reference
            // 
            // 
            // 
            // 
            this.txb_register_reference.CustomButton.Image = null;
            this.txb_register_reference.CustomButton.Location = new System.Drawing.Point(374, 1);
            this.txb_register_reference.CustomButton.Name = "";
            this.txb_register_reference.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txb_register_reference.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txb_register_reference.CustomButton.TabIndex = 1;
            this.txb_register_reference.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txb_register_reference.CustomButton.UseSelectable = true;
            this.txb_register_reference.CustomButton.Visible = false;
            this.txb_register_reference.Lines = new string[0];
            this.txb_register_reference.Location = new System.Drawing.Point(40, 116);
            this.txb_register_reference.MaxLength = 32767;
            this.txb_register_reference.Name = "txb_register_reference";
            this.txb_register_reference.PasswordChar = '\0';
            this.txb_register_reference.PromptText = "Referencia";
            this.txb_register_reference.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txb_register_reference.SelectedText = "";
            this.txb_register_reference.SelectionLength = 0;
            this.txb_register_reference.SelectionStart = 0;
            this.txb_register_reference.ShortcutsEnabled = true;
            this.txb_register_reference.Size = new System.Drawing.Size(396, 23);
            this.txb_register_reference.Style = MetroFramework.MetroColorStyle.Red;
            this.txb_register_reference.TabIndex = 9;
            this.txb_register_reference.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txb_register_reference.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txb_register_reference.UseSelectable = true;
            this.txb_register_reference.WaterMark = "Referencia";
            this.txb_register_reference.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txb_register_reference.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txb_register_phone2
            // 
            // 
            // 
            // 
            this.txb_register_phone2.CustomButton.Image = null;
            this.txb_register_phone2.CustomButton.Location = new System.Drawing.Point(176, 1);
            this.txb_register_phone2.CustomButton.Name = "";
            this.txb_register_phone2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txb_register_phone2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txb_register_phone2.CustomButton.TabIndex = 1;
            this.txb_register_phone2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txb_register_phone2.CustomButton.UseSelectable = true;
            this.txb_register_phone2.CustomButton.Visible = false;
            this.txb_register_phone2.Lines = new string[0];
            this.txb_register_phone2.Location = new System.Drawing.Point(238, 68);
            this.txb_register_phone2.MaxLength = 32767;
            this.txb_register_phone2.Name = "txb_register_phone2";
            this.txb_register_phone2.PasswordChar = '\0';
            this.txb_register_phone2.PromptText = "Telefone 2";
            this.txb_register_phone2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txb_register_phone2.SelectedText = "";
            this.txb_register_phone2.SelectionLength = 0;
            this.txb_register_phone2.SelectionStart = 0;
            this.txb_register_phone2.ShortcutsEnabled = true;
            this.txb_register_phone2.Size = new System.Drawing.Size(198, 23);
            this.txb_register_phone2.Style = MetroFramework.MetroColorStyle.Red;
            this.txb_register_phone2.TabIndex = 5;
            this.txb_register_phone2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txb_register_phone2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txb_register_phone2.UseSelectable = true;
            this.txb_register_phone2.WaterMark = "Telefone 2";
            this.txb_register_phone2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txb_register_phone2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txb_register_phone1
            // 
            // 
            // 
            // 
            this.txb_register_phone1.CustomButton.Image = null;
            this.txb_register_phone1.CustomButton.Location = new System.Drawing.Point(176, 1);
            this.txb_register_phone1.CustomButton.Name = "";
            this.txb_register_phone1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txb_register_phone1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txb_register_phone1.CustomButton.TabIndex = 1;
            this.txb_register_phone1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txb_register_phone1.CustomButton.UseSelectable = true;
            this.txb_register_phone1.CustomButton.Visible = false;
            this.txb_register_phone1.Lines = new string[0];
            this.txb_register_phone1.Location = new System.Drawing.Point(40, 68);
            this.txb_register_phone1.MaxLength = 32767;
            this.txb_register_phone1.Name = "txb_register_phone1";
            this.txb_register_phone1.PasswordChar = '\0';
            this.txb_register_phone1.PromptText = "Telefone 1";
            this.txb_register_phone1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txb_register_phone1.SelectedText = "";
            this.txb_register_phone1.SelectionLength = 0;
            this.txb_register_phone1.SelectionStart = 0;
            this.txb_register_phone1.ShortcutsEnabled = true;
            this.txb_register_phone1.Size = new System.Drawing.Size(198, 23);
            this.txb_register_phone1.Style = MetroFramework.MetroColorStyle.Red;
            this.txb_register_phone1.TabIndex = 4;
            this.txb_register_phone1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txb_register_phone1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txb_register_phone1.UseSelectable = true;
            this.txb_register_phone1.WaterMark = "Telefone 1";
            this.txb_register_phone1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txb_register_phone1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txb_register_bairro
            // 
            // 
            // 
            // 
            this.txb_register_bairro.CustomButton.Image = null;
            this.txb_register_bairro.CustomButton.Location = new System.Drawing.Point(176, 1);
            this.txb_register_bairro.CustomButton.Name = "";
            this.txb_register_bairro.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txb_register_bairro.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txb_register_bairro.CustomButton.TabIndex = 1;
            this.txb_register_bairro.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txb_register_bairro.CustomButton.UseSelectable = true;
            this.txb_register_bairro.CustomButton.Visible = false;
            this.txb_register_bairro.Lines = new string[0];
            this.txb_register_bairro.Location = new System.Drawing.Point(40, 92);
            this.txb_register_bairro.MaxLength = 32767;
            this.txb_register_bairro.Name = "txb_register_bairro";
            this.txb_register_bairro.PasswordChar = '\0';
            this.txb_register_bairro.PromptText = "Bairro";
            this.txb_register_bairro.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txb_register_bairro.SelectedText = "";
            this.txb_register_bairro.SelectionLength = 0;
            this.txb_register_bairro.SelectionStart = 0;
            this.txb_register_bairro.ShortcutsEnabled = true;
            this.txb_register_bairro.Size = new System.Drawing.Size(198, 23);
            this.txb_register_bairro.Style = MetroFramework.MetroColorStyle.Red;
            this.txb_register_bairro.TabIndex = 6;
            this.txb_register_bairro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txb_register_bairro.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txb_register_bairro.UseSelectable = true;
            this.txb_register_bairro.WaterMark = "Bairro";
            this.txb_register_bairro.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txb_register_bairro.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txb_register_date
            // 
            // 
            // 
            // 
            this.txb_register_date.CustomButton.Image = null;
            this.txb_register_date.CustomButton.Location = new System.Drawing.Point(139, 1);
            this.txb_register_date.CustomButton.Name = "";
            this.txb_register_date.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txb_register_date.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txb_register_date.CustomButton.TabIndex = 1;
            this.txb_register_date.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txb_register_date.CustomButton.UseSelectable = true;
            this.txb_register_date.CustomButton.Visible = false;
            this.txb_register_date.Lines = new string[0];
            this.txb_register_date.Location = new System.Drawing.Point(275, 44);
            this.txb_register_date.MaxLength = 32767;
            this.txb_register_date.Name = "txb_register_date";
            this.txb_register_date.PasswordChar = '\0';
            this.txb_register_date.PromptText = "Data de Nascimento";
            this.txb_register_date.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txb_register_date.SelectedText = "";
            this.txb_register_date.SelectionLength = 0;
            this.txb_register_date.SelectionStart = 0;
            this.txb_register_date.ShortcutsEnabled = true;
            this.txb_register_date.Size = new System.Drawing.Size(161, 23);
            this.txb_register_date.Style = MetroFramework.MetroColorStyle.Red;
            this.txb_register_date.TabIndex = 3;
            this.txb_register_date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txb_register_date.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txb_register_date.UseSelectable = true;
            this.txb_register_date.WaterMark = "Data de Nascimento";
            this.txb_register_date.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txb_register_date.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txb_register_email
            // 
            // 
            // 
            // 
            this.txb_register_email.CustomButton.Image = null;
            this.txb_register_email.CustomButton.Location = new System.Drawing.Point(213, 1);
            this.txb_register_email.CustomButton.Name = "";
            this.txb_register_email.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txb_register_email.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txb_register_email.CustomButton.TabIndex = 1;
            this.txb_register_email.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txb_register_email.CustomButton.UseSelectable = true;
            this.txb_register_email.CustomButton.Visible = false;
            this.txb_register_email.Lines = new string[0];
            this.txb_register_email.Location = new System.Drawing.Point(40, 44);
            this.txb_register_email.MaxLength = 32767;
            this.txb_register_email.Name = "txb_register_email";
            this.txb_register_email.PasswordChar = '\0';
            this.txb_register_email.PromptText = "Email";
            this.txb_register_email.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txb_register_email.SelectedText = "";
            this.txb_register_email.SelectionLength = 0;
            this.txb_register_email.SelectionStart = 0;
            this.txb_register_email.ShortcutsEnabled = true;
            this.txb_register_email.Size = new System.Drawing.Size(235, 23);
            this.txb_register_email.Style = MetroFramework.MetroColorStyle.Red;
            this.txb_register_email.TabIndex = 2;
            this.txb_register_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txb_register_email.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txb_register_email.UseSelectable = true;
            this.txb_register_email.WaterMark = "Email";
            this.txb_register_email.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txb_register_email.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txb_register_name
            // 
            // 
            // 
            // 
            this.txb_register_name.CustomButton.Image = null;
            this.txb_register_name.CustomButton.Location = new System.Drawing.Point(237, 1);
            this.txb_register_name.CustomButton.Name = "";
            this.txb_register_name.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txb_register_name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txb_register_name.CustomButton.TabIndex = 1;
            this.txb_register_name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txb_register_name.CustomButton.UseSelectable = true;
            this.txb_register_name.CustomButton.Visible = false;
            this.txb_register_name.Lines = new string[0];
            this.txb_register_name.Location = new System.Drawing.Point(40, 20);
            this.txb_register_name.MaxLength = 32767;
            this.txb_register_name.Name = "txb_register_name";
            this.txb_register_name.PasswordChar = '\0';
            this.txb_register_name.PromptText = "Nome";
            this.txb_register_name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txb_register_name.SelectedText = "";
            this.txb_register_name.SelectionLength = 0;
            this.txb_register_name.SelectionStart = 0;
            this.txb_register_name.ShortcutsEnabled = true;
            this.txb_register_name.Size = new System.Drawing.Size(259, 23);
            this.txb_register_name.Style = MetroFramework.MetroColorStyle.Red;
            this.txb_register_name.TabIndex = 0;
            this.txb_register_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txb_register_name.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txb_register_name.UseSelectable = true;
            this.txb_register_name.WaterMark = "Nome";
            this.txb_register_name.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txb_register_name.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(147, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dados Pessoais";
            // 
            // newRegisterClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "newRegisterClient";
            this.Size = new System.Drawing.Size(767, 469);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTextBox txb_register_name;
        private MetroFramework.Controls.MetroTextBox txb_register_email;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox txb_register_date;
        private MetroFramework.Controls.MetroTextBox txb_register_phone2;
        private MetroFramework.Controls.MetroTextBox txb_register_phone1;
        private MetroFramework.Controls.MetroTextBox txb_register_bairro;
        private MetroFramework.Controls.MetroTextBox txb_register_number;
        private MetroFramework.Controls.MetroTextBox txb_register_reference;
        private MetroFramework.Controls.MetroCheckBox chk_edit_contact;
        private MetroFramework.Controls.MetroTextBox txb_register_cep;
        private FontAwesome.Sharp.IconButton btn_remove_client;
        private FontAwesome.Sharp.IconButton btn_register_saveclient;
    }
}
