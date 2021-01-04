using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using Docs_Buger;

namespace Docs_Haus
{

    public partial class newProducts : UserControl
    {
        DataBaseConfigs DataBaseConfig = new DataBaseConfigs();
        public bool bChangeDB = false;

        public void updateData()
        {
            DataBaseConfig.connectionDB();
            ListViewProducts.Items.Clear();
            try
            {
                SqlCommand nameDB = new SqlCommand("USE Sales SELECT * FROM Sales_DB ORDER BY PRODUCT", DataBaseConfig.varCnn());
                SqlDataReader executReader = nameDB.ExecuteReader();
                while (executReader.Read())
                {
                    ListViewItem items = new ListViewItem(executReader["PRODUCT"].ToString());
                    items.SubItems.Add(executReader["QUANT_PRODUCT"].ToString());
                    items.SubItems.Add(executReader["VALUE_COST_PRODUCT"].ToString());
                    items.SubItems.Add(executReader["VALUE_FINAL_PRODUCT"].ToString());
                    items.SubItems.Add(executReader["CODIGO_PRODUCT"].ToString());
                    items.SubItems.Add((Convert.ToDouble(executReader["VALUE_COST_PRODUCT"]) * Convert.ToDouble(executReader["QUANT_PRODUCT"])).ToString());
                    ListViewProducts.Items.Add(items);
                }
                if (DataBaseConfig.varCnn() != null) DataBaseConfig.varCnn().Close();
            }
            catch (SqlException)
            {
                if (DataBaseConfig.varCnn() != null) DataBaseConfig.varCnn().Close();
            }
        }
       
        public newProducts()
        {
            InitializeComponent();
            updateData();
        }

