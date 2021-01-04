namespace Docs_Haus
{
    partial class newCash
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
            this.pieChart1 = new LiveCharts.WinForms.PieChart();
            this.cb_Date = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // pieChart1
            // 
            this.pieChart1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pieChart1.Location = new System.Drawing.Point(141, 66);
            this.pieChart1.Name = "pieChart1";
            this.pieChart1.Size = new System.Drawing.Size(485, 337);
            this.pieChart1.TabIndex = 1;
            this.pieChart1.Text = "pieChart1";
            // 
            // cb_Date
            // 
            this.cb_Date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_Date.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cb_Date.FormattingEnabled = true;
            this.cb_Date.ItemHeight = 19;
            this.cb_Date.Items.AddRange(new object[] {
            "Dia",
            "Mês",
            "Ano"});
            this.cb_Date.Location = new System.Drawing.Point(264, 31);
            this.cb_Date.Name = "cb_Date";
            this.cb_Date.PromptText = "Dia/Mês/Ano";
            this.cb_Date.Size = new System.Drawing.Size(238, 25);
            this.cb_Date.Style = MetroFramework.MetroColorStyle.Red;
            this.cb_Date.TabIndex = 0;
            this.cb_Date.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cb_Date.UseSelectable = true;
            this.cb_Date.SelectedIndexChanged += new System.EventHandler(this.cb_Date_SelectedIndexChanged);
            // 
            // newCash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.Controls.Add(this.cb_Date);
            this.Controls.Add(this.pieChart1);
            this.Name = "newCash";
            this.Size = new System.Drawing.Size(767, 469);
            this.ResumeLayout(false);

        }

        #endregion

        private LiveCharts.WinForms.PieChart pieChart1;
        private MetroFramework.Controls.MetroComboBox cb_Date;
    }
}
