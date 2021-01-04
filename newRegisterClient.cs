using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using System.Data.SqlClient;
using Docs_Buger;


namespace Docs_Buger
{
    public partial class newRegisterClient : UserControl
    {
        DataBaseConfigs DataBaseConfig = new DataBaseConfigs();
        public AutoCompleteStringCollection customtext = new AutoCompleteStringCollection();
        public bool bChangeDB = false;

        public void updateData()
        {
            try
            {
                // Insert New Item
                DataBaseConfig.insertInDataBase("Sales", "Sales_Historic", "DATE_SALE_COMPLETED, VALUE_SALES",
                    "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "', '" + 0 + "'");
            }
            catch (SqlException) { }

            try
            {
                try
                {
                    DataBaseConfig.connectionDB();
                    txb_register_name.AutoCompleteCustomSource.Clear();
                    txb_register_name.AutoCompleteMode = AutoCompleteMode.Suggest;
                    txb_register_name.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    SqlCommand command = new SqlCommand("USE Sales SELECT * FROM Client_DB", DataBaseConfig.varCnn());
                    SqlDataReader executReader = command.ExecuteReader();

                    // AutoCompleteMode
                    while (executReader.Read())
                    {
                        customtext.Add(executReader["NOME_CLIENT"].ToString());
                    }
                    txb_register_name.AutoCompleteCustomSource = customtext;
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

            if (DataBaseConfig.varCnn() != null) DataBaseConfig.varCnn().Close();
        }


        public newRegisterClient()
        {
            InitializeComponent();
        }


        private void chk_edit_contact_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_edit_contact.Checked == true)
                bChangeDB = true;
            else
                txb_register_name.AutoCompleteCustomSource.Clear();
        }


        private void btn_register_saveclient_Click(object sender, EventArgs e)
        {
            if(txb_register_name.Text != "" && txb_register_phone1.Text != "" &&
                txb_register_bairro.Text != "" && txb_register_cep.Text != "" &&
                txb_register_number.Text != "" && txb_register_reference.Text != "")
            {
                DataBaseConfig.insertInDataBase("Sales", "Client_DB",
                        "NOME_CLIENT, EMAIL_CLIENT, PHONE1_CLIENT, PHONE2_CLIENT, BAIRRO_CLIENT, CEP_CLIENT, NUMBER_CLIENT, REFERENCE_CLIENT",
                        "'" + txb_register_name.Text + txb_register_phone1.Text.Substring(txb_register_phone1.Text.Length - 4) + "', " +
                        "'" + txb_register_email.Text + "', " +
                        "'" + txb_register_phone1.Text + "', " +
                        "'" + txb_register_phone2.Text + "', " +
                        "'" + txb_register_bairro.Text + "', " +
                        "'" + txb_register_cep.Text + "', " +
                        txb_register_number.Text + ", " +
                        "'" + txb_register_reference.Text + "'");

                MetroFramework.MetroMessageBox.Show(this, "Cliente Cadastrado com sucesso!",
                       "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bChangeDB = true;
            }
            else
            {
                    MetroMessageBox.Show(this,
                    "Verifique se os campos obrigatórios estão preenchidos!\nSendo estes: Nome, Telefone1, Bairro, Cep, Número e Refêrencia",
                    "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       

        private void btn_remove_client_Click(object sender, EventArgs e)
        {
            DataBaseConfig.deleteDataBaseSpecificItems("Sales", "Client_DB", "NOME_CLIENT", "'" + txb_register_name.Text + "'");
            txb_register_name.Text = "";
            txb_register_email.Text = "";
            txb_register_phone1.Text = "";
            txb_register_phone2.Text = "";
            txb_register_bairro.Text = "";
            txb_register_cep.Text = "";
            txb_register_number.Text = "";
            txb_register_reference.Text = "";
            bChangeDB = true;
        }
    }
}
