using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Docs_Buger;
using System.Data.SqlClient;

namespace Docs_Buger
{
    public partial class newFinancial : UserControl
    {
        DataBaseConfigs DataBaseConfig = new DataBaseConfigs();
        public bool bChangeDB = false;

        public void updateData()
        {
            try
            {
                //Total de Gastos: 5000           Total de Lucro: 5000
                double AMOUNT = 0, PROFIT = 0;

                DataBaseConfig.connectionDB();
                SqlCommand command = new SqlCommand("USE Sales SELECT * FROM Sales_Historic", DataBaseConfig.varCnn());
                SqlDataReader executReader = command.ExecuteReader();

                while (executReader.Read())
                {
                    AMOUNT += Convert.ToDouble(executReader["VALUE_AMOUNT"]);
                    PROFIT += Convert.ToDouble(executReader["VALUE_PROFIT"]);
                }

                lb_profit_amount.Text = "Total de Gastos: " + AMOUNT + "           Total de Lucro: " + PROFIT;

                if (DataBaseConfig.varCnn() != null) DataBaseConfig.varCnn().Close();
            }
            catch (SqlException)
            {
                if (DataBaseConfig.varCnn() != null) DataBaseConfig.varCnn().Close();
            }
            catch (Exception)
            {
                if (DataBaseConfig.varCnn() != null) DataBaseConfig.varCnn().Close();
            }


            DataBaseConfig.connectionDB();
            ListViewFinancial.Items.Clear();
            try
            {
                SqlCommand nameDB = new SqlCommand("USE Sales SELECT * FROM Financial_Month_Spend_DB ORDER BY PRODUCT", DataBaseConfig.varCnn());
                SqlDataReader executReader = nameDB.ExecuteReader();
                while (executReader.Read())
                {
                    ListViewItem items = new ListViewItem(executReader["PRODUCT"].ToString());
                    items.SubItems.Add(executReader["QUANT_PRODUCT"].ToString());
                    items.SubItems.Add(executReader["PAY_PRODUCT"].ToString());
                    items.SubItems.Add(executReader["VALUE_PRODUCT"].ToString());
                    items.SubItems.Add(executReader["DATE_PRODUCT"].ToString());
                    ListViewFinancial.Items.Add(items);
                }
                if (DataBaseConfig.varCnn() != null) DataBaseConfig.varCnn().Close();
            }
            catch (SqlException)
            {
                if (DataBaseConfig.varCnn() != null) DataBaseConfig.varCnn().Close();
            }
            catch (Exception)
            {
                if (DataBaseConfig.varCnn() != null) DataBaseConfig.varCnn().Close();
            }
            bChangeDB = false;
        }


        public newFinancial()
        {
            InitializeComponent();
            updateData();
        }


