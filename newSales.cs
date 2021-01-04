using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using Docs_Buger;
using System.Threading;

namespace Docs_Haus
{
    public partial class newSales : UserControl
    {
        DataBaseConfigs DataBaseConfig = new DataBaseConfigs();
        public AutoCompleteStringCollection customtextProducts = new AutoCompleteStringCollection();
        public AutoCompleteStringCollection customTextClient = new AutoCompleteStringCollection();

        public bool bChangeDB = false;

        public void updateData()
        {
            try
            {
                // Insert New Item
                DataBaseConfig.insertInDataBase("Sales", "Sales_Historic", "DATE_SALE_COMPLETED, VALUE_AMOUNT, VALUE_PROFIT",
                    "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "', '" + 0 + "'" + "', '" + 0 + "'");
            }
            catch (SqlException) { }


            try
            {
                try
                {
                    DataBaseConfig.connectionDB();
                    txb_sales_client.AutoCompleteCustomSource.Clear();
                    txb_sales_client.AutoCompleteMode = AutoCompleteMode.Suggest;
                    txb_sales_client.AutoCompleteSource = AutoCompleteSource.CustomSource;

                    SqlCommand command = new SqlCommand("USE Sales SELECT * FROM Client_DB", DataBaseConfig.varCnn());
                    SqlDataReader executReader = command.ExecuteReader();

                    // AutoCompleteMode
                    while (executReader.Read())
                    {
                        customTextClient.Add(executReader["NOME_CLIENT"].ToString());
                    }
                    txb_sales_client.AutoCompleteCustomSource = customTextClient;
                    if (DataBaseConfig.varCnn() != null) DataBaseConfig.varCnn().Close();
                }
                catch (Exception)
                {
                    if (DataBaseConfig.varCnn() != null) DataBaseConfig.varCnn().Close();
                }
            }
            catch (SqlException)
            {
                if (DataBaseConfig.varCnn() != null) DataBaseConfig.varCnn().Close();
            }


            try
            {
                try
                {
                    DataBaseConfig.connectionDB();
                    txb_sales_products.AutoCompleteCustomSource.Clear();
                    txb_sales_products.AutoCompleteMode = AutoCompleteMode.Suggest;
                    txb_sales_products.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    SqlCommand command = new SqlCommand("USE Sales SELECT * FROM Sales_DB", DataBaseConfig.varCnn());
                    SqlDataReader executReader = command.ExecuteReader();

                    // AutoCompleteMode
                    while (executReader.Read())
                    {
                        customtextProducts.Add(executReader["PRODUCT"].ToString());
                    }
                    txb_sales_products.AutoCompleteCustomSource = customtextProducts;
                    if (DataBaseConfig.varCnn() != null) DataBaseConfig.varCnn().Close();
                }
                catch (Exception)
                {
                    if (DataBaseConfig.varCnn() != null) DataBaseConfig.varCnn().Close();
                }
            }
            catch (SqlException)
            {
                if (DataBaseConfig.varCnn() != null) DataBaseConfig.varCnn().Close();
            }

            bChangeDB = false;
        }

        private void btn_saleAddItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txb_sales_products.AutoCompleteCustomSource.Contains(txb_sales_products.Text))
                {
                    MetroFramework.MetroMessageBox.Show(this,
                    "Item não cadastrado em nosso catalogo",
                    "Info",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    return;
                }


                if (Convert.ToInt32(txb_sales_quant.Text) > 0)
                {
                    DataBaseConfig.connectionDB();
                    String sql = "USE Sales SELECT * FROM Sales_DB WHERE PRODUCT = '" + txb_sales_products.Text + "'";
                    SqlDataAdapter nameDB = new SqlDataAdapter();
                    SqlCommand command = new SqlCommand(sql, DataBaseConfig.varCnn());
                    nameDB.InsertCommand = new SqlCommand(sql, DataBaseConfig.varCnn());
                    nameDB.InsertCommand.ExecuteNonQuery();
                    command.Dispose();
                    SqlDataReader executReader = command.ExecuteReader();
                    while (executReader.Read())
                    {
                        double valorFinal = (Convert.ToDouble(executReader["VALUE_FINAL_PRODUCT"]) *
                            Convert.ToInt32(txb_sales_quant.Text) -
                            (Convert.ToDouble(executReader["VALUE_FINAL_PRODUCT"]) *
                            (Convert.ToInt32(txb_sales_quant.Text))) * Convert.ToInt32(executReader["DISCOUNT"]) / 100);

                        ListViewItem items = new ListViewItem(executReader["PRODUCT"].ToString());
                        items.SubItems.Add(txb_sales_quant.Text);
                        items.SubItems.Add(executReader["CODIGO_PRODUCT"].ToString());
                        items.SubItems.Add(valorFinal.ToString());
                        items.SubItems.Add(executReader["DISCOUNT"].ToString());
                        items.SubItems.Add(txb_sales_details.Text);
                        ListViewSales.Items.Add(items);
                        if (txb_sales_subTotal.Text == "")
                            txb_sales_subTotal.Text = "0";
                        txb_sales_subTotal.Text = (Convert.ToDouble(txb_sales_subTotal.Text) + valorFinal).ToString("F");
                    }
                    if (DataBaseConfig.varCnn() != null) DataBaseConfig.varCnn().Close();
                    txb_sales_products.Text = "";
                    txb_sales_quant.Text = "";
                    txb_sales_value.Text = "";
                    txb_sales_details.Text = "";
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this,
                    "Valor inserido incorretamente!",
                    "Info",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    return;
                }
            }
            catch (SqlException)
            {
                if (DataBaseConfig.varCnn() != null) DataBaseConfig.varCnn().Close();
                MetroFramework.MetroMessageBox.Show(this,
                    "Não foi possível inserir o item selecionado, contate o administrador do Sistema.",
                    "Info",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                if (DataBaseConfig.varCnn() != null) DataBaseConfig.varCnn().Close();
                MetroFramework.MetroMessageBox.Show(this,
                   "Ocorreu algo errado!\nTente novamente ou contate o administrador do Sistema.",
                   "Info",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
        }

        private void btn_saleFinally_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this,
                            "Deseja realmente finalizar a venda?", "Info",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (Convert.ToDouble(txb_sales_subTotal.Text) > Convert.ToDouble(txb_sales_inputClient.Text))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Entrada de dinheiro informada é menor que o valor solicitado!",
                        "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Declaration of variables for use
                String oldNameItem = "", oldValueCost = "", oldValueFinal = "", oldCode = "", oldQuant = "", oldDiscount = "";
                double valueFinnaly = 0;

                for (int i = 0; i < ListViewSales.Items.Count; i++)
                {
                    // Backup Table Sales_DB
                    oldNameItem = DataBaseConfig.readDataBaseSpecificItems("Sales", "Sales_DB", "PRODUCT", "'" + ListViewSales.Items[i].SubItems[0].Text + "'", "PRODUCT");
                    oldValueCost = DataBaseConfig.readDataBaseSpecificItems("Sales", "Sales_DB", "PRODUCT", "'" + ListViewSales.Items[i].SubItems[0].Text + "'", "VALUE_COST_PRODUCT");
                    oldValueFinal = DataBaseConfig.readDataBaseSpecificItems("Sales", "Sales_DB", "PRODUCT", "'" + ListViewSales.Items[i].SubItems[0].Text + "'", "VALUE_FINAL_PRODUCT");
                    oldCode = DataBaseConfig.readDataBaseSpecificItems("Sales", "Sales_DB", "PRODUCT", "'" + ListViewSales.Items[i].SubItems[0].Text + "'", "CODIGO_PRODUCT");
                    oldQuant = DataBaseConfig.readDataBaseSpecificItems("Sales", "Sales_DB", "PRODUCT", "'" + ListViewSales.Items[i].SubItems[0].Text + "'", "QUANT_PRODUCT");
                    oldDiscount = DataBaseConfig.readDataBaseSpecificItems("Sales", "Sales_DB", "PRODUCT", "'" + ListViewSales.Items[i].SubItems[0].Text + "'", "DISCOUNT");

                    // Check final value is greater or less than the value entered
                    if (Convert.ToInt32(ListViewSales.Items[i].SubItems[1].Text) > Convert.ToInt32(oldQuant))
                    {
                        MetroFramework.MetroMessageBox.Show(this, "A quantidade de " + ListViewSales.Items[i].SubItems[0].Text +
                        " Pedida no momento está indisponível, Verifique se digitou a quantidade correta!"
                        ,
                        "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    oldQuant = (Convert.ToInt32(oldQuant) - Convert.ToInt32(ListViewSales.Items[i].SubItems[1].Text)).ToString();

                    //  Delete Old Item
                    DataBaseConfig.deleteDataBaseSpecificItems("Sales", "Sales_DB", "PRODUCT", "'" + ListViewSales.Items[i].SubItems[0].Text + "'");

                    // Insert New Item in Sales_DB
                    DataBaseConfig.insertInDataBase("Sales", "Sales_DB",
                        "PRODUCT, QUANT_PRODUCT, VALUE_COST_PRODUCT, VALUE_FINAL_PRODUCT, CODIGO_PRODUCT, DISCOUNT",
                        "'" + oldNameItem + "', " + Convert.ToInt32(oldQuant) +
                        ", " + Convert.ToDouble(oldValueCost) + ", " + Convert.ToDouble(oldValueFinal) + ", '" + oldCode + "', " + oldDiscount);
      

                    valueFinnaly = Convert.ToDouble(txb_sales_inputClient.Text) - Convert.ToDouble(txb_sales_subTotal.Text);


                    //  Insert New Item in Sales_Historic
                    DataBaseConfig.insertInDataBase("Sales", "Sales_Historic",
                        "DATE_SALE_COMPLETED, VALUE_AMOUNT, VALUE_PROFIT",
                        "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") +
                        "', " + Convert.ToDouble(oldValueCost) * Convert.ToInt32(ListViewSales.Items[i].SubItems[1].Text) +
                        ", " + (Convert.ToDouble(oldValueFinal) - Convert.ToDouble(oldValueCost)) * Convert.ToInt32(ListViewSales.Items[i].SubItems[1].Text));


                    // Backup Table Sales_Resume
                    String oldDate_Completed = "", oldDate_Day = "",
                            oldDate_Month = "", oldDate_Year = "", oldProfits = "";

                    oldDate_Completed = DataBaseConfig.readDataBaseSpecificItems("Sales", "Sales_Resume",
                        "DATE_SALE_COMPLETED",
                        "'" + DateTime.Now.ToString("dd/MM/yyyy") + "'",
                        "DATE_SALE_COMPLETED");

                    oldDate_Day = DataBaseConfig.readDataBaseSpecificItems("Sales", "Sales_Resume",
                        "DATE_SALE_COMPLETED",
                        "'" + DateTime.Now.ToString("dd/MM/yyyy") + "'",
                        "DATE_SALE_DAY");

                    oldDate_Month = DataBaseConfig.readDataBaseSpecificItems("Sales", "Sales_Resume",
                        "DATE_SALE_COMPLETED",
                        "'" + DateTime.Now.ToString("dd/MM/yyyy") + "'",
                        "DATE_SALE_MONTH");

                    oldDate_Year = DataBaseConfig.readDataBaseSpecificItems("Sales", "Sales_Resume",
                        "DATE_SALE_COMPLETED",
                        "'" + DateTime.Now.ToString("dd/MM/yyyy") + "'",
                        "DATE_SALE_YEAR");

                    oldProfits = (Convert.ToDouble(DataBaseConfig.readDataBaseSpecificItems("Sales", "Sales_Resume",
                        "DATE_SALE_COMPLETED",
                        "'" + DateTime.Now.ToString("dd/MM/yyyy") + "'",
                        "PROFITS")) + (Convert.ToDouble(txb_sales_subTotal.Text) - (Convert.ToDouble(ListViewSales.Items[i].SubItems[4].Text) / 100))).ToString();

                    // Delete Old Item in Sales_Resume
                    DataBaseConfig.deleteDataBaseSpecificItems("Sales", "Sales_Resume", "DATE_SALE_COMPLETED",
                        "'" + DateTime.Now.ToString("dd/MM/yyyy") + "'");

                    // Insert New Item in Sales_Resume
                    DataBaseConfig.insertInDataBase("Sales", "Sales_Resume",
                        "DATE_SALE_COMPLETED, DATE_SALE_DAY, DATE_SALE_MONTH, DATE_SALE_YEAR, PROFITS",
                        "'" + oldDate_Completed + "', '" + oldDate_Day +
                        "', '" + oldDate_Month + "', '" + oldDate_Year +
                        "', '" + oldProfits + "'");
                }


                txb_sales_products.Text = "";
                txb_sales_quant.Text = "";
                txb_sales_value.Text = "";
                txb_sales_details.Text = "";
                txb_sales_subTotal.Text = "";
                txb_sales_inputClient.Text = "";
                ListViewSales.Items.Clear();

                MetroFramework.MetroMessageBox.Show(this, "Venda realizada com sucesso! Troco a ser entregue: R$" +
                                valueFinnaly.ToString("F"),
                                "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                bChangeDB = true;
            }
        }


        public newSales()
        {
            InitializeComponent();
            updateData();
        }


        private void btn_saleRemovItem_Click(object sender, EventArgs e)
        {
            if (ListViewSales.SelectedItems.Count > 0)
            {
                // Item selected
                if (MetroFramework.MetroMessageBox.Show(this,
                    "Tem certeza que deseja remover?", "Info",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    txb_sales_subTotal.Text = (Convert.ToDouble(txb_sales_subTotal.Text) - Convert.ToDouble(ListViewSales.SelectedItems[0].SubItems[3].Text)).ToString();
                    ListViewSales.SelectedItems[0].Remove();
                }
            }
            else
            {
                // Item not selected
                MetroFramework.MetroMessageBox.Show(this,
                "Não foi possível remover o item desejado! Selecione algum item ou contate o administrador do Sistema.",
                "Info",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }
    }
}
