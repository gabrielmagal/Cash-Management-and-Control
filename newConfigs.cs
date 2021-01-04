using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using Docs_Buger;

namespace Docs_Haus
{
    public partial class newConfigs : UserControl
    {
        DataBaseConfigs DataBaseConfig = new DataBaseConfigs();
        public newConfigs()
        {
            InitializeComponent();
        }

        private void btn_sales_saveFile_Click(object sender, EventArgs e)
        {
            DataBaseConfig.connectionDB();
            String sql = "USE Sales SELECT * FROM Sales_Historic";
            SqlCommand command = new SqlCommand(sql, DataBaseConfig.varCnn());
            SqlDataReader executReader = command.ExecuteReader();
            String backupAvailable = "Backup";
            try 
            {
                for (int i = 0; i < 1000; i++)
                {
                    //
                    // Backup lenght max 1000
                    //
                    if (!File.Exists(backupAvailable + i + ".txt"))
                    {
                        //
                        // Create new .txt if Available
                        //
                        using (StreamWriter sw = File.CreateText(backupAvailable + i + ".txt"))
                        {

                            while (executReader.Read())
                            {
                                //
                                // Backup Historic sales
                                //
                                sw.Write(executReader["DATE_SALE_COMPLETED"].ToString());
                                sw.Write("        Gasto total: " + executReader["VALUE_AMOUNT"].ToString());
                                sw.Write("        Lucro: " + executReader["VALUE_PROFIT"].ToString() + "\n");
                            }

                            DataBaseConfig.varCnn().Close();

                            sw.WriteLine();
                            sw.WriteLine();
                            sw.WriteLine();

                            DataBaseConfig.connectionDB();

                            sql = "USE Sales SELECT * FROM Sales_DB";
                            command = new SqlCommand(sql, DataBaseConfig.varCnn());
                            executReader = command.ExecuteReader();

                            while (executReader.Read())
                            {
                                //
                                // Backup Historic Products
                                //
                                sw.Write("Produto: " + executReader["PRODUCT"].ToString());
                                sw.Write("   Quant: " + executReader["QUANT_PRODUCT"].ToString());
                                sw.Write("   Valor Custo: " + executReader["VALUE_COST_PRODUCT"].ToString());
                                sw.Write("   Valor Final: " + executReader["VALUE_FINAL_PRODUCT"].ToString());
                                sw.Write("   Codig: " + executReader["CODIGO_PRODUCT"].ToString());
                                sw.Write("   Descon: " + executReader["DISCOUNT"].ToString() + "\n");
                            }
                            DataBaseConfig.varCnn().Close();

                            sw.WriteLine();
                            sw.WriteLine();
                            sw.WriteLine();

                            DataBaseConfig.connectionDB();

                            sql = "USE Sales SELECT * FROM Sales_Resume";
                            command = new SqlCommand(sql, DataBaseConfig.varCnn());
                            executReader = command.ExecuteReader();

                            while (executReader.Read())
                            {
                                //
                                // Backup Historic sales day
                                //
                                sw.Write(executReader["DATE_SALE_COMPLETED"].ToString());
                                sw.WriteLine("   Vendas do dia: " + executReader["PROFITS"].ToString());
                            }
                            if (DataBaseConfig.varCnn() != null) DataBaseConfig.varCnn().Close();
                        }
                        break;
                    }
                }
                if (DataBaseConfig.varCnn() != null) DataBaseConfig.varCnn().Close();
                MetroFramework.MetroMessageBox.Show(this,
                   "Backup concluído com sucesso!",
                   "Info",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
            }
            catch(SqlException)
            {
                // Backup SQL Exception
                if (DataBaseConfig.varCnn() != null) DataBaseConfig.varCnn().Close();
                MetroFramework.MetroMessageBox.Show(this,
                   "(SQL) - Não foi possível se conectar ao Banco de Dados, contate o administrador do Sistema.",
                   "Info",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
            catch(Exception)
            {
                if (DataBaseConfig.varCnn() != null) DataBaseConfig.varCnn().Close();
            }
        }

        private void btn_sales_trashHistory_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this,
                "Tem certeza que deseja resetar todo banco de dados?\nEssa ação não pode ser desfeita!",
                "Info",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                // if selected, delete all DB
                DataBaseConfig.deleteDataBase("Sales", "Sales_DB");
                DataBaseConfig.deleteDataBase("Sales", "Sales_Historic");
                DataBaseConfig.deleteDataBase("Sales", "Sales_Resume");
                MetroFramework.MetroMessageBox.Show(this,
                "Histórico removido com sucesso!",
                "Info",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
        }

        private void btn_sales_resetItens_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this,
                "Tem certeza que deseja resetar todos itens do Banco de dados?\nEssa ação não pode ser desfeita!",
                "Info",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                // if selected, delete all items
                DataBaseConfig.deleteDataBase("Sales", "Sales_DB");
                MetroFramework.MetroMessageBox.Show(this,
                "Itens resetados com sucesso! Abra novamente o programa para concluir as alterações!",
                "Info",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                Application.Exit();
            }
        }

        private void btn_descont_apply_Click(object sender, EventArgs e)
        {
            try
            {
                String sql = "USE Sales SELECT * FROM Sales_DB WHERE PRODUCT = '" + txb_discount_item.Text + "'";
                // Read Selected Item

                String oldNameItem = DataBaseConfig.readDataBaseSpecificItems("Sales", "Sales_DB", "PRODUCT",
                                            "'" + txb_discount_item.Text + "'", "PRODUCT"),
                oldValue = DataBaseConfig.readDataBaseSpecificItems("Sales", "Sales_DB", "PRODUCT",
                                            "'" + txb_discount_item.Text + "'", "VALUE_PRODUCT"),

                oldValueCostProduct = DataBaseConfig.readDataBaseSpecificItems("Sales", "Sales_DB", "PRODUCT",
                                            "'" + txb_discount_item.Text + "'", "VALUE_COST_PRODUCT"),

                oldValueFinalProduct = DataBaseConfig.readDataBaseSpecificItems("Sales", "Sales_DB", "PRODUCT",
                                            "'" + txb_discount_item.Text + "'", "VALUE_FINAL_PRODUCT"),

                oldCode = DataBaseConfig.readDataBaseSpecificItems("Sales", "Sales_DB", "PRODUCT",
                                            "'" + txb_discount_item.Text + "'", "CODIGO_PRODUCT"),
                oldQuant = DataBaseConfig.readDataBaseSpecificItems("Sales", "Sales_DB", "PRODUCT",
                                            "'" + txb_discount_item.Text + "'", "QUANT_PRODUCT");

                if (DataBaseConfig.varCnn() != null) DataBaseConfig.varCnn().Close();

                // Delete Old Item

                DataBaseConfig.deleteDataBaseSpecificItems("Sales", "Sales_DB", "PRODUCT",
                                            "'" + txb_discount_item.Text + "'");


                DataBaseConfig.insertInDataBase("Sales", "Sales_DB",
                                            "PRODUCT, QUANT_PRODUCT, VALUE_COST_PRODUCT, VALUE_FINAL_PRODUCT, CODIGO_PRODUCT, DISCOUNT",
                                            "'" + oldNameItem + "', " + Convert.ToInt32(oldQuant) +
                                            ", " + Convert.ToDouble(oldValueCostProduct) + "," + Convert.ToDouble(oldValueFinalProduct) + " ,'" +
                                            oldCode +"', " + txb_discount_input.Text);



                MetroFramework.MetroMessageBox.Show(this,
                    "Desconto aplicado com sucesso!",
                    "Info",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txb_discount_input.Text = "";
                txb_discount_item.Text = "";
            }
            catch(SqlException)
            {
                if (DataBaseConfig.varCnn() != null) DataBaseConfig.varCnn().Close();
                MetroFramework.MetroMessageBox.Show(this,
                     "(SQL) - Não foi possível remover todos os dados, contate o administrador do Sistema.",
                     "Info",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
            }
        }

        private void btn_geral_resetProgram_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this,
                "Tem certeza que deseja resetar todo o programa?\nEssa ação não pode ser desfeita!",
                "Info",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                DataBaseConfig.deleteDataBase("Sales", "Sales_DB");
                DataBaseConfig.deleteDataBase("Sales", "Sales_Historic");
                DataBaseConfig.deleteDataBase("Sales", "Sales_Resume");
                DataBaseConfig.deleteDataBase("Sales", "Client_DB");
                DataBaseConfig.deleteDataBase("Sales", "Financial_Month_Spend_DB");
                Application.Exit();
            }
        }

        public void ClearFolder(string FolderName)
        {
            DirectoryInfo dir = new DirectoryInfo(FolderName);

            foreach (FileInfo fi in dir.GetFiles())
            {
                try
                {
                    fi.Delete();
                }
                catch (Exception) { } // Ignore all exceptions
            }

            foreach (DirectoryInfo di in dir.GetDirectories())
            {
                ClearFolder(di.FullName);
                try
                {
                    di.Delete();
                }
                catch (Exception) { } // Ignore all exceptions
            }
        }

        private void btn_geral_optimize_Click(object sender, EventArgs e)
        {
            string current_partition = Path.GetPathRoot(Environment.SystemDirectory);
            try
            {
                MetroFramework.MetroMessageBox.Show(this,
                  "Não feche a aplicação, isso pode demorar um pouco!",
                  "Info",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
                ClearFolder(Path.GetTempPath());
                ClearFolder(current_partition + @"\Windows\SoftwareDistribution\Download");
                ClearFolder(current_partition + @"\Windows\Prefetch");
                ClearFolder(current_partition + @"\Windows\Installer");
                Process.Start(current_partition + @"\WINDOWS\system32\cleanmgr.exe");

                MetroFramework.MetroMessageBox.Show(this,
                  "Concluído com sucesso!\nArquivos desnecessários deletados!",
                  "Info",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
            }
            catch (Exception) { }
           
        }

        private void btn_geral_update_Click(object sender, EventArgs e)
        {
            MetroFramework.MetroMessageBox.Show(this,
                  "Você está utilizando a versão mais recente do programa!",
                  "Info",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
        }

        private void txb_descont_item_TextChanged(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    DataBaseConfig.connectionDB();
                    txb_discount_item.AutoCompleteMode = AutoCompleteMode.Suggest;
                    txb_discount_item.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    AutoCompleteStringCollection customtext = new AutoCompleteStringCollection();
                    SqlCommand command = new SqlCommand("USE Sales SELECT * FROM Sales_DB ORDER BY PRODUCT", DataBaseConfig.varCnn());
                    SqlDataReader executReader = command.ExecuteReader();
                    while (executReader.Read())
                    {
                        customtext.Add(executReader["PRODUCT"].ToString());
                    }
                    txb_discount_item.AutoCompleteCustomSource = customtext;
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
        }
    }
}