        private void btn_products_addItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txb_financial_item.Text != "" && Convert.ToInt32(txb_financial_quant.Text) > 0 && cb_form_payment.SelectedIndex != -1 &&
                        Convert.ToDouble(txb_financial_value.Text) > 0 && txb_financial_date.Text != "")
                {

                    //Financial_Month_Spend_DB
                    DataBaseConfig.insertInDataBase("Sales", "Financial_Month_Spend_DB", "PRODUCT, QUANT_PRODUCT, PAY_PRODUCT, VALUE_PRODUCT, DATE_PRODUCT",
                        "'" + txb_financial_item.Text + "', " + Convert.ToInt32(txb_financial_quant.Text) + ", '" + cb_form_payment.SelectedItem.ToString() + "', " +
                        Convert.ToDouble(txb_financial_value.Text) + ", '" + txb_financial_date.Text + "'");
                    
                    updateData();
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this,
                    "Não foi possível adicionar o item desejado. Valor inserido incorretamente ou repetido.",
                    "Info",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }
            catch (SqlException)
            {
                MetroFramework.MetroMessageBox.Show(this,
                "(SQL) - Não foi possível adicionar o item desejado, contate o administrador",
                "Info",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void btn_products_remItem_Click(object sender, EventArgs e)
        {
            DataBaseConfig.connectionDB();
            if (ListViewFinancial.SelectedItems.Count > 0)
            {
                try
                {
                    if (MetroFramework.MetroMessageBox.Show(this,
                    "Tem certeza que deseja remover?", "Info",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        String sql = "USE Sales DELETE FROM Financial_Month_Spend_DB WHERE PRODUCT = '" + ListViewFinancial.SelectedItems[0].Text + "'";
                        SqlDataAdapter nameDB = new SqlDataAdapter();
                        SqlCommand command = new SqlCommand(sql);
                        nameDB.InsertCommand = new SqlCommand(sql, DataBaseConfig.varCnn());
                        nameDB.InsertCommand.ExecuteNonQuery();
                        command.Dispose();
                        if (DataBaseConfig.varCnn() != null) DataBaseConfig.varCnn().Close();
                        ListViewFinancial.Items.Clear();
                       
                        bChangeDB = true;
                        MetroFramework.MetroMessageBox.Show(this,
                        "Produto removido com sucesso!",
                        "Info",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                        return;
                    }
                }
                catch (SqlException)
                {
                    MetroFramework.MetroMessageBox.Show(this,
                    "(SQL) - Não foi possível adicionar o item desejado, contate o administrador",
                    "Info",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
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
            if (DataBaseConfig.varCnn() != null) DataBaseConfig.varCnn().Close();
        }

        private void btn_products_editItem_Click(object sender, EventArgs e)
        {
            if (ListViewFinancial.SelectedItems.Count > 0)
            {
                DataBaseConfig.connectionDB();

                //Get Selected Item
                String sql = "USE Sales SELECT * FROM Financial_Month_Spend_DB WHERE PRODUCT = '" + ListViewFinancial.SelectedItems[0].SubItems[0].Text + "'";
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand command = new SqlCommand(sql, DataBaseConfig.varCnn());
                adapter.InsertCommand = new SqlCommand(sql, DataBaseConfig.varCnn());
                adapter.InsertCommand.ExecuteNonQuery();
                command.Dispose();

                SqlDataReader executReader = command.ExecuteReader();

                // Read Selected Item
                while (executReader.Read())
                {
                    txb_financial_item.Text = executReader["PRODUCT"].ToString();
                    txb_financial_quant.Text = executReader["QUANT_PRODUCT"].ToString();//QUANT_PRODUCT


                    switch (executReader["PAY_PRODUCT"].ToString())
                    {
                        case "Dinheiro":
                            cb_form_payment.SelectedIndex = 0;
                        break;

                        case "Cartão C.":
                            cb_form_payment.SelectedIndex = 1;
                            break;

                        case "Cartão D.":
                            cb_form_payment.SelectedIndex = 2;
                            break;

                        case "PicPay":
                            cb_form_payment.SelectedIndex = 3;
                        break;
                    }

                    txb_financial_value.Text = executReader["VALUE_PRODUCT"].ToString();
                    txb_financial_date.Text = executReader["DATE_PRODUCT"].ToString();
                }

                if (DataBaseConfig.varCnn() != null) DataBaseConfig.varCnn().Close();

                // Delete Old Item
                DataBaseConfig.connectionDB();

                sql = "USE Sales DELETE FROM Financial_Month_Spend_DB WHERE PRODUCT = '" + txb_financial_item.Text + "'";
                adapter = new SqlDataAdapter();
                command = new SqlCommand(sql);
                adapter.InsertCommand = new SqlCommand(sql, DataBaseConfig.varCnn());
                adapter.InsertCommand.ExecuteNonQuery();
                command.Dispose();
                if (DataBaseConfig.varCnn() != null) DataBaseConfig.varCnn().Close();
                ListViewFinancial.Items.Clear();

                updateData();
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