        private void btn_products_addItem_Click(object sender, EventArgs e)
        {
            DataBaseConfig.connectionDB();
            
            try
            {
                if (txb_sales_products.Text != "" && Convert.ToInt32(txb_sales_quant.Text) > 0 &&
                        Convert.ToDouble(txb_sales_value_cost.Text) > 0 &&
                        Convert.ToDouble(txb_sales_value_final.Text) > 0 && txb_sales_code.Text != "")
                {
                    String sql = "USE Sales INSERT INTO Sales_DB" +
                        "(PRODUCT, QUANT_PRODUCT, VALUE_COST_PRODUCT, VALUE_FINAL_PRODUCT, CODIGO_PRODUCT, DISCOUNT) " +
                        "VALUES ('" + txb_sales_products.Text +
                        "', " + Convert.ToInt32(txb_sales_quant.Text) +
                        ", " + Convert.ToDouble(txb_sales_value_cost.Text) +
                        ", " + Convert.ToDouble(txb_sales_value_final.Text) +
                        ", '" + txb_sales_code.Text +
                        "', " + 0 + ")";
                    SqlDataAdapter nameDB = new SqlDataAdapter();
                    SqlCommand command = new SqlCommand(sql);
                    nameDB.InsertCommand = new SqlCommand(sql, DataBaseConfig.varCnn());
                    nameDB.InsertCommand.ExecuteNonQuery();
                    command.Dispose();

                    if (DataBaseConfig.varCnn() != null) DataBaseConfig.varCnn().Close();

                    DataBaseConfig.connectionDB();
                    ListViewProducts.Items.Clear();
                    command = new SqlCommand("USE Sales SELECT * FROM Sales_DB ORDER BY PRODUCT", DataBaseConfig.varCnn());
                    SqlDataReader executReader = command.ExecuteReader();
                    while (executReader.Read())
                    {
                        ListViewItem items = new ListViewItem(executReader["PRODUCT"].ToString());
                        items.SubItems.Add(executReader["QUANT_PRODUCT"].ToString());
                        items.SubItems.Add(executReader["VALUE_COST_PRODUCT"].ToString());
                        items.SubItems.Add(executReader["VALUE_FINAL_PRODUCT"].ToString());
                        items.SubItems.Add(executReader["CODIGO_PRODUCT"].ToString());
                        ListViewProducts.Items.Add(items);
                    }
                    if (DataBaseConfig.varCnn() != null) DataBaseConfig.varCnn().Close();

                    txb_sales_products.Text = "";
                    txb_sales_code.Text = "";
                    txb_sales_quant.Text = "";
                    txb_sales_value_cost.Text = "";
                    txb_sales_value_final.Text = "";

                    MetroFramework.MetroMessageBox.Show(this,
                    "Produto inserido no estoque com sucesso!",
                    "Info",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                    bChangeDB = true;
                    return;
                }
                else
                {
                    if (DataBaseConfig.varCnn() != null) DataBaseConfig.varCnn().Close();
                    MetroFramework.MetroMessageBox.Show(this,
                    "Não foi possível adicionar o item desejado. Valor inserido incorretamente",
                    "Info",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }
            catch(SqlException)
            {
                if (DataBaseConfig.varCnn() != null) DataBaseConfig.varCnn().Close();
                MetroFramework.MetroMessageBox.Show(this,
                "(SQL) - Não foi possível adicionar o item desejado, contate o administrador",
                "Info",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }

            if (DataBaseConfig.varCnn() != null) DataBaseConfig.varCnn().Close();
            txb_sales_products.Text = "";
            txb_sales_quant.Text = "";
            txb_sales_value_cost.Text = "";
            txb_sales_value_final.Text = "";
            txb_sales_code.Text = "";
        }

        private void btn_products_remItem_Click(object sender, EventArgs e)
        {
             DataBaseConfig.connectionDB();
            if (ListViewProducts.SelectedItems.Count > 0)
            {
                if (MetroFramework.MetroMessageBox.Show(this,
                    "Tem certeza que deseja remover?", "Info",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    String sql = "USE Sales DELETE FROM Sales_DB WHERE PRODUCT = '" + ListViewProducts.SelectedItems[0].Text + "'";
                    SqlDataAdapter nameDB = new SqlDataAdapter();
                    SqlCommand command = new SqlCommand(sql);
                    nameDB.InsertCommand = new SqlCommand(sql, DataBaseConfig.varCnn());
                    nameDB.InsertCommand.ExecuteNonQuery();
                    command.Dispose();
                    if (DataBaseConfig.varCnn() != null) DataBaseConfig.varCnn().Close();
                    ListViewProducts.Items.Clear();
                     DataBaseConfig.connectionDB();
                    command = new SqlCommand("USE Sales SELECT * FROM Sales_DB ORDER BY PRODUCT", DataBaseConfig.varCnn());
                    SqlDataReader executReader = command.ExecuteReader();
                    while (executReader.Read())
                    {
                        ListViewItem items = new ListViewItem(executReader["PRODUCT"].ToString());
                        items.SubItems.Add(executReader["QUANT_PRODUCT"].ToString());
                        items.SubItems.Add(executReader["VALUE_COST_PRODUCT"].ToString());
                        items.SubItems.Add(executReader["VALUE_FINAL_PRODUCT"].ToString());
                        items.SubItems.Add(executReader["CODIGO_PRODUCT"].ToString());
                        ListViewProducts.Items.Add(items);
                    }
                    if (DataBaseConfig.varCnn() != null) DataBaseConfig.varCnn().Close();

                    MetroFramework.MetroMessageBox.Show(this,
                        "Produto removido com sucesso!",
                        "Info",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            else
            {
                if (DataBaseConfig.varCnn() != null) DataBaseConfig.varCnn().Close();
                MetroFramework.MetroMessageBox.Show(this,
                "Não foi possível remover o item desejado! Selecione algum item ou contate o administrador do Sistema.",
                "Info",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            if(DataBaseConfig.varCnn() != null) DataBaseConfig.varCnn().Close();
        }

        private void btn_products_editItem_Click(object sender, EventArgs e)
        {
            if (ListViewProducts.SelectedItems.Count > 0)
            {
                 DataBaseConfig.connectionDB();

                //Get Selected Item
                String sql = "USE Sales SELECT * FROM Sales_DB WHERE PRODUCT = '" + ListViewProducts.SelectedItems[0].SubItems[0].Text + "'";
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand command = new SqlCommand(sql, DataBaseConfig.varCnn());
                adapter.InsertCommand = new SqlCommand(sql, DataBaseConfig.varCnn());
                adapter.InsertCommand.ExecuteNonQuery();
                command.Dispose();

                SqlDataReader executReader = command.ExecuteReader();

                // Read Selected Item
                while (executReader.Read())
                {
                    txb_sales_products.Text = executReader["PRODUCT"].ToString();
                    txb_sales_quant.Text = executReader["QUANT_PRODUCT"].ToString();//QUANT_PRODUCT
                    txb_sales_value_cost.Text = executReader["VALUE_COST_PRODUCT"].ToString();
                    txb_sales_value_cost.Text = executReader["VALUE_FINAL_PRODUCT"].ToString();
                    txb_sales_code.Text = executReader["CODIGO_PRODUCT"].ToString();

                }

                if (DataBaseConfig.varCnn() != null) DataBaseConfig.varCnn().Close();

                // Delete Old Item
                 DataBaseConfig.connectionDB();

                sql = "USE Sales DELETE FROM Sales_DB WHERE PRODUCT = '" + txb_sales_products.Text + "'";
                adapter = new SqlDataAdapter();
                command = new SqlCommand(sql);
                adapter.InsertCommand = new SqlCommand(sql, DataBaseConfig.varCnn());
                adapter.InsertCommand.ExecuteNonQuery();
                command.Dispose();
                if (DataBaseConfig.varCnn() != null) DataBaseConfig.varCnn().Close();

                ListViewProducts.Items.Clear();

                DataBaseConfig.connectionDB();
                SqlCommand nameDB = new SqlCommand("USE Sales SELECT * FROM Sales_DB ORDER BY PRODUCT", DataBaseConfig.varCnn());
                executReader = nameDB.ExecuteReader();
                while (executReader.Read())
                {
                    ListViewItem items = new ListViewItem(executReader["PRODUCT"].ToString());
                    items.SubItems.Add(executReader["QUANT_PRODUCT"].ToString());
                    items.SubItems.Add(executReader["VALUE_COST_PRODUCT"].ToString());
                    items.SubItems.Add(executReader["VALUE_FINAL_PRODUCT"].ToString());
                    items.SubItems.Add(executReader["CODIGO_PRODUCT"].ToString());
                    ListViewProducts.Items.Add(items);
                }
                if (DataBaseConfig.varCnn() != null) DataBaseConfig.varCnn().Close();
            }
            else
            {
                if (DataBaseConfig.varCnn() != null) DataBaseConfig.varCnn().Close();
                MetroFramework.MetroMessageBox.Show(this,
                "Não foi possível alterar o item desejado! Selecione algum item ou contate o administrador do Sistema.",
                "Info",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }
    }
}
